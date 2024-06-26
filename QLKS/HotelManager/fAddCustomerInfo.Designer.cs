﻿namespace HotelManager
{
    partial class fAddCustomerInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddCustomerInfo));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbNationality = new MetroFramework.Controls.MetroComboBox();
            this.dpkDateOfBirth = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCustomerType = new MetroFramework.Controls.MetroComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.DatepickerDateOfReceive = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txbAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSex = new MetroFramework.Controls.MetroComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbPhoneNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbIDCard = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.txbFullName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose_ = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddCustomer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txbIDCardSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbNationality);
            this.groupBox2.Controls.Add(this.dpkDateOfBirth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbCustomerType);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.DatepickerDateOfReceive);
            this.groupBox2.Controls.Add(this.txbAddress);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbSex);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txbPhoneNumber);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txbIDCard);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txbFullName);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(32, 222);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(680, 398);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // cbNationality
            // 
            this.cbNationality.BackColor = System.Drawing.Color.White;
            this.cbNationality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.ItemHeight = 23;
            this.cbNationality.Items.AddRange(new object[] {
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
            this.cbNationality.Location = new System.Drawing.Point(360, 319);
            this.cbNationality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(302, 29);
            this.cbNationality.Style = MetroFramework.MetroColorStyle.Green;
            this.cbNationality.TabIndex = 53;
            this.cbNationality.UseCustomBackColor = true;
            this.cbNationality.UseCustomForeColor = true;
            this.cbNationality.UseSelectable = true;
            this.cbNationality.UseStyleColors = true;
            // 
            // dpkDateOfBirth
            // 
            this.dpkDateOfBirth.BackColor = System.Drawing.Color.MintCream;
            this.dpkDateOfBirth.BorderRadius = 0;
            this.dpkDateOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dpkDateOfBirth.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.dpkDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDateOfBirth.FormatCustom = null;
            this.dpkDateOfBirth.Location = new System.Drawing.Point(360, 71);
            this.dpkDateOfBirth.Margin = new System.Windows.Forms.Padding(21, 32, 21, 32);
            this.dpkDateOfBirth.Name = "dpkDateOfBirth";
            this.dpkDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dpkDateOfBirth.Size = new System.Drawing.Size(305, 44);
            this.dpkDateOfBirth.TabIndex = 47;
            this.dpkDateOfBirth.Value = new System.DateTime(1998, 4, 6, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(357, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 31);
            this.label6.TabIndex = 46;
            this.label6.Text = "Ngày sinh:";
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.BackColor = System.Drawing.Color.White;
            this.cbCustomerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.ItemHeight = 23;
            this.cbCustomerType.Location = new System.Drawing.Point(15, 239);
            this.cbCustomerType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(302, 29);
            this.cbCustomerType.TabIndex = 42;
            this.cbCustomerType.UseCustomBackColor = true;
            this.cbCustomerType.UseCustomForeColor = true;
            this.cbCustomerType.UseSelectable = true;
            this.cbCustomerType.UseStyleColors = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label20.Location = new System.Drawing.Point(12, 201);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(185, 31);
            this.label20.TabIndex = 41;
            this.label20.Text = "Loại khách hàng:";
            // 
            // DatepickerDateOfReceive
            // 
            this.DatepickerDateOfReceive.BackColor = System.Drawing.Color.SeaGreen;
            this.DatepickerDateOfReceive.BorderRadius = 0;
            this.DatepickerDateOfReceive.ForeColor = System.Drawing.Color.White;
            this.DatepickerDateOfReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatepickerDateOfReceive.FormatCustom = "";
            this.DatepickerDateOfReceive.Location = new System.Drawing.Point(63, 1179);
            this.DatepickerDateOfReceive.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.DatepickerDateOfReceive.Name = "DatepickerDateOfReceive";
            this.DatepickerDateOfReceive.Size = new System.Drawing.Size(456, 72);
            this.DatepickerDateOfReceive.TabIndex = 30;
            this.DatepickerDateOfReceive.Value = new System.DateTime(2018, 2, 23, 23, 29, 57, 962);
            // 
            // txbAddress
            // 
            this.txbAddress.BorderColorFocused = System.Drawing.Color.Gray;
            this.txbAddress.BorderColorIdle = System.Drawing.Color.Gray;
            this.txbAddress.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
            this.txbAddress.BorderThickness = 1;
            this.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbAddress.isPassword = false;
            this.txbAddress.Location = new System.Drawing.Point(360, 155);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(305, 45);
            this.txbAddress.TabIndex = 25;
            this.txbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label11.Location = new System.Drawing.Point(357, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 31);
            this.label11.TabIndex = 35;
            this.label11.Text = "Địa chỉ:";
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.White;
            this.cbSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.ItemHeight = 23;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbSex.Location = new System.Drawing.Point(360, 234);
            this.cbSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(302, 29);
            this.cbSex.Style = MetroFramework.MetroColorStyle.Green;
            this.cbSex.TabIndex = 26;
            this.cbSex.UseCustomBackColor = true;
            this.cbSex.UseCustomForeColor = true;
            this.cbSex.UseSelectable = true;
            this.cbSex.UseStyleColors = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label12.Location = new System.Drawing.Point(357, 280);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 31);
            this.label12.TabIndex = 29;
            this.label12.Text = "Quốc tịch:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label13.Location = new System.Drawing.Point(357, 201);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 31);
            this.label13.TabIndex = 28;
            this.label13.Text = "Giới tính:";
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.BorderColorFocused = System.Drawing.Color.Gray;
            this.txbPhoneNumber.BorderColorIdle = System.Drawing.Color.Gray;
            this.txbPhoneNumber.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
            this.txbPhoneNumber.BorderThickness = 1;
            this.txbPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbPhoneNumber.isPassword = false;
            this.txbPhoneNumber.Location = new System.Drawing.Point(15, 319);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(305, 45);
            this.txbPhoneNumber.TabIndex = 24;
            this.txbPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPhoneNumber_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label14.Location = new System.Drawing.Point(12, 288);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 31);
            this.label14.TabIndex = 26;
            this.label14.Text = "Số điện thoại:";
            // 
            // txbIDCard
            // 
            this.txbIDCard.BorderColorFocused = System.Drawing.Color.Gray;
            this.txbIDCard.BorderColorIdle = System.Drawing.Color.Gray;
            this.txbIDCard.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
            this.txbIDCard.BorderThickness = 1;
            this.txbIDCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDCard.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbIDCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIDCard.isPassword = false;
            this.txbIDCard.Location = new System.Drawing.Point(15, 152);
            this.txbIDCard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbIDCard.Name = "txbIDCard";
            this.txbIDCard.Size = new System.Drawing.Size(305, 45);
            this.txbIDCard.TabIndex = 22;
            this.txbIDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIDCard_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label15.Location = new System.Drawing.Point(12, 119);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(237, 31);
            this.label15.TabIndex = 24;
            this.label15.Text = "Thẻ căn cước/ CMND:";
            // 
            // txbFullName
            // 
            this.txbFullName.BorderColorFocused = System.Drawing.Color.Gray;
            this.txbFullName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txbFullName.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
            this.txbFullName.BorderThickness = 1;
            this.txbFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFullName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFullName.isPassword = false;
            this.txbFullName.Location = new System.Drawing.Point(15, 71);
            this.txbFullName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(305, 45);
            this.txbFullName.TabIndex = 21;
            this.txbFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label16.Location = new System.Drawing.Point(12, 38);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 31);
            this.label16.TabIndex = 22;
            this.label16.Text = "Họ và tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose_);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.bunifuThinButton21);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(32, 640);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(680, 191);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
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
            this.btnClose_.Location = new System.Drawing.Point(15, 106);
            this.btnClose_.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(305, 61);
            this.btnClose_.TabIndex = 51;
            this.btnClose_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose_.Click += new System.EventHandler(this.btnClose__Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ActiveBorderThickness = 1;
            this.btnAddCustomer.ActiveCornerRadius = 20;
            this.btnAddCustomer.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCustomer.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCustomer.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
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
            this.btnAddCustomer.Size = new System.Drawing.Size(305, 61);
            this.btnAddCustomer.TabIndex = 48;
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Hủy";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleBorderThickness = 2;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.Location = new System.Drawing.Point(360, 38);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(305, 61);
            this.bunifuThinButton21.TabIndex = 50;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.Turquoise;
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Tìm Kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.IdleBorderThickness = 2;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.White;
            this.btnSearch.IdleForecolor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.IdleLineColor = System.Drawing.Color.Gray;
            this.btnSearch.Location = new System.Drawing.Point(488, 142);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 45);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbIDCardSearch
            // 
            this.txbIDCardSearch.BorderColorFocused = System.Drawing.Color.Gray;
            this.txbIDCardSearch.BorderColorIdle = System.Drawing.Color.Gray;
            this.txbIDCardSearch.BorderColorMouseHover = System.Drawing.Color.LightSeaGreen;
            this.txbIDCardSearch.BorderThickness = 1;
            this.txbIDCardSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDCardSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbIDCardSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbIDCardSearch.isPassword = false;
            this.txbIDCardSearch.Location = new System.Drawing.Point(66, 142);
            this.txbIDCardSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbIDCardSearch.Name = "txbIDCardSearch";
            this.txbIDCardSearch.Size = new System.Drawing.Size(382, 45);
            this.txbIDCardSearch.TabIndex = 27;
            this.txbIDCardSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbIDCardSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIDCardSearch_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(60, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 31);
            this.label9.TabIndex = 28;
            this.label9.Text = "Thẻ căn cước/ CMND:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(717, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 31;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fAddCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 845);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txbIDCardSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAddCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAddCustomerInfo";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDateOfBirth;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox cbCustomerType;
        private System.Windows.Forms.Label label20;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerDateOfReceive;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbAddress;
        private System.Windows.Forms.Label label11;
        private MetroFramework.Controls.MetroComboBox cbSex;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbPhoneNumber;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbIDCard;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbFullName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private Bunifu.Framework.UI.BunifuMetroTextbox txbIDCardSearch;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroComboBox cbNationality;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose_;
    }
}