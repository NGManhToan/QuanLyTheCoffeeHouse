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
    public partial class ChiTietPhieuXuat : Form
    {
        public ChiTietPhieuXuat()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void ChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinCTPXK();
            dgvChiTietXuatKho.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txtMaXuatKho.Focus();
            dgvChiTietXuatKho.Columns[0].HeaderText = "Mã xuất kho";
            dgvChiTietXuatKho.Columns[1].HeaderText = "Mã món xuất kho";
            DataGridView dgv = dgvChiTietXuatKho;
            {
                dgv.Columns[0].Width = 519;
                dgv.Columns[1].Width = 519;
            }
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }
            dgvChiTietXuatKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietXuatKho.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvChiTietXuatKho.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MaXK = txtMaXuatKho.Text;
                string MaMon = txtMaMonXuatKho.Text;
                string insert = @"insert into CTPhieuXuatKho (MaXK,MaMon) values
                        ('" + MaXK + "','" + MaMon + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + MaXK, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChiTietPhieuXuat_Load(sender, e);

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

                string MaXK = txtMaXuatKho.Text;
                string MaMon = txtMaMonXuatKho.Text;
                string delete = @"delete from CTPhieuXuatKho 
                        where MaXK='" + MaXK + "';";

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaXK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaXK, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChiTietPhieuXuat_Load(sender, e);
                    txtMaXuatKho.Clear();
                    txtMaMonXuatKho.Clear();
                    txtMaXuatKho.Focus();
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
                string MaXK = txtMaXuatKho.Text;
                string MaMon = txtMaMonXuatKho.Text;
                string update = @"update CTPhieuXuatKho set 
                   MaXK='" + MaXK + "',MaMon='" + MaMon + "' WHERE MaXK='" + MaXK + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaXK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChiTietPhieuXuat_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ChiTietPhieuXuat_Load(sender, e);
            txtMaXuatKho.Clear();
            txtMaMonXuatKho.Clear();
            txtMaXuatKho.Focus();
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from CTPhieuXuatKho"));
            if (rdMaXuatKho.Checked == true)
            {
                dv.RowFilter = String.Format(" MaXK LIKE '%{0}%'", txttimkiem.Text);
                dgvChiTietXuatKho.DataSource = dv;
                
            }
            else if (rdMaMon.Checked == true)
            {

                dv.RowFilter = String.Format("MaMon LIKE '%{0}%'", txttimkiem.Text);
                dgvChiTietXuatKho.DataSource = dv;
               
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
            dgvChiTietXuatKho_SelectionChanged(sender, e);
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
            dgvChiTietXuatKho_SelectionChanged(sender, e);
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
            dgvChiTietXuatKho_SelectionChanged(sender, e);
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
            dgvChiTietXuatKho_SelectionChanged(sender, e);
        }

        private void rdMaXuatKho_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinCTPXK();
            dgvChiTietXuatKho.DataSource = bdsource;
        }

        private void rdMaMon_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinCTPXK();
            dgvChiTietXuatKho.DataSource = bdsource;
        }
        

        private void dgvChiTietXuatKho_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvChiTietXuatKho.CurrentCell.RowIndex;
            txtMaXuatKho.Text = dgvChiTietXuatKho.Rows[vitri].Cells[0].Value.ToString();
            txtMaMonXuatKho.Text = dgvChiTietXuatKho.Rows[vitri].Cells[1].Value.ToString();
        }

       
    }
}
