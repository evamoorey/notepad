
using System;

namespace notepad
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.newPage = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.createPage = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewWin = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.closeW = new System.Windows.Forms.ToolStripMenuItem();
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.selectText = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.formatt = new System.Windows.Forms.ToolStripMenuItem();
            this.undoText = new System.Windows.Forms.ToolStripMenuItem();
            this.redoText = new System.Windows.Forms.ToolStripMenuItem();
            this.format = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMain = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.offAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.everyMin = new System.Windows.Forms.ToolStripMenuItem();
            this.every5Minutes = new System.Windows.Forms.ToolStripMenuItem();
            this.every15Minutes = new System.Windows.Forms.ToolStripMenuItem();
            this.every30Minutes = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.darkTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.lightTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.experimentalTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCompil = new System.Windows.Forms.ToolStripMenuItem();
            this.rollback = new System.Windows.Forms.ToolStripMenuItem();
            this.formating = new System.Windows.Forms.ToolStripMenuItem();
            this.compile = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.CutMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.redo = new System.Windows.Forms.ToolStripMenuItem();
            this.bold = new System.Windows.Forms.Button();
            this.italics = new System.Windows.Forms.Button();
            this.underline = new System.Windows.Forms.Button();
            this.striked = new System.Windows.Forms.Button();
            this.autoSaveText = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // newPage
            // 
            this.newPage.BackColor = System.Drawing.Color.DarkGray;
            this.newPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newPage.FlatAppearance.BorderSize = 0;
            this.newPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPage.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newPage.Location = new System.Drawing.Point(0, 540);
            this.newPage.Name = "newPage";
            this.newPage.Size = new System.Drawing.Size(195, 53);
            this.newPage.TabIndex = 1;
            this.newPage.Text = "  + New page";
            this.newPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newPage.UseVisualStyleBackColor = false;
            this.newPage.Click += new System.EventHandler(this.newPage_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 30);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.edit,
            this.format,
            this.settings,
            this.rollback,
            this.formating,
            this.compile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(209, 593);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "File";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPage,
            this.open,
            this.openNewWin,
            this.close,
            this.save,
            this.saveAs,
            this.saveAll,
            this.closeW});
            this.file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.file.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(196, 24);
            this.file.Text = "File";
            this.file.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createPage
            // 
            this.createPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createPage.Name = "createPage";
            this.createPage.ShortcutKeyDisplayString = "Ctrl + O";
            this.createPage.Size = new System.Drawing.Size(398, 26);
            this.createPage.Text = "Create page";
            this.createPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createPage.Click += new System.EventHandler(this.newPage_Click);
            // 
            // open
            // 
            this.open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.open.Name = "open";
            this.open.ShortcutKeyDisplayString = "";
            this.open.Size = new System.Drawing.Size(398, 26);
            this.open.Text = "Open file";
            this.open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // openNewWin
            // 
            this.openNewWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openNewWin.Name = "openNewWin";
            this.openNewWin.ShortcutKeyDisplayString = "Ctrl + W";
            this.openNewWin.Size = new System.Drawing.Size(398, 26);
            this.openNewWin.Text = "Create page in new window";
            this.openNewWin.Click += new System.EventHandler(this.openNewWin_Click);
            // 
            // close
            // 
            this.close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(398, 26);
            this.close.Text = "Close";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.save.Name = "save";
            this.save.ShortcutKeyDisplayString = "Ctrl + S";
            this.save.Size = new System.Drawing.Size(398, 26);
            this.save.Text = "Save";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveAs
            // 
            this.saveAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(398, 26);
            this.saveAs.Text = "Save as...";
            this.saveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // saveAll
            // 
            this.saveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveAll.Name = "saveAll";
            this.saveAll.ShortcutKeyDisplayString = "Ctrl + P";
            this.saveAll.Size = new System.Drawing.Size(398, 26);
            this.saveAll.Text = "Save all files";
            this.saveAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAll.Click += new System.EventHandler(this.saveAll_Click);
            // 
            // closeW
            // 
            this.closeW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeW.Name = "closeW";
            this.closeW.ShortcutKeyDisplayString = "Ctrl + Q";
            this.closeW.Size = new System.Drawing.Size(398, 26);
            this.closeW.Text = "Close application";
            this.closeW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edit
            // 
            this.edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectText,
            this.cut,
            this.copy,
            this.paste,
            this.formatt,
            this.undoText,
            this.redoText});
            this.edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(196, 24);
            this.edit.Text = "Edit";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectText
            // 
            this.selectText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectText.Name = "selectText";
            this.selectText.ShortcutKeyDisplayString = "Ctrl + A";
            this.selectText.Size = new System.Drawing.Size(281, 26);
            this.selectText.Text = "Select all";
            this.selectText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectText.Click += new System.EventHandler(this.selectText_Click);
            // 
            // cut
            // 
            this.cut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cut.Name = "cut";
            this.cut.ShortcutKeyDisplayString = "Ctrl + X";
            this.cut.Size = new System.Drawing.Size(281, 26);
            this.cut.Text = "Cut";
            this.cut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.copy.Name = "copy";
            this.copy.ShortcutKeyDisplayString = "Ctrl + C";
            this.copy.Size = new System.Drawing.Size(281, 26);
            this.copy.Text = "Copy";
            this.copy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.paste.Name = "paste";
            this.paste.ShortcutKeyDisplayString = "Ctrl + V";
            this.paste.Size = new System.Drawing.Size(281, 26);
            this.paste.Text = "Paste";
            this.paste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // formatt
            // 
            this.formatt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formatt.Name = "formatt";
            this.formatt.ShortcutKeyDisplayString = "Ctrl + F";
            this.formatt.Size = new System.Drawing.Size(281, 26);
            this.formatt.Text = "Format";
            this.formatt.Click += new System.EventHandler(this.formattt_Click);
            // 
            // undoText
            // 
            this.undoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.undoText.Name = "undoText";
            this.undoText.ShortcutKeyDisplayString = "Ctrl + Z";
            this.undoText.Size = new System.Drawing.Size(281, 26);
            this.undoText.Text = "Undo";
            this.undoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.undoText.Click += new System.EventHandler(this.undoText_Click);
            // 
            // redoText
            // 
            this.redoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.redoText.Name = "redoText";
            this.redoText.ShortcutKeyDisplayString = "Ctrl + Shift + Z";
            this.redoText.Size = new System.Drawing.Size(281, 26);
            this.redoText.Text = "Redo";
            this.redoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redoText.Click += new System.EventHandler(this.redoText_Click);
            // 
            // format
            // 
            this.format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontMain});
            this.format.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(196, 24);
            this.format.Text = "Format";
            this.format.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fontMain
            // 
            this.fontMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fontMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fontMain.Name = "fontMain";
            this.fontMain.Size = new System.Drawing.Size(173, 26);
            this.fontMain.Text = "Main font";
            this.fontMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fontMain.Click += new System.EventHandler(this.fontMain_Click);
            // 
            // settings
            // 
            this.settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoSave,
            this.mainTheme,
            this.changeCompil});
            this.settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(196, 24);
            this.settings.Text = "Settings";
            this.settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // autoSave
            // 
            this.autoSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offAutoSave,
            this.everyMin,
            this.every5Minutes,
            this.every15Minutes,
            this.every30Minutes});
            this.autoSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoSave.Name = "autoSave";
            this.autoSave.Size = new System.Drawing.Size(227, 26);
            this.autoSave.Text = "Auto save";
            this.autoSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // offAutoSave
            // 
            this.offAutoSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.offAutoSave.Name = "offAutoSave";
            this.offAutoSave.Size = new System.Drawing.Size(236, 26);
            this.offAutoSave.Text = "Turn off ";
            this.offAutoSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.offAutoSave.Click += new System.EventHandler(this.offAutoSave_Click);
            // 
            // everyMin
            // 
            this.everyMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.everyMin.Name = "everyMin";
            this.everyMin.Size = new System.Drawing.Size(236, 26);
            this.everyMin.Text = "Every minute";
            this.everyMin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.everyMin.Click += new System.EventHandler(this.everyMin_Click);
            // 
            // every5Minutes
            // 
            this.every5Minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.every5Minutes.Name = "every5Minutes";
            this.every5Minutes.Size = new System.Drawing.Size(236, 26);
            this.every5Minutes.Text = "Every 5 minutes";
            this.every5Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.every5Minutes.Click += new System.EventHandler(this.every5Minutes_Click);
            // 
            // every15Minutes
            // 
            this.every15Minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.every15Minutes.Name = "every15Minutes";
            this.every15Minutes.Size = new System.Drawing.Size(236, 26);
            this.every15Minutes.Text = "Every 15 minutes";
            this.every15Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.every15Minutes.Click += new System.EventHandler(this.every15Minutes_Click);
            // 
            // every30Minutes
            // 
            this.every30Minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.every30Minutes.Name = "every30Minutes";
            this.every30Minutes.Size = new System.Drawing.Size(236, 26);
            this.every30Minutes.Text = "Every 30 minutes";
            this.every30Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.every30Minutes.Click += new System.EventHandler(this.every30Minutes_Click);
            // 
            // mainTheme
            // 
            this.mainTheme.BackColor = System.Drawing.SystemColors.Control;
            this.mainTheme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkTheme,
            this.lightTheme,
            this.experimentalTheme});
            this.mainTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainTheme.Name = "mainTheme";
            this.mainTheme.Size = new System.Drawing.Size(227, 26);
            this.mainTheme.Text = "Main theme";
            this.mainTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // darkTheme
            // 
            this.darkTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.darkTheme.Name = "darkTheme";
            this.darkTheme.Size = new System.Drawing.Size(254, 26);
            this.darkTheme.Text = "Dark theme";
            this.darkTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.darkTheme.Click += new System.EventHandler(this.darkTheme_Click);
            // 
            // lightTheme
            // 
            this.lightTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lightTheme.Name = "lightTheme";
            this.lightTheme.Size = new System.Drawing.Size(254, 26);
            this.lightTheme.Text = "Light theme";
            this.lightTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lightTheme.Click += new System.EventHandler(this.lightTheme_Click);
            // 
            // experimentalTheme
            // 
            this.experimentalTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.experimentalTheme.Name = "experimentalTheme";
            this.experimentalTheme.Size = new System.Drawing.Size(254, 26);
            this.experimentalTheme.Text = "Experimental theme";
            this.experimentalTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.experimentalTheme.Click += new System.EventHandler(this.experimentalTheme_Click);
            // 
            // changeCompil
            // 
            this.changeCompil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeCompil.Name = "changeCompil";
            this.changeCompil.Size = new System.Drawing.Size(227, 26);
            this.changeCompil.Text = "Change compiler";
            this.changeCompil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeCompil.Click += new System.EventHandler(this.changeCompil_Click);
            // 
            // rollback
            // 
            this.rollback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rollback.Name = "rollback";
            this.rollback.Size = new System.Drawing.Size(196, 24);
            this.rollback.Text = "Rollback";
            this.rollback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rollback.Click += new System.EventHandler(this.rollback_Click);
            // 
            // formating
            // 
            this.formating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formating.Name = "formating";
            this.formating.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.formating.Size = new System.Drawing.Size(196, 24);
            this.formating.Text = "Format code";
            this.formating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formating.Click += new System.EventHandler(this.formating_Click);
            // 
            // compile
            // 
            this.compile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.compile.Name = "compile";
            this.compile.Size = new System.Drawing.Size(196, 24);
            this.compile.Text = "Compile code        ";
            this.compile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compile.Click += new System.EventHandler(this.compile_Click);
            // 
            // tabControl
            // 
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(194, -2);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 595);
            this.tabControl.TabIndex = 10;
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fontDialog.Apply += new System.EventHandler(this.fontMain_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllMouse,
            this.CutMouse,
            this.copyMouse,
            this.pasteMouse,
            this.formatMouse,
            this.undo,
            this.redo});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(246, 158);
            // 
            // selectAllMouse
            // 
            this.selectAllMouse.BackColor = System.Drawing.SystemColors.Control;
            this.selectAllMouse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectAllMouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectAllMouse.Name = "selectAllMouse";
            this.selectAllMouse.ShortcutKeyDisplayString = "Ctrl + A";
            this.selectAllMouse.Size = new System.Drawing.Size(245, 22);
            this.selectAllMouse.Text = "Select all";
            this.selectAllMouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectAllMouse.Click += new System.EventHandler(this.selectAllMouse_Click);
            // 
            // CutMouse
            // 
            this.CutMouse.BackColor = System.Drawing.SystemColors.Control;
            this.CutMouse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CutMouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CutMouse.Name = "CutMouse";
            this.CutMouse.ShortcutKeyDisplayString = "Ctrl + X";
            this.CutMouse.Size = new System.Drawing.Size(245, 22);
            this.CutMouse.Text = "Cut";
            this.CutMouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CutMouse.Click += new System.EventHandler(this.cutMouse_Click);
            // 
            // copyMouse
            // 
            this.copyMouse.BackColor = System.Drawing.SystemColors.Control;
            this.copyMouse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyMouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.copyMouse.Name = "copyMouse";
            this.copyMouse.ShortcutKeyDisplayString = "Ctrl + C";
            this.copyMouse.Size = new System.Drawing.Size(245, 22);
            this.copyMouse.Text = "Copy";
            this.copyMouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyMouse.Click += new System.EventHandler(this.copyMouse_Click);
            // 
            // pasteMouse
            // 
            this.pasteMouse.BackColor = System.Drawing.SystemColors.Control;
            this.pasteMouse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pasteMouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pasteMouse.Name = "pasteMouse";
            this.pasteMouse.ShortcutKeyDisplayString = "Ctrl + V";
            this.pasteMouse.Size = new System.Drawing.Size(245, 22);
            this.pasteMouse.Text = "Paste";
            this.pasteMouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pasteMouse.Click += new System.EventHandler(this.pasteMouse_Click);
            // 
            // formatMouse
            // 
            this.formatMouse.BackColor = System.Drawing.SystemColors.Control;
            this.formatMouse.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formatMouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formatMouse.Name = "formatMouse";
            this.formatMouse.ShortcutKeyDisplayString = "Ctrl + F";
            this.formatMouse.Size = new System.Drawing.Size(245, 22);
            this.formatMouse.Text = "Format";
            this.formatMouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formatMouse.Click += new System.EventHandler(this.formatMouse_Click);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.undo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.undo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.undo.Name = "undo";
            this.undo.ShortcutKeyDisplayString = "Ctrl + Z";
            this.undo.Size = new System.Drawing.Size(245, 22);
            this.undo.Text = "Undo";
            this.undo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.redo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.redo.Name = "redo";
            this.redo.ShortcutKeyDisplayString = "Ctrl + Shift + Z";
            this.redo.Size = new System.Drawing.Size(245, 22);
            this.redo.Text = "Redo";
            this.redo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // bold
            // 
            this.bold.BackColor = System.Drawing.Color.DarkGray;
            this.bold.FlatAppearance.BorderSize = 0;
            this.bold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bold.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bold.Location = new System.Drawing.Point(164, 0);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(30, 30);
            this.bold.TabIndex = 12;
            this.bold.Text = "B";
            this.bold.UseVisualStyleBackColor = false;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italics
            // 
            this.italics.BackColor = System.Drawing.Color.DarkGray;
            this.italics.FlatAppearance.BorderSize = 0;
            this.italics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italics.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.italics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.italics.Location = new System.Drawing.Point(164, 29);
            this.italics.Name = "italics";
            this.italics.Size = new System.Drawing.Size(30, 30);
            this.italics.TabIndex = 13;
            this.italics.Text = "I";
            this.italics.UseVisualStyleBackColor = false;
            this.italics.Click += new System.EventHandler(this.italics_Click);
            // 
            // underline
            // 
            this.underline.BackColor = System.Drawing.Color.DarkGray;
            this.underline.FlatAppearance.BorderSize = 0;
            this.underline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underline.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.underline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.underline.Location = new System.Drawing.Point(164, 58);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(30, 30);
            this.underline.TabIndex = 14;
            this.underline.Text = "U";
            this.underline.UseVisualStyleBackColor = false;
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // striked
            // 
            this.striked.BackColor = System.Drawing.Color.DarkGray;
            this.striked.FlatAppearance.BorderSize = 0;
            this.striked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.striked.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.striked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.striked.Location = new System.Drawing.Point(164, 87);
            this.striked.Name = "striked";
            this.striked.Size = new System.Drawing.Size(30, 30);
            this.striked.TabIndex = 15;
            this.striked.Text = "S";
            this.striked.UseVisualStyleBackColor = false;
            this.striked.Click += new System.EventHandler(this.striked_Click);
            // 
            // autoSaveText
            // 
            this.autoSaveText.AutoSize = true;
            this.autoSaveText.BackColor = System.Drawing.Color.DarkGray;
            this.autoSaveText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autoSaveText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.autoSaveText.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autoSaveText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoSaveText.Location = new System.Drawing.Point(24, 512);
            this.autoSaveText.Name = "autoSaveText";
            this.autoSaveText.Size = new System.Drawing.Size(146, 21);
            this.autoSaveText.TabIndex = 17;
            this.autoSaveText.Text = "Auto save - off";
            this.autoSaveText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.DarkGray;
            this.info.FlatAppearance.BorderSize = 0;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.info.Location = new System.Drawing.Point(48, 483);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(94, 29);
            this.info.TabIndex = 19;
            this.info.Text = "Info";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 593);
            this.Controls.Add(this.info);
            this.Controls.Add(this.autoSaveText);
            this.Controls.Add(this.striked);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.italics);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.newPage);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "form";
            this.ShowIcon = false;
            this.Text = "NotePad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Button newPage;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem autoSave;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem format;
        private System.Windows.Forms.ToolStripMenuItem copyMouse;
        private System.Windows.Forms.ToolStripMenuItem fontMain;
        private System.Windows.Forms.ToolStripMenuItem settings;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem offAutoSave;
        private System.Windows.Forms.ToolStripMenuItem everyMin;
        private System.Windows.Forms.ToolStripMenuItem every5Minutes;
        private System.Windows.Forms.ToolStripMenuItem every15Minutes;
        private System.Windows.Forms.ToolStripMenuItem mainTheme;
        private System.Windows.Forms.ToolStripMenuItem every30Minutes;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem saveAll;
        private System.Windows.Forms.ToolStripMenuItem openNewWin;
        private System.Windows.Forms.ToolStripMenuItem closeW;
        private System.Windows.Forms.ToolStripMenuItem createPage;
        private System.Windows.Forms.ToolStripMenuItem selectText;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem selectAllMouse;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem formatt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CutMouse;
        private System.Windows.Forms.ToolStripMenuItem pasteMouse;
        private System.Windows.Forms.ToolStripMenuItem formatMouse;
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.Button italics;
        private System.Windows.Forms.Button underline;
        private System.Windows.Forms.Button striked;
        private System.Windows.Forms.ToolStripMenuItem darkTheme;
        private System.Windows.Forms.ToolStripMenuItem lightTheme;
        private System.Windows.Forms.ToolStripMenuItem experimentalTheme;
        private System.Windows.Forms.Label autoSaveText;
        private System.Windows.Forms.ToolStripMenuItem rollback;
        private System.Windows.Forms.ToolStripMenuItem formating;
        private System.Windows.Forms.ToolStripMenuItem undoText;
        private System.Windows.Forms.ToolStripMenuItem redoText;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripMenuItem redo;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.ToolStripMenuItem compile;
        private System.Windows.Forms.ToolStripMenuItem changeCompil;
    }
}

