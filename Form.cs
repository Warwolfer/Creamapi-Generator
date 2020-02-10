using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreamAPI_Generator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private FileInfo[] steamAPIs = new FileInfo[0];
        private FileInfo[] exeFiles = new FileInfo[0];
        private Dictionary<string, Label> api2Label;
        private bool validID = false;
        private bool validDir = false;
        private Thread searchThread;

        public Form()
        {
            InitializeComponent();
            api2Label = new Dictionary<string, Label> { { "steam_api.dll", lblAPI }, { "steam_api64.dll", lblAPI64 } };
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        public async Task<JObject> GetAppInfo(string appid)
        {
            string uri = $"https://store.steampowered.com/api/appdetails/?appids={appid}";
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string httpBody = await httpClient.GetStringAsync(uri);
                    JObject json = JObject.Parse(httpBody);
                    return json;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                    return null;
                }
            }
        }

        public async Task LoadDLCList(string appid)
        {
            JObject appJson = await GetAppInfo(appid);
            JArray dlcList = (JArray)appJson[appid]["data"]["dlc"];

            dlcListView.Rows.Clear();
            foreach (string dlc in dlcList)
            {
                LoadDLC(dlc);
            }
        }

        public async Task LoadDLC(string dlc)
        {
            JObject dlcJson = await GetAppInfo(dlc);
            string name = (string)dlcJson[dlc]["data"]["name"];

            using(Stream imgStream = await new HttpClient().GetStreamAsync($"https://steamcdn-a.akamaihd.net/steam/apps/{dlc}/header.jpg"))
            {
                Image image = Image.FromStream(imgStream);
                dlcListView.Rows.Add(image, name, dlc);
            }
            dlcListView.Sort(dlcListView.Columns[2], System.ComponentModel.ListSortDirection.Descending);
        }

        private void LoadAppID(string appid)
        {
            try
            {
                pictureBox.Load($"https://steamcdn-a.akamaihd.net/steam/apps/{appid}/header.jpg");
                pictureBox.Cursor = Cursors.Hand;
                validID = true;
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Invalid game App ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAppID.Text = "";
                pictureBox.Image = pictureBox.Image = null;
                pictureBox.Cursor = Cursors.Arrow;
                validID = false;
                return;
            }
            LoadDLCList(appid);
        }

        private void FindSteamAPI()
        {
            searchThread = new Thread(new ThreadStart(SearchAPIs));
            foreach (var lbl in api2Label)
            {
                lbl.Value.Text = "Searching";
                lbl.Value.ForeColor = Color.FromArgb(200, 208, 220);
                validDir = false;
            }
            if (!searchThread.IsAlive)
                searchThread.Start();
            else
                searchThread.Abort();
        }

        private void SearchAPIs()
        {
            DirectoryInfo dir = new DirectoryInfo(dirBox.Text);
            try
            {
                steamAPIs = dir.GetFiles("steam_api??.dll", SearchOption.AllDirectories);
                exeFiles = dir.GetFiles("*.exe", SearchOption.AllDirectories);
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("File access not authorized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Invoke(new MethodInvoker(delegate { UpdateAPIs(steamAPIs); }));
        }

        private void UpdateAPIs(FileInfo[] files)
        {
            foreach (var lbl in api2Label)
            {
                lbl.Value.Text = "Not Found";
                lbl.Value.ForeColor = Color.Red;
            }
            if (steamAPIs.Length > 2 || steamAPIs.Length == 0 || exeFiles.Length == 0)
            {
                MessageBox.Show("Invalid game folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dirBox.Text = "";
                folderBrowserDialog.SelectedPath = "";
                return;
            }
            validDir = true;
            cbExe.Items.Clear();
            foreach (var file in exeFiles)
            {
                cbExe.Items.Add(file);
            }
            foreach (var file in steamAPIs)
            {
                Label label = api2Label[file.Name];
                label.Text = "Found";
                label.ForeColor = Color.Green;  
            }
        }

        private void ReplaceAPIs(string path)
        {
            foreach (FileInfo file in steamAPIs)
            {
                try
                {
                    if (file.Name == "steam_api.dll")
                    {
                        File.Copy(file.FullName, path + @"\steam_api_o.dll", false);
                        File.WriteAllBytes(file.FullName, Properties.Resources.steam_api);
                    }
                    if (file.Name == "steam_api64.dll")
                    {
                        File.Copy(file.FullName, path + @"\steam_api64_o.dll", false);
                        File.WriteAllBytes(file.FullName, Properties.Resources.steam_api64);
                    }
                }
                catch(System.IO.IOException e)
                {
                    MessageBox.Show("The game seems to be already fixed \n" +
                                    "Only the config is been updated.", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
        }

        private Dictionary<string, string> GetSelectedDLC()
        {
            Dictionary<string, string> selectedDLC = new Dictionary<string, string>();

            foreach(DataGridViewRow row in dlcListView.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() == "enabled")
                {
                    selectedDLC.Add(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString());
                }
            }
            return selectedDLC;
        }

        private void WriteCfg(string path)
        {
            string[] cfgLines = Properties.Resources.cream_api.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            using (StreamWriter stream = new StreamWriter(path + @"\cream_api.ini"))
            {
                foreach (string line in cfgLines)
                {
                    if (Regex.IsMatch(line, @"^(?!;)\w+( = )"))
                    {
                        string field = Regex.Match(line, @"^(?!;)\w+").Value;
                        string value = "";
                        switch (field)
                        {
                            case "appid":
                                value = tbAppID.Text;
                                break;
                            default:
                                stream.WriteLine(line);
                                break;
                        }
                        if (value != "")
                            stream.WriteLine($"{field} = {value}");
                    }
                    else
                        stream.WriteLine(line);
                    if (line == "[dlc]")
                    {
                        foreach (KeyValuePair<string, string> dlc in GetSelectedDLC())
                        {
                            stream.WriteLine($"{dlc.Key} = {dlc.Value}");
                        }
                    }
                }
            }
        }

        private void TextBoxAppID_Leave(object sender, EventArgs e)
        {
            LoadAppID(tbAppID.Text);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (validID == true)
                System.Diagnostics.Process.Start("https://store.steampowered.com/app/" + tbAppID.Text);
        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                dirBox.Text = folderBrowserDialog.SelectedPath;
                FindSteamAPI();
            }
        }

        private void BtnFix_Click(object sender, EventArgs e)
        {
            if (dirBox.TextLength == 0)
            {
                MessageBox.Show("Select the game directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbExe.SelectedItem == null)
            {
                MessageBox.Show("Select the game executable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validID == false)
            {
                MessageBox.Show("Invalid game App ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (steamAPIs.Length == 0 || validDir == false)
            {
                MessageBox.Show("steam_api(64).dll not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            unlockAll();
            FileInfo exeDir = (FileInfo) cbExe.SelectedItem;
            WriteCfg(exeDir.DirectoryName);
            ReplaceAPIs(exeDir.DirectoryName);
            MessageBox.Show("Steamworks fix successfull.", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDLC_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;
        }

        private void BtnWrapper_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dlcListView.Rows)
            {
                row.Cells[3].Value = "enabled";
            }
        }

        private void DeselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dlcListView.Rows)
            {
                row.Cells[3].Value = "disabled";
            }
        }

        private void lblCreamAPI_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void tbAppID_TextChanged(object sender, EventArgs e)
        {

        }

        private void unlockAll ()
        {
            foreach (DataGridViewRow row in dlcListView.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    row.Cells[3].Value = "enabled";
                }
            }
        }

    }
}
