namespace HotelManager
{
    partial class fAddCustomer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddCustomer));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox4 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 54);
            this.label2.TabIndex = 27;
            this.label2.Text = "Thêm Khách Hàng";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 72);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(680, 15);
            this.bunifuSeparator1.TabIndex = 30;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(731, 6);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 52;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose__Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroComboBox1);
            this.groupBox3.Controls.Add(this.bunifuDatepicker1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.metroComboBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.bunifuDatepicker2);
            this.groupBox3.Controls.Add(this.bunifuMetroTextbox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.metroComboBox3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.bunifuMetroTextbox2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.bunifuMetroTextbox3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.bunifuMetroTextbox4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.Gray;
            this.groupBox3.Location = new System.Drawing.Point(33, 112);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(680, 398);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label10.Location = new System.Drawing.Point(12, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 31);
            this.label10.TabIndex = 22;
            this.label10.Text = "Họ và tên:";
            // 
            // bunifuMetroTextbox4
            // 
            this.bunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
            this.bunifuMetroTextbox4.BorderThickness = 1;
            this.bunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox4.isPassword = false;
            this.bunifuMetroTextbox4.Location = new System.Drawing.Point(15, 71);
            this.bunifuMetroTextbox4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMetroTextbox4.Name = "bunifuMetroTextbox4";
            this.bunifuMetroTextbox4.Size = new System.Drawing.Size(305, 45);
            this.bunifuMetroTextbox4.TabIndex = 0;
            this.bunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(12, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "Thẻ căn cước/ CMND:";
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
            this.bunifuMetroTextbox3.BorderThickness = 1;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(15, 152);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(305, 45);
            this.bunifuMetroTextbox3.TabIndex = 1;
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(12, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 31);
            this.label8.TabIndex = 26;
            this.label8.Text = "Số điện thoại:";
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
            this.bunifuMetroTextbox2.BorderThickness = 1;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(15, 319);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(305, 45);
            this.bunifuMetroTextbox2.TabIndex = 3;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPhoneNumber_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(357, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(357, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "Quốc tịch:";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.BackColor = System.Drawing.Color.White;
            this.metroComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.metroComboBox3.Location = new System.Drawing.Point(360, 234);
            this.metroComboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(302, 29);
            this.metroComboBox3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox3.TabIndex = 5;
            this.metroComboBox3.UseCustomBackColor = true;
            this.metroComboBox3.UseCustomForeColor = true;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.UseStyleColors = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(357, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Địa chỉ:";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(360, 155);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(305, 45);
            this.bunifuMetroTextbox1.TabIndex = 4;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker2.FormatCustom = "";
            this.bunifuDatepicker2.Location = new System.Drawing.Point(63, 1179);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(456, 72);
            this.bunifuDatepicker2.TabIndex = 30;
            this.bunifuDatepicker2.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(12, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "Loại khách hàng:";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.BackColor = System.Drawing.Color.White;
            this.metroComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox2.ForeColor = System.Drawing.Color.Gray;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(15, 239);
            this.metroComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(302, 29);
            this.metroComboBox2.TabIndex = 2;
            this.metroComboBox2.UseCustomBackColor = true;
            this.metroComboBox2.UseCustomForeColor = true;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(357, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ngày sinh:";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.MintCream;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(360, 71);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(21, 32, 21, 32);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuDatepicker1.Size = new System.Drawing.Size(305, 44);
            this.bunifuDatepicker1.TabIndex = 47;
            this.bunifuDatepicker1.Value = new System.DateTime(1998, 4, 6, 0, 0, 0, 0);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.BackColor = System.Drawing.Color.White;
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroComboBox1.ForeColor = System.Drawing.Color.Gray;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Việt Nam",
            "Trung Quốc",
            "Hàn Quốc",
            "Nhật Bản",
            "Đài Loan",
            "Malaysia",
            "Thái Lan",
            "Singapore",
            "Nga",
            "Anh",
            "Pháp",
            "Đức",
            "Hoa Kỳ",
            "Hà Lan",
            "Tây Ban Nha",
            "Ý",
            "Khác"});
            this.metroComboBox1.Location = new System.Drawing.Point(360, 319);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(302, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox1.TabIndex = 6;
            this.metroComboBox1.UseCustomBackColor = true;
            this.metroComboBox1.UseCustomForeColor = true;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.UseStyleColors = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose_);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(33, 518);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(680, 109);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ActiveBorderThickness = 1;
            this.btnAddCustomer.ActiveCornerRadius = 20;
            this.btnAddCustomer.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCustomer.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddCustomer.BackColor = System.Drawing.Color.White;
            this.btnAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.BackgroundImage")));
            this.btnAddCustomer.ButtonText = "Thêm Khách Hàng";
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCustomer.IdleBorderThickness = 2;
            this.btnAddCustomer.IdleCornerRadius = 20;
            this.btnAddCustomer.IdleFillColor = System.Drawing.Color.White;
            this.btnAddCustomer.IdleForecolor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCustomer.IdleLineColor = System.Drawing.Color.Gray;
            this.btnAddCustomer.Location = new System.Drawing.Point(18, 38);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(299, 61);
            this.btnAddCustomer.TabIndex = 48;
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnClose_
            // 
            this.btnClose_.ActiveBorderThickness = 1;
            this.btnClose_.ActiveCornerRadius = 20;
            this.btnClose_.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btnClose_.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose_.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btnClose_.BackColor = System.Drawing.Color.White;
            this.btnClose_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose_.BackgroundImage")));
            this.btnClose_.ButtonText = "Đóng";
            this.btnClose_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose_.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose_.ForeColor = System.Drawing.Color.Crimson;
            this.btnClose_.IdleBorderThickness = 2;
            this.btnClose_.IdleCornerRadius = 20;
            this.btnClose_.IdleFillColor = System.Drawing.Color.White;
            this.btnClose_.IdleForecolor = System.Drawing.Color.Crimson;
            this.btnClose_.IdleLineColor = System.Drawing.Color.Gray;
            this.btnClose_.Location = new System.Drawing.Point(360, 38);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(242, 61);
            this.btnClose_.TabIndex = 51;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose_.Click += new System.EventHandler(this.btnClose__Click);
            // 
            // fAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 665);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddCustomerInfo";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox4;
        private System.Windows.Forms.Label label10;
    }
}