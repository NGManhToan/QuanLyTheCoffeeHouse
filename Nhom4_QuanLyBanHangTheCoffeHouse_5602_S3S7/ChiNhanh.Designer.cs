namespace Quanlyquancoffe
{
    partial class ChiNhanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvChiNhanh = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTenCN = new System.Windows.Forms.RadioButton();
            this.rdCN = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKe = new ePOSOne.btnProduct.Button_WOC();
            this.txtHienhanh = new round();
            this.btnThoat = new ePOSOne.btnProduct.Button_WOC();
            this.btnCuoi = new ePOSOne.btnProduct.Button_WOC();
            this.txtTongSo = new round();
            this.btnTruoc = new ePOSOne.btnProduct.Button_WOC();
            this.btnDau = new ePOSOne.btnProduct.Button_WOC();
            this.btnTimKiem = new ePOSOne.btnProduct.Button_WOC();
            this.txttimkiem = new round();
            this.btnLamMoi = new ePOSOne.btnProduct.Button_WOC();
            this.btnSua = new ePOSOne.btnProduct.Button_WOC();
            this.btnXoa = new ePOSOne.btnProduct.Button_WOC();
            this.btnThem = new ePOSOne.btnProduct.Button_WOC();
            this.txtDiaChi = new round();
            this.txtTenCN = new round();
            this.txtMaCN = new round();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã chi nhánh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Địa chỉ ";
            // 
            // dgvChiNhanh
            // 
            this.dgvChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiNhanh.Location = new System.Drawing.Point(1, 346);
            this.dgvChiNhanh.Name = "dgvChiNhanh";
            this.dgvChiNhanh.Size = new System.Drawing.Size(1060, 142);
            this.dgvChiNhanh.TabIndex = 34;
            this.dgvChiNhanh.SelectionChanged += new System.EventHandler(this.dgvChiNhanh_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Tên chi nhánh";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.txtTenCN);
            this.groupBox3.Controls.Add(this.txtMaCN);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(10, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(655, 280);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi nhánh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.rdTenCN);
            this.groupBox1.Controls.Add(this.rdCN);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(674, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 212);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // rdTenCN
            // 
            this.rdTenCN.AutoSize = true;
            this.rdTenCN.Location = new System.Drawing.Point(214, 31);
            this.rdTenCN.Name = "rdTenCN";
            this.rdTenCN.Size = new System.Drawing.Size(155, 24);
            this.rdTenCN.TabIndex = 16;
            this.rdTenCN.TabStop = true;
            this.rdTenCN.Text = "Tên chi nhánh";
            this.rdTenCN.UseVisualStyleBackColor = true;
            this.rdTenCN.CheckedChanged += new System.EventHandler(this.rdTenCN_CheckedChanged);
            // 
            // rdCN
            // 
            this.rdCN.AutoSize = true;
            this.rdCN.Location = new System.Drawing.Point(12, 31);
            this.rdCN.Name = "rdCN";
            this.rdCN.Size = new System.Drawing.Size(147, 24);
            this.rdCN.TabIndex = 15;
            this.rdCN.TabStop = true;
            this.rdCN.Text = "Mã chi nhánh";
            this.rdCN.UseVisualStyleBackColor = true;
            this.rdCN.CheckedChanged += new System.EventHandler(this.rdCN_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(38, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 74);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(878, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 17);
            this.label13.TabIndex = 58;
            this.label13.Text = "Tổng trang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(671, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "Mẫu hiện hành";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.label3.Font = new System.Drawing.Font("Baron Neue Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(5, -16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 58);
            this.label3.TabIndex = 64;
            this.label3.Text = "THE COFFE HOUSE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("iCiel Brush Up", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(407, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 48);
            this.label6.TabIndex = 65;
            this.label6.Text = "Danh sách chi nhánh";
            // 
            // btnKe
            // 
            this.btnKe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnKe.ButtonColor = System.Drawing.Color.OrangeRed;
            this.btnKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnKe.Location = new System.Drawing.Point(886, 278);
            this.btnKe.Name = "btnKe";
            this.btnKe.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnKe.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKe.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnKe.Size = new System.Drawing.Size(64, 32);
            this.btnKe.TabIndex = 12;
            this.btnKe.Text = ">";
            this.btnKe.TextColor = System.Drawing.Color.White;
            this.btnKe.UseVisualStyleBackColor = true;
            this.btnKe.Click += new System.EventHandler(this.btnKe_Click);
            // 
            // txtHienhanh
            // 
            this.txtHienhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienhanh.Location = new System.Drawing.Point(782, 317);
            this.txtHienhanh.Multiline = true;
            this.txtHienhanh.Name = "txtHienhanh";
            this.txtHienhanh.Size = new System.Drawing.Size(90, 22);
            this.txtHienhanh.TabIndex = 62;
            this.txtHienhanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BackgroundImage = global::Quanlyquancoffe.Properties.Resources._3;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoat.ButtonColor = System.Drawing.Color.Transparent;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnThoat.Location = new System.Drawing.Point(1000, -2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnThoat.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnThoat.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnThoat.Size = new System.Drawing.Size(78, 51);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCuoi
            // 
            this.btnCuoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnCuoi.ButtonColor = System.Drawing.Color.OrangeRed;
            this.btnCuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnCuoi.Location = new System.Drawing.Point(965, 278);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnCuoi.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCuoi.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnCuoi.Size = new System.Drawing.Size(64, 32);
            this.btnCuoi.TabIndex = 13;
            this.btnCuoi.Text = ">|";
            this.btnCuoi.TextColor = System.Drawing.Color.White;
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // txtTongSo
            // 
            this.txtTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSo.Location = new System.Drawing.Point(965, 316);
            this.txtTongSo.Multiline = true;
            this.txtTongSo.Name = "txtTongSo";
            this.txtTongSo.Size = new System.Drawing.Size(90, 22);
            this.txtTongSo.TabIndex = 63;
            this.txtTongSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTruoc
            // 
            this.btnTruoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnTruoc.ButtonColor = System.Drawing.Color.OrangeRed;
            this.btnTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTruoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnTruoc.Location = new System.Drawing.Point(806, 278);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnTruoc.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTruoc.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnTruoc.Size = new System.Drawing.Size(64, 32);
            this.btnTruoc.TabIndex = 11;
            this.btnTruoc.Tag = "64, 32";
            this.btnTruoc.Text = "<";
            this.btnTruoc.TextColor = System.Drawing.Color.White;
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDau.ButtonColor = System.Drawing.Color.OrangeRed;
            this.btnDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnDau.Location = new System.Drawing.Point(725, 278);
            this.btnDau.Name = "btnDau";
            this.btnDau.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDau.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDau.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDau.Size = new System.Drawing.Size(64, 32);
            this.btnDau.TabIndex = 10;
            this.btnDau.Text = "|<";
            this.btnDau.TextColor = System.Drawing.Color.White;
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::Quanlyquancoffe.Properties.Resources.tim;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.BorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.ButtonColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnTimKiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnTimKiem.Location = new System.Drawing.Point(214, 160);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Size = new System.Drawing.Size(127, 46);
            this.btnTimKiem.TabIndex = 33;
            this.btnTimKiem.Text = "                  Tìm";
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(31, 29);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(265, 29);
            this.txttimkiem.TabIndex = 7;
            this.txttimkiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnLamMoi.BackgroundImage = global::Quanlyquancoffe.Properties.Resources._5;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.BorderColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.ButtonColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnLamMoi.Location = new System.Drawing.Point(464, 222);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Size = new System.Drawing.Size(163, 51);
            this.btnLamMoi.TabIndex = 34;
            this.btnLamMoi.Text = "                        Reset";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.TextColor = System.Drawing.Color.White;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImage = global::Quanlyquancoffe.Properties.Resources._261228360_206749288307243_3421972228413392021_n;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.BorderColor = System.Drawing.Color.Transparent;
            this.btnSua.ButtonColor = System.Drawing.Color.Transparent;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnSua.Location = new System.Drawing.Point(334, 222);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSua.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnSua.Size = new System.Drawing.Size(124, 51);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "                   Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundImage = global::Quanlyquancoffe.Properties.Resources._2;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.BorderColor = System.Drawing.Color.Transparent;
            this.btnXoa.ButtonColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoa.Location = new System.Drawing.Point(171, 223);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnXoa.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXoa.Size = new System.Drawing.Size(140, 51);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "                    Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImage = global::Quanlyquancoffe.Properties.Resources._261215269_332485138314071_7727042643032708630_n;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.BorderColor = System.Drawing.Color.Transparent;
            this.btnThem.ButtonColor = System.Drawing.Color.Transparent;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.btnThem.Location = new System.Drawing.Point(5, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnThem.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnThem.Size = new System.Drawing.Size(160, 51);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "                      Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(102, 140);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(516, 26);
            this.txtDiaChi.TabIndex = 2;
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCN.Location = new System.Drawing.Point(448, 58);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(170, 26);
            this.txtTenCN.TabIndex = 1;
            this.txtTenCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaCN
            // 
            this.txtMaCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCN.Location = new System.Drawing.Point(131, 58);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(170, 26);
            this.txtMaCN.TabIndex = 0;
            this.txtMaCN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 15;
            this.elipseControl1.TargetControl = this;
            // 
            // ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1061, 486);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKe);
            this.Controls.Add(this.txtHienhanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCuoi);
            this.Controls.Add(this.txtTongSo);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnDau);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvChiNhanh);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiNhanh";
            this.Load += new System.EventHandler(this.ChiNhanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvChiNhanh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ePOSOne.btnProduct.Button_WOC btnThoat;
        private round txtMaCN;
        private round txtTenCN;
        private round txtDiaChi;
        private ePOSOne.btnProduct.Button_WOC btnKe;
        private round txtHienhanh;
        private ePOSOne.btnProduct.Button_WOC btnCuoi;
        private round txtTongSo;
        private ePOSOne.btnProduct.Button_WOC btnTruoc;
        private ePOSOne.btnProduct.Button_WOC btnDau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTenCN;
        private System.Windows.Forms.RadioButton rdCN;
        private System.Windows.Forms.GroupBox groupBox2;
        private round txttimkiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private ePOSOne.btnProduct.Button_WOC btnLamMoi;
        private ePOSOne.btnProduct.Button_WOC btnSua;
        private ePOSOne.btnProduct.Button_WOC btnXoa;
        private ePOSOne.btnProduct.Button_WOC btnThem;
        private ePOSOne.btnProduct.Button_WOC btnTimKiem;
    }
}