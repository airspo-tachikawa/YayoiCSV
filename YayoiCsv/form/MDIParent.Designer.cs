namespace YayoiCsv
{
    partial class MDIParent
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miNendoSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.shiwakeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miShiwakeInput = new System.Windows.Forms.ToolStripMenuItem();
            this.miViewShiwake = new System.Windows.Forms.ToolStripMenuItem();
            this.miKotsuhiBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.uriageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miInputUriage = new System.Windows.Forms.ToolStripMenuItem();
            this.miShisan = new System.Windows.Forms.ToolStripMenuItem();
            this.DaichoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miGenkinSuitocho = new System.Windows.Forms.ToolStripMenuItem();
            this.miYokinSuitocho = new System.Windows.Forms.ToolStripMenuItem();
            this.kurikoshiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miZandakaNyuryoku = new System.Windows.Forms.ToolStripMenuItem();
            this.来年度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayoiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miYayoiCsvOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.miCsvOutputNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miCsvOutputOld = new System.Windows.Forms.ToolStripMenuItem();
            this.miYayoiCsvImportAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.miYayoiCsvImport = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.shiwakeMenu,
            this.uriageMenu,
            this.DaichoMenu,
            this.kurikoshiMenu,
            this.yayoiMenu,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNendoSelect,
            this.toolStripSeparator5,
            this.miExit});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(67, 20);
            this.fileMenu.Text = "ファイル(&F)";
            // 
            // miNendoSelect
            // 
            this.miNendoSelect.ImageTransparentColor = System.Drawing.Color.Black;
            this.miNendoSelect.Name = "miNendoSelect";
            this.miNendoSelect.Size = new System.Drawing.Size(192, 22);
            this.miNendoSelect.Text = "年度変更";
            this.miNendoSelect.Click += new System.EventHandler(this.miNendoSelect_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(189, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(192, 22);
            this.miExit.Text = "アプリケーションの終了(&X)";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // shiwakeMenu
            // 
            this.shiwakeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miShiwakeInput,
            this.miViewShiwake,
            this.miKotsuhiBatch});
            this.shiwakeMenu.Name = "shiwakeMenu";
            this.shiwakeMenu.Size = new System.Drawing.Size(58, 20);
            this.shiwakeMenu.Text = "経費(&K)";
            // 
            // miShiwakeInput
            // 
            this.miShiwakeInput.Name = "miShiwakeInput";
            this.miShiwakeInput.Size = new System.Drawing.Size(158, 22);
            this.miShiwakeInput.Text = "経費入力";
            this.miShiwakeInput.Click += new System.EventHandler(this.miShiwakeInput_Click);
            // 
            // miViewShiwake
            // 
            this.miViewShiwake.Name = "miViewShiwake";
            this.miViewShiwake.Size = new System.Drawing.Size(158, 22);
            this.miViewShiwake.Text = "経費照会";
            this.miViewShiwake.Click += new System.EventHandler(this.miViewShiwake_Click);
            // 
            // miKotsuhiBatch
            // 
            this.miKotsuhiBatch.Name = "miKotsuhiBatch";
            this.miKotsuhiBatch.Size = new System.Drawing.Size(158, 22);
            this.miKotsuhiBatch.Text = "交通費一括出力";
            this.miKotsuhiBatch.Click += new System.EventHandler(this.miKotsuhiBatch_Click);
            // 
            // uriageMenu
            // 
            this.uriageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInputUriage,
            this.miShisan});
            this.uriageMenu.Name = "uriageMenu";
            this.uriageMenu.Size = new System.Drawing.Size(59, 20);
            this.uriageMenu.Text = "売上(&U)";
            // 
            // miInputUriage
            // 
            this.miInputUriage.Name = "miInputUriage";
            this.miInputUriage.Size = new System.Drawing.Size(122, 22);
            this.miInputUriage.Text = "売上入力";
            this.miInputUriage.Click += new System.EventHandler(this.miInputUriage_Click);
            // 
            // miShisan
            // 
            this.miShisan.Name = "miShisan";
            this.miShisan.Size = new System.Drawing.Size(122, 22);
            this.miShisan.Text = "資産照会";
            this.miShisan.Click += new System.EventHandler(this.資産照会ToolStripMenuItem_Click);
            // 
            // DaichoMenu
            // 
            this.DaichoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGenkinSuitocho,
            this.miYokinSuitocho});
            this.DaichoMenu.Name = "DaichoMenu";
            this.DaichoMenu.Size = new System.Drawing.Size(59, 20);
            this.DaichoMenu.Text = "台帳(&D)";
            // 
            // miGenkinSuitocho
            // 
            this.miGenkinSuitocho.Name = "miGenkinSuitocho";
            this.miGenkinSuitocho.Size = new System.Drawing.Size(134, 22);
            this.miGenkinSuitocho.Text = "現金出納帳";
            this.miGenkinSuitocho.Click += new System.EventHandler(this.miGenkinSuitocho_Click);
            // 
            // miYokinSuitocho
            // 
            this.miYokinSuitocho.Name = "miYokinSuitocho";
            this.miYokinSuitocho.Size = new System.Drawing.Size(134, 22);
            this.miYokinSuitocho.Text = "預金出納帳";
            this.miYokinSuitocho.Click += new System.EventHandler(this.miYokinSuitocho_Click);
            // 
            // kurikoshiMenu
            // 
            this.kurikoshiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miZandakaNyuryoku,
            this.来年度ToolStripMenuItem});
            this.kurikoshiMenu.Name = "kurikoshiMenu";
            this.kurikoshiMenu.Size = new System.Drawing.Size(66, 20);
            this.kurikoshiMenu.Text = "繰越し(&Z)";
            // 
            // miZandakaNyuryoku
            // 
            this.miZandakaNyuryoku.Name = "miZandakaNyuryoku";
            this.miZandakaNyuryoku.Size = new System.Drawing.Size(122, 22);
            this.miZandakaNyuryoku.Text = "残高入力";
            this.miZandakaNyuryoku.Click += new System.EventHandler(this.miZandakaNyuryoku_Click);
            // 
            // 来年度ToolStripMenuItem
            // 
            this.来年度ToolStripMenuItem.Name = "来年度ToolStripMenuItem";
            this.来年度ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.来年度ToolStripMenuItem.Text = "繰越処理";
            // 
            // yayoiMenu
            // 
            this.yayoiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miYayoiCsvOutput,
            this.miYayoiCsvImportAppend,
            this.miYayoiCsvImport});
            this.yayoiMenu.Name = "yayoiMenu";
            this.yayoiMenu.Size = new System.Drawing.Size(106, 20);
            this.yayoiMenu.Text = "弥生会計連携(&Y)";
            // 
            // miYayoiCsvOutput
            // 
            this.miYayoiCsvOutput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCsvOutputNew,
            this.miCsvOutputOld});
            this.miYayoiCsvOutput.Name = "miYayoiCsvOutput";
            this.miYayoiCsvOutput.Size = new System.Drawing.Size(175, 22);
            this.miYayoiCsvOutput.Text = "CSV出力";
            this.miYayoiCsvOutput.Click += new System.EventHandler(this.miYayoiCsvOutput_Click);
            // 
            // miCsvOutputNew
            // 
            this.miCsvOutputNew.Name = "miCsvOutputNew";
            this.miCsvOutputNew.Size = new System.Drawing.Size(154, 22);
            this.miCsvOutputNew.Text = "（新）バージョン";
            this.miCsvOutputNew.Click += new System.EventHandler(this.miCsvOutputNew_Click);
            // 
            // miCsvOutputOld
            // 
            this.miCsvOutputOld.Name = "miCsvOutputOld";
            this.miCsvOutputOld.Size = new System.Drawing.Size(154, 22);
            this.miCsvOutputOld.Text = "（旧）バージョン";
            this.miCsvOutputOld.Click += new System.EventHandler(this.miCsvOutputOld_Click);
            // 
            // miYayoiCsvImportAppend
            // 
            this.miYayoiCsvImportAppend.Name = "miYayoiCsvImportAppend";
            this.miYayoiCsvImportAppend.Size = new System.Drawing.Size(175, 22);
            this.miYayoiCsvImportAppend.Text = "CSV取込（追加）";
            this.miYayoiCsvImportAppend.Click += new System.EventHandler(this.miYayoiCsvImportAppend_Click);
            // 
            // miYayoiCsvImport
            // 
            this.miYayoiCsvImport.Name = "miYayoiCsvImport";
            this.miYayoiCsvImport.Size = new System.Drawing.Size(175, 22);
            this.miYayoiCsvImport.Text = "CSV取込（上書き）";
            this.miYayoiCsvImport.Click += new System.EventHandler(this.miYayoiCsvImport_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(80, 20);
            this.windowsMenu.Text = "ウィンドウ(&W)";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.closeAllToolStripMenuItem.Text = "すべて閉じる(&L)";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 725);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "弥生会計 経費入力 サポート";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIParent_FormClosed);
            this.Load += new System.EventHandler(this.MDIParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem miNendoSelect;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem shiwakeMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem miShiwakeInput;
        private System.Windows.Forms.ToolStripMenuItem miKotsuhiBatch;
        private System.Windows.Forms.ToolStripMenuItem uriageMenu;
        private System.Windows.Forms.ToolStripMenuItem miInputUriage;
        private System.Windows.Forms.ToolStripMenuItem miViewShiwake;
        private System.Windows.Forms.ToolStripMenuItem yayoiMenu;
        private System.Windows.Forms.ToolStripMenuItem miYayoiCsvOutput;
        private System.Windows.Forms.ToolStripMenuItem miYayoiCsvImportAppend;
        private System.Windows.Forms.ToolStripMenuItem miYayoiCsvImport;
        private System.Windows.Forms.ToolStripMenuItem miShisan;
        private System.Windows.Forms.ToolStripMenuItem kurikoshiMenu;
        private System.Windows.Forms.ToolStripMenuItem miZandakaNyuryoku;
        private System.Windows.Forms.ToolStripMenuItem 来年度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DaichoMenu;
        private System.Windows.Forms.ToolStripMenuItem miGenkinSuitocho;
        private System.Windows.Forms.ToolStripMenuItem miYokinSuitocho;
        private System.Windows.Forms.ToolStripMenuItem miCsvOutputNew;
        private System.Windows.Forms.ToolStripMenuItem miCsvOutputOld;
    }
}



