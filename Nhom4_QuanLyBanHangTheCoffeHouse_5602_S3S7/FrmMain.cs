using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quanlyquancoffe
{
    public partial class FrmMain : Form
    {
        KetNoi KN = new KetNoi();
       
        public FrmMain()
        {
            InitializeComponent();
           
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void TSMDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn đăng xuất ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (thongbao == DialogResult.Yes)
            {
                this.Hide();
                Login lg = new Login();
                lg.ShowDialog();
            }
            
        }

        private void TSMTTTK_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan TK = new TaiKhoan();
            TK.Show();
        }

        private void TSMNhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien NV = new NhanVien();
            NV.Show();
        }

        private void TSMPhuCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhuCap PC = new PhuCap();
            PC.Show();
        }

        private void TSMChinhanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiNhanh CN = new ChiNhanh();
            CN.Show();
        }

        private void TSMCTNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuNhap PN = new PhieuNhap();
            PN.Show();
        }

        private void TSMMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu PN = new Menu();
            PN.Show();
        }

        

        private void TSMKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang KH = new KhachHang();
            KH.Show();
        }

        private void TSMKhuyenMai_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhuyenMai KM = new KhuyenMai();
            KM.Show();
        }

        private void TSMHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            CSDL KM = new CSDL();
            KM.Show();
        }

        private void TSMCTXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietNhapKho CTPN = new ChiTietNhapKho();
            CTPN.Show();
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuXuat CTPN = new PhieuXuat();
            CTPN.Show();
        }

        private void chiTiếtPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiTietPhieuXuat CTPN = new ChiTietPhieuXuat();
            CTPN.Show();
        }

        private void TSMBCHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoHoaDon BCHD = new BaoCaoHoaDon();
            BCHD.Show();
        }

        private void TSMBCKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoKhachHang BCKH = new BaoCaoKhachHang();
            BCKH.Show();
        }

        private void TSMBCNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoNhanVien BCNV= new BaoCaoNhanVien();
            BCNV.Show();
        }

        private void TSMNPhuCap_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoPhuCap BCPC = new BaoCaoPhuCap();
            BCPC.Show();
        }

        private void TSMNTroGiup_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("CHƯƠNG-4.docx");
            if (System.IO.File.Exists(helpProvider1.HelpNamespace))
            {
                System.Diagnostics.Process.Start(helpProvider1.HelpNamespace);
            }
        }
    }
}
