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
    public partial class BaoCaoHoaDon : Form
    {
        public BaoCaoHoaDon()
        {
            InitializeComponent();
        }
        Model1 md = new Model1();
        private void BaoCaoHoaDon_Load(object sender, EventArgs e)
        {
           
            this.rpwrBaoCao.RefreshReport();
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
            rpwrBaoCao.Visible = true;
            List<TBHoaDon> listHoaDon = md.TBHoaDons.ToList();
            this.rpwrBaoCao.LocalReport.ReportPath = "./BaoCaoHoaDon.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("HoaDon", listHoaDon);

            rpwrBaoCao.LocalReport.DataSources.Clear();

            rpwrBaoCao.LocalReport.DataSources.Add(reportDataSource);
            this.rpwrBaoCao.RefreshReport();
        }
    }
}
