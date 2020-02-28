namespace YayoiCsv
{
    partial class InputUriage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoYokinToKojin = new System.Windows.Forms.RadioButton();
            this.rdoGenkinUriage = new System.Windows.Forms.RadioButton();
            this.rdoUrikake = new System.Windows.Forms.RadioButton();
            this.rdoGenkinToKojin = new System.Windows.Forms.RadioButton();
            this.rdoGenkinToYokin = new System.Windows.Forms.RadioButton();
            this.rdoUrikakeKYokin = new System.Windows.Forms.RadioButton();
            this.rdoUrikakeKGenkin = new System.Windows.Forms.RadioButton();
            this.rdoYokinToGenkin = new System.Windows.Forms.RadioButton();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKrKmkNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKrHKmkNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKsKmkNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKsHKmkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKingaku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTekiyo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(926, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(8, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(940, 91);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "入力";
            // 
            // txtNo
            // 
            this.txtNo.InputType = YayoiCsv.control.InputType.String;
            this.txtNo.Location = new System.Drawing.Point(29, 19);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(30, 23);
            this.txtNo.TabIndex = 28;
            this.txtNo.Visible = false;
            // 
            // txtTekiyo
            // 
            this.txtTekiyo.InputType = YayoiCsv.control.InputType.String;
            this.txtTekiyo.Location = new System.Drawing.Point(574, 55);
            this.txtTekiyo.Name = "txtTekiyo";
            this.txtTekiyo.Size = new System.Drawing.Size(264, 23);
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
            this.btnRepair.Location = new System.Drawing.Point(844, 45);
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
            this.btnRegist.Location = new System.Drawing.Point(890, 45);
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
            this.cmbKmk_Ks.FormattingEnabled = true;
            this.cmbKmk_Ks.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.cmbKmk_Ks.Location = new System.Drawing.Point(113, 53);
            this.cmbKmk_Ks.Name = "cmbKmk_Ks";
            this.cmbKmk_Ks.Size = new System.Drawing.Size(110, 23);
            this.cmbKmk_Ks.TabIndex = 4;
            this.cmbKmk_Ks.SelectedIndexChanged += new System.EventHandler(this.cmbKmk_Ks_SelectedIndexChanged);
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
            this.txtKin.Size = new System.Drawing.Size(117, 23);
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
            this.txtHi.Size = new System.Drawing.Size(89, 23);
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
            this.colKsKmkNm,
            this.colKsHKmkName,
            this.colKingaku,
            this.colTekiyo,
            this.colNo,
            this.colUpd,
            this.colDel});
            this.dataGridView1.Location = new System.Drawing.Point(8, 225);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(940, 365);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoYokinToKojin);
            this.groupBox3.Controls.Add(this.rdoGenkinUriage);
            this.groupBox3.Controls.Add(this.rdoUrikake);
            this.groupBox3.Controls.Add(this.rdoGenkinToKojin);
            this.groupBox3.Controls.Add(this.rdoGenkinToYokin);
            this.groupBox3.Controls.Add(this.rdoUrikakeKYokin);
            this.groupBox3.Controls.Add(this.rdoUrikakeKGenkin);
            this.groupBox3.Controls.Add(this.rdoYokinToGenkin);
            this.groupBox3.Location = new System.Drawing.Point(8, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 121);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "選択";
            // 
            // rdoYokinToKojin
            // 
            this.rdoYokinToKojin.AutoSize = true;
            this.rdoYokinToKojin.Location = new System.Drawing.Point(146, 94);
            this.rdoYokinToKojin.Name = "rdoYokinToKojin";
            this.rdoYokinToKojin.Size = new System.Drawing.Size(127, 19);
            this.rdoYokinToKojin.TabIndex = 7;
            this.rdoYokinToKojin.TabStop = true;
            this.rdoYokinToKojin.Text = "預金を個人的に使用";
            this.rdoYokinToKojin.UseVisualStyleBackColor = true;
            this.rdoYokinToKojin.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoGenkinUriage
            // 
            this.rdoGenkinUriage.AutoSize = true;
            this.rdoGenkinUriage.Location = new System.Drawing.Point(66, 19);
            this.rdoGenkinUriage.Name = "rdoGenkinUriage";
            this.rdoGenkinUriage.Size = new System.Drawing.Size(73, 19);
            this.rdoGenkinUriage.TabIndex = 1;
            this.rdoGenkinUriage.TabStop = true;
            this.rdoGenkinUriage.Text = "現金売上";
            this.rdoGenkinUriage.UseVisualStyleBackColor = true;
            this.rdoGenkinUriage.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoUrikake
            // 
            this.rdoUrikake.AutoSize = true;
            this.rdoUrikake.Location = new System.Drawing.Point(7, 19);
            this.rdoUrikake.Name = "rdoUrikake";
            this.rdoUrikake.Size = new System.Drawing.Size(61, 19);
            this.rdoUrikake.TabIndex = 0;
            this.rdoUrikake.TabStop = true;
            this.rdoUrikake.Text = "売掛金";
            this.rdoUrikake.UseVisualStyleBackColor = true;
            this.rdoUrikake.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoGenkinToKojin
            // 
            this.rdoGenkinToKojin.AutoSize = true;
            this.rdoGenkinToKojin.Location = new System.Drawing.Point(7, 94);
            this.rdoGenkinToKojin.Name = "rdoGenkinToKojin";
            this.rdoGenkinToKojin.Size = new System.Drawing.Size(127, 19);
            this.rdoGenkinToKojin.TabIndex = 6;
            this.rdoGenkinToKojin.TabStop = true;
            this.rdoGenkinToKojin.Text = "現金を個人的に使用";
            this.rdoGenkinToKojin.UseVisualStyleBackColor = true;
            this.rdoGenkinToKojin.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoGenkinToYokin
            // 
            this.rdoGenkinToYokin.AutoSize = true;
            this.rdoGenkinToYokin.Location = new System.Drawing.Point(146, 69);
            this.rdoGenkinToYokin.Name = "rdoGenkinToYokin";
            this.rdoGenkinToYokin.Size = new System.Drawing.Size(100, 19);
            this.rdoGenkinToYokin.TabIndex = 5;
            this.rdoGenkinToYokin.TabStop = true;
            this.rdoGenkinToYokin.Text = "現金を預金した";
            this.rdoGenkinToYokin.UseVisualStyleBackColor = true;
            this.rdoGenkinToYokin.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoUrikakeKYokin
            // 
            this.rdoUrikakeKYokin.AutoSize = true;
            this.rdoUrikakeKYokin.Location = new System.Drawing.Point(7, 44);
            this.rdoUrikakeKYokin.Name = "rdoUrikakeKYokin";
            this.rdoUrikakeKYokin.Size = new System.Drawing.Size(133, 19);
            this.rdoUrikakeKYokin.TabIndex = 2;
            this.rdoUrikakeKYokin.TabStop = true;
            this.rdoUrikakeKYokin.Text = "売掛金回収（預金）";
            this.rdoUrikakeKYokin.UseVisualStyleBackColor = true;
            this.rdoUrikakeKYokin.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoUrikakeKGenkin
            // 
            this.rdoUrikakeKGenkin.AutoSize = true;
            this.rdoUrikakeKGenkin.Location = new System.Drawing.Point(146, 44);
            this.rdoUrikakeKGenkin.Name = "rdoUrikakeKGenkin";
            this.rdoUrikakeKGenkin.Size = new System.Drawing.Size(133, 19);
            this.rdoUrikakeKGenkin.TabIndex = 3;
            this.rdoUrikakeKGenkin.TabStop = true;
            this.rdoUrikakeKGenkin.Text = "売掛金回収（現金）";
            this.rdoUrikakeKGenkin.UseVisualStyleBackColor = true;
            this.rdoUrikakeKGenkin.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoYokinToGenkin
            // 
            this.rdoYokinToGenkin.AutoSize = true;
            this.rdoYokinToGenkin.Location = new System.Drawing.Point(7, 69);
            this.rdoYokinToGenkin.Name = "rdoYokinToGenkin";
            this.rdoYokinToGenkin.Size = new System.Drawing.Size(124, 19);
            this.rdoYokinToGenkin.TabIndex = 4;
            this.rdoYokinToGenkin.TabStop = true;
            this.rdoYokinToGenkin.Text = "預金から現金を引出";
            this.rdoYokinToGenkin.UseVisualStyleBackColor = true;
            this.rdoYokinToGenkin.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
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
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 75;
            // 
            // colWeek
            // 
            this.colWeek.DataPropertyName = "Week";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.colWeek.DefaultCellStyle = dataGridViewCellStyle2;
            this.colWeek.HeaderText = "曜";
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
            this.colKrKmkNm.HeaderText = "科目名_借方";
            this.colKrKmkNm.Name = "colKrKmkNm";
            this.colKrKmkNm.ReadOnly = true;
            // 
            // colKrHKmkNm
            // 
            this.colKrHKmkNm.DataPropertyName = "KrHKmkName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.colKrHKmkNm.DefaultCellStyle = dataGridViewCellStyle4;
            this.colKrHKmkNm.HeaderText = "補助科目名_借方";
            this.colKrHKmkNm.Name = "colKrHKmkNm";
            this.colKrHKmkNm.ReadOnly = true;
            this.colKrHKmkNm.Width = 125;
            // 
            // colKsKmkNm
            // 
            this.colKsKmkNm.DataPropertyName = "KsKmkName";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.colKsKmkNm.DefaultCellStyle = dataGridViewCellStyle5;
            this.colKsKmkNm.HeaderText = "科目名_貸方";
            this.colKsKmkNm.Name = "colKsKmkNm";
            this.colKsKmkNm.ReadOnly = true;
            // 
            // colKsHKmkName
            // 
            this.colKsHKmkName.DataPropertyName = "KsHKmkName";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.colKsHKmkName.DefaultCellStyle = dataGridViewCellStyle6;
            this.colKsHKmkName.HeaderText = "補助科目名_貸方";
            this.colKsHKmkName.Name = "colKsHKmkName";
            this.colKsHKmkName.ReadOnly = true;
            this.colKsHKmkName.Width = 125;
            // 
            // colKingaku
            // 
            this.colKingaku.DataPropertyName = "Kingaku";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.colKingaku.DefaultCellStyle = dataGridViewCellStyle7;
            this.colKingaku.HeaderText = "金額";
            this.colKingaku.Name = "colKingaku";
            this.colKingaku.ReadOnly = true;
            // 
            // colTekiyo
            // 
            this.colTekiyo.DataPropertyName = "Tekiyo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.colTekiyo.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTekiyo.HeaderText = "摘要";
            this.colTekiyo.Name = "colTekiyo";
            this.colTekiyo.ReadOnly = true;
            this.colTekiyo.Width = 150;
            // 
            // colNo
            // 
            this.colNo.DataPropertyName = "No";
            this.colNo.HeaderText = "連番";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Visible = false;
            // 
            // colUpd
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.colUpd.DefaultCellStyle = dataGridViewCellStyle9;
            this.colUpd.HeaderText = "修正";
            this.colUpd.Name = "colUpd";
            this.colUpd.ReadOnly = true;
            this.colUpd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUpd.Width = 50;
            // 
            // colDel
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            this.colDel.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDel.HeaderText = "削除";
            this.colDel.Name = "colDel";
            this.colDel.ReadOnly = true;
            this.colDel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDel.Width = 50;
            // 
            // InputUriage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 602);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputUriage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "売上入力";
            this.Load += new System.EventHandler(this.InputUriage_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoUrikakeKGenkin;
        private System.Windows.Forms.RadioButton rdoUrikakeKYokin;
        private System.Windows.Forms.RadioButton rdoGenkinUriage;
        private System.Windows.Forms.RadioButton rdoUrikake;
        private System.Windows.Forms.RadioButton rdoGenkinToYokin;
        private System.Windows.Forms.RadioButton rdoYokinToGenkin;
        private System.Windows.Forms.RadioButton rdoGenkinToKojin;
        private System.Windows.Forms.RadioButton rdoYokinToKojin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKrKmkNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKrHKmkNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKsKmkNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKsHKmkName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKingaku;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTekiyo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewButtonColumn colUpd;
        private System.Windows.Forms.DataGridViewButtonColumn colDel;
    }
}

