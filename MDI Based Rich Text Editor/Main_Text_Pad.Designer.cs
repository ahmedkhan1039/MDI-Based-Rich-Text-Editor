namespace MDI_Based_Rich_Text_Editor
{
    partial class Main_Text_Pad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Text_Pad));
            this.mst_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setFontFormat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setFontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColor_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColor_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setParagraphFormat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.fd_Text = new System.Windows.Forms.FontDialog();
            this.cd_Text = new System.Windows.Forms.ColorDialog();
            this.ts_Formatting = new System.Windows.Forms.ToolStrip();
            this.tsb_Bold = new System.Windows.Forms.ToolStripButton();
            this.tsb_Italic = new System.Windows.Forms.ToolStripButton();
            this.tsb_UnderLine = new System.Windows.Forms.ToolStripButton();
            this.tsb_StrikeThrough = new System.Windows.Forms.ToolStripButton();
            this.tsb_AlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tsb_AlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tsb_AlignRight = new System.Windows.Forms.ToolStripButton();
            this.tsb_IncreaseIndent = new System.Windows.Forms.ToolStripButton();
            this.tsb_DecreaseIndent = new System.Windows.Forms.ToolStripButton();
            this.tscbx_Fontfamily = new System.Windows.Forms.ToolStripComboBox();
            this.tscbx_Fontsize = new System.Windows.Forms.ToolStripComboBox();
            this.tsb_Forecolor = new System.Windows.Forms.ToolStripButton();
            this.tsb_Backcolor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_New = new System.Windows.Forms.ToolStripButton();
            this.tsb_Save = new System.Windows.Forms.ToolStripButton();
            this.tsb_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Bullet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mst_Main.SuspendLayout();
            this.ts_Formatting.SuspendLayout();
            this.SuspendLayout();
            // 
            // mst_Main
            // 
            this.mst_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatTextToolStripMenuItem1});
            this.mst_Main.Location = new System.Drawing.Point(0, 0);
            this.mst_Main.Name = "mst_Main";
            this.mst_Main.Size = new System.Drawing.Size(814, 24);
            this.mst_Main.TabIndex = 1;
            this.mst_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile_ToolStripMenuItem,
            this.openFile_ToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newFile_ToolStripMenuItem
            // 
            this.newFile_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newFile_ToolStripMenuItem.Image")));
            this.newFile_ToolStripMenuItem.Name = "newFile_ToolStripMenuItem";
            this.newFile_ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newFile_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFile_ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newFile_ToolStripMenuItem.Text = "New File";
            this.newFile_ToolStripMenuItem.Click += new System.EventHandler(this.newFile_ToolStripMenuItem_Click);
            // 
            // openFile_ToolStripMenuItem
            // 
            this.openFile_ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFile_ToolStripMenuItem.Image")));
            this.openFile_ToolStripMenuItem.Name = "openFile_ToolStripMenuItem";
            this.openFile_ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openFile_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile_ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openFile_ToolStripMenuItem.Text = "Open File";
            this.openFile_ToolStripMenuItem.Click += new System.EventHandler(this.openFile_ToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.Cut_Copy_Paste_ToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.Cut_Copy_Paste_ToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.Cut_Copy_Paste_ToolStripMenuItem_Click);
            // 
            // formatTextToolStripMenuItem1
            // 
            this.formatTextToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setFontFormat_ToolStripMenuItem,
            this.setFontColorToolStripMenuItem,
            this.setParagraphFormat_ToolStripMenuItem});
            this.formatTextToolStripMenuItem1.Name = "formatTextToolStripMenuItem1";
            this.formatTextToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.formatTextToolStripMenuItem1.Text = "Format &Text";
            // 
            // setFontFormat_ToolStripMenuItem
            // 
            this.setFontFormat_ToolStripMenuItem.Name = "setFontFormat_ToolStripMenuItem";
            this.setFontFormat_ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.setFontFormat_ToolStripMenuItem.Text = "Set Font Format";
            this.setFontFormat_ToolStripMenuItem.Click += new System.EventHandler(this.setFontFormat_ToolStripMenuItem_Click);
            // 
            // setFontColorToolStripMenuItem
            // 
            this.setFontColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColor_ToolStripMenuItem,
            this.backgroundColor_ToolStripMenuItem});
            this.setFontColorToolStripMenuItem.Name = "setFontColorToolStripMenuItem";
            this.setFontColorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.setFontColorToolStripMenuItem.Text = "Set Font Color";
            // 
            // foreColor_ToolStripMenuItem
            // 
            this.foreColor_ToolStripMenuItem.Name = "foreColor_ToolStripMenuItem";
            this.foreColor_ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.foreColor_ToolStripMenuItem.Text = "Fore Color";
            this.foreColor_ToolStripMenuItem.Click += new System.EventHandler(this.setFontFormat_ToolStripMenuItem_Click);
            // 
            // backgroundColor_ToolStripMenuItem
            // 
            this.backgroundColor_ToolStripMenuItem.Name = "backgroundColor_ToolStripMenuItem";
            this.backgroundColor_ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColor_ToolStripMenuItem.Text = "Background Color";
            this.backgroundColor_ToolStripMenuItem.Click += new System.EventHandler(this.setFontFormat_ToolStripMenuItem_Click);
            // 
            // setParagraphFormat_ToolStripMenuItem
            // 
            this.setParagraphFormat_ToolStripMenuItem.Name = "setParagraphFormat_ToolStripMenuItem";
            this.setParagraphFormat_ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.setParagraphFormat_ToolStripMenuItem.Text = "Set Paragraph Format";
            this.setParagraphFormat_ToolStripMenuItem.Click += new System.EventHandler(this.setParagraphFormat_ToolStripMenuItem_Click);
            // 
            // ts_Formatting
            // 
            this.ts_Formatting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_New,
            this.tsb_Open,
            this.tsb_Save,
            this.toolStripSeparator5,
            this.tsb_Bold,
            this.tsb_Italic,
            this.tsb_UnderLine,
            this.tsb_StrikeThrough,
            this.toolStripSeparator1,
            this.tsb_AlignLeft,
            this.tsb_AlignCenter,
            this.tsb_AlignRight,
            this.toolStripSeparator2,
            this.tsb_IncreaseIndent,
            this.tsb_DecreaseIndent,
            this.toolStripSeparator3,
            this.tsb_Bullet,
            this.toolStripSeparator6,
            this.tscbx_Fontfamily,
            this.tscbx_Fontsize,
            this.toolStripSeparator4,
            this.tsb_Forecolor,
            this.tsb_Backcolor});
            this.ts_Formatting.Location = new System.Drawing.Point(0, 24);
            this.ts_Formatting.Name = "ts_Formatting";
            this.ts_Formatting.Size = new System.Drawing.Size(814, 27);
            this.ts_Formatting.TabIndex = 3;
            this.ts_Formatting.Text = "toolStrip1";
            // 
            // tsb_Bold
            // 
            this.tsb_Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Bold.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_Bold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsb_Bold.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Bold.Image")));
            this.tsb_Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Bold.Name = "tsb_Bold";
            this.tsb_Bold.Size = new System.Drawing.Size(23, 24);
            this.tsb_Bold.Text = "B";
            this.tsb_Bold.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // tsb_Italic
            // 
            this.tsb_Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Italic.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_Italic.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Italic.Image")));
            this.tsb_Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Italic.Name = "tsb_Italic";
            this.tsb_Italic.Size = new System.Drawing.Size(23, 24);
            this.tsb_Italic.Text = "I";
            this.tsb_Italic.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // tsb_UnderLine
            // 
            this.tsb_UnderLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_UnderLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_UnderLine.Image = ((System.Drawing.Image)(resources.GetObject("tsb_UnderLine.Image")));
            this.tsb_UnderLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_UnderLine.Name = "tsb_UnderLine";
            this.tsb_UnderLine.Size = new System.Drawing.Size(24, 24);
            this.tsb_UnderLine.Text = "U";
            this.tsb_UnderLine.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // tsb_StrikeThrough
            // 
            this.tsb_StrikeThrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_StrikeThrough.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_StrikeThrough.Image = ((System.Drawing.Image)(resources.GetObject("tsb_StrikeThrough.Image")));
            this.tsb_StrikeThrough.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_StrikeThrough.Name = "tsb_StrikeThrough";
            this.tsb_StrikeThrough.Size = new System.Drawing.Size(23, 24);
            this.tsb_StrikeThrough.Text = "S";
            this.tsb_StrikeThrough.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // tsb_AlignLeft
            // 
            this.tsb_AlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AlignLeft.Image")));
            this.tsb_AlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AlignLeft.Name = "tsb_AlignLeft";
            this.tsb_AlignLeft.Size = new System.Drawing.Size(23, 24);
            this.tsb_AlignLeft.Text = "Left";
            this.tsb_AlignLeft.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // tsb_AlignCenter
            // 
            this.tsb_AlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AlignCenter.Image")));
            this.tsb_AlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AlignCenter.Name = "tsb_AlignCenter";
            this.tsb_AlignCenter.Size = new System.Drawing.Size(23, 24);
            this.tsb_AlignCenter.Text = "Center";
            this.tsb_AlignCenter.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // tsb_AlignRight
            // 
            this.tsb_AlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tsb_AlignRight.Image")));
            this.tsb_AlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AlignRight.Name = "tsb_AlignRight";
            this.tsb_AlignRight.Size = new System.Drawing.Size(23, 24);
            this.tsb_AlignRight.Text = "Right";
            this.tsb_AlignRight.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // tsb_IncreaseIndent
            // 
            this.tsb_IncreaseIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_IncreaseIndent.Image = ((System.Drawing.Image)(resources.GetObject("tsb_IncreaseIndent.Image")));
            this.tsb_IncreaseIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_IncreaseIndent.Name = "tsb_IncreaseIndent";
            this.tsb_IncreaseIndent.Size = new System.Drawing.Size(23, 24);
            this.tsb_IncreaseIndent.Text = "Increase Indent";
            this.tsb_IncreaseIndent.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // tsb_DecreaseIndent
            // 
            this.tsb_DecreaseIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_DecreaseIndent.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DecreaseIndent.Image")));
            this.tsb_DecreaseIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DecreaseIndent.Name = "tsb_DecreaseIndent";
            this.tsb_DecreaseIndent.Size = new System.Drawing.Size(23, 24);
            this.tsb_DecreaseIndent.Text = "Decrease Indent";
            this.tsb_DecreaseIndent.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // tscbx_Fontfamily
            // 
            this.tscbx_Fontfamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbx_Fontfamily.Name = "tscbx_Fontfamily";
            this.tscbx_Fontfamily.Size = new System.Drawing.Size(121, 27);
            this.tscbx_Fontfamily.SelectedIndexChanged += new System.EventHandler(this.FontFamily_Size_Index_Changed);
            // 
            // tscbx_Fontsize
            // 
            this.tscbx_Fontsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbx_Fontsize.Name = "tscbx_Fontsize";
            this.tscbx_Fontsize.Size = new System.Drawing.Size(121, 27);
            this.tscbx_Fontsize.SelectedIndexChanged += new System.EventHandler(this.FontFamily_Size_Index_Changed);
            // 
            // tsb_Forecolor
            // 
            this.tsb_Forecolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Forecolor.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Forecolor.Image")));
            this.tsb_Forecolor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Forecolor.Name = "tsb_Forecolor";
            this.tsb_Forecolor.Size = new System.Drawing.Size(23, 24);
            this.tsb_Forecolor.Text = "Fore Color";
            this.tsb_Forecolor.Click += new System.EventHandler(this.setFontFormat_ToolStripMenuItem_Click);
            // 
            // tsb_Backcolor
            // 
            this.tsb_Backcolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Backcolor.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Backcolor.Image")));
            this.tsb_Backcolor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Backcolor.Name = "tsb_Backcolor";
            this.tsb_Backcolor.Size = new System.Drawing.Size(23, 24);
            this.tsb_Backcolor.Text = "Background Color";
            this.tsb_Backcolor.Click += new System.EventHandler(this.setFontFormat_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_New
            // 
            this.tsb_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_New.Image = ((System.Drawing.Image)(resources.GetObject("tsb_New.Image")));
            this.tsb_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_New.Name = "tsb_New";
            this.tsb_New.Size = new System.Drawing.Size(23, 24);
            this.tsb_New.Click += new System.EventHandler(this.newFile_ToolStripMenuItem_Click);
            // 
            // tsb_Save
            // 
            this.tsb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Save.Image")));
            this.tsb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Save.Name = "tsb_Save";
            this.tsb_Save.Size = new System.Drawing.Size(23, 24);
            this.tsb_Save.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tsb_Open
            // 
            this.tsb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Open.Image")));
            this.tsb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Open.Name = "tsb_Open";
            this.tsb_Open.Size = new System.Drawing.Size(23, 24);
            this.tsb_Open.Click += new System.EventHandler(this.openFile_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_Bullet
            // 
            this.tsb_Bullet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Bullet.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Bullet.Image")));
            this.tsb_Bullet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Bullet.Name = "tsb_Bullet";
            this.tsb_Bullet.Size = new System.Drawing.Size(23, 24);
            this.tsb_Bullet.Click += new System.EventHandler(this.format_Text_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // Main_Text_Pad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 261);
            this.Controls.Add(this.ts_Formatting);
            this.Controls.Add(this.mst_Main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mst_Main;
            this.Name = "Main_Text_Pad";
            this.Text = "BABA-G Text Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Text_Pad_Load);
            this.mst_Main.ResumeLayout(false);
            this.mst_Main.PerformLayout();
            this.ts_Formatting.ResumeLayout(false);
            this.ts_Formatting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mst_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFile_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setFontFormat_ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fd_Text;
        private System.Windows.Forms.ToolStripMenuItem setFontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColor_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColor_ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cd_Text;
        private System.Windows.Forms.ToolStripMenuItem setParagraphFormat_ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts_Formatting;
        private System.Windows.Forms.ToolStripButton tsb_Bold;
        private System.Windows.Forms.ToolStripButton tsb_Italic;
        private System.Windows.Forms.ToolStripButton tsb_UnderLine;
        private System.Windows.Forms.ToolStripButton tsb_StrikeThrough;
        private System.Windows.Forms.ToolStripButton tsb_AlignLeft;
        private System.Windows.Forms.ToolStripButton tsb_AlignCenter;
        private System.Windows.Forms.ToolStripButton tsb_AlignRight;
        private System.Windows.Forms.ToolStripButton tsb_IncreaseIndent;
        private System.Windows.Forms.ToolStripButton tsb_DecreaseIndent;
        private System.Windows.Forms.ToolStripComboBox tscbx_Fontfamily;
        private System.Windows.Forms.ToolStripComboBox tscbx_Fontsize;
        private System.Windows.Forms.ToolStripButton tsb_Forecolor;
        private System.Windows.Forms.ToolStripButton tsb_Backcolor;
        private System.Windows.Forms.ToolStripButton tsb_New;
        private System.Windows.Forms.ToolStripButton tsb_Open;
        private System.Windows.Forms.ToolStripButton tsb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_Bullet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

