namespace YayoiCsv
{
    partial class InputKeihi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHKmkSrch = new YayoiCsv.control.ComboBoxEx();
            this.cmbKmkSrch = new YayoiCsv.control.ComboBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDateSrch = new YayoiCsv.control.TextBoxEx();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNo = new YayoiCsv.control.TextBoxEx();
            this.txtTekiyo = new YayoiCsv.control.TextBoxEx();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHKmk_Ks = new YayoiCsv.control.ComboBoxEx();
            this.cmbKmk_Ks = new YayoiCsv.control.ComboBoxEx();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKin = new YayoiCsv.control.TextBoxEx();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHi = new YayoiCsv.control.TextBoxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHKmk_Kr = new YayoiCsv.control.ComboBoxEx();
            this.cmbKmk_Kr = new YayoiCsv.control.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKrKmkNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKrHKmkNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTekiyo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKsKmkNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKsHKmkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbHKmkSrch);
            this.groupBox1.Controls.Add(this.cmbKmkSrch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDateSrch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(229, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "補助科目(借方)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbHKmkSrch
            // 
            this.cmbHKmkSrch.FormattingEnabled = true;
            this.cmbHKmkSrch.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbHKmkSrch.Location = new System.Drawing.Point(336, 16);
            this.cmbHKmkSrch.Name = "cmbHKmkSrch";
            this.cmbHKmkSrch.Size = new System.Drawing.Size(126, 27);
            this.cmbHKmkSrch.TabIndex = 1;
            this.cmbHKmkSrch.SelectedIndexChanged += new System.EventHandler(this.cmbHKmkSrch_SelectedIndexChanged);
            this.cmbHKmkSrch.TextChanged += new System.EventHandler(this.cmbHKmkSrch_TextChanged);
            // 
            // cmbKmkSrch
            // 
            this.cmbKmkSrch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKmkSrch.FormattingEnabled = true;
            this.cmbKmkSrch.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbKmkSrch.Location = new System.Drawing.Point(113, 16);
            this.cmbKmkSrch.Name = "cmbKmkSrch";
            this.cmbKmkSrch.Size = new System.Drawing.Size(110, 27);
            this.cmbKmkSrch.TabIndex = 0;
            this.cmbKmkSrch.SelectedIndexChanged += new System.EventHandler(this.cmbKmkSrch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "科目(借方)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDateSrch
            // 
            this.txtDateSrch.InputType = YayoiCsv.control.InputType.Date;
            this.txtDateSrch.Location = new System.Drawing.Point(574, 16);
            this.txtDateSrch.MaxLength = 4;
            this.txtDateSrch.Name = "txtDateSrch";
            this.txtDateSrch.Size = new System.Drawing.Size(89, 27);
            this.txtDateSrch.TabIndex = 2;
            this.txtDateSrch.TextChanged += new System.EventHandler(this.txtDateSrch_TextChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.YellowGreen;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(467, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 18;
            this.label11.Text = "日付";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNo);
            this.groupBox2.Controls.Add(this.txtTekiyo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnRepair);
            this.groupBox2.Controls.Add(this.btnRegist);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbHKmk_Ks);
            this.groupBox2.Controls.Add(this.cmbKmk_Ks);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtKin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtHi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbHKmk_Kr);
            this.groupBox2.Controls.Add(this.cmbKmk_Kr);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 91);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "入力";
            // 
            // txtNo
            // 
            this.txtNo.InputType = YayoiCsv.control.InputType.String;
            this.txtNo.Location = new System.Drawing.Point(29, 19);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(30, 27);
            this.txtNo.TabIndex = 28;
            this.txtNo.Visible = false;
            // 
            // txtTekiyo
            // 
            this.txtTekiyo.InputType = YayoiCsv.control.InputType.String;
            this.txtTekiyo.Location = new System.Drawing.Point(574, 55);
            this.txtTekiyo.Name = "txtTekiyo";
            this.txtTekiyo.Size = new System.Drawing.Size(227, 27);
            this.txtTekiyo.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.YellowGreen;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(467, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "摘要";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRepair
            // 
            this.btnRepair.BackColor = System.Drawing.SystemColors.Info;
            this.btnRepair.Location = new System.Drawing.Point(807, 45);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(40, 40);
            this.btnRepair.TabIndex = 7;
            this.btnRepair.Text = "修正";
            this.btnRepair.UseVisualStyleBackColor = false;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRegist.Location = new System.Drawing.Point(853, 45);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(40, 40);
            this.btnRegist.TabIndex = 8;
            this.btnRegist.Text = "追加";
            this.btnRegist.UseVisualStyleBackColor = false;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
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
            this.cmbHKmk_Ks.Size = new System.Drawing.Size(126, 27);
            this.cmbHKmk_Ks.TabIndex = 5;
            // 
            // cmbKmk_Ks
            // 
            this.cmbKmk_Ks.FormattingEnabled = true;
            this.cmbKmk_Ks.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbKmk_Ks.Items.AddRange(new object[] {
            "現金",
            "事業主借"});
            this.cmbKmk_Ks.Location = new System.Drawing.Point(113, 53);
            this.cmbKmk_Ks.Name = "cmbKmk_Ks";
            this.cmbKmk_Ks.Size = new System.Drawing.Size(110, 27);
            this.cmbKmk_Ks.TabIndex = 4;
            this.cmbKmk_Ks.Text = "現金";
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
            // txtKin
            // 
            this.txtKin.InputType = YayoiCsv.control.InputType.Number;
            this.txtKin.Location = new System.Drawing.Point(776, 19);
            this.txtKin.MaxLength = 7;
            this.txtKin.Name = "txtKin";
            this.txtKin.Size = new System.Drawing.Size(117, 27);
            this.txtKin.TabIndex = 3;
            this.txtKin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.YellowGreen;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(669, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "金額";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHi
            // 
            this.txtHi.InputType = YayoiCsv.control.InputType.Date;
            this.txtHi.Location = new System.Drawing.Point(574, 19);
            this.txtHi.MaxLength = 4;
            this.txtHi.Name = "txtHi";
            this.txtHi.Size = new System.Drawing.Size(89, 27);
            this.txtHi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.YellowGreen;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(467, 19);
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
            this.cmbHKmk_Kr.Size = new System.Drawing.Size(126, 27);
            this.cmbHKmk_Kr.TabIndex = 1;
            // 
            // cmbKmk_Kr
            // 
            this.cmbKmk_Kr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKmk_Kr.FormattingEnabled = true;
            this.cmbKmk_Kr.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbKmk_Kr.Location = new System.Drawing.Point(113, 19);
            this.cmbKmk_Kr.Name = "cmbKmk_Kr";
            this.cmbKmk_Kr.Size = new System.Drawing.Size(110, 27);
            this.cmbKmk_Kr.TabIndex = 0;
            this.cmbKmk_Kr.SelectedIndexChanged += new System.EventHandler(this.cmbKmk_Kr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "科目(借方)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.colDate,
            this.colWeek,
            this.colKrKmkNm,
            this.colKrHKmkNm,
            this.colTekiyo,
            this.colKingaku,
            this.colNo,
            this.colKsKmkNm,
            this.colKsHKmkName,
            this.colUpd,
            this.colDel});
            this.dataGridView1.Location = new System.Drawing.Point(11, 155);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(891, 435);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "CustomDate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "00/00";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.colDate.HeaderText = "取引日";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 80;
            // 
            // colWeek
            // 
            this.colWeek.DataPropertyName = "Week";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.colWeek.DefaultCellStyle = dataGridViewCellStyle2;
            this.colWeek.HeaderText = "曜";
            this.colWeek.MinimumWidth = 6;
            this.colWeek.Name = "colWeek";
            this.colWeek.ReadOnly = true;
            this.colWeek.Width = 40;
            // 
            // colKrKmkNm
            // 
            this.colKrKmkNm.DataPropertyName = "KrKmkName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.colKrKmkNm.DefaultCellStyle = dataGridViewCellStyle3;
            this.colKrKmkNm.HeaderText = "科目名";
            this.colKrKmkNm.MinimumWidth = 6;
            this.colKrKmkNm.Name = "colKrKmkNm";
            this.colKrKmkNm.ReadOnly = true;
            this.colKrKmkNm.Width = 150;
            // 
            // colKrHKmkNm
            // 
            this.colKrHKmkNm.DataPropertyName = "KrHKmkName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.colKrHKmkNm.DefaultCellStyle = dataGridViewCellStyle4;
            this.colKrHKmkNm.HeaderText = "補助科目名";
            this.colKrHKmkNm.MinimumWidth = 6;
            this.colKrHKmkNm.Name = "colKrHKmkNm";
            this.colKrHKmkNm.ReadOnly = true;
            this.colKrHKmkNm.Width = 150;
            // 
            // colTekiyo
            // 
            this.colTekiyo.DataPropertyName = "Tekiyo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.colTekiyo.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTekiyo.HeaderText = "摘要";
            this.colTekiyo.MinimumWidth = 6;
            this.colTekiyo.Name = "colTekiyo";
            this.colTekiyo.ReadOnly = true;
            this.colTekiyo.Width = 250;
            // 
            // colKingaku
            // 
            this.colKingaku.DataPropertyName = "Kingaku";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C0";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.colKingaku.DefaultCellStyle = dataGridViewCellStyle6;
            this.colKingaku.HeaderText = "金額";
            this.colKingaku.MinimumWidth = 6;
            this.colKingaku.Name = "colKingaku";
            this.colKingaku.ReadOnly = true;
            this.colKingaku.Width = 125;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "連番";
            this.colNo.MinimumWidth = 6;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Visible = false;
            this.colNo.Width = 125;
            // 
            // colKsKmkNm
            // 
            this.colKsKmkNm.DataPropertyName = "KsKmkName";
            this.colKsKmkNm.HeaderText = "科目名";
            this.colKsKmkNm.MinimumWidth = 6;
            this.colKsKmkNm.Name = "colKsKmkNm";
            this.colKsKmkNm.ReadOnly = true;
            this.colKsKmkNm.Visible = false;
            this.colKsKmkNm.Width = 125;
            // 
            // colKsHKmkName
            // 
            this.colKsHKmkName.DataPropertyName = "KsHKmkName";
            this.colKsHKmkName.HeaderText = "補助科目名";
            this.colKsHKmkName.MinimumWidth = 6;
            this.colKsHKmkName.Name = "colKsHKmkName";
            this.colKsHKmkName.ReadOnly = true;
            this.colKsHKmkName.Visible = false;
            this.colKsHKmkName.Width = 125;
            // 
            // colUpd
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.colUpd.DefaultCellStyle = dataGridViewCellStyle7;
            this.colUpd.HeaderText = "修正";
            this.colUpd.MinimumWidth = 6;
            this.colUpd.Name = "colUpd";
            this.colUpd.ReadOnly = true;
            this.colUpd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUpd.Width = 50;
            // 
            // colDel
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.colDel.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDel.HeaderText = "削除";
            this.colDel.MinimumWidth = 6;
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel.Width = 50;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(877, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InputKeihi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 602);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputKeihi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "経費入力";
            this.Load += new System.EventHandler(this.InputShiwake_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private control.ComboBoxEx cmbKmkSrch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private control.ComboBoxEx cmbHKmkSrch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private control.ComboBoxEx cmbKmk_Kr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private control.ComboBoxEx cmbHKmk_Kr;
        private control.TextBoxEx txtHi;
        private System.Windows.Forms.Label label7;
        private control.ComboBoxEx cmbHKmk_Ks;
        private control.ComboBoxEx cmbKmk_Ks;
        private System.Windows.Forms.Label label8;
        private control.TextBoxEx txtKin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnRepair;
        private control.TextBoxEx txtTekiyo;
        private System.Windows.Forms.Label label10;
        private control.TextBoxEx txtNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private control.TextBoxEx txtDateSrch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKrKmkNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKrHKmkNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTekiyo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKsKmkNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKsHKmkName;
        private System.Windows.Forms.DataGridViewButtonColumn colUpd;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}

