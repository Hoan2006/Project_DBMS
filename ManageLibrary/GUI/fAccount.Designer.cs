﻿namespace GUI
{
    partial class fAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbSoDienThoai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbVaiTro = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbMaTaiKhoan = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.TaiKhoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.inpAccPhone = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.numAccID = new System.Windows.Forms.NumericUpDown();
            this.dtpAccNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.inpAccName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inpAccPass = new System.Windows.Forms.TextBox();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFindAcc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.cbAccRole = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.inpAccEmail = new System.Windows.Forms.TextBox();
            this.inpAccAddress = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccID)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 579);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin tài khoản";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnChangePassword);
            this.panel2.Controls.Add(this.btnUpdateProfile);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 526);
            this.panel2.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChangePassword.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Location = new System.Drawing.Point(741, 423);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(202, 101);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUpdateProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Location = new System.Drawing.Point(0, 423);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(195, 101);
            this.btnUpdateProfile.TabIndex = 7;
            this.btnUpdateProfile.Text = "Cập nhật";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.lbSoDienThoai);
            this.panel12.Controls.Add(this.label4);
            this.panel12.Controls.Add(this.lbVaiTro);
            this.panel12.Controls.Add(this.lbEmail);
            this.panel12.Controls.Add(this.label1);
            this.panel12.Controls.Add(this.label15);
            this.panel12.Controls.Add(this.label14);
            this.panel12.Controls.Add(this.lbGioiTinh);
            this.panel12.Controls.Add(this.lbNgaySinh);
            this.panel12.Controls.Add(this.lbDiaChi);
            this.panel12.Controls.Add(this.lbMaTaiKhoan);
            this.panel12.Controls.Add(this.lbHoTen);
            this.panel12.Controls.Add(this.label13);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.label2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(943, 423);
            this.panel12.TabIndex = 6;
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.AutoSize = true;
            this.lbSoDienThoai.Location = new System.Drawing.Point(671, 93);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(72, 29);
            this.lbSoDienThoai.TabIndex = 18;
            this.lbSoDienThoai.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số điện thoại:";
            // 
            // lbVaiTro
            // 
            this.lbVaiTro.AutoSize = true;
            this.lbVaiTro.Location = new System.Drawing.Point(126, 20);
            this.lbVaiTro.Name = "lbVaiTro";
            this.lbVaiTro.Size = new System.Drawing.Size(72, 29);
            this.lbVaiTro.TabIndex = 16;
            this.lbVaiTro.Text = "None";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(109, 178);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(72, 29);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vai Trò:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 178);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 29);
            this.label15.TabIndex = 13;
            this.label15.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(505, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 29);
            this.label14.TabIndex = 12;
            this.label14.Text = "Giới tính:";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(618, 357);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(72, 29);
            this.lbGioiTinh.TabIndex = 11;
            this.lbGioiTinh.Text = "None";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(636, 265);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(72, 29);
            this.lbNgaySinh.TabIndex = 9;
            this.lbNgaySinh.Text = "None";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(603, 178);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(72, 29);
            this.lbDiaChi.TabIndex = 8;
            this.lbDiaChi.Text = "None";
            // 
            // lbMaTaiKhoan
            // 
            this.lbMaTaiKhoan.AutoSize = true;
            this.lbMaTaiKhoan.Location = new System.Drawing.Point(183, 93);
            this.lbMaTaiKhoan.Name = "lbMaTaiKhoan";
            this.lbMaTaiKhoan.Size = new System.Drawing.Size(72, 29);
            this.lbMaTaiKhoan.TabIndex = 7;
            this.lbMaTaiKhoan.Text = "None";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(600, 20);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(72, 29);
            this.lbHoTen.TabIndex = 6;
            this.lbHoTen.Text = "None";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "Mã tài khoản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý nhóm tài khoản";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvAccount);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(953, 541);
            this.panel5.TabIndex = 3;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AllowUserToResizeColumns = false;
            this.dgvAccount.AllowUserToResizeRows = false;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaiKhoanID,
            this.HoTen,
            this.Email,
            this.MatKhau,
            this.SDT,
            this.VaiTro,
            this.NgaySinh,
            this.DiaChi,
            this.GioiTinh});
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAccount.Location = new System.Drawing.Point(0, 144);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersVisible = false;
            this.dgvAccount.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvAccount.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(953, 397);
            this.dgvAccount.TabIndex = 3;
            this.dgvAccount.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_CellMouseClick);
            // 
            // TaiKhoanID
            // 
            this.TaiKhoanID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TaiKhoanID.DataPropertyName = "MaTaiKhoan";
            this.TaiKhoanID.HeaderText = "ID";
            this.TaiKhoanID.MinimumWidth = 6;
            this.TaiKhoanID.Name = "TaiKhoanID";
            this.TaiKhoanID.ReadOnly = true;
            this.TaiKhoanID.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 79;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 71;
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Width = 97;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SDT.DataPropertyName = "SoDienThoai";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 65;
            // 
            // VaiTro
            // 
            this.VaiTro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VaiTro.DataPropertyName = "VaiTro";
            this.VaiTro.HeaderText = "Vai trò";
            this.VaiTro.MinimumWidth = 6;
            this.VaiTro.Name = "VaiTro";
            this.VaiTro.ReadOnly = true;
            this.VaiTro.Width = 78;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 80;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 89;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rbtnNu);
            this.panel8.Controls.Add(this.rbtnNam);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.inpAccPhone);
            this.panel8.Controls.Add(this.btnReset);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.numAccID);
            this.panel8.Controls.Add(this.dtpAccNgaySinh);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.inpAccName);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.inpAccPass);
            this.panel8.Controls.Add(this.btnDeleteAcc);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.btnFindAcc);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.btnUpdateAcc);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.btnAddAcc);
            this.panel8.Controls.Add(this.cbAccRole);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.inpAccEmail);
            this.panel8.Controls.Add(this.inpAccAddress);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(953, 541);
            this.panel8.TabIndex = 2;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Font = new System.Drawing.Font("Arial", 9F);
            this.rbtnNu.Location = new System.Drawing.Point(819, 4);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(49, 21);
            this.rbtnNu.TabIndex = 22;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Font = new System.Drawing.Font("Arial", 9F);
            this.rbtnNam.Location = new System.Drawing.Point(706, 4);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(60, 21);
            this.rbtnNam.TabIndex = 21;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F);
            this.label16.Location = new System.Drawing.Point(598, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "Số điện thoại";
            // 
            // inpAccPhone
            // 
            this.inpAccPhone.Location = new System.Drawing.Point(706, 31);
            this.inpAccPhone.Name = "inpAccPhone";
            this.inpAccPhone.Size = new System.Drawing.Size(162, 25);
            this.inpAccPhone.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnReset.Location = new System.Drawing.Point(819, 98);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 38);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F);
            this.label17.Location = new System.Drawing.Point(598, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Giới tính";
            // 
            // numAccID
            // 
            this.numAccID.Location = new System.Drawing.Point(114, 63);
            this.numAccID.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numAccID.Name = "numAccID";
            this.numAccID.Size = new System.Drawing.Size(120, 25);
            this.numAccID.TabIndex = 13;
            // 
            // dtpAccNgaySinh
            // 
            this.dtpAccNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpAccNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAccNgaySinh.Location = new System.Drawing.Point(114, 98);
            this.dtpAccNgaySinh.Name = "dtpAccNgaySinh";
            this.dtpAccNgaySinh.Size = new System.Drawing.Size(200, 25);
            this.dtpAccNgaySinh.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày sinh";
            // 
            // inpAccName
            // 
            this.inpAccName.Location = new System.Drawing.Point(114, 3);
            this.inpAccName.Name = "inpAccName";
            this.inpAccName.Size = new System.Drawing.Size(200, 25);
            this.inpAccName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(322, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mật khẩu";
            // 
            // inpAccPass
            // 
            this.inpAccPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAccPass.Location = new System.Drawing.Point(402, 2);
            this.inpAccPass.Name = "inpAccPass";
            this.inpAccPass.Size = new System.Drawing.Size(174, 23);
            this.inpAccPass.TabIndex = 1;
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnDeleteAcc.Location = new System.Drawing.Point(742, 98);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(75, 38);
            this.btnDeleteAcc.TabIndex = 8;
            this.btnDeleteAcc.Text = "Xóa";
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(5, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên tài khoản";
            // 
            // btnFindAcc
            // 
            this.btnFindAcc.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnFindAcc.Location = new System.Drawing.Point(661, 98);
            this.btnFindAcc.Name = "btnFindAcc";
            this.btnFindAcc.Size = new System.Drawing.Size(75, 38);
            this.btnFindAcc.TabIndex = 10;
            this.btnFindAcc.Text = "Tìm";
            this.btnFindAcc.UseVisualStyleBackColor = true;
            this.btnFindAcc.Click += new System.EventHandler(this.btnFindAcc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F);
            this.label11.Location = new System.Drawing.Point(327, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Vai trò";
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnUpdateAcc.Location = new System.Drawing.Point(517, 98);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(138, 38);
            this.btnUpdateAcc.TabIndex = 9;
            this.btnUpdateAcc.Text = "Cập nhật";
            this.btnUpdateAcc.UseVisualStyleBackColor = true;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F);
            this.label12.Location = new System.Drawing.Point(8, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mã tài khoản";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F);
            this.label10.Location = new System.Drawing.Point(8, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email";
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.Font = new System.Drawing.Font("Arial", 10.2F);
            this.btnAddAcc.Location = new System.Drawing.Point(322, 98);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(189, 38);
            this.btnAddAcc.TabIndex = 7;
            this.btnAddAcc.Text = "Thêm";
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // cbAccRole
            // 
            this.cbAccRole.FormattingEnabled = true;
            this.cbAccRole.Items.AddRange(new object[] {
            "Sinh viên CLC",
            "Sinh viên đại trà",
            "Học viên cao học",
            "Giảng viên",
            "Thủ thư",
            "Quản trị viên"});
            this.cbAccRole.Location = new System.Drawing.Point(402, 29);
            this.cbAccRole.Name = "cbAccRole";
            this.cbAccRole.Size = new System.Drawing.Size(174, 27);
            this.cbAccRole.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.Location = new System.Drawing.Point(322, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Địa chỉ";
            // 
            // inpAccEmail
            // 
            this.inpAccEmail.Location = new System.Drawing.Point(114, 32);
            this.inpAccEmail.Name = "inpAccEmail";
            this.inpAccEmail.Size = new System.Drawing.Size(200, 25);
            this.inpAccEmail.TabIndex = 1;
            // 
            // inpAccAddress
            // 
            this.inpAccAddress.Location = new System.Drawing.Point(402, 62);
            this.inpAccAddress.Name = "inpAccAddress";
            this.inpAccAddress.Size = new System.Drawing.Size(466, 25);
            this.inpAccAddress.TabIndex = 1;
            // 
            // fAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 579);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAccount";
            this.Text = "fAccount";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAccID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lbSoDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbVaiTro;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbMaTaiKhoan;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox inpAccPhone;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numAccID;
        private System.Windows.Forms.DateTimePicker dtpAccNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inpAccName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inpAccPass;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFindAcc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.ComboBox cbAccRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox inpAccEmail;
        private System.Windows.Forms.TextBox inpAccAddress;
    }
}