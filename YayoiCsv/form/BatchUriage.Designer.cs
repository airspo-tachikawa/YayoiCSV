namespace YayoiCsv
{
    partial class BatchUriage
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKeihiAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEx1 = new YayoiCsv.control.TextBoxEx();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHKmk_Ks = new YayoiCsv.control.ComboBoxEx();
            this.cmbKmk_Ks = new YayoiCsv.control.ComboBoxEx();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEx2 = new YayoiCsv.control.TextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHi = new YayoiCsv.control.TextBoxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHKmk_Kr = new YayoiCsv.control.ComboBoxEx();
            this.cmbKmk_Kr = new YayoiCsv.control.ComboBoxEx();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoUrikake = new System.Windows.Forms.RadioButton();
            this.rdoGenkinUriage = new System.Windows.Forms.RadioButton();
            this.rdoUrikakeKYokin = new System.Windows.Forms.RadioButton();
            this.rdoUrikakeKGenkin = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYayoiCSV
            // 
            this.btnYayoiCSV.Location = new System.Drawing.Point(405, 248);
            this.btnYayoiCSV.Name = "btnYayoiCSV";
            this.btnYayoiCSV.Size = new System.Drawing.Size(84, 51);
            this.btnYayoiCSV.TabIndex = 5;
            this.btnYayoiCSV.Text = "弥生Import形式CSV";
            this.btnYayoiCSV.Click += new System.EventHandler(this.btnYayoiCSV_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(442, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKeihiAdd
            // 
            this.btnKeihiAdd.Location = new System.Drawing.Point(315, 248);
            this.btnKeihiAdd.Name = "btnKeihiAdd";
            this.btnKeihiAdd.Size = new System.Drawing.Size(84, 51);
            this.btnKeihiAdd.TabIndex = 11;
            this.btnKeihiAdd.Text = "売上に追加";
            this.btnKeihiAdd.UseVisualStyleBackColor = true;
            this.btnKeihiAdd.Click += new System.EventHandler(this.btnKeihiAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbHKmk_Ks);
            this.groupBox2.Controls.Add(this.cmbKmk_Ks);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbHKmk_Kr);
            this.groupBox2.Controls.Add(this.cmbKmk_Kr);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 88);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "表示";
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.InputType = YayoiCsv.control.InputType.String;
            this.textBoxEx1.Location = new System.Drawing.Point(113, 55);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Size = new System.Drawing.Size(227, 23);
            this.textBoxEx1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.YellowGreen;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(6, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "摘要";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.YellowGreen;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(229, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "補助科目(貸方)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbHKmk_Ks
            // 
            this.cmbHKmk_Ks.Enabled = false;
            this.cmbHKmk_Ks.FormattingEnabled = true;
            this.cmbHKmk_Ks.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbHKmk_Ks.Location = new System.Drawing.Point(336, 53);
            this.cmbHKmk_Ks.Name = "cmbHKmk_Ks";
            this.cmbHKmk_Ks.Size = new System.Drawing.Size(126, 23);
            this.cmbHKmk_Ks.TabIndex = 5;
            // 
            // cmbKmk_Ks
            // 
            this.cmbKmk_Ks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKmk_Ks.Enabled = false;
            this.cmbKmk_Ks.FormattingEnabled = true;
            this.cmbKmk_Ks.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbKmk_Ks.Location = new System.Drawing.Point(113, 53);
            this.cmbKmk_Ks.Name = "cmbKmk_Ks";
            this.cmbKmk_Ks.Size = new System.Drawing.Size(110, 23);
            this.cmbKmk_Ks.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.YellowGreen;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "科目(貸方)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxEx2
            // 
            this.textBoxEx2.InputType = YayoiCsv.control.InputType.Number;
            this.textBoxEx2.Location = new System.Drawing.Point(315, 19);
            this.textBoxEx2.MaxLength = 7;
            this.textBoxEx2.Name = "textBoxEx2";
            this.textBoxEx2.Size = new System.Drawing.Size(117, 23);
            this.textBoxEx2.TabIndex = 3;
            this.textBoxEx2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.YellowGreen;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(208, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "金額";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHi
            // 
            this.txtHi.InputType = YayoiCsv.control.InputType.Date;
            this.txtHi.Location = new System.Drawing.Point(113, 19);
            this.txtHi.MaxLength = 4;
            this.txtHi.Name = "txtHi";
            this.txtHi.Size = new System.Drawing.Size(89, 23);
            this.txtHi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.YellowGreen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "日付";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(229, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "補助科目(借方)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbHKmk_Kr
            // 
            this.cmbHKmk_Kr.FormattingEnabled = true;
            this.cmbHKmk_Kr.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbHKmk_Kr.Location = new System.Drawing.Point(336, 19);
            this.cmbHKmk_Kr.Name = "cmbHKmk_Kr";
            this.cmbHKmk_Kr.Size = new System.Drawing.Size(126, 23);
            this.cmbHKmk_Kr.TabIndex = 1;
            // 
            // cmbKmk_Kr
            // 
            this.cmbKmk_Kr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKmk_Kr.FormattingEnabled = true;
            this.cmbKmk_Kr.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbKmk_Kr.Location = new System.Drawing.Point(113, 19);
            this.cmbKmk_Kr.Name = "cmbKmk_Kr";
            this.cmbKmk_Kr.Size = new System.Drawing.Size(110, 23);
            this.cmbKmk_Kr.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.YellowGreen;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "科目(借方)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxEx1);
            this.groupBox1.Controls.Add(this.textBoxEx2);
            this.groupBox1.Controls.Add(this.txtHi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 90);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入力";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoUrikakeKGenkin);
            this.groupBox3.Controls.Add(this.rdoUrikakeKYokin);
            this.groupBox3.Controls.Add(this.rdoGenkinUriage);
            this.groupBox3.Controls.Add(this.rdoUrikake);
            this.groupBox3.Location = new System.Drawing.Point(12, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 53);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "選択";
            // 
            // rdoUrikake
            // 
            this.rdoUrikake.AutoSize = true;
            this.rdoUrikake.Location = new System.Drawing.Point(7, 22);
            this.rdoUrikake.Name = "rdoUrikake";
            this.rdoUrikake.Size = new System.Drawing.Size(61, 19);
            this.rdoUrikake.TabIndex = 29;
            this.rdoUrikake.TabStop = true;
            this.rdoUrikake.Text = "売掛金";
            this.rdoUrikake.UseVisualStyleBackColor = true;
            // 
            // rdoGenkinUriage
            // 
            this.rdoGenkinUriage.AutoSize = true;
            this.rdoGenkinUriage.Location = new System.Drawing.Point(71, 22);
            this.rdoGenkinUriage.Name = "rdoGenkinUriage";
            this.rdoGenkinUriage.Size = new System.Drawing.Size(73, 19);
            this.rdoGenkinUriage.TabIndex = 30;
            this.rdoGenkinUriage.TabStop = true;
            this.rdoGenkinUriage.Text = "現金売上";
            this.rdoGenkinUriage.UseVisualStyleBackColor = true;
            // 
            // rdoUrikakeKYokin
            // 
            this.rdoUrikakeKYokin.AutoSize = true;
            this.rdoUrikakeKYokin.Location = new System.Drawing.Point(147, 22);
            this.rdoUrikakeKYokin.Name = "rdoUrikakeKYokin";
            this.rdoUrikakeKYokin.Size = new System.Drawing.Size(133, 19);
            this.rdoUrikakeKYokin.TabIndex = 31;
            this.rdoUrikakeKYokin.TabStop = true;
            this.rdoUrikakeKYokin.Text = "売掛金回収（預金）";
            this.rdoUrikakeKYokin.UseVisualStyleBackColor = true;
            // 
            // rdoUrikakeKGenkin
            // 
            this.rdoUrikakeKGenkin.AutoSize = true;
            this.rdoUrikakeKGenkin.Location = new System.Drawing.Point(283, 22);
            this.rdoUrikakeKGenkin.Name = "rdoUrikakeKGenkin";
            this.rdoUrikakeKGenkin.Size = new System.Drawing.Size(133, 19);
            this.rdoUrikakeKGenkin.TabIndex = 32;
            this.rdoUrikakeKGenkin.TabStop = true;
            this.rdoUrikakeKGenkin.Text = "売掛金回収（現金）";
            this.rdoUrikakeKGenkin.UseVisualStyleBackColor = true;
            // 
            // BatchUriage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 318);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKeihiAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnYayoiCSV);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchUriage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "売上高（売掛金）出力";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYayoiCSV;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKeihiAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private control.TextBoxEx textBoxEx1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private control.ComboBoxEx cmbHKmk_Ks;
        private control.ComboBoxEx cmbKmk_Ks;
        private System.Windows.Forms.Label label8;
        private control.TextBoxEx textBoxEx2;
        private System.Windows.Forms.Label label6;
        private control.TextBoxEx txtHi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private control.ComboBoxEx cmbHKmk_Kr;
        private control.ComboBoxEx cmbKmk_Kr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoUrikakeKGenkin;
        private System.Windows.Forms.RadioButton rdoUrikakeKYokin;
        private System.Windows.Forms.RadioButton rdoGenkinUriage;
        private System.Windows.Forms.RadioButton rdoUrikake;
    }
}