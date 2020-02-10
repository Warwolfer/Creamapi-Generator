namespace CreamAPI_Generator
{
    partial class Form
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.dirBox = new System.Windows.Forms.TextBox();
            this.labelGameFolder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnWrapper = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCreamAPI = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dlcListView = new System.Windows.Forms.DataGridView();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDLC = new System.Windows.Forms.Button();
            this.lblGameExe = new System.Windows.Forms.Label();
            this.pnlAPIStatus = new System.Windows.Forms.Panel();
            this.labelSteam64 = new System.Windows.Forms.Label();
            this.lblAPI64 = new System.Windows.Forms.Label();
            this.lblAPI = new System.Windows.Forms.Label();
            this.labelSteam = new System.Windows.Forms.Label();
            this.cbExe = new System.Windows.Forms.ComboBox();
            this.tbAppID = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblAppID = new System.Windows.Forms.Label();
            this.labelAPIStatus = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlcListView)).BeginInit();
            this.columnMenuStrip.SuspendLayout();
            this.pnlAPIStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog_HelpRequest);
            // 
            // dirBox
            // 
            this.dirBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.dirBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dirBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.dirBox.Location = new System.Drawing.Point(98, 45);
            this.dirBox.Name = "dirBox";
            this.dirBox.ReadOnly = true;
            this.dirBox.Size = new System.Drawing.Size(396, 20);
            this.dirBox.TabIndex = 1;
            // 
            // labelGameFolder
            // 
            this.labelGameFolder.AutoSize = true;
            this.labelGameFolder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.labelGameFolder.Location = new System.Drawing.Point(12, 47);
            this.labelGameFolder.Name = "labelGameFolder";
            this.labelGameFolder.Size = new System.Drawing.Size(80, 14);
            this.labelGameFolder.TabIndex = 0;
            this.labelGameFolder.Text = "Game Folder:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.button1.Location = new System.Drawing.Point(500, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.button2.Location = new System.Drawing.Point(375, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Export Zip";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.btnFix.FlatAppearance.BorderSize = 0;
            this.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFix.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.btnFix.Location = new System.Drawing.Point(456, 405);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(119, 23);
            this.btnFix.TabIndex = 9;
            this.btnFix.Text = "Fix Steamworks";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.BtnFix_Click);
            // 
            // btnWrapper
            // 
            this.btnWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.btnWrapper.FlatAppearance.BorderSize = 0;
            this.btnWrapper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrapper.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrapper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.btnWrapper.Location = new System.Drawing.Point(15, 82);
            this.btnWrapper.Name = "btnWrapper";
            this.btnWrapper.Size = new System.Drawing.Size(68, 23);
            this.btnWrapper.TabIndex = 3;
            this.btnWrapper.Text = "Game";
            this.btnWrapper.UseVisualStyleBackColor = false;
            this.btnWrapper.Click += new System.EventHandler(this.BtnWrapper_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.btnClose.Location = new System.Drawing.Point(546, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblCreamAPI
            // 
            this.lblCreamAPI.AutoSize = true;
            this.lblCreamAPI.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreamAPI.Location = new System.Drawing.Point(13, 11);
            this.lblCreamAPI.Name = "lblCreamAPI";
            this.lblCreamAPI.Size = new System.Drawing.Size(242, 14);
            this.lblCreamAPI.TabIndex = 18;
            this.lblCreamAPI.Text = "CreamAPI Generator (No Wrapper Version)";
            this.lblCreamAPI.Click += new System.EventHandler(this.lblCreamAPI_Click);
            this.lblCreamAPI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.lblCreamAPI.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.lblCreamAPI.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.lblCreamAPI);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(591, 37);
            this.titleBar.TabIndex = 19;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "Created by Arciduca Zagaria, updated by Warwolfer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dlcListView
            // 
            this.dlcListView.AllowUserToAddRows = false;
            this.dlcListView.AllowUserToDeleteRows = false;
            this.dlcListView.AllowUserToResizeColumns = false;
            this.dlcListView.AllowUserToResizeRows = false;
            this.dlcListView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.dlcListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dlcListView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dlcListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dlcListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dlcListView.ColumnHeadersHeight = 30;
            this.dlcListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dlcListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.img,
            this.name,
            this.appid,
            this.checkBox});
            this.dlcListView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dlcListView.EnableHeadersVisualStyles = false;
            this.dlcListView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.dlcListView.Location = new System.Drawing.Point(15, 111);
            this.dlcListView.MultiSelect = false;
            this.dlcListView.Name = "dlcListView";
            this.dlcListView.RowHeadersVisible = false;
            this.dlcListView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.dlcListView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dlcListView.RowTemplate.Height = 42;
            this.dlcListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dlcListView.Size = new System.Drawing.Size(560, 282);
            this.dlcListView.TabIndex = 23;
            // 
            // img
            // 
            this.img.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.img.HeaderText = "DLC";
            this.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.img.MinimumWidth = 90;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.img.Width = 90;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 100;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // appid
            // 
            this.appid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.appid.DefaultCellStyle = dataGridViewCellStyle2;
            this.appid.HeaderText = "App ID";
            this.appid.MinimumWidth = 100;
            this.appid.Name = "appid";
            this.appid.ReadOnly = true;
            this.appid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.appid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // checkBox
            // 
            this.checkBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.checkBox.ContextMenuStrip = this.columnMenuStrip;
            this.checkBox.FalseValue = "disabled";
            this.checkBox.HeaderText = "Enable";
            this.checkBox.MinimumWidth = 100;
            this.checkBox.Name = "checkBox";
            this.checkBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkBox.ToolTipText = "Right-click to enable or disable all";
            this.checkBox.TrueValue = "enabled";
            // 
            // columnMenuStrip
            // 
            this.columnMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.columnMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.columnMenuStrip.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.columnMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableMenuItem,
            this.disableMenuItem});
            this.columnMenuStrip.Name = "columnMenuStrip";
            this.columnMenuStrip.ShowImageMargin = false;
            this.columnMenuStrip.Size = new System.Drawing.Size(109, 48);
            // 
            // enableMenuItem
            // 
            this.enableMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.enableMenuItem.Name = "enableMenuItem";
            this.enableMenuItem.Size = new System.Drawing.Size(108, 22);
            this.enableMenuItem.Text = "Enable All";
            this.enableMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // disableMenuItem
            // 
            this.disableMenuItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.disableMenuItem.Name = "disableMenuItem";
            this.disableMenuItem.Size = new System.Drawing.Size(108, 22);
            this.disableMenuItem.Text = "Disable All";
            this.disableMenuItem.Click += new System.EventHandler(this.DeselectAllToolStripMenuItem_Click);
            // 
            // btnDLC
            // 
            this.btnDLC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.btnDLC.FlatAppearance.BorderSize = 0;
            this.btnDLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDLC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDLC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.btnDLC.Location = new System.Drawing.Point(89, 82);
            this.btnDLC.Name = "btnDLC";
            this.btnDLC.Size = new System.Drawing.Size(60, 23);
            this.btnDLC.TabIndex = 4;
            this.btnDLC.Text = "DLC";
            this.btnDLC.UseVisualStyleBackColor = false;
            this.btnDLC.Click += new System.EventHandler(this.BtnDLC_Click);
            // 
            // lblGameExe
            // 
            this.lblGameExe.AutoSize = true;
            this.lblGameExe.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameExe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.lblGameExe.Location = new System.Drawing.Point(27, 65);
            this.lblGameExe.Name = "lblGameExe";
            this.lblGameExe.Size = new System.Drawing.Size(101, 14);
            this.lblGameExe.TabIndex = 20;
            this.lblGameExe.Text = "Game Executable";
            // 
            // pnlAPIStatus
            // 
            this.pnlAPIStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAPIStatus.Controls.Add(this.labelSteam);
            this.pnlAPIStatus.Controls.Add(this.lblAPI);
            this.pnlAPIStatus.Controls.Add(this.lblAPI64);
            this.pnlAPIStatus.Controls.Add(this.labelSteam64);
            this.pnlAPIStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.pnlAPIStatus.Location = new System.Drawing.Point(359, 192);
            this.pnlAPIStatus.Name = "pnlAPIStatus";
            this.pnlAPIStatus.Size = new System.Drawing.Size(180, 70);
            this.pnlAPIStatus.TabIndex = 10;
            // 
            // labelSteam64
            // 
            this.labelSteam64.AutoSize = true;
            this.labelSteam64.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSteam64.Location = new System.Drawing.Point(8, 40);
            this.labelSteam64.Name = "labelSteam64";
            this.labelSteam64.Size = new System.Drawing.Size(92, 14);
            this.labelSteam64.TabIndex = 9;
            this.labelSteam64.Text = "steam_api64.dll";
            // 
            // lblAPI64
            // 
            this.lblAPI64.AutoSize = true;
            this.lblAPI64.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPI64.ForeColor = System.Drawing.Color.Red;
            this.lblAPI64.Location = new System.Drawing.Point(106, 40);
            this.lblAPI64.Name = "lblAPI64";
            this.lblAPI64.Size = new System.Drawing.Size(62, 14);
            this.lblAPI64.TabIndex = 0;
            this.lblAPI64.Text = "Not Found";
            // 
            // lblAPI
            // 
            this.lblAPI.AutoSize = true;
            this.lblAPI.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPI.ForeColor = System.Drawing.Color.Red;
            this.lblAPI.Location = new System.Drawing.Point(106, 17);
            this.lblAPI.Name = "lblAPI";
            this.lblAPI.Size = new System.Drawing.Size(62, 14);
            this.lblAPI.TabIndex = 0;
            this.lblAPI.Text = "Not Found";
            // 
            // labelSteam
            // 
            this.labelSteam.AutoSize = true;
            this.labelSteam.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSteam.Location = new System.Drawing.Point(8, 17);
            this.labelSteam.Name = "labelSteam";
            this.labelSteam.Size = new System.Drawing.Size(80, 14);
            this.labelSteam.TabIndex = 8;
            this.labelSteam.Text = "steam_api.dll";
            // 
            // cbExe
            // 
            this.cbExe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.cbExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.cbExe.Location = new System.Drawing.Point(30, 82);
            this.cbExe.Name = "cbExe";
            this.cbExe.Size = new System.Drawing.Size(145, 21);
            this.cbExe.TabIndex = 21;
            this.cbExe.TabStop = false;
            this.toolTips.SetToolTip(this.cbExe, "Select the game executable to fix.\r\nOpen the game and check the .exe from the tas" +
        "k manager.");
            // 
            // tbAppID
            // 
            this.tbAppID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.tbAppID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAppID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.tbAppID.Location = new System.Drawing.Point(30, 35);
            this.tbAppID.Name = "tbAppID";
            this.tbAppID.Size = new System.Drawing.Size(145, 20);
            this.tbAppID.TabIndex = 6;
            this.tbAppID.TextChanged += new System.EventHandler(this.tbAppID_TextChanged);
            this.tbAppID.Leave += new System.EventHandler(this.TextBoxAppID_Leave);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(71)))), ((int)(((byte)(81)))));
            this.pictureBox.BackgroundImage = global::CreamAPI_Generator.Properties.Resources.background;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(209, -1);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(350, 165);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.WaitOnLoad = true;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.Location = new System.Drawing.Point(27, 19);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(77, 14);
            this.lblAppID.TabIndex = 5;
            this.lblAppID.Text = "Game App ID";
            // 
            // labelAPIStatus
            // 
            this.labelAPIStatus.AutoSize = true;
            this.labelAPIStatus.Location = new System.Drawing.Point(365, 185);
            this.labelAPIStatus.Name = "labelAPIStatus";
            this.labelAPIStatus.Size = new System.Drawing.Size(113, 13);
            this.labelAPIStatus.TabIndex = 11;
            this.labelAPIStatus.Text = "Status of steam_api.dll";
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.labelAPIStatus);
            this.pnlMain.Controls.Add(this.lblAppID);
            this.pnlMain.Controls.Add(this.pictureBox);
            this.pnlMain.Controls.Add(this.tbAppID);
            this.pnlMain.Controls.Add(this.cbExe);
            this.pnlMain.Controls.Add(this.pnlAPIStatus);
            this.pnlMain.Controls.Add(this.lblGameExe);
            this.pnlMain.Location = new System.Drawing.Point(15, 111);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(560, 282);
            this.pnlMain.TabIndex = 16;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(591, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.btnDLC);
            this.Controls.Add(this.btnWrapper);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelGameFolder);
            this.Controls.Add(this.dirBox);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.dlcListView);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "CreamAPI Generator";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlcListView)).EndInit();
            this.columnMenuStrip.ResumeLayout(false);
            this.pnlAPIStatus.ResumeLayout(false);
            this.pnlAPIStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox dirBox;
        private System.Windows.Forms.Label labelGameFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnWrapper;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCreamAPI;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dlcListView;
        private System.Windows.Forms.Button btnDLC;
        private System.Windows.Forms.ContextMenuStrip columnMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem enableMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn appid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBox;
        private System.Windows.Forms.Label lblGameExe;
        private System.Windows.Forms.Panel pnlAPIStatus;
        private System.Windows.Forms.Label labelSteam;
        public System.Windows.Forms.Label lblAPI;
        public System.Windows.Forms.Label lblAPI64;
        private System.Windows.Forms.Label labelSteam64;
        private System.Windows.Forms.ComboBox cbExe;
        private System.Windows.Forms.TextBox tbAppID;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label labelAPIStatus;
        private System.Windows.Forms.Panel pnlMain;
    }
}

