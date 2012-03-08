﻿using System.Windows.Forms;
using MagicMongoDBTool.Module;

namespace MagicMongoDBTool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSelectedObj = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SrvStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandAllConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseAllConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataNaviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LastPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.QueryDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AggregationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distinctToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapReduceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExpandAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CollapseAllDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMongoDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.AddUserToAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveUserFromAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.slaveResyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SvrPropertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateMongoCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMongoDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.AddUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.evalJSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RepairDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelMongoCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IndexManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReIndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.DelSelectRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DropElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridFsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InitGFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DumpAndRestoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestoreMongoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DumpDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DumpCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.ImportCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DosCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportDataFromAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DistributedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReplicaSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShardingConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabDataShower = new System.Windows.Forms.TabControl();
            this.tabTreeView = new System.Windows.Forms.TabPage();
            this.trvData = new System.Windows.Forms.TreeView();
            this.tabTableView = new System.Windows.Forms.TabPage();
            this.lstData = new System.Windows.Forms.ListView();
            this.tabTextView = new System.Windows.Forms.TabPage();
            this.lnkFile = new System.Windows.Forms.LinkLabel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.trvsrvlst = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ServerStatusCtl = new MagicMongoDBTool.UserController.ctlServerStatus();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.ViewtoolStrip = new System.Windows.Forms.ToolStrip();
            this.SvrStatustoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ShellCommandtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CollectiontoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.RefreshViewtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.tabDataShower.SuspendLayout();
            this.tabTreeView.SuspendLayout();
            this.tabTableView.SuspendLayout();
            this.tabTextView.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ViewtoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.Color.Transparent;
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSelectedObj,
            this.lblUserInfo});
            this.statusStripMain.Location = new System.Drawing.Point(0, 680);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1223, 22);
            this.statusStripMain.TabIndex = 8;
            // 
            // toolStripStatusSelectedObj
            // 
            this.toolStripStatusSelectedObj.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusSelectedObj.Name = "toolStripStatusSelectedObj";
            this.toolStripStatusSelectedObj.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusSelectedObj.Text = "Ready";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(29, 17);
            this.lblUserInfo.Text = "User";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1223, 25);
            this.toolStripMain.TabIndex = 7;
            this.toolStripMain.Text = "工具栏";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagerToolStripMenuItem,
            this.DataNaviToolStripMenuItem,
            this.OperationToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.DistributedToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1223, 24);
            this.menuStripMain.TabIndex = 6;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // ManagerToolStripMenuItem
            // 
            this.ManagerToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddConnectionToolStripMenuItem,
            this.SrvStatusToolStripMenuItem,
            this.RefreshToolStripMenuItem,
            this.toolStripMenuItem10,
            this.ExpandAllConnectionToolStripMenuItem,
            this.CollapseAllConnectionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem";
            this.ManagerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ManagerToolStripMenuItem.Text = "&Management";
            // 
            // AddConnectionToolStripMenuItem
            // 
            this.AddConnectionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.AddConnectionToolStripMenuItem.Name = "AddConnectionToolStripMenuItem";
            this.AddConnectionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.AddConnectionToolStripMenuItem.Text = "&Connection Manager";
            this.AddConnectionToolStripMenuItem.Click += new System.EventHandler(this.AddConnectionToolStripMenuItem_Click);
            // 
            // SrvStatusToolStripMenuItem
            // 
            this.SrvStatusToolStripMenuItem.Name = "SrvStatusToolStripMenuItem";
            this.SrvStatusToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.SrvStatusToolStripMenuItem.Text = "&Status";
            this.SrvStatusToolStripMenuItem.Click += new System.EventHandler(this.SrvStatusToolStripMenuItem_Click);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(170, 6);
            // 
            // ExpandAllConnectionToolStripMenuItem
            // 
            this.ExpandAllConnectionToolStripMenuItem.Name = "ExpandAllConnectionToolStripMenuItem";
            this.ExpandAllConnectionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ExpandAllConnectionToolStripMenuItem.Text = "Collapse";
            this.ExpandAllConnectionToolStripMenuItem.Click += new System.EventHandler(this.ExpandAllToolStripMenuItem_Click);
            // 
            // CollapseAllConnectionToolStripMenuItem
            // 
            this.CollapseAllConnectionToolStripMenuItem.Name = "CollapseAllConnectionToolStripMenuItem";
            this.CollapseAllConnectionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.CollapseAllConnectionToolStripMenuItem.Text = "Expansion";
            this.CollapseAllConnectionToolStripMenuItem.Click += new System.EventHandler(this.CollapseAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // DataNaviToolStripMenuItem
            // 
            this.DataNaviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrePageToolStripMenuItem,
            this.NextPageToolStripMenuItem,
            this.FirstPageToolStripMenuItem,
            this.LastPageToolStripMenuItem,
            this.toolStripMenuItem9,
            this.QueryDataToolStripMenuItem,
            this.ConvertSqlToolStripMenuItem,
            this.AggregationToolStripMenuItem,
            this.DataFilterToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ExpandAllDataToolStripMenuItem,
            this.CollapseAllDataToolStripMenuItem});
            this.DataNaviToolStripMenuItem.Name = "DataNaviToolStripMenuItem";
            this.DataNaviToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.DataNaviToolStripMenuItem.Text = "&DataView";
            // 
            // PrePageToolStripMenuItem
            // 
            this.PrePageToolStripMenuItem.Name = "PrePageToolStripMenuItem";
            this.PrePageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.PrePageToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.PrePageToolStripMenuItem.Text = "Previous";
            this.PrePageToolStripMenuItem.Click += new System.EventHandler(this.PrePageToolStripMenuItem_Click);
            // 
            // NextPageToolStripMenuItem
            // 
            this.NextPageToolStripMenuItem.Name = "NextPageToolStripMenuItem";
            this.NextPageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.NextPageToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.NextPageToolStripMenuItem.Text = "Next";
            this.NextPageToolStripMenuItem.Click += new System.EventHandler(this.NextPageToolStripMenuItem_Click);
            // 
            // FirstPageToolStripMenuItem
            // 
            this.FirstPageToolStripMenuItem.Name = "FirstPageToolStripMenuItem";
            this.FirstPageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.FirstPageToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.FirstPageToolStripMenuItem.Text = "First";
            this.FirstPageToolStripMenuItem.Click += new System.EventHandler(this.FirstPageToolStripMenuItem_Click);
            // 
            // LastPageToolStripMenuItem
            // 
            this.LastPageToolStripMenuItem.Name = "LastPageToolStripMenuItem";
            this.LastPageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.LastPageToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.LastPageToolStripMenuItem.Text = "Last";
            this.LastPageToolStripMenuItem.Click += new System.EventHandler(this.LastPageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(159, 6);
            // 
            // QueryDataToolStripMenuItem
            // 
            this.QueryDataToolStripMenuItem.Name = "QueryDataToolStripMenuItem";
            this.QueryDataToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.QueryDataToolStripMenuItem.Text = "Query";
            this.QueryDataToolStripMenuItem.Click += new System.EventHandler(this.QueryDataToolStripMenuItem_Click);
            // 
            // ConvertSqlToolStripMenuItem
            // 
            this.ConvertSqlToolStripMenuItem.Name = "ConvertSqlToolStripMenuItem";
            this.ConvertSqlToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ConvertSqlToolStripMenuItem.Text = "Convert Select Sql";
            this.ConvertSqlToolStripMenuItem.Click += new System.EventHandler(this.ConvertSqlToolStripMenuItem_Click);
            // 
            // AggregationToolStripMenuItem
            // 
            this.AggregationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countToolStripMenuItem,
            this.distinctToolStripMenuItem,
            this.groupToolStripMenuItem,
            this.mapReduceToolStripMenuItem});
            this.AggregationToolStripMenuItem.Name = "AggregationToolStripMenuItem";
            this.AggregationToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.AggregationToolStripMenuItem.Text = "Aggregation";
            // 
            // countToolStripMenuItem
            // 
            this.countToolStripMenuItem.Name = "countToolStripMenuItem";
            this.countToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.countToolStripMenuItem.Text = "Count";
            this.countToolStripMenuItem.Click += new System.EventHandler(this.countToolStripMenuItem_Click);
            // 
            // distinctToolStripMenuItem
            // 
            this.distinctToolStripMenuItem.Name = "distinctToolStripMenuItem";
            this.distinctToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.distinctToolStripMenuItem.Text = "Distinct";
            this.distinctToolStripMenuItem.Click += new System.EventHandler(this.distinctToolStripMenuItem_Click);
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // mapReduceToolStripMenuItem
            // 
            this.mapReduceToolStripMenuItem.Name = "mapReduceToolStripMenuItem";
            this.mapReduceToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mapReduceToolStripMenuItem.Text = "MapReduce";
            this.mapReduceToolStripMenuItem.Click += new System.EventHandler(this.mapReduceToolStripMenuItem_Click);
            // 
            // DataFilterToolStripMenuItem
            // 
            this.DataFilterToolStripMenuItem.Name = "DataFilterToolStripMenuItem";
            this.DataFilterToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.DataFilterToolStripMenuItem.Text = "Data Filter";
            this.DataFilterToolStripMenuItem.Click += new System.EventHandler(this.DataFilterToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 6);
            // 
            // ExpandAllDataToolStripMenuItem
            // 
            this.ExpandAllDataToolStripMenuItem.Name = "ExpandAllDataToolStripMenuItem";
            this.ExpandAllDataToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ExpandAllDataToolStripMenuItem.Text = "Collapse";
            this.ExpandAllDataToolStripMenuItem.Click += new System.EventHandler(this.ExpandAllDataToolStripMenuItem_Click);
            // 
            // CollapseAllDataToolStripMenuItem
            // 
            this.CollapseAllDataToolStripMenuItem.Name = "CollapseAllDataToolStripMenuItem";
            this.CollapseAllDataToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CollapseAllDataToolStripMenuItem.Text = "Expansion";
            this.CollapseAllDataToolStripMenuItem.Click += new System.EventHandler(this.CollapseAllDataToolStripMenuItem_Click);
            // 
            // OperationToolStripMenuItem
            // 
            this.OperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerToolStripMenuItem,
            this.DataBaseToolStripMenuItem,
            this.DataCollectionToolStripMenuItem,
            this.DataDocumentToolStripMenuItem,
            this.GridFsToolStripMenuItem,
            this.DumpAndRestoreToolStripMenuItem});
            this.OperationToolStripMenuItem.Name = "OperationToolStripMenuItem";
            this.OperationToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.OperationToolStripMenuItem.Text = "&Operation";
            // 
            // ServerToolStripMenuItem
            // 
            this.ServerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMongoDBToolStripMenuItem,
            this.toolStripMenuItem4,
            this.AddUserToAdminToolStripMenuItem,
            this.RemoveUserFromAdminToolStripMenuItem,
            this.toolStripMenuItem3,
            this.slaveResyncToolStripMenuItem,
            this.DisconnectToolStripMenuItem,
            this.ShutDownToolStripMenuItem,
            this.SvrPropertyToolStripMenuItem});
            this.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem";
            this.ServerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ServerToolStripMenuItem.Text = "Server";
            // 
            // CreateMongoDBToolStripMenuItem
            // 
            this.CreateMongoDBToolStripMenuItem.Name = "CreateMongoDBToolStripMenuItem";
            this.CreateMongoDBToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.CreateMongoDBToolStripMenuItem.Text = "New Database";
            this.CreateMongoDBToolStripMenuItem.Click += new System.EventHandler(this.CreateMongoDBToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(202, 6);
            // 
            // AddUserToAdminToolStripMenuItem
            // 
            this.AddUserToAdminToolStripMenuItem.Name = "AddUserToAdminToolStripMenuItem";
            this.AddUserToAdminToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.AddUserToAdminToolStripMenuItem.Text = "Add User To Admin Group";
            this.AddUserToAdminToolStripMenuItem.Click += new System.EventHandler(this.AddUserToAdminToolStripMenuItem_Click);
            // 
            // RemoveUserFromAdminToolStripMenuItem
            // 
            this.RemoveUserFromAdminToolStripMenuItem.Name = "RemoveUserFromAdminToolStripMenuItem";
            this.RemoveUserFromAdminToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.RemoveUserFromAdminToolStripMenuItem.Text = "Del User From Admin Group";
            this.RemoveUserFromAdminToolStripMenuItem.Click += new System.EventHandler(this.RemoveUserFromAdminToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(202, 6);
            // 
            // slaveResyncToolStripMenuItem
            // 
            this.slaveResyncToolStripMenuItem.Name = "slaveResyncToolStripMenuItem";
            this.slaveResyncToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.slaveResyncToolStripMenuItem.Text = "Slave Resync";
            this.slaveResyncToolStripMenuItem.Click += new System.EventHandler(this.slaveResyncToolStripMenuItem_Click);
            // 
            // DisconnectToolStripMenuItem
            // 
            this.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem";
            this.DisconnectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.DisconnectToolStripMenuItem.Text = "Disconnect";
            this.DisconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // ShutDownToolStripMenuItem
            // 
            this.ShutDownToolStripMenuItem.Name = "ShutDownToolStripMenuItem";
            this.ShutDownToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ShutDownToolStripMenuItem.Text = "ShutDown Server";
            this.ShutDownToolStripMenuItem.Click += new System.EventHandler(this.ShutDownToolStripMenuItem_Click);
            // 
            // SvrPropertyToolStripMenuItem
            // 
            this.SvrPropertyToolStripMenuItem.Name = "SvrPropertyToolStripMenuItem";
            this.SvrPropertyToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SvrPropertyToolStripMenuItem.Text = "Server Properties";
            this.SvrPropertyToolStripMenuItem.Click += new System.EventHandler(this.SvrPropertyToolStripMenuItem_Click);
            // 
            // DataBaseToolStripMenuItem
            // 
            this.DataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMongoCollectionToolStripMenuItem,
            this.DelMongoDBToolStripMenuItem,
            this.toolStripMenuItem5,
            this.AddUserToolStripMenuItem,
            this.RemoveUserToolStripMenuItem,
            this.toolStripMenuItem11,
            this.evalJSToolStripMenuItem,
            this.RepairDBToolStripMenuItem});
            this.DataBaseToolStripMenuItem.Name = "DataBaseToolStripMenuItem";
            this.DataBaseToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DataBaseToolStripMenuItem.Text = "Database";
            // 
            // CreateMongoCollectionToolStripMenuItem
            // 
            this.CreateMongoCollectionToolStripMenuItem.Name = "CreateMongoCollectionToolStripMenuItem";
            this.CreateMongoCollectionToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.CreateMongoCollectionToolStripMenuItem.Text = "New Collection";
            this.CreateMongoCollectionToolStripMenuItem.Click += new System.EventHandler(this.CreateMongoCollectionToolStripMenuItem_Click);
            // 
            // DelMongoDBToolStripMenuItem
            // 
            this.DelMongoDBToolStripMenuItem.Name = "DelMongoDBToolStripMenuItem";
            this.DelMongoDBToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.DelMongoDBToolStripMenuItem.Text = "Del Database";
            this.DelMongoDBToolStripMenuItem.Click += new System.EventHandler(this.DelMongoDBToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(151, 6);
            // 
            // AddUserToolStripMenuItem
            // 
            this.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem";
            this.AddUserToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddUserToolStripMenuItem.Text = "Add User";
            this.AddUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // RemoveUserToolStripMenuItem
            // 
            this.RemoveUserToolStripMenuItem.Name = "RemoveUserToolStripMenuItem";
            this.RemoveUserToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.RemoveUserToolStripMenuItem.Text = "Del User";
            this.RemoveUserToolStripMenuItem.Click += new System.EventHandler(this.RemoveUserToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(151, 6);
            // 
            // evalJSToolStripMenuItem
            // 
            this.evalJSToolStripMenuItem.Name = "evalJSToolStripMenuItem";
            this.evalJSToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.evalJSToolStripMenuItem.Text = "Eval Javascript";
            this.evalJSToolStripMenuItem.Click += new System.EventHandler(this.evalJSToolStripMenuItem_Click);
            // 
            // RepairDBToolStripMenuItem
            // 
            this.RepairDBToolStripMenuItem.Name = "RepairDBToolStripMenuItem";
            this.RepairDBToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.RepairDBToolStripMenuItem.Text = "Repair Database";
            this.RepairDBToolStripMenuItem.Click += new System.EventHandler(this.RepairDBToolStripMenuItem_Click);
            // 
            // DataCollectionToolStripMenuItem
            // 
            this.DataCollectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelMongoCollectionToolStripMenuItem,
            this.RenameCollectionToolStripMenuItem,
            this.IndexManageToolStripMenuItem,
            this.ReIndexToolStripMenuItem,
            this.toolStripMenuItem8,
            this.DelSelectRecordToolStripMenuItem,
            this.CompactToolStripMenuItem});
            this.DataCollectionToolStripMenuItem.Name = "DataCollectionToolStripMenuItem";
            this.DataCollectionToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DataCollectionToolStripMenuItem.Text = "Collection";
            // 
            // DelMongoCollectionToolStripMenuItem
            // 
            this.DelMongoCollectionToolStripMenuItem.Name = "DelMongoCollectionToolStripMenuItem";
            this.DelMongoCollectionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.DelMongoCollectionToolStripMenuItem.Text = "Drop Collection";
            this.DelMongoCollectionToolStripMenuItem.Click += new System.EventHandler(this.DelMongoCollectionToolStripMenuItem_Click);
            // 
            // RenameCollectionToolStripMenuItem
            // 
            this.RenameCollectionToolStripMenuItem.Name = "RenameCollectionToolStripMenuItem";
            this.RenameCollectionToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.RenameCollectionToolStripMenuItem.Text = "Rename";
            this.RenameCollectionToolStripMenuItem.Click += new System.EventHandler(this.RenameCollectionToolStripMenuItem_Click);
            // 
            // IndexManageToolStripMenuItem
            // 
            this.IndexManageToolStripMenuItem.Name = "IndexManageToolStripMenuItem";
            this.IndexManageToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.IndexManageToolStripMenuItem.Text = "Index Management";
            this.IndexManageToolStripMenuItem.Click += new System.EventHandler(this.IndexManageToolStripMenuItem_Click);
            // 
            // ReIndexToolStripMenuItem
            // 
            this.ReIndexToolStripMenuItem.Name = "ReIndexToolStripMenuItem";
            this.ReIndexToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ReIndexToolStripMenuItem.Text = "ReIndex";
            this.ReIndexToolStripMenuItem.Click += new System.EventHandler(this.ReIndexToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(187, 6);
            // 
            // DelSelectRecordToolStripMenuItem
            // 
            this.DelSelectRecordToolStripMenuItem.Name = "DelSelectRecordToolStripMenuItem";
            this.DelSelectRecordToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.DelSelectRecordToolStripMenuItem.Text = "Delect Selected Records";
            this.DelSelectRecordToolStripMenuItem.Click += new System.EventHandler(this.DelSelectRecordToolStripMenuItem_Click);
            // 
            // CompactToolStripMenuItem
            // 
            this.CompactToolStripMenuItem.Name = "CompactToolStripMenuItem";
            this.CompactToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.CompactToolStripMenuItem.Text = "Compact";
            this.CompactToolStripMenuItem.Click += new System.EventHandler(this.CompactToolStripMenuItem_Click);
            // 
            // DataDocumentToolStripMenuItem
            // 
            this.DataDocumentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddElementToolStripMenuItem,
            this.DropElementToolStripMenuItem,
            this.ModifyElementToolStripMenuItem,
            this.AddDocumentToolStripMenuItem,
            this.toolStripMenuItem12,
            this.CopyElementToolStripMenuItem,
            this.CutElementToolStripMenuItem,
            this.PasteElementToolStripMenuItem});
            this.DataDocumentToolStripMenuItem.Name = "DataDocumentToolStripMenuItem";
            this.DataDocumentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DataDocumentToolStripMenuItem.Text = "Document";
            // 
            // AddElementToolStripMenuItem
            // 
            this.AddElementToolStripMenuItem.Name = "AddElementToolStripMenuItem";
            this.AddElementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddElementToolStripMenuItem.Text = "Add Element";
            this.AddElementToolStripMenuItem.Click += new System.EventHandler(this.AddElementToolStripMenuItem_Click);
            // 
            // DropElementToolStripMenuItem
            // 
            this.DropElementToolStripMenuItem.Name = "DropElementToolStripMenuItem";
            this.DropElementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DropElementToolStripMenuItem.Text = "Drop Element";
            this.DropElementToolStripMenuItem.Click += new System.EventHandler(this.DropElementToolStripMenuItem_Click);
            // 
            // ModifyElementToolStripMenuItem
            // 
            this.ModifyElementToolStripMenuItem.Name = "ModifyElementToolStripMenuItem";
            this.ModifyElementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ModifyElementToolStripMenuItem.Text = "Modify Element";
            this.ModifyElementToolStripMenuItem.Click += new System.EventHandler(this.ModifyElementToolStripMenuItem_Click);
            // 
            // AddDocumentToolStripMenuItem
            // 
            this.AddDocumentToolStripMenuItem.Name = "AddDocumentToolStripMenuItem";
            this.AddDocumentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddDocumentToolStripMenuItem.Text = "Add Document";
            this.AddDocumentToolStripMenuItem.Click += new System.EventHandler(this.AddDocumentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(177, 6);
            // 
            // CopyElementToolStripMenuItem
            // 
            this.CopyElementToolStripMenuItem.Name = "CopyElementToolStripMenuItem";
            this.CopyElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyElementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopyElementToolStripMenuItem.Text = "Copy Element";
            this.CopyElementToolStripMenuItem.Click += new System.EventHandler(this.CopyElementToolStripMenuItem_Click);
            // 
            // CutElementToolStripMenuItem
            // 
            this.CutElementToolStripMenuItem.Name = "CutElementToolStripMenuItem";
            this.CutElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutElementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CutElementToolStripMenuItem.Text = "Cut Element";
            this.CutElementToolStripMenuItem.Click += new System.EventHandler(this.CutElementToolStripMenuItem_Click);
            // 
            // PasteElementToolStripMenuItem
            // 
            this.PasteElementToolStripMenuItem.Name = "PasteElementToolStripMenuItem";
            this.PasteElementToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteElementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PasteElementToolStripMenuItem.Text = "Paste Element";
            this.PasteElementToolStripMenuItem.Click += new System.EventHandler(this.PasteElementToolStripMenuItem_Click);
            // 
            // GridFsToolStripMenuItem
            // 
            this.GridFsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UploadFileToolStripMenuItem,
            this.DownloadFileToolStripMenuItem,
            this.OpenFileToolStripMenuItem,
            this.DelFileToolStripMenuItem,
            this.InitGFSToolStripMenuItem});
            this.GridFsToolStripMenuItem.Name = "GridFsToolStripMenuItem";
            this.GridFsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.GridFsToolStripMenuItem.Text = "Grid File System";
            // 
            // UploadFileToolStripMenuItem
            // 
            this.UploadFileToolStripMenuItem.Name = "UploadFileToolStripMenuItem";
            this.UploadFileToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.UploadFileToolStripMenuItem.Text = "Upload File";
            this.UploadFileToolStripMenuItem.Click += new System.EventHandler(this.UploadFileToolStripMenuItem_Click);
            // 
            // DownloadFileToolStripMenuItem
            // 
            this.DownloadFileToolStripMenuItem.Name = "DownloadFileToolStripMenuItem";
            this.DownloadFileToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.DownloadFileToolStripMenuItem.Text = "Download File";
            this.DownloadFileToolStripMenuItem.Click += new System.EventHandler(this.DownloadFileToolStripMenuItem_Click);
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.OpenFileToolStripMenuItem.Text = "Open File";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // DelFileToolStripMenuItem
            // 
            this.DelFileToolStripMenuItem.Name = "DelFileToolStripMenuItem";
            this.DelFileToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.DelFileToolStripMenuItem.Text = "Delete File";
            this.DelFileToolStripMenuItem.Click += new System.EventHandler(this.DelFileToolStripMenuItem_Click);
            // 
            // InitGFSToolStripMenuItem
            // 
            this.InitGFSToolStripMenuItem.Name = "InitGFSToolStripMenuItem";
            this.InitGFSToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.InitGFSToolStripMenuItem.Text = "Init GFS";
            this.InitGFSToolStripMenuItem.Click += new System.EventHandler(this.InitGFSToolStripMenuItem_Click);
            // 
            // DumpAndRestoreToolStripMenuItem
            // 
            this.DumpAndRestoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreMongoToolStripMenuItem,
            this.DumpDatabaseToolStripMenuItem,
            this.DumpCollectionToolStripMenuItem,
            this.toolStripMenuItem6,
            this.ImportCollectionToolStripMenuItem,
            this.ExportCollectionToolStripMenuItem});
            this.DumpAndRestoreToolStripMenuItem.Name = "DumpAndRestoreToolStripMenuItem";
            this.DumpAndRestoreToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.DumpAndRestoreToolStripMenuItem.Text = "Dump And Restore";
            // 
            // RestoreMongoToolStripMenuItem
            // 
            this.RestoreMongoToolStripMenuItem.Name = "RestoreMongoToolStripMenuItem";
            this.RestoreMongoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.RestoreMongoToolStripMenuItem.Text = "Restore";
            this.RestoreMongoToolStripMenuItem.Click += new System.EventHandler(this.RestoreMongoToolStripMenuItem_Click);
            // 
            // DumpDatabaseToolStripMenuItem
            // 
            this.DumpDatabaseToolStripMenuItem.Name = "DumpDatabaseToolStripMenuItem";
            this.DumpDatabaseToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.DumpDatabaseToolStripMenuItem.Text = "Dump DataBase";
            this.DumpDatabaseToolStripMenuItem.Click += new System.EventHandler(this.DumpDatabaseToolStripMenuItem_Click);
            // 
            // DumpCollectionToolStripMenuItem
            // 
            this.DumpCollectionToolStripMenuItem.Name = "DumpCollectionToolStripMenuItem";
            this.DumpCollectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.DumpCollectionToolStripMenuItem.Text = "Dump Collection";
            this.DumpCollectionToolStripMenuItem.Click += new System.EventHandler(this.DumpCollectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(175, 6);
            // 
            // ImportCollectionToolStripMenuItem
            // 
            this.ImportCollectionToolStripMenuItem.Name = "ImportCollectionToolStripMenuItem";
            this.ImportCollectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ImportCollectionToolStripMenuItem.Text = "Import DataCollection";
            this.ImportCollectionToolStripMenuItem.Click += new System.EventHandler(this.ImportCollectionToolStripMenuItem_Click);
            // 
            // ExportCollectionToolStripMenuItem
            // 
            this.ExportCollectionToolStripMenuItem.Name = "ExportCollectionToolStripMenuItem";
            this.ExportCollectionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ExportCollectionToolStripMenuItem.Text = "Export DataCollection";
            this.ExportCollectionToolStripMenuItem.Click += new System.EventHandler(this.ExportCollectionToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DosCommandToolStripMenuItem,
            this.ImportDataFromAccessToolStripMenuItem,
            this.toolStripMenuItem7,
            this.OptionsToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ToolsToolStripMenuItem.Text = "&Tools";
            // 
            // DosCommandToolStripMenuItem
            // 
            this.DosCommandToolStripMenuItem.Name = "DosCommandToolStripMenuItem";
            this.DosCommandToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.DosCommandToolStripMenuItem.Text = "&DOS Command";
            this.DosCommandToolStripMenuItem.Click += new System.EventHandler(this.DosCommandToolStripMenuItem_Click);
            // 
            // ImportDataFromAccessToolStripMenuItem
            // 
            this.ImportDataFromAccessToolStripMenuItem.Name = "ImportDataFromAccessToolStripMenuItem";
            this.ImportDataFromAccessToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ImportDataFromAccessToolStripMenuItem.Text = "&Import Access DB";
            this.ImportDataFromAccessToolStripMenuItem.Click += new System.EventHandler(this.ImportDataFromAccessToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(155, 6);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.OptionsToolStripMenuItem.Text = "&Options";
            this.OptionsToolStripMenuItem.Click += new System.EventHandler(this.OptionToolStripMenuItem_Click);
            // 
            // DistributedToolStripMenuItem
            // 
            this.DistributedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReplicaSetToolStripMenuItem,
            this.ShardingConfigToolStripMenuItem});
            this.DistributedToolStripMenuItem.Name = "DistributedToolStripMenuItem";
            this.DistributedToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.DistributedToolStripMenuItem.Text = "D&istributed";
            // 
            // ReplicaSetToolStripMenuItem
            // 
            this.ReplicaSetToolStripMenuItem.Name = "ReplicaSetToolStripMenuItem";
            this.ReplicaSetToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ReplicaSetToolStripMenuItem.Text = "&ReplicaSet";
            this.ReplicaSetToolStripMenuItem.Click += new System.EventHandler(this.ReplicaSetToolStripMenuItem_Click);
            // 
            // ShardingConfigToolStripMenuItem
            // 
            this.ShardingConfigToolStripMenuItem.Name = "ShardingConfigToolStripMenuItem";
            this.ShardingConfigToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ShardingConfigToolStripMenuItem.Text = "&Sharding Config";
            this.ShardingConfigToolStripMenuItem.Click += new System.EventHandler(this.ShardingConfigToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.ThanksToolStripMenuItem,
            this.UserGuideToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.AboutToolStripMenuItem.Text = "&About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ThanksToolStripMenuItem
            // 
            this.ThanksToolStripMenuItem.Name = "ThanksToolStripMenuItem";
            this.ThanksToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ThanksToolStripMenuItem.Text = "&Thanks";
            this.ThanksToolStripMenuItem.Click += new System.EventHandler(this.ThanksToolStripMenuItem_Click);
            // 
            // UserGuideToolStripMenuItem
            // 
            this.UserGuideToolStripMenuItem.Name = "UserGuideToolStripMenuItem";
            this.UserGuideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.UserGuideToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.UserGuideToolStripMenuItem.Text = "UserGuide";
            this.UserGuideToolStripMenuItem.Click += new System.EventHandler(this.userGuideToolStripMenuItem_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(61, 4);
            // 
            // tabDataShower
            // 
            this.tabDataShower.Controls.Add(this.tabTreeView);
            this.tabDataShower.Controls.Add(this.tabTableView);
            this.tabDataShower.Controls.Add(this.tabTextView);
            this.tabDataShower.Location = new System.Drawing.Point(32, 26);
            this.tabDataShower.Name = "tabDataShower";
            this.tabDataShower.SelectedIndex = 0;
            this.tabDataShower.Size = new System.Drawing.Size(590, 550);
            this.tabDataShower.TabIndex = 0;
            // 
            // tabTreeView
            // 
            this.tabTreeView.BackColor = System.Drawing.Color.Orange;
            this.tabTreeView.Controls.Add(this.trvData);
            this.tabTreeView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabTreeView.Location = new System.Drawing.Point(4, 25);
            this.tabTreeView.Name = "tabTreeView";
            this.tabTreeView.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreeView.Size = new System.Drawing.Size(582, 521);
            this.tabTreeView.TabIndex = 0;
            this.tabTreeView.Text = "TreeView";
            // 
            // trvData
            // 
            this.trvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvData.Location = new System.Drawing.Point(3, 3);
            this.trvData.Name = "trvData";
            this.trvData.Size = new System.Drawing.Size(576, 515);
            this.trvData.TabIndex = 0;
            // 
            // tabTableView
            // 
            this.tabTableView.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabTableView.Controls.Add(this.lstData);
            this.tabTableView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabTableView.Location = new System.Drawing.Point(4, 25);
            this.tabTableView.Name = "tabTableView";
            this.tabTableView.Padding = new System.Windows.Forms.Padding(3);
            this.tabTableView.Size = new System.Drawing.Size(582, 521);
            this.tabTableView.TabIndex = 1;
            this.tabTableView.Text = "TableView";
            // 
            // lstData
            // 
            this.lstData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstData.FullRowSelect = true;
            this.lstData.GridLines = true;
            this.lstData.HideSelection = false;
            this.lstData.Location = new System.Drawing.Point(3, 3);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(576, 518);
            this.lstData.TabIndex = 1;
            this.lstData.UseCompatibleStateImageBehavior = false;
            this.lstData.View = System.Windows.Forms.View.Details;
            // 
            // tabTextView
            // 
            this.tabTextView.BackColor = System.Drawing.Color.Yellow;
            this.tabTextView.Controls.Add(this.lnkFile);
            this.tabTextView.Controls.Add(this.txtData);
            this.tabTextView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabTextView.Location = new System.Drawing.Point(4, 25);
            this.tabTextView.Name = "tabTextView";
            this.tabTextView.Padding = new System.Windows.Forms.Padding(3);
            this.tabTextView.Size = new System.Drawing.Size(582, 521);
            this.tabTextView.TabIndex = 2;
            this.tabTextView.Text = "TextView";
            // 
            // lnkFile
            // 
            this.lnkFile.AutoSize = true;
            this.lnkFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.lnkFile.Location = new System.Drawing.Point(470, 3);
            this.lnkFile.Name = "lnkFile";
            this.lnkFile.Size = new System.Drawing.Size(134, 16);
            this.lnkFile.TabIndex = 1;
            this.lnkFile.TabStop = true;
            this.lnkFile.Text = "Open In Native Editor";
            this.lnkFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFile_LinkClicked);
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(3, 3);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(576, 515);
            this.txtData.TabIndex = 0;
            // 
            // trvsrvlst
            // 
            this.trvsrvlst.BackColor = System.Drawing.Color.White;
            this.trvsrvlst.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvsrvlst.Location = new System.Drawing.Point(0, 0);
            this.trvsrvlst.Name = "trvsrvlst";
            this.trvsrvlst.Size = new System.Drawing.Size(334, 631);
            this.trvsrvlst.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.trvsrvlst);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 631);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ViewtoolStrip);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(337, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 631);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ServerStatusCtl);
            this.panel3.Controls.Add(this.tabDataShower);
            this.panel3.Controls.Add(this.txtCommand);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(886, 606);
            this.panel3.TabIndex = 2;
            // 
            // ServerStatusCtl
            // 
            this.ServerStatusCtl.Location = new System.Drawing.Point(731, 51);
            this.ServerStatusCtl.Margin = new System.Windows.Forms.Padding(4);
            this.ServerStatusCtl.Name = "ServerStatusCtl";
            this.ServerStatusCtl.Size = new System.Drawing.Size(128, 313);
            this.ServerStatusCtl.TabIndex = 2;
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(624, 51);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(100, 313);
            this.txtCommand.TabIndex = 1;
            // 
            // ViewtoolStrip
            // 
            this.ViewtoolStrip.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewtoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshViewtoolStripButton,
            this.SvrStatustoolStripButton,
            this.ShellCommandtoolStripButton,
            this.toolStripSeparator1,
            this.CollectiontoolStripButton});
            this.ViewtoolStrip.Location = new System.Drawing.Point(0, 0);
            this.ViewtoolStrip.Name = "ViewtoolStrip";
            this.ViewtoolStrip.Size = new System.Drawing.Size(886, 25);
            this.ViewtoolStrip.TabIndex = 1;
            this.ViewtoolStrip.Text = "toolStrip1";
            // 
            // SvrStatustoolStripButton
            // 
            this.SvrStatustoolStripButton.CheckOnClick = true;
            this.SvrStatustoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SvrStatustoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SvrStatustoolStripButton.Image")));
            this.SvrStatustoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SvrStatustoolStripButton.Name = "SvrStatustoolStripButton";
            this.SvrStatustoolStripButton.Size = new System.Drawing.Size(46, 22);
            this.SvrStatustoolStripButton.Text = "Status";
            this.SvrStatustoolStripButton.Click += new System.EventHandler(this.StatustoolStripButton_Click);
            // 
            // ShellCommandtoolStripButton
            // 
            this.ShellCommandtoolStripButton.CheckOnClick = true;
            this.ShellCommandtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ShellCommandtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ShellCommandtoolStripButton.Image")));
            this.ShellCommandtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShellCommandtoolStripButton.Name = "ShellCommandtoolStripButton";
            this.ShellCommandtoolStripButton.Size = new System.Drawing.Size(94, 22);
            this.ShellCommandtoolStripButton.Text = "Shell Command";
            this.ShellCommandtoolStripButton.Click += new System.EventHandler(this.ShellCommandtoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CollectiontoolStripButton
            // 
            this.CollectiontoolStripButton.CheckOnClick = true;
            this.CollectiontoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CollectiontoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CollectiontoolStripButton.Image")));
            this.CollectiontoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CollectiontoolStripButton.Name = "CollectiontoolStripButton";
            this.CollectiontoolStripButton.Size = new System.Drawing.Size(63, 22);
            this.CollectiontoolStripButton.Text = "Collection";
            this.CollectiontoolStripButton.Click += new System.EventHandler(this.CollectiontoolStripButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(334, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 631);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // RefreshViewtoolStripButton
            // 
            this.RefreshViewtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshViewtoolStripButton.Image = global::MagicMongoDBTool.Properties.Resources.Refresh;
            this.RefreshViewtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshViewtoolStripButton.Name = "RefreshViewtoolStripButton";
            this.RefreshViewtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshViewtoolStripButton.Click += new System.EventHandler(this.RefreshViewtoolStripButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1223, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mongo-Cola";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabDataShower.ResumeLayout(false);
            this.tabTreeView.ResumeLayout(false);
            this.tabTableView.ResumeLayout(false);
            this.tabTextView.ResumeLayout(false);
            this.tabTextView.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ViewtoolStrip.ResumeLayout(false);
            this.ViewtoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /// <summary>
        /// 设置图标
        /// </summary>
        private void SetMenuImage()
        {
            this.PrePageToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.PrePage);
            this.NextPageToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.NextPage);
            this.FirstPageToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.FirstPage);
            this.LastPageToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.LastPage);
            this.QueryDataToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.Query);
            this.DataFilterToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.Filter);

            this.DelMongoCollectionToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();
            this.DelMongoDBToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();
            this.RemoveUserFromAdminToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();
            this.RemoveUserToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();
            this.DelSelectRecordToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();
            this.DropElementToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();
            this.DelFileToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetIcon(IconType.No).ToBitmap();

            this.ImportDataFromAccessToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.AccessDB);
            this.RefreshToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.Refresh);
            this.OptionsToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.Option);

            this.ThanksToolStripMenuItem.Image = MagicMongoDBTool.Module.GetResource.GetImage(MagicMongoDBTool.Module.ImageType.Smile);

        }
        /// <summary>
        /// 初始化Toolbar
        /// </summary>
        private void InitToolBar()
        {


            FirstPageToolStripButton = this.FirstPageToolStripMenuItem.CloneFromMenuItem();
            PrePageToolStripButton = this.PrePageToolStripMenuItem.CloneFromMenuItem();
            NextPageToolStripButton = this.NextPageToolStripMenuItem.CloneFromMenuItem();
            LastPageToolStripButton = this.LastPageToolStripMenuItem.CloneFromMenuItem();
            QueryDataToolStripButton = this.QueryDataToolStripMenuItem.CloneFromMenuItem();
            DataFilterToolStripButton = this.DataFilterToolStripMenuItem.CloneFromMenuItem();
            DataNaviToolStripLabel = new ToolStripLabel();
            RefreshToolStripButton = this.RefreshToolStripMenuItem.CloneFromMenuItem();
            ImportDataFromAccessToolStripButton = this.ImportDataFromAccessToolStripMenuItem.CloneFromMenuItem();
            OptionToolStripButton = this.OptionsToolStripMenuItem.CloneFromMenuItem();

#if MONO
            FirstPageToolStripButton.Click += new System.EventHandler(FirstPageToolStripMenuItem_Click);
            PrePageToolStripButton.Click += new System.EventHandler(PrePageToolStripMenuItem_Click);
            NextPageToolStripButton.Click += new System.EventHandler(NextPageToolStripMenuItem_Click);
            LastPageToolStripButton.Click += new System.EventHandler(LastPageToolStripMenuItem_Click);
            QueryDataToolStripButton.Click += new System.EventHandler(QueryDataToolStripMenuItem_Click);
            DataFilterToolStripButton.Click += new System.EventHandler(DataFilterToolStripMenuItem_Click);
            RefreshToolStripButton.Click += new System.EventHandler(RefreshToolStripMenuItem_Click);
            ImportDataFromAccessToolStripButton.Click += new System.EventHandler(ImportDataFromAccessToolStripMenuItem_Click);
            OptionToolStripButton.Click += new System.EventHandler(OptionToolStripMenuItem_Click);
#endif
            this.ViewtoolStrip.Items.Add(FirstPageToolStripButton);
            this.ViewtoolStrip.Items.Add(PrePageToolStripButton);
            this.ViewtoolStrip.Items.Add(NextPageToolStripButton);
            this.ViewtoolStrip.Items.Add(LastPageToolStripButton);
            this.ViewtoolStrip.Items.Add(QueryDataToolStripButton);
            this.ViewtoolStrip.Items.Add(DataNaviToolStripLabel);
            this.ViewtoolStrip.Items.Add(DataFilterToolStripButton);

            this.toolStripMain.Items.Add(RefreshToolStripButton);
#if !MONO
            this.toolStripMain.Items.Add(ImportDataFromAccessToolStripButton);
#endif
            this.toolStripMain.Items.Add(OptionToolStripButton);
        }
        /// <summary>
        /// 设定工具栏
        /// </summary>
        private void SetToolBarEnabled()
        {
            FirstPageToolStripButton.Enabled = this.FirstPageToolStripMenuItem.Enabled;
            PrePageToolStripButton.Enabled = this.PrePageToolStripMenuItem.Enabled;
            NextPageToolStripButton.Enabled = this.NextPageToolStripMenuItem.Enabled;
            LastPageToolStripButton.Enabled = this.LastPageToolStripMenuItem.Enabled;
            QueryDataToolStripButton.Enabled = this.QueryDataToolStripMenuItem.Enabled;
            DataFilterToolStripButton.Enabled = this.DataFilterToolStripMenuItem.Enabled;
            DataFilterToolStripButton.Checked = this.DataFilterToolStripMenuItem.Checked;
            RefreshToolStripButton.Enabled = this.RefreshToolStripMenuItem.Enabled;
#if !MONO
            ImportDataFromAccessToolStripButton.Enabled = this.ImportDataFromAccessToolStripMenuItem.Enabled;
#endif
            OptionToolStripButton.Enabled = this.OptionsToolStripMenuItem.Enabled;
        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSelectedObj;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SrvStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataNaviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NextPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FirstPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LastPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QueryDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMongoDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelMongoDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateMongoCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelMongoCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IndexManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelSelectRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GridFsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DownloadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DosCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportDataFromAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DistributedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReplicaSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShardingConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapReduceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem AddUserToAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThanksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InitGFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpandAllConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CollapseAllConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SvrPropertyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExpandAllDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CollapseAllDataToolStripMenuItem;

        private ToolStripButton ImportDataFromAccessToolStripButton;
        private ToolStripButton RefreshToolStripButton;
        private ToolStripButton OptionToolStripButton;

        private ToolStripButton NextPageToolStripButton;
        private ToolStripButton PrePageToolStripButton;
        private ToolStripButton FirstPageToolStripButton;
        private ToolStripButton LastPageToolStripButton;
        private ToolStripButton QueryDataToolStripButton;
        private ToolStripButton DataFilterToolStripButton;
        private ToolStripLabel DataNaviToolStripLabel;
        private ToolStripMenuItem DumpAndRestoreToolStripMenuItem;
        private ToolStripMenuItem RestoreMongoToolStripMenuItem;
        private ToolStripMenuItem DumpDatabaseToolStripMenuItem;
        private ToolStripMenuItem DumpCollectionToolStripMenuItem;
        private ToolStripMenuItem ImportCollectionToolStripMenuItem;
        private ToolStripMenuItem ExportCollectionToolStripMenuItem;
        private ToolStripMenuItem DataFilterToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem9;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem ReIndexToolStripMenuItem;
        private ToolStripMenuItem AggregationToolStripMenuItem;
        private ToolStripMenuItem countToolStripMenuItem;
        private ToolStripMenuItem distinctToolStripMenuItem;
        private ToolStripMenuItem groupToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem11;
        private ToolStripMenuItem evalJSToolStripMenuItem;
        private ToolStripMenuItem ConvertSqlToolStripMenuItem;
        private ToolStripMenuItem RemoveUserFromAdminToolStripMenuItem;
        private ToolStripMenuItem DataDocumentToolStripMenuItem;
        private ToolStripMenuItem AddElementToolStripMenuItem;
        private ToolStripMenuItem DropElementToolStripMenuItem;
        private ToolStripMenuItem ModifyElementToolStripMenuItem;
        private ToolStripMenuItem DisconnectToolStripMenuItem;
        private ToolStripStatusLabel lblUserInfo;
        private ToolStripMenuItem AddDocumentToolStripMenuItem;
        private TabControl tabDataShower;
        private TabPage tabTreeView;
        private TreeView trvData;
        private TabPage tabTableView;
        private ListView lstData;
        private TabPage tabTextView;
        private TextBox txtData;
        private TreeView trvsrvlst;
        private ToolStripMenuItem RepairDBToolStripMenuItem;
        private ToolStripMenuItem slaveResyncToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem12;
        private ToolStripMenuItem CopyElementToolStripMenuItem;
        private ToolStripMenuItem PasteElementToolStripMenuItem;
        private ToolStripMenuItem CutElementToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private ToolStripMenuItem UserGuideToolStripMenuItem;
        private LinkLabel lnkFile;
        private ToolStripMenuItem CompactToolStripMenuItem;
        private ToolStrip ViewtoolStrip;
        private ToolStripButton ShellCommandtoolStripButton;
        private ToolStripButton SvrStatustoolStripButton;
        private ToolStripButton CollectiontoolStripButton;
        private Panel panel3;
        private TextBox txtCommand;
        private UserController.ctlServerStatus ServerStatusCtl;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton RefreshViewtoolStripButton;
    }
}