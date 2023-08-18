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
    public partial class ChiTietNhapKho : Form
    {
        public ChiTietNhapKho()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void ChiTietNhapKho_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinCTPNK();
            dgvChiTietNhapKho.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txtMaNhapKho.Focus();
            dgvChiTietNhapKho.Columns[0].HeaderText = "Mã nhập kho";
            dgvChiTietNhapKho.Columns[1].HeaderText = "Mã món nhập kho";
            DataGridView dgv = dgvChiTietNhapKho;
            {
                dgv.Columns[0].Width = 519;
                dgv.Columns[1].Width = 519;
            }
            dgvChiTietNhapKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietNhapKho.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvChiTietNhapKho.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
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



        private void btnDau_Click(object sender, EventArgs e)
        {
            bdsource.Position = 0;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            btnDau.Enabled = false;
            btnTruoc.Enabled = false;
            btnKe.Enabled = true;
            btnCuoi.Enabled = true;
            dgvChiTietNhapKho_SelectionChanged(sender, e);
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
            dgvChiTietNhapKho_SelectionChanged(sender, e);
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
            dgvChiTietNhapKho_SelectionChanged(sender, e);
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
            dgvChiTietNhapKho_SelectionChanged(sender, e);
        }

        private void rdMaNhapKho_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinCTPNK();
            dgvChiTietNhapKho.DataSource = bdsource;
        }

        private void rdMaMon_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinCTPNK();
            dgvChiTietNhapKho.DataSource = bdsource;
        }

        private void dgvChiTietNhapKho_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvChiTietNhapKho.CurrentCell.RowIndex;
            txtMaNhapKho.Text = dgvChiTietNhapKho.Rows[vitri].Cells[0].Value.ToString();
            txtMaMonNhapKho.Text = dgvChiTietNhapKho.Rows[vitri].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNK = txtMaNhapKho.Text;
                string MaMon = txtMaMonNhapKho.Text;
                string insert = @"insert into CTPhieuNhapKho (MaNK,MaMon) values
                        ('" + MaNK + "','" + MaMon + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + MaNK, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChiTietNhapKho_Load(sender, e);

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

                string MaNK = txtMaNhapKho.Text;
                string MaMon = txtMaMonNhapKho.Text;
                string delete = @"delete from CTPhieuNhapKho 
                        where MaNK='" + MaNK + "';";

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaNK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaNK, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChiTietNhapKho_Load(sender, e);
                    txtMaNhapKho.Clear();
                    txtMaMonNhapKho.Clear();
                    txtMaNhapKho.Focus();
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
                string MaNK = txtMaNhapKho.Text;
                string MaMon = txtMaMonNhapKho.Text;
                string update = @"update CTPhieuNhapKho set 
                   MaNK='" + MaNK + "',MaMon='" + MaMon + "' WHERE MaNK='" + MaNK + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaNK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChiTietNhapKho_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ChiTietNhapKho_Load(sender, e);
            txtMaNhapKho.Clear();
            txtMaMonNhapKho.Clear();
            txtMaNhapKho.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from CTPhieuNhapKho"));
            if (rdMaNhapKho.Checked == true)
            {
                dv.RowFilter = String.Format(" MaNK LIKE '%{0}%'", txttimkiem.Text);
                dgvChiTietNhapKho.DataSource = dv;
            }
            else if (rdMaMon.Checked == true)
            {

                dv.RowFilter = String.Format("MaMon LIKE '%{0}%'", txttimkiem.Text);
                dgvChiTietNhapKho.DataSource = dv;
            }
        }
    }
}
