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
    public partial class PhieuXuat : Form
    {
        public PhieuXuat()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinPX();
            dgvPhieuXuat.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txtMaXK.Focus();
            dgvPhieuXuat.Columns[0].HeaderText = "Mã phiếu xuất kho";
            dgvPhieuXuat.Columns[1].HeaderText = "Ngày xuất kho";
            dgvPhieuXuat.Columns[2].HeaderText = "Số lượng xuất";
            dgvPhieuXuat.Columns[3].HeaderText = "Mã nhân viên xuất kho";
            DataGridView dgv = dgvPhieuXuat;
            {
                dgv.Columns[0].Width = 281;
                dgv.Columns[1].Width = 281;
                dgv.Columns[2].Width = 281;
                dgv.Columns[3].Width = 281;

            }
            dgvPhieuXuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuXuat.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvPhieuXuat.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
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
            dgvPhieuXuat_SelectionChanged(sender, e);
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
            dgvPhieuXuat_SelectionChanged(sender, e);   
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
            dgvPhieuXuat_SelectionChanged(sender, e);
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
            dgvPhieuXuat_SelectionChanged(sender, e);
        }

     

        private void rdMaNV_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinPX();
            dgvPhieuXuat.DataSource = bdsource;
        }

        private void dgvPhieuXuat_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvPhieuXuat.CurrentCell.RowIndex;
            txtMaXK.Text = dgvPhieuXuat.Rows[vitri].Cells[0].Value.ToString();
            DTPNgayXuat.Text = dgvPhieuXuat.Rows[vitri].Cells[1].Value.ToString();
            txtSL.Text = dgvPhieuXuat.Rows[vitri].Cells[2].Value.ToString();
            txtMaNV.Text = dgvPhieuXuat.Rows[vitri].Cells[3].Value.ToString();
        }

        private void rdMaXK_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinPX();
            dgvPhieuXuat.DataSource = bdsource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MaXK = txtMaXK.Text;
                string MaNV = txtMaNV.Text;
                DateTime NgayXuat = DTPNgayXuat.Value;
                string SoLuong = txtSL.Text;
                string insert = @"insert into PhieuXuatKho (MaXK,NgayXK,SoLuongXuat,MaNV) values
                        ('" + MaXK + "','" + NgayXuat + " ','" + SoLuong + " ','" + MaNV + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + MaXK, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PhieuXuat_Load(sender, e);

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

                string MaXK = txtMaXK.Text;
                string MaNV = txtMaNV.Text;
                DateTime NgayXuat = DTPNgayXuat.Value;
                string SoLuong = txtSL.Text;
                string delete = @"delete from PhieuXuatKho 
                        where MaXK='" + MaXK + "';";

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaXK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaXK, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhieuXuat_Load(sender, e);
                    txtMaNV.Clear();
                    txtMaXK.Clear();
                    txtSL.Clear();
                    DTPNgayXuat.ResetText();
                    txtMaXK.Focus();
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
                string MaXK = txtMaXK.Text;
                string MaNV = txtMaNV.Text;
                DateTime NgayNhap = DTPNgayXuat.Value;
                string SoLuong = txtSL.Text;
                string update = @"update PhieuXuatKho set 
                   MaXK='" + MaXK + "',NgayXK='" + NgayNhap + "',SoLuongXuat='" + SoLuong + "' ,MaNV='" + MaNV + "' WHERE MaXK='" + MaXK + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaXK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    PhieuXuat_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            PhieuXuat_Load(sender, e);
            txtMaNV.Clear();
            txtMaXK.Clear();
            txtSL.Clear();
            txttimkiem.Clear();
            DTPNgayXuat.ResetText();
            txtMaXK.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from PhieuXuatKho"));
            if (rdMaXK.Checked == true)
            {
                dv.RowFilter = String.Format(" MaXK LIKE '%{0}%'", txttimkiem.Text);
                dgvPhieuXuat.DataSource = dv;
            }
            else if (rdMaNV.Checked == true)
            {

                dv.RowFilter = String.Format("MaXV LIKE '%{0}%'", txttimkiem.Text);
                dgvPhieuXuat.DataSource = dv;
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
