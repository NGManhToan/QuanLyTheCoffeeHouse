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
    public partial class BaoCaoPhuCap : Form
    {
        public BaoCaoPhuCap()
        {
            InitializeComponent();
        }
        Model1 md = new Model1();
        private void BaoCaoPhuCap_Load(object sender, EventArgs e)
        {
            rpvrBaoCaoPhuCap.Visible = false;
            this.rpvrBaoCaoPhuCap.RefreshReport();
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            rpvrBaoCaoPhuCap.Visible = true;
            List<TBPhuCap> listPhuCap = md.TBPhuCaps.ToList();
            this.rpvrBaoCaoPhuCap.LocalReport.ReportPath = "./BaoCaoPhuCap.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("PhuCap", listPhuCap);

            rpvrBaoCaoPhuCap.LocalReport.DataSources.Clear();

            rpvrBaoCaoPhuCap.LocalReport.DataSources.Add(reportDataSource);
            this.rpvrBaoCaoPhuCap.RefreshReport();
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
    }
}
