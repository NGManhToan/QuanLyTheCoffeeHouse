namespace Quanlyquancoffe
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMTTTK = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMTTNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMPhuCap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNhapXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCTNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMCTXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtPhiếuXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMChinhanh = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMKhuyenMai = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBCHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBCKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMBCNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNPhuCap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMNTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMHethong,
            this.TSMTTNhanvien,
            this.TSMNhapXuat,
            this.tàiKhoảnToolStripMenuItem,
            this.TSMBaoCao,
            this.TSMNTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMHethong
            // 
            this.TSMHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMDangxuat,
            this.TSMTTTK});
            this.TSMHethong.Name = "TSMHethong";
            this.TSMHethong.Size = new System.Drawing.Size(69, 20);
            this.TSMHethong.Text = "Hệ thống";
            // 
            // TSMDangxuat
            // 
            this.TSMDangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMDangxuat.Name = "TSMDangxuat";
            this.TSMDangxuat.Size = new System.Drawing.Size(177, 22);
            this.TSMDangxuat.Text = "Đăng xuất";
            this.TSMDangxuat.Click += new System.EventHandler(this.TSMDangxuat_Click);
            // 
            // TSMTTTK
            // 
            this.TSMTTTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMTTTK.Name = "TSMTTTK";
            this.TSMTTTK.Size = new System.Drawing.Size(177, 22);
            this.TSMTTTK.Text = "Thông tin tài khoản";
            this.TSMTTTK.Click += new System.EventHandler(this.TSMTTTK_Click_1);
            // 
            // TSMTTNhanvien
            // 
            this.TSMTTNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TSMTTNhanvien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMNhanvien,
            this.TSMPhuCap});
            this.TSMTTNhanvien.Name = "TSMTTNhanvien";
            this.TSMTTNhanvien.Size = new System.Drawing.Size(125, 20);
            this.TSMTTNhanvien.Text = "Thông tin nhân viên";
            // 
            // TSMNhanvien
            // 
            this.TSMNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMNhanvien.Name = "TSMNhanvien";
            this.TSMNhanvien.Size = new System.Drawing.Size(128, 22);
            this.TSMNhanvien.Text = "Nhân viên";
            this.TSMNhanvien.Click += new System.EventHandler(this.TSMNhanvien_Click);
            // 
            // TSMPhuCap
            // 
            this.TSMPhuCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMPhuCap.Name = "TSMPhuCap";
            this.TSMPhuCap.Size = new System.Drawing.Size(128, 22);
            this.TSMPhuCap.Text = "Phụ cấp";
            this.TSMPhuCap.Click += new System.EventHandler(this.TSMPhuCap_Click);
            // 
            // TSMNhapXuat
            // 
            this.TSMNhapXuat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMCTNhap,
            this.TSMCTXuat,
            this.phiếuXuấtToolStripMenuItem,
            this.chiTiếtPhiếuXuấtToolStripMenuItem});
            this.TSMNhapXuat.Name = "TSMNhapXuat";
            this.TSMNhapXuat.Size = new System.Drawing.Size(100, 20);
            this.TSMNhapXuat.Text = "Nhập/Xuất kho";
            // 
            // TSMCTNhap
            // 
            this.TSMCTNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMCTNhap.Name = "TSMCTNhap";
            this.TSMCTNhap.Size = new System.Drawing.Size(175, 22);
            this.TSMCTNhap.Text = "Phiếu nhập";
            this.TSMCTNhap.Click += new System.EventHandler(this.TSMCTNhap_Click);
            // 
            // TSMCTXuat
            // 
            this.TSMCTXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMCTXuat.Name = "TSMCTXuat";
            this.TSMCTXuat.Size = new System.Drawing.Size(175, 22);
            this.TSMCTXuat.Text = "Chi tiết phiếu nhập";
            this.TSMCTXuat.Click += new System.EventHandler(this.TSMCTXuat_Click);
            // 
            // phiếuXuấtToolStripMenuItem
            // 
            this.phiếuXuấtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.phiếuXuấtToolStripMenuItem.Name = "phiếuXuấtToolStripMenuItem";
            this.phiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.phiếuXuấtToolStripMenuItem.Text = "Phiếu xuất";
            this.phiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.phiếuXuấtToolStripMenuItem_Click);
            // 
            // chiTiếtPhiếuXuấtToolStripMenuItem
            // 
            this.chiTiếtPhiếuXuấtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chiTiếtPhiếuXuấtToolStripMenuItem.Name = "chiTiếtPhiếuXuấtToolStripMenuItem";
            this.chiTiếtPhiếuXuấtToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.chiTiếtPhiếuXuấtToolStripMenuItem.Text = "Chi tiết phiếu xuất";
            this.chiTiếtPhiếuXuấtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtPhiếuXuấtToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMChinhanh,
            this.TSMMenu,
            this.TSMKhachHang,
            this.TSMKhuyenMai,
            this.TSMHoaDon});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Thông tin";
            // 
            // TSMChinhanh
            // 
            this.TSMChinhanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMChinhanh.Name = "TSMChinhanh";
            this.TSMChinhanh.Size = new System.Drawing.Size(137, 22);
            this.TSMChinhanh.Text = "Chi nhánh";
            this.TSMChinhanh.Click += new System.EventHandler(this.TSMChinhanh_Click);
            // 
            // TSMMenu
            // 
            this.TSMMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMMenu.Name = "TSMMenu";
            this.TSMMenu.Size = new System.Drawing.Size(137, 22);
            this.TSMMenu.Text = "Menu";
            this.TSMMenu.Click += new System.EventHandler(this.TSMMenu_Click);
            // 
            // TSMKhachHang
            // 
            this.TSMKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMKhachHang.Name = "TSMKhachHang";
            this.TSMKhachHang.Size = new System.Drawing.Size(137, 22);
            this.TSMKhachHang.Text = "Khách hàng";
            this.TSMKhachHang.Click += new System.EventHandler(this.TSMKhachHang_Click);
            // 
            // TSMKhuyenMai
            // 
            this.TSMKhuyenMai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMKhuyenMai.Name = "TSMKhuyenMai";
            this.TSMKhuyenMai.Size = new System.Drawing.Size(137, 22);
            this.TSMKhuyenMai.Text = "Khuyến mãi";
            this.TSMKhuyenMai.Click += new System.EventHandler(this.TSMKhuyenMai_Click);
            // 
            // TSMHoaDon
            // 
            this.TSMHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMHoaDon.Name = "TSMHoaDon";
            this.TSMHoaDon.Size = new System.Drawing.Size(137, 22);
            this.TSMHoaDon.Text = "Hóa đơn";
            this.TSMHoaDon.Click += new System.EventHandler(this.TSMHoaDon_Click);
            // 
            // TSMBaoCao
            // 
            this.TSMBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMBCHoaDon,
            this.TSMBCKhachHang,
            this.TSMBCNhanVien,
            this.TSMNPhuCap});
            this.TSMBaoCao.Name = "TSMBaoCao";
            this.TSMBaoCao.Size = new System.Drawing.Size(61, 20);
            this.TSMBaoCao.Text = "Báo cáo";
            // 
            // TSMBCHoaDon
            // 
            this.TSMBCHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMBCHoaDon.Name = "TSMBCHoaDon";
            this.TSMBCHoaDon.Size = new System.Drawing.Size(181, 22);
            this.TSMBCHoaDon.Text = "Báo cáo hóa đơn";
            this.TSMBCHoaDon.Click += new System.EventHandler(this.TSMBCHoaDon_Click);
            // 
            // TSMBCKhachHang
            // 
            this.TSMBCKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMBCKhachHang.Name = "TSMBCKhachHang";
            this.TSMBCKhachHang.Size = new System.Drawing.Size(181, 22);
            this.TSMBCKhachHang.Text = "Báo cáo khách hàng";
            this.TSMBCKhachHang.Click += new System.EventHandler(this.TSMBCKhachHang_Click);
            // 
            // TSMBCNhanVien
            // 
            this.TSMBCNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMBCNhanVien.Name = "TSMBCNhanVien";
            this.TSMBCNhanVien.Size = new System.Drawing.Size(181, 22);
            this.TSMBCNhanVien.Text = "Báo cáo nhân viên ";
            this.TSMBCNhanVien.Click += new System.EventHandler(this.TSMBCNhanVien_Click);
            // 
            // TSMNPhuCap
            // 
            this.TSMNPhuCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TSMNPhuCap.Name = "TSMNPhuCap";
            this.TSMNPhuCap.Size = new System.Drawing.Size(181, 22);
            this.TSMNPhuCap.Text = "Báo cáo phụ cấp";
            this.TSMNPhuCap.Click += new System.EventHandler(this.TSMNPhuCap_Click);
            // 
            // TSMNTroGiup
            // 
            this.TSMNTroGiup.Name = "TSMNTroGiup";
            this.TSMNTroGiup.Size = new System.Drawing.Size(62, 20);
            this.TSMNTroGiup.Text = "Trợ giúp";
            this.TSMNTroGiup.Click += new System.EventHandler(this.TSMNTroGiup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "TroGiup.chm";
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 15;
            this.elipseControl1.TargetControl = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem TSMHethong;
        private System.Windows.Forms.ToolStripMenuItem TSMDangxuat;
        private System.Windows.Forms.ToolStripMenuItem TSMTTTK;
        private System.Windows.Forms.ToolStripMenuItem TSMTTNhanvien;
        private System.Windows.Forms.ToolStripMenuItem TSMNhapXuat;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMBaoCao;
        private System.Windows.Forms.ToolStripMenuItem TSMNhanvien;
        private System.Windows.Forms.ToolStripMenuItem TSMPhuCap;
        private System.Windows.Forms.ToolStripMenuItem TSMCTNhap;
        private System.Windows.Forms.ToolStripMenuItem TSMCTXuat;
        private System.Windows.Forms.ToolStripMenuItem TSMChinhanh;
        private System.Windows.Forms.ToolStripMenuItem TSMMenu;
        private System.Windows.Forms.ToolStripMenuItem TSMBCHoaDon;
        private System.Windows.Forms.ToolStripMenuItem TSMBCKhachHang;
        private System.Windows.Forms.ToolStripMenuItem TSMBCNhanVien;
        private System.Windows.Forms.ToolStripMenuItem phiếuXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtPhiếuXuấtToolStripMenuItem;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.ToolStripMenuItem TSMKhachHang;
        private System.Windows.Forms.ToolStripMenuItem TSMKhuyenMai;
        private System.Windows.Forms.ToolStripMenuItem TSMHoaDon;
        private System.Windows.Forms.ToolStripMenuItem TSMNPhuCap;
        private System.Windows.Forms.ToolStripMenuItem TSMNTroGiup;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}