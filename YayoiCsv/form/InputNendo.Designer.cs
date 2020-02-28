namespace YayoiCsv
{
    partial class InputNendo
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
            this.cmbNendo = new YayoiCsv.control.ComboBoxEx();
            this.btnNendoSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbNendo
            // 
            this.cmbNendo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNendo.FormattingEnabled = true;
            this.cmbNendo.Location = new System.Drawing.Point(119, 12);
            this.cmbNendo.Name = "cmbNendo";
            this.cmbNendo.Size = new System.Drawing.Size(144, 23);
            this.cmbNendo.TabIndex = 0;
            // 
            // btnNendoSelect
            // 
            this.btnNendoSelect.Location = new System.Drawing.Point(119, 58);
            this.btnNendoSelect.Name = "btnNendoSelect";
            this.btnNendoSelect.Size = new System.Drawing.Size(197, 51);
            this.btnNendoSelect.TabIndex = 1;
            this.btnNendoSelect.Text = "年度決定";
            this.btnNendoSelect.UseVisualStyleBackColor = true;
            this.btnNendoSelect.Click += new System.EventHandler(this.btnNendoSelect_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "年度選択";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(291, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InputNendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 119);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNendoSelect);
            this.Controls.Add(this.cmbNendo);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputNendo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "年度選択";
            this.ResumeLayout(false);

        }

        #endregion

        private control.ComboBoxEx cmbNendo;
        private System.Windows.Forms.Button btnNendoSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}