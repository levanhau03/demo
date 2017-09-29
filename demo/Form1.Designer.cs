namespace demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.PanelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btRemove = new DevComponents.DotNetBar.ButtonX();
            this.btUnpack = new DevComponents.DotNetBar.ButtonX();
            this.txtout = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsytem = new DevComponents.DotNetBar.LabelX();
            this.btExtrat = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.systemfile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtrom = new DevComponents.DotNetBar.LabelX();
            this.romfile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tabfirmware = new DevComponents.DotNetBar.SuperTabItem();
            this.SuperTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabrecovery = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabboot = new DevComponents.DotNetBar.SuperTabItem();
            this.metroShell1 = new DevComponents.DotNetBar.Metro.MetroShell();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.CMD = new DevComponents.DotNetBar.CheckBoxItem();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.PanelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // superTabControl1
            // 
            this.superTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.ControlBox.Visible = false;
            this.superTabControl1.Controls.Add(this.superTabControlPanel3);
            this.superTabControl1.Controls.Add(this.superTabControlPanel4);
            this.superTabControl1.Controls.Add(this.SuperTabControlPanel1);
            this.superTabControl1.ForeColor = System.Drawing.Color.Black;
            this.superTabControl1.ItemPadding.Left = 6;
            this.superTabControl1.ItemPadding.Right = 4;
            this.superTabControl1.ItemPadding.Top = 4;
            this.superTabControl1.Location = new System.Drawing.Point(1, 55);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = false;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(849, 449);
            this.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left;
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superTabControl1.TabHorizontalSpacing = 16;
            this.superTabControl1.TabIndex = 16;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabfirmware,
            this.tabboot,
            this.tabrecovery});
            this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue;
            this.superTabControl1.TabVerticalSpacing = 8;
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel3.Controls.Add(this.PanelEx1);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(176, 0);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(673, 449);
            this.superTabControlPanel3.TabIndex = 3;
            this.superTabControlPanel3.TabItem = this.tabfirmware;
            // 
            // PanelEx1
            // 
            this.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelEx1.Controls.Add(this.circularProgress1);
            this.PanelEx1.Controls.Add(this.labelX4);
            this.PanelEx1.Controls.Add(this.btRemove);
            this.PanelEx1.Controls.Add(this.btUnpack);
            this.PanelEx1.Controls.Add(this.txtout);
            this.PanelEx1.Controls.Add(this.txtsytem);
            this.PanelEx1.Controls.Add(this.btExtrat);
            this.PanelEx1.Controls.Add(this.checkBoxX2);
            this.PanelEx1.Controls.Add(this.checkBoxX1);
            this.PanelEx1.Controls.Add(this.systemfile);
            this.PanelEx1.Controls.Add(this.txtrom);
            this.PanelEx1.Controls.Add(this.romfile);
            this.PanelEx1.Controls.Add(this.labelX3);
            this.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.PanelEx1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PanelEx1.Location = new System.Drawing.Point(3, 6);
            this.PanelEx1.Name = "PanelEx1";
            this.PanelEx1.Size = new System.Drawing.Size(675, 440);
            this.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.White;
            this.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.Silver;
            this.PanelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left;
            this.PanelEx1.Style.ForeColor.Color = System.Drawing.Color.Gray;
            this.PanelEx1.Style.GradientAngle = 90;
            this.PanelEx1.TabIndex = 20;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(531, 393);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(77, 23);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX4.TabIndex = 15;
            // 
            // btRemove
            // 
            this.btRemove.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btRemove.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btRemove.EnableMarkup = false;
            this.btRemove.FadeEffect = false;
            this.btRemove.FocusCuesEnabled = false;
            this.btRemove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btRemove.Location = new System.Drawing.Point(614, 280);
            this.btRemove.Name = "btRemove";
            this.btRemove.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btRemove.Size = new System.Drawing.Size(40, 40);
            this.btRemove.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btRemove.TabIndex = 14;
            this.btRemove.Text = "R";
            this.btRemove.MouseLeave += new System.EventHandler(this.buttonX3_MouseLeave);
            this.btRemove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonX3_MouseMove);
            // 
            // btUnpack
            // 
            this.btUnpack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btUnpack.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btUnpack.EnableMarkup = false;
            this.btUnpack.FadeEffect = false;
            this.btUnpack.FocusCuesEnabled = false;
            this.btUnpack.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btUnpack.Location = new System.Drawing.Point(614, 332);
            this.btUnpack.Name = "btUnpack";
            this.btUnpack.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btUnpack.Size = new System.Drawing.Size(40, 40);
            this.btUnpack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btUnpack.TabIndex = 13;
            this.btUnpack.Text = "U";
            this.btUnpack.TextColor = System.Drawing.Color.SandyBrown;
            this.btUnpack.MouseLeave += new System.EventHandler(this.buttonX2_MouseLeave);
            this.btUnpack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonX2_MouseMove);
            // 
            // txtout
            // 
            this.txtout.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtout.Border.Class = "TextBoxBorder";
            this.txtout.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtout.DisabledBackColor = System.Drawing.Color.White;
            this.txtout.ForeColor = System.Drawing.Color.Black;
            this.txtout.Location = new System.Drawing.Point(39, 240);
            this.txtout.Multiline = true;
            this.txtout.Name = "txtout";
            this.txtout.PreventEnterBeep = true;
            this.txtout.ReadOnly = true;
            this.txtout.Size = new System.Drawing.Size(483, 187);
            this.txtout.TabIndex = 12;
            this.txtout.WatermarkColor = System.Drawing.SystemColors.Info;
            // 
            // txtsytem
            // 
            // 
            // 
            // 
            this.txtsytem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsytem.ForeColor = System.Drawing.Color.Black;
            this.txtsytem.Location = new System.Drawing.Point(39, 89);
            this.txtsytem.Name = "txtsytem";
            this.txtsytem.Size = new System.Drawing.Size(75, 23);
            this.txtsytem.TabIndex = 11;
            this.txtsytem.Text = "System File";
            // 
            // btExtrat
            // 
            this.btExtrat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btExtrat.BackColor = System.Drawing.Color.Transparent;
            this.btExtrat.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btExtrat.EnableMarkup = false;
            this.btExtrat.FadeEffect = false;
            this.btExtrat.FocusCuesEnabled = false;
            this.btExtrat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btExtrat.Location = new System.Drawing.Point(614, 383);
            this.btExtrat.Name = "btExtrat";
            this.btExtrat.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btExtrat.Size = new System.Drawing.Size(40, 40);
            this.btExtrat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btExtrat.TabIndex = 9;
            this.btExtrat.Text = "E";
            this.btExtrat.TextColor = System.Drawing.Color.Red;
            this.btExtrat.Click += new System.EventHandler(this.btExtrat_Click);
            this.btExtrat.MouseLeave += new System.EventHandler(this.buttonX1_MouseLeave);
            this.btExtrat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonX1_MouseMove);
            // 
            // checkBoxX2
            // 
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.EnableMarkup = false;
            this.checkBoxX2.FocusCuesEnabled = false;
            this.checkBoxX2.ForeColor = System.Drawing.Color.Black;
            this.checkBoxX2.Location = new System.Drawing.Point(39, 204);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(133, 23);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 7;
            this.checkBoxX2.Text = "remove app file";
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.EnableMarkup = false;
            this.checkBoxX1.FocusCuesEnabled = false;
            this.checkBoxX1.ForeColor = System.Drawing.Color.Black;
            this.checkBoxX1.Location = new System.Drawing.Point(39, 175);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(133, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 6;
            this.checkBoxX1.Text = "unpack after unzip";
            // 
            // systemfile
            // 
            this.systemfile.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.systemfile.Border.Class = "TextBoxBorder";
            this.systemfile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.systemfile.ButtonCustom.Visible = true;
            this.systemfile.DisabledBackColor = System.Drawing.Color.White;
            this.systemfile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.systemfile.ForeColor = System.Drawing.Color.Black;
            this.systemfile.HideSelection = false;
            this.systemfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.systemfile.Location = new System.Drawing.Point(169, 89);
            this.systemfile.Name = "systemfile";
            this.systemfile.PreventEnterBeep = true;
            this.systemfile.ReadOnly = true;
            this.systemfile.ShortcutsEnabled = false;
            this.systemfile.Size = new System.Drawing.Size(489, 23);
            this.systemfile.TabIndex = 5;
            this.systemfile.WatermarkText = "Select TYPE system ( *.img , *.new.dat )";
            this.systemfile.ButtonCustomClick += new System.EventHandler(this.systemfile_ButtonCustomClick);
            // 
            // txtrom
            // 
            // 
            // 
            // 
            this.txtrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtrom.ForeColor = System.Drawing.Color.Black;
            this.txtrom.Location = new System.Drawing.Point(39, 46);
            this.txtrom.Name = "txtrom";
            this.txtrom.Size = new System.Drawing.Size(75, 23);
            this.txtrom.TabIndex = 4;
            this.txtrom.Text = "ROM File";
            // 
            // romfile
            // 
            this.romfile.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.romfile.Border.Class = "TextBoxBorder";
            this.romfile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.romfile.ButtonCustom.Symbol = "";
            this.romfile.ButtonCustom2.Visible = true;
            this.romfile.DisabledBackColor = System.Drawing.Color.White;
            this.romfile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.romfile.ForeColor = System.Drawing.Color.Black;
            this.romfile.HideSelection = false;
            this.romfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.romfile.Location = new System.Drawing.Point(169, 46);
            this.romfile.Name = "romfile";
            this.romfile.PreventEnterBeep = true;
            this.romfile.ReadOnly = true;
            this.romfile.ShortcutsEnabled = false;
            this.romfile.Size = new System.Drawing.Size(489, 23);
            this.romfile.TabIndex = 3;
            this.romfile.WatermarkText = "Select ROM file ( *.zip )";
            this.romfile.WordWrap = false;
            this.romfile.ButtonCustomClick += new System.EventHandler(this.romfile_ButtonCustomClick);
            this.romfile.ButtonCustom2Click += new System.EventHandler(this.romfile_ButtonCustom2Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX3.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Gray;
            this.labelX3.BackgroundStyle.BorderBottomWidth = 1;
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.FontBold = true;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(3, 0);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(672, 23);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX3.Symbol = "58133";
            this.labelX3.SymbolColor = System.Drawing.Color.Red;
            this.labelX3.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "<b><font color=\"#0072BC\">UNPACK</font></b>";
            // 
            // tabfirmware
            // 
            this.tabfirmware.AttachedControl = this.superTabControlPanel3;
            this.tabfirmware.GlobalItem = false;
            this.tabfirmware.Image = ((System.Drawing.Image)(resources.GetObject("tabfirmware.Image")));
            this.tabfirmware.KeyTips = "P";
            this.tabfirmware.Name = "tabfirmware";
            this.tabfirmware.Text = "FIRMWARE";
            // 
            // SuperTabControlPanel1
            // 
            this.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuperTabControlPanel1.Location = new System.Drawing.Point(176, 0);
            this.SuperTabControlPanel1.Name = "SuperTabControlPanel1";
            this.SuperTabControlPanel1.Size = new System.Drawing.Size(673, 449);
            this.SuperTabControlPanel1.TabIndex = 0;
            this.SuperTabControlPanel1.TabItem = this.tabrecovery;
            this.SuperTabControlPanel1.Visible = false;
            // 
            // tabrecovery
            // 
            this.tabrecovery.AttachedControl = this.SuperTabControlPanel1;
            this.tabrecovery.GlobalItem = false;
            this.tabrecovery.Image = ((System.Drawing.Image)(resources.GetObject("tabrecovery.Image")));
            this.tabrecovery.Name = "tabrecovery";
            this.tabrecovery.Text = "RECOVERY";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight;
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(176, 0);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Padding = new System.Windows.Forms.Padding(12);
            this.superTabControlPanel4.Size = new System.Drawing.Size(673, 449);
            this.superTabControlPanel4.TabIndex = 4;
            this.superTabControlPanel4.TabItem = this.tabboot;
            this.superTabControlPanel4.Visible = false;
            // 
            // tabboot
            // 
            this.tabboot.AttachedControl = this.superTabControlPanel4;
            this.tabboot.GlobalItem = false;
            this.tabboot.Image = ((System.Drawing.Image)(resources.GetObject("tabboot.Image")));
            this.tabboot.KeyTips = "H";
            this.tabboot.Name = "tabboot";
            this.tabboot.Text = "BOOT";
            // 
            // metroShell1
            // 
            this.metroShell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroShell1.CanCustomize = false;
            this.metroShell1.CaptionVisible = true;
            this.metroShell1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroShell1.ForeColor = System.Drawing.Color.Black;
            this.metroShell1.HelpButtonText = null;
            this.metroShell1.HelpButtonVisible = false;
            this.metroShell1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.metroShell1.Location = new System.Drawing.Point(1, 1);
            this.metroShell1.Margin = new System.Windows.Forms.Padding(1);
            this.metroShell1.Name = "metroShell1";
            this.metroShell1.SettingsButtonVisible = false;
            this.metroShell1.Size = new System.Drawing.Size(852, 32);
            this.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.metroShell1.SystemText.QatDialogAddButton = "&Add >>";
            this.metroShell1.SystemText.QatDialogCancelButton = "Cancel";
            this.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.metroShell1.SystemText.QatDialogOkButton = "OK";
            this.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatDialogRemoveButton = "&Remove";
            this.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.metroShell1.TabIndex = 3;
            this.metroShell1.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroShell1.TitleText = "<b>AUTO TOOL - BETA 1</b>";
            this.metroShell1.UseCustomizeDialog = false;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199))))));
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.CMD});
            this.metroStatusBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.metroStatusBar1.Location = new System.Drawing.Point(1, 504);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(852, 22);
            this.metroStatusBar1.TabIndex = 29;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // CMD
            // 
            this.CMD.Name = "CMD";
            this.CMD.Text = "CMD";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(1, 33);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(852, 22);
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelEx2.Style.ForeColor.Color = System.Drawing.Color.Blue;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 30;
            this.panelEx2.Text = " Auto tools by Mr.Hau © 2017";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // circularProgress1
            // 
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(608, 234);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgress1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.circularProgress1.ProgressTextVisible = true;
            this.circularProgress1.Size = new System.Drawing.Size(52, 40);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 16;
            this.circularProgress1.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 527);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.metroShell1);
            this.Controls.Add(this.superTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.PanelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.PanelEx PanelEx1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.SuperTabItem tabfirmware;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem tabboot;
        private DevComponents.DotNetBar.SuperTabControlPanel SuperTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabrecovery;
        private DevComponents.DotNetBar.Metro.MetroShell metroShell1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.CheckBoxItem CMD;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX romfile;
        private DevComponents.DotNetBar.LabelX txtrom;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX systemfile;
        private DevComponents.DotNetBar.ButtonX btExtrat;
        private DevComponents.DotNetBar.LabelX txtsytem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtout;
        private DevComponents.DotNetBar.ButtonX btUnpack;
        private DevComponents.DotNetBar.ButtonX btRemove;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
    }
}

