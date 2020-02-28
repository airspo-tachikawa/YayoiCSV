namespace YayoiCsv
{
    partial class BatchKotsuhi
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
            this.btnYayoiCSV = new System.Windows.Forms.Button();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rdoTsuki = new System.Windows.Forms.RadioButton();
            this.rdoYobi = new System.Windows.Forms.RadioButton();
            this.rdoYear = new System.Windows.Forms.RadioButton();
            this.rdoHoliday = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.btnCSV = new System.Windows.Forms.Button();
            this.txtKin = new YayoiCsv.control.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTekiyo = new YayoiCsv.control.TextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHojo = new System.Windows.Forms.ComboBox();
            this.btnShiwakeAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpYobi = new System.Windows.Forms.GroupBox();
            this.chkYobiGetsu = new System.Windows.Forms.CheckBox();
            this.chkYobiKa = new System.Windows.Forms.CheckBox();
            this.chkYobiDo = new System.Windows.Forms.CheckBox();
            this.chkYobiKin = new System.Windows.Forms.CheckBox();
            this.chkYobiMoku = new System.Windows.Forms.CheckBox();
            this.chkYobiSui = new System.Windows.Forms.CheckBox();
            this.chkYobiNichi = new System.Windows.Forms.CheckBox();
            this.grpTsuki = new System.Windows.Forms.GroupBox();
            this.chkTsuki09 = new System.Windows.Forms.CheckBox();
            this.chkTsuki10 = new System.Windows.Forms.CheckBox();
            this.chkTsuki11 = new System.Windows.Forms.CheckBox();
            this.chkTsuki12 = new System.Windows.Forms.CheckBox();
            this.chkTsuki08 = new System.Windows.Forms.CheckBox();
            this.chkTsuki02 = new System.Windows.Forms.CheckBox();
            this.chkTsuki03 = new System.Windows.Forms.CheckBox();
            this.chkTsuki07 = new System.Windows.Forms.CheckBox();
            this.chkTsuki06 = new System.Windows.Forms.CheckBox();
            this.chkTsuki05 = new System.Windows.Forms.CheckBox();
            this.chkTsuki04 = new System.Windows.Forms.CheckBox();
            this.chkTsuki01 = new System.Windows.Forms.CheckBox();
            this.grpBox.SuspendLayout();
            this.grpYobi.SuspendLayout();
            this.grpTsuki.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYayoiCSV
            // 
            this.btnYayoiCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYayoiCSV.Location = new System.Drawing.Point(360, 326);
            this.btnYayoiCSV.Name = "btnYayoiCSV";
            this.btnYayoiCSV.Size = new System.Drawing.Size(84, 51);
            this.btnYayoiCSV.TabIndex = 5;
            this.btnYayoiCSV.Text = "弥生Import形式CSV";
            this.btnYayoiCSV.Click += new System.EventHandler(this.btnYayoiCSV_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rdoTsuki);
            this.grpBox.Controls.Add(this.rdoYobi);
            this.grpBox.Controls.Add(this.rdoYear);
            this.grpBox.Controls.Add(this.rdoHoliday);
            this.grpBox.Controls.Add(this.rdoNormal);
            this.grpBox.Location = new System.Drawing.Point(12, 2);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(390, 57);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            // 
            // rdoTsuki
            // 
            this.rdoTsuki.AutoSize = true;
            this.rdoTsuki.Location = new System.Drawing.Point(237, 22);
            this.rdoTsuki.Name = "rdoTsuki";
            this.rdoTsuki.Size = new System.Drawing.Size(61, 19);
            this.rdoTsuki.TabIndex = 4;
            this.rdoTsuki.Text = "月指定";
            this.rdoTsuki.UseVisualStyleBackColor = true;
            // 
            // rdoYobi
            // 
            this.rdoYobi.AutoSize = true;
            this.rdoYobi.Location = new System.Drawing.Point(158, 22);
            this.rdoYobi.Name = "rdoYobi";
            this.rdoYobi.Size = new System.Drawing.Size(73, 19);
            this.rdoYobi.TabIndex = 3;
            this.rdoYobi.Text = "曜日指定";
            this.rdoYobi.UseVisualStyleBackColor = true;
            // 
            // rdoYear
            // 
            this.rdoYear.AutoSize = true;
            this.rdoYear.Location = new System.Drawing.Point(316, 22);
            this.rdoYear.Name = "rdoYear";
            this.rdoYear.Size = new System.Drawing.Size(56, 19);
            this.rdoYear.TabIndex = 2;
            this.rdoYear.Text = "1年分";
            this.rdoYear.UseVisualStyleBackColor = true;
            // 
            // rdoHoliday
            // 
            this.rdoHoliday.AutoSize = true;
            this.rdoHoliday.Location = new System.Drawing.Point(82, 22);
            this.rdoHoliday.Name = "rdoHoliday";
            this.rdoHoliday.Size = new System.Drawing.Size(70, 19);
            this.rdoHoliday.TabIndex = 1;
            this.rdoHoliday.Text = "休日のみ";
            this.rdoHoliday.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Checked = true;
            this.rdoNormal.Location = new System.Drawing.Point(6, 22);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(70, 19);
            this.rdoNormal.TabIndex = 0;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "平日のみ";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // btnCSV
            // 
            this.btnCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCSV.Location = new System.Drawing.Point(267, 326);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(84, 51);
            this.btnCSV.TabIndex = 4;
            this.btnCSV.Text = "CSV";
            this.btnCSV.UseVisualStyleBackColor = true;
            this.btnCSV.Click += new System.EventHandler(this.btnCSV_Click);
            // 
            // txtKin
            // 
            this.txtKin.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtKin.InputType = YayoiCsv.control.InputType.Number;
            this.txtKin.Location = new System.Drawing.Point(119, 260);
            this.txtKin.Name = "txtKin";
            this.txtKin.Size = new System.Drawing.Size(194, 23);
            this.txtKin.TabIndex = 2;
            this.txtKin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "金額";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "補助科目";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTekiyo
            // 
            this.txtTekiyo.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtTekiyo.InputType = YayoiCsv.control.InputType.String;
            this.txtTekiyo.Location = new System.Drawing.Point(119, 286);
            this.txtTekiyo.Name = "txtTekiyo";
            this.txtTekiyo.Size = new System.Drawing.Size(194, 23);
            this.txtTekiyo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(12, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "摘要";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbHojo
            // 
            this.cmbHojo.FormattingEnabled = true;
            this.cmbHojo.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbHojo.Location = new System.Drawing.Point(119, 234);
            this.cmbHojo.Name = "cmbHojo";
            this.cmbHojo.Size = new System.Drawing.Size(194, 23);
            this.cmbHojo.TabIndex = 1;
            // 
            // btnShiwakeAdd
            // 
            this.btnShiwakeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShiwakeAdd.Location = new System.Drawing.Point(12, 326);
            this.btnShiwakeAdd.Name = "btnShiwakeAdd";
            this.btnShiwakeAdd.Size = new System.Drawing.Size(84, 51);
            this.btnShiwakeAdd.TabIndex = 11;
            this.btnShiwakeAdd.Text = "経費に追加";
            this.btnShiwakeAdd.UseVisualStyleBackColor = true;
            this.btnShiwakeAdd.Click += new System.EventHandler(this.btnShiwakeAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(414, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpYobi
            // 
            this.grpYobi.Controls.Add(this.chkYobiGetsu);
            this.grpYobi.Controls.Add(this.chkYobiKa);
            this.grpYobi.Controls.Add(this.chkYobiDo);
            this.grpYobi.Controls.Add(this.chkYobiKin);
            this.grpYobi.Controls.Add(this.chkYobiMoku);
            this.grpYobi.Controls.Add(this.chkYobiSui);
            this.grpYobi.Controls.Add(this.chkYobiNichi);
            this.grpYobi.Location = new System.Drawing.Point(12, 60);
            this.grpYobi.Name = "grpYobi";
            this.grpYobi.Size = new System.Drawing.Size(390, 55);
            this.grpYobi.TabIndex = 13;
            this.grpYobi.TabStop = false;
            this.grpYobi.Text = "曜日指定時のみ有効";
            // 
            // chkYobiGetsu
            // 
            this.chkYobiGetsu.AutoSize = true;
            this.chkYobiGetsu.Location = new System.Drawing.Point(50, 22);
            this.chkYobiGetsu.Name = "chkYobiGetsu";
            this.chkYobiGetsu.Size = new System.Drawing.Size(38, 19);
            this.chkYobiGetsu.TabIndex = 20;
            this.chkYobiGetsu.Text = "月";
            this.chkYobiGetsu.UseVisualStyleBackColor = true;
            // 
            // chkYobiKa
            // 
            this.chkYobiKa.AutoSize = true;
            this.chkYobiKa.Location = new System.Drawing.Point(94, 22);
            this.chkYobiKa.Name = "chkYobiKa";
            this.chkYobiKa.Size = new System.Drawing.Size(38, 19);
            this.chkYobiKa.TabIndex = 19;
            this.chkYobiKa.Text = "火";
            this.chkYobiKa.UseVisualStyleBackColor = true;
            // 
            // chkYobiDo
            // 
            this.chkYobiDo.AutoSize = true;
            this.chkYobiDo.Location = new System.Drawing.Point(270, 22);
            this.chkYobiDo.Name = "chkYobiDo";
            this.chkYobiDo.Size = new System.Drawing.Size(38, 19);
            this.chkYobiDo.TabIndex = 18;
            this.chkYobiDo.Text = "土";
            this.chkYobiDo.UseVisualStyleBackColor = true;
            // 
            // chkYobiKin
            // 
            this.chkYobiKin.AutoSize = true;
            this.chkYobiKin.Location = new System.Drawing.Point(226, 22);
            this.chkYobiKin.Name = "chkYobiKin";
            this.chkYobiKin.Size = new System.Drawing.Size(38, 19);
            this.chkYobiKin.TabIndex = 17;
            this.chkYobiKin.Text = "金";
            this.chkYobiKin.UseVisualStyleBackColor = true;
            // 
            // chkYobiMoku
            // 
            this.chkYobiMoku.AutoSize = true;
            this.chkYobiMoku.Location = new System.Drawing.Point(182, 22);
            this.chkYobiMoku.Name = "chkYobiMoku";
            this.chkYobiMoku.Size = new System.Drawing.Size(38, 19);
            this.chkYobiMoku.TabIndex = 16;
            this.chkYobiMoku.Text = "木";
            this.chkYobiMoku.UseVisualStyleBackColor = true;
            // 
            // chkYobiSui
            // 
            this.chkYobiSui.AutoSize = true;
            this.chkYobiSui.Location = new System.Drawing.Point(138, 22);
            this.chkYobiSui.Name = "chkYobiSui";
            this.chkYobiSui.Size = new System.Drawing.Size(38, 19);
            this.chkYobiSui.TabIndex = 15;
            this.chkYobiSui.Text = "水";
            this.chkYobiSui.UseVisualStyleBackColor = true;
            // 
            // chkYobiNichi
            // 
            this.chkYobiNichi.AutoSize = true;
            this.chkYobiNichi.Location = new System.Drawing.Point(6, 22);
            this.chkYobiNichi.Name = "chkYobiNichi";
            this.chkYobiNichi.Size = new System.Drawing.Size(38, 19);
            this.chkYobiNichi.TabIndex = 14;
            this.chkYobiNichi.Text = "日";
            this.chkYobiNichi.UseVisualStyleBackColor = true;
            // 
            // grpTsuki
            // 
            this.grpTsuki.Controls.Add(this.chkTsuki09);
            this.grpTsuki.Controls.Add(this.chkTsuki10);
            this.grpTsuki.Controls.Add(this.chkTsuki11);
            this.grpTsuki.Controls.Add(this.chkTsuki12);
            this.grpTsuki.Controls.Add(this.chkTsuki08);
            this.grpTsuki.Controls.Add(this.chkTsuki02);
            this.grpTsuki.Controls.Add(this.chkTsuki03);
            this.grpTsuki.Controls.Add(this.chkTsuki07);
            this.grpTsuki.Controls.Add(this.chkTsuki06);
            this.grpTsuki.Controls.Add(this.chkTsuki05);
            this.grpTsuki.Controls.Add(this.chkTsuki04);
            this.grpTsuki.Controls.Add(this.chkTsuki01);
            this.grpTsuki.Location = new System.Drawing.Point(12, 121);
            this.grpTsuki.Name = "grpTsuki";
            this.grpTsuki.Size = new System.Drawing.Size(390, 87);
            this.grpTsuki.TabIndex = 21;
            this.grpTsuki.TabStop = false;
            this.grpTsuki.Text = "月指定時のみ有効（平日のみ）";
            // 
            // chkTsuki09
            // 
            this.chkTsuki09.AutoSize = true;
            this.chkTsuki09.Location = new System.Drawing.Point(108, 47);
            this.chkTsuki09.Name = "chkTsuki09";
            this.chkTsuki09.Size = new System.Drawing.Size(45, 19);
            this.chkTsuki09.TabIndex = 25;
            this.chkTsuki09.Text = "9月";
            this.chkTsuki09.UseVisualStyleBackColor = true;
            // 
            // chkTsuki10
            // 
            this.chkTsuki10.AutoSize = true;
            this.chkTsuki10.Location = new System.Drawing.Point(158, 47);
            this.chkTsuki10.Name = "chkTsuki10";
            this.chkTsuki10.Size = new System.Drawing.Size(52, 19);
            this.chkTsuki10.TabIndex = 24;
            this.chkTsuki10.Text = "10月";
            this.chkTsuki10.UseVisualStyleBackColor = true;
            // 
            // chkTsuki11
            // 
            this.chkTsuki11.AutoSize = true;
            this.chkTsuki11.Location = new System.Drawing.Point(216, 47);
            this.chkTsuki11.Name = "chkTsuki11";
            this.chkTsuki11.Size = new System.Drawing.Size(52, 19);
            this.chkTsuki11.TabIndex = 23;
            this.chkTsuki11.Text = "11月";
            this.chkTsuki11.UseVisualStyleBackColor = true;
            // 
            // chkTsuki12
            // 
            this.chkTsuki12.AutoSize = true;
            this.chkTsuki12.Location = new System.Drawing.Point(274, 47);
            this.chkTsuki12.Name = "chkTsuki12";
            this.chkTsuki12.Size = new System.Drawing.Size(52, 19);
            this.chkTsuki12.TabIndex = 22;
            this.chkTsuki12.Text = "12月";
            this.chkTsuki12.UseVisualStyleBackColor = true;
            // 
            // chkTsuki08
            // 
            this.chkTsuki08.AutoSize = true;
            this.chkTsuki08.Location = new System.Drawing.Point(57, 47);
            this.chkTsuki08.Name = "chkTsuki08";
            this.chkTsuki08.Size = new System.Drawing.Size(45, 19);
            this.chkTsuki08.TabIndex = 21;
            this.chkTsuki08.Text = "8月";
            this.chkTsuki08.UseVisualStyleBackColor = true;
            // 
            // chkTsuki02
            // 
            this.chkTsuki02.AutoSize = true;
            this.chkTsuki02.Location = new System.Drawing.Point(57, 22);
            this.chkTsuki02.Name = "chkTsuki02";
            this.chkTsuki02.Size = new System.Drawing.Size(45, 19);
            this.chkTsuki02.TabIndex = 20;
            this.chkTsuki02.Text = "2月";
            this.chkTsuki02.UseVisualStyleBackColor = true;
            // 
            // chkTsuki03
            // 
            this.chkTsuki03.AutoSize = true;
            this.chkTsuki03.Location = new System.Drawing.Point(108, 22);
            this.chkTsuki03.Name = "chkTsuki03";
            this.chkTsuki03.Size = new System.Drawing.Size(45, 19);
            this.chkTsuki03.TabIndex = 19;
            this.chkTsuki03.Text = "3月";
            this.chkTsuki03.UseVisualStyleBackColor = true;
            // 
            // chkTsuki07
            // 
            this.chkTsuki07.AutoSize = true;
            this.chkTsuki07.Location = new System.Drawing.Point(6, 47);
            this.chkTsuki07.Name = "chkTsuki07";
            this.chkTsuki07.Size = new System.Drawing.Size(45, 19);
            this.chkTsuki07.TabIndex = 18;
            this.chkTsuki07.Text = "7月";
            this.chkTsuki07.UseVisualStyleBackColor = true;
            // 
            // chkTsuki06
            // 
            this.chkTsuki06.AutoSize = true;
            this.chkTsuki06.Location = new System.Drawing.Point(274, 22);
            this.chkTsuki06.Name = "chkTsuki06";
            this.chkTsuki06.Size = new System.Drawing.Size(45, 19);
            this.chkTsuki06.TabIndex = 17;
            this.chkTsuki06.Text = "6月";
            this.chkTsuki06.UseVisualStyleBackColor = true;
            // 
            // chkTsuki05
            // 
            this.chkTsuki05.AutoSize = true;
            this.chkTsuki05.Location = new System.Drawing.Point(216, 22);
            this.chkTsuki05.Name = "chkTsuki05";
            this.chkTsuki05.Size = new System.Drawing.Size(45, 19);
            this.chkTsuki05.TabIndex = 16;
            this.chkTsuki05.Text = "5月";
            this.chkTsuki05.UseVisualStyleBackColor = true;
            // 
            // chkTsuki04
            // 
            this.chkTsuki04.AutoSize = true;
            this.chkTsuki04.Location = new System.Drawing.Point(159, 22);
            this.chkTsuki04.Name = "chkTsuki04";
            this.chkTsuki04.Size = new System.Drawing.Size(45, 19);
            this.chkTsuki04.TabIndex = 15;
            this.chkTsuki04.Text = "4月";
            this.chkTsuki04.UseVisualStyleBackColor = true;
            // 
            // chkTsuki01
            // 
            this.chkTsuki01.AutoSize = true;
            this.chkTsuki01.Location = new System.Drawing.Point(6, 22);
            this.chkTsuki01.Name = "chkTsuki01";
            this.chkTsuki01.Size = new System.Drawing.Size(45, 19);
            this.chkTsuki01.TabIndex = 14;
            this.chkTsuki01.Text = "1月";
            this.chkTsuki01.UseVisualStyleBackColor = true;
            // 
            // BatchKotsuhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 389);
            this.ControlBox = false;
            this.Controls.Add(this.grpTsuki);
            this.Controls.Add(this.grpYobi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShiwakeAdd);
            this.Controls.Add(this.cmbHojo);
            this.Controls.Add(this.txtTekiyo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKin);
            this.Controls.Add(this.btnCSV);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.btnYayoiCSV);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchKotsuhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "交通費一括出力";
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.grpYobi.ResumeLayout(false);
            this.grpYobi.PerformLayout();
            this.grpTsuki.ResumeLayout(false);
            this.grpTsuki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYayoiCSV;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton rdoYear;
        private System.Windows.Forms.RadioButton rdoHoliday;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.Button btnCSV;
        private control.TextBoxEx txtKin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private control.TextBoxEx txtTekiyo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHojo;
        private System.Windows.Forms.Button btnShiwakeAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoYobi;
        private System.Windows.Forms.GroupBox grpYobi;
        private System.Windows.Forms.CheckBox chkYobiGetsu;
        private System.Windows.Forms.CheckBox chkYobiKa;
        private System.Windows.Forms.CheckBox chkYobiDo;
        private System.Windows.Forms.CheckBox chkYobiKin;
        private System.Windows.Forms.CheckBox chkYobiMoku;
        private System.Windows.Forms.CheckBox chkYobiSui;
        private System.Windows.Forms.CheckBox chkYobiNichi;
        private System.Windows.Forms.RadioButton rdoTsuki;
        private System.Windows.Forms.GroupBox grpTsuki;
        private System.Windows.Forms.CheckBox chkTsuki09;
        private System.Windows.Forms.CheckBox chkTsuki10;
        private System.Windows.Forms.CheckBox chkTsuki11;
        private System.Windows.Forms.CheckBox chkTsuki12;
        private System.Windows.Forms.CheckBox chkTsuki08;
        private System.Windows.Forms.CheckBox chkTsuki02;
        private System.Windows.Forms.CheckBox chkTsuki03;
        private System.Windows.Forms.CheckBox chkTsuki07;
        private System.Windows.Forms.CheckBox chkTsuki06;
        private System.Windows.Forms.CheckBox chkTsuki05;
        private System.Windows.Forms.CheckBox chkTsuki04;
        private System.Windows.Forms.CheckBox chkTsuki01;
    }
}