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
    public partial class BaoCaoNhanVien : Form
    {
        public BaoCaoNhanVien()
        {
            InitializeComponent();
        }
        Model1 md = new Model1();
        private void BaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            
            this.rpvrBaoCaoNhanVien.RefreshReport();
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
            rpvrBaoCaoNhanVien.Visible = true;
            List<TBNhanVien> listNhanVien = md.TBNhanViens.ToList();
            this.rpvrBaoCaoNhanVien.LocalReport.ReportPath = "./BaoCaoNhanVien.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("NhanVien", listNhanVien);

            rpvrBaoCaoNhanVien.LocalReport.DataSources.Clear();

            rpvrBaoCaoNhanVien.LocalReport.DataSources.Add(reportDataSource);
            this.rpvrBaoCaoNhanVien.RefreshReport();
        }
    }
}
