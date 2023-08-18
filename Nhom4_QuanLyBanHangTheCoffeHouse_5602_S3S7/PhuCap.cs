using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlyquancoffe
{
    public partial class PhuCap : Form
    {
        public PhuCap()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void Phụ_cấp_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinPC();
            dgvPhuCap.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txtMaPhuCap.Focus();
            dgvPhuCap.Columns[0].HeaderText = "Mã phụ cấp";
            dgvPhuCap.Columns[1].HeaderText = "Mã nhân viên";
            dgvPhuCap.Columns[2].HeaderText = "Tiền phụ câp";

            DataGridView dgv = dgvPhuCap;
            {
                dgv.Columns[0].Width = 320;
                dgv.Columns[1].Width = 320;
                dgv.Columns[2].Width = 335;
            }
            dgvPhuCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhuCap.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvPhuCap.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        
        private void dgvPhuCap_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvPhuCap.CurrentCell.RowIndex;
            txtMaNhanVien.Text = dgvPhuCap.Rows[vitri].Cells[1].Value.ToString();
            txtMaPhuCap.Text = dgvPhuCap.Rows[vitri].Cells[0].Value.ToString();
            txtPhuCap.Text = dgvPhuCap.Rows[vitri].Cells[2].Value.ToString();
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
        }

       

        private void rdMaPhuCap_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinPC();
            dgvPhuCap.DataSource = bdsource;
        }

        private void rdMaNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinPC();
            dgvPhuCap.DataSource = bdsource;
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnKe.Enabled = true;
            btnCuoi.Enabled = true;
            dgvPhuCap_SelectionChanged(sender, e);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            bdsource.Position -= 1;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }
            btnKe.Enabled = true;
            btnCuoi.Enabled = true;
            dgvPhuCap_SelectionChanged(sender, e);
        }

        private void btnKe_Click(object sender, EventArgs e)
        {
            bdsource.Position += 1;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            if (bdsource.Position == bdsource.Count - 1)
            {
                btnKe.Enabled = false;
                btnCuoi.Enabled = false;
            }
            btnDau.Enabled = true;
            btnTruoc.Enabled = true;
            dgvPhuCap_SelectionChanged(sender, e);
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            bdsource.Position = bdsource.Count - 1;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            btnKe.Enabled = false;
            btnCuoi.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
            dgvPhuCap_SelectionChanged(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string Manv = txtMaNhanVien.Text;
                string MaPhuCap = txtMaPhuCap.Text;
                string PhuCap = txtPhuCap.Text;
                string insert = @"insert into TBPhuCap (MaPC,MaNV,PhuCap) values
                        ('" + MaPhuCap + "','" + Manv + " ','" + PhuCap + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + Manv, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Phụ_cấp_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                string Manv = txtMaNhanVien.Text;
                string MaPhuCap = txtMaPhuCap.Text;
                string PhuCap = txtPhuCap.Text;
                string delete = @"delete from TBPhuCap 
                        where MaPC='" + MaPhuCap + "';";

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaPhuCap, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaPhuCap, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Phụ_cấp_Load(sender, e);
                    txtMaNhanVien.Clear();
                    txtMaPhuCap.Clear();
                    txtPhuCap.Clear();
                    txtMaPhuCap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string Manv = txtMaNhanVien.Text;
                string MaPhuCap = txtMaPhuCap.Text;
                string PhuCap = txtPhuCap.Text;
                string update = @"update  TBPhuCap set MaPC='" + MaPhuCap + "',MaNV = '" + Manv +
                    "',PhuCap='" + PhuCap + "'WHERE MaPC='" + MaPhuCap + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaPhuCap, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Phụ_cấp_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Phụ_cấp_Load(sender, e);
            txtMaNhanVien.Clear();
            txtMaPhuCap.Clear();
            txtPhuCap.Clear();
            txtHienhanh.Clear();
            txtTongSo.Clear();
            txttimkiem.Clear();
            txtMaPhuCap.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from TBPhuCap"));
            if (rdMaPhuCap.Checked == true)
            {
                dv.RowFilter = String.Format(" MaPC LIKE '%{0}%'", txttimkiem.Text);
                dgvPhuCap.DataSource = dv;
                txtHienhanh.Text = (bdsource.Position + 1).ToString();
                txtTongSo.Text = bdsource.Count.ToString();
            }
            else if (rdMaNhanVien.Checked == true)
            {

                dv.RowFilter = String.Format("MaNV LIKE '%{0}%'", txttimkiem.Text);
                dgvPhuCap.DataSource = dv;
            }
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
