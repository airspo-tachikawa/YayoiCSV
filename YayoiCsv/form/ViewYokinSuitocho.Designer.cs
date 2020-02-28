namespace YayoiCsv
{
    partial class ViewYokinSuitocho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewYokinSuitocho));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHKmk = new YayoiCsv.control.ComboBoxEx();
            this.cmbKmk = new YayoiCsv.control.ComboBoxEx();
            this.dataGridView1 = new YayoiCsv.control.DataGridViewEx();
            this.btnExcel = new System.Windows.Forms.Button();
            this.colKrKmkNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KrKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZanKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(552, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(230, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "補助科目";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "科目";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbHKmk
            // 
            this.cmbHKmk.FormattingEnabled = true;
            this.cmbHKmk.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbHKmk.Location = new System.Drawing.Point(337, 10);
            this.cmbHKmk.Name = "cmbHKmk";
            this.cmbHKmk.Size = new System.Drawing.Size(126, 23);
            this.cmbHKmk.TabIndex = 26;
            // 
            // cmbKmk
            // 
            this.cmbKmk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKmk.FormattingEnabled = true;
            this.cmbKmk.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbKmk.Location = new System.Drawing.Point(114, 10);
            this.cmbKmk.Name = "cmbKmk";
            this.cmbKmk.Size = new System.Drawing.Size(110, 23);
            this.cmbKmk.TabIndex = 25;
            this.cmbKmk.SelectedIndexChanged += new System.EventHandler(this.cmbKmk_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKrKmkNm,
            this.colDate,
            this.colWeek,
            this.KrKingaku,
            this.colKingaku,
            this.colZanKingaku});
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(586, 433);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcel.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(517, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(30, 30);
            this.btnExcel.TabIndex = 29;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // colKrKmkNm
            // 
            this.colKrKmkNm.DataPropertyName = "KrKmkName";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.colKrKmkNm.DefaultCellStyle = dataGridViewCellStyle1;
            this.colKrKmkNm.HeaderText = "科目名";
            this.colKrKmkNm.Name = "colKrKmkNm";
            this.colKrKmkNm.ReadOnly = true;
            this.colKrKmkNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colKrKmkNm.Width = 150;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "CustomDate";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDate.HeaderText = "取引日";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDate.Width = 70;
            // 
            // colWeek
            // 
            this.colWeek.DataPropertyName = "Week";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.colWeek.DefaultCellStyle = dataGridViewCellStyle3;
            this.colWeek.HeaderText = "曜";
            this.colWeek.Name = "colWeek";
            this.colWeek.ReadOnly = true;
            this.colWeek.Width = 40;
            // 
            // KrKingaku
            // 
            this.KrKingaku.DataPropertyName = "KrKingaku";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.KrKingaku.DefaultCellStyle = dataGridViewCellStyle4;
            this.KrKingaku.HeaderText = "借方金額";
            this.KrKingaku.Name = "KrKingaku";
            this.KrKingaku.ReadOnly = true;
            this.KrKingaku.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colKingaku
            // 
            this.colKingaku.DataPropertyName = "KsKingaku";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C0";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.colKingaku.DefaultCellStyle = dataGridViewCellStyle5;
            this.colKingaku.HeaderText = "貸方金額";
            this.colKingaku.Name = "colKingaku";
            this.colKingaku.ReadOnly = true;
            this.colKingaku.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colZanKingaku
            // 
            this.colZanKingaku.DataPropertyName = "ZanKingaku";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.colZanKingaku.DefaultCellStyle = dataGridViewCellStyle6;
            this.colZanKingaku.HeaderText = "現金残";
            this.colZanKingaku.Name = "colZanKingaku";
            this.colZanKingaku.ReadOnly = true;
            this.colZanKingaku.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ViewYokinSuitocho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 462);
            this.ControlBox = false;
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHKmk);
            this.Controls.Add(this.cmbKmk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewYokinSuitocho";
            this.Text = "預金出納帳";
            this.Load += new System.EventHandler(this.InputShiwake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private control.DataGridViewEx dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private control.ComboBoxEx cmbHKmk;
        private control.ComboBoxEx cmbKmk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKrKmkNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn KrKingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZanKingaku;
    }
}

