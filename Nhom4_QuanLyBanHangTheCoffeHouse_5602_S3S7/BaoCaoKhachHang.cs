using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Quanlyquancoffe.DuLieu;

namespace Quanlyquancoffe
{
    public partial class BaoCaoKhachHang : Form
    {
        public BaoCaoKhachHang()
        {
            InitializeComponent();
        }
        Model1 md = new Model1();
        private void BaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            
            this.rpvrBaocaoKhachHang.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
            if (thongbao == DialogResult.Yes)
            {
                this.Close();
                this.Hide();
                FrmMain main = new FrmMain();
                main.ShowDialog();
            }
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            rpvrBaocaoKhachHang.Visible = true;
            List<TBKhachHang> listKhachHang = md.TBKhachHangs.ToList();
            this.rpvrBaocaoKhachHang.LocalReport.ReportPath = "./BaoCaoKhachHang.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("KhachHang", listKhachHang);

            rpvrBaocaoKhachHang.LocalReport.DataSources.Clear();

            rpvrBaocaoKhachHang.LocalReport.DataSources.Add(reportDataSource);
            this.rpvrBaocaoKhachHang.RefreshReport();
        }
    }
}
