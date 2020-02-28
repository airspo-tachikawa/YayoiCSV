namespace YayoiCsv
{
    partial class InputKurikoshi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.txtYoKin = new YayoiCsv.control.TextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenKin = new YayoiCsv.control.TextBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtUrikake = new YayoiCsv.control.TextBoxEx();
            this.lblUrikake = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrikake);
            this.groupBox1.Controls.Add(this.lblUrikake);
            this.groupBox1.Controls.Add(this.btnRegist);
            this.groupBox1.Controls.Add(this.txtYoKin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGenKin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "繰越金額";
            // 
            // btnRegist
            // 
            this.btnRegist.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRegist.Location = new System.Drawing.Point(247, 55);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(86, 57);
            this.btnRegist.TabIndex = 3;
            this.btnRegist.Text = "更新";
            this.btnRegist.UseVisualStyleBackColor = false;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // txtYoKin
            // 
            this.txtYoKin.InputType = YayoiCsv.control.InputType.Number;
            this.txtYoKin.Location = new System.Drawing.Point(124, 55);
            this.txtYoKin.MaxLength = 7;
            this.txtYoKin.Name = "txtYoKin";
            this.txtYoKin.Size = new System.Drawing.Size(117, 23);
            this.txtYoKin.TabIndex = 1;
            this.txtYoKin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "預金";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGenKin
            // 
            this.txtGenKin.InputType = YayoiCsv.control.InputType.Number;
            this.txtGenKin.Location = new System.Drawing.Point(124, 21);
            this.txtGenKin.MaxLength = 7;
            this.txtGenKin.Name = "txtGenKin";
            this.txtGenKin.Size = new System.Drawing.Size(117, 23);
            this.txtGenKin.TabIndex = 0;
            this.txtGenKin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "現金";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(355, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUrikake
            // 
            this.txtUrikake.InputType = YayoiCsv.control.InputType.Number;
            this.txtUrikake.Location = new System.Drawing.Point(124, 88);
            this.txtUrikake.MaxLength = 7;
            this.txtUrikake.Name = "txtUrikake";
            this.txtUrikake.Size = new System.Drawing.Size(117, 23);
            this.txtUrikake.TabIndex = 2;
            this.txtUrikake.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUrikake
            // 
            this.lblUrikake.BackColor = System.Drawing.Color.YellowGreen;
            this.lblUrikake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUrikake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUrikake.Location = new System.Drawing.Point(17, 88);
            this.lblUrikake.Name = "lblUrikake";
            this.lblUrikake.Size = new System.Drawing.Size(101, 23);
            this.lblUrikake.TabIndex = 28;
            this.lblUrikake.Text = "売掛金";
            this.lblUrikake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InputKurikoshi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 156);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputKurikoshi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "繰越金額入力";
            this.Load += new System.EventHandler(this.InputKurikoshi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private control.TextBoxEx txtGenKin;
        private control.TextBoxEx txtYoKin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegist;
        private control.TextBoxEx txtUrikake;
        private System.Windows.Forms.Label lblUrikake;
    }
}

