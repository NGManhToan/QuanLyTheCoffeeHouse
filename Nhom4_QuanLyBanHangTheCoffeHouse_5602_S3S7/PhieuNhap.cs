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
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        

        

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinPN();
            dgvPhieuNhap.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txtMaNK.Focus();
            dgvPhieuNhap.Columns[0].HeaderText = "Mã phiếu nhập kho";
            dgvPhieuNhap.Columns[1].HeaderText = "Ngày nhập kho";
            dgvPhieuNhap.Columns[2].HeaderText = "Số lượng nhập";
            dgvPhieuNhap.Columns[3].HeaderText = "Mã nhân viên nhập kho";
            DataGridView dgv = dgvPhieuNhap;
            {
                dgv.Columns[0].Width = 260;
                dgv.Columns[1].Width = 260;
                dgv.Columns[2].Width = 263;
                dgv.Columns[3].Width = 295;

            }
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvPhieuNhap.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }

        

        private void rdMaNK_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinPN();
            dgvPhieuNhap.DataSource = bdsource;
        }

        private void rdMaNV_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinPN();
            dgvPhieuNhap.DataSource = bdsource;
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
            dgvPhieuNhap_SelectionChanged(sender, e);
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
            dgvPhieuNhap_SelectionChanged(sender, e);
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
            dgvPhieuNhap_SelectionChanged(sender, e);
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
            dgvPhieuNhap_SelectionChanged(sender, e);
        }

        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvPhieuNhap.CurrentCell.RowIndex;
            txtMaNK.Text = dgvPhieuNhap.Rows[vitri].Cells[0].Value.ToString();
            DTPNgayNhap.Text = dgvPhieuNhap.Rows[vitri].Cells[1].Value.ToString();
            txtSL.Text = dgvPhieuNhap.Rows[vitri].Cells[2].Value.ToString();
            txtMaNV.Text = dgvPhieuNhap.Rows[vitri].Cells[3].Value.ToString();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNK = txtMaNK.Text;
                string MaNV = txtMaNV.Text;
                DateTime NgayNhap = DTPNgayNhap.Value;
                string SoLuong = txtSL.Text;
                string update = @"update PhieuNhapKho set 
                   MaNK='" + MaNK + "',NgayNK='" + NgayNhap + "',SoLuongNhap='" + SoLuong + "' ,MaNV='" + MaNV + "' WHERE MaNK='" + MaNK + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaNK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhieuNhap_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from PhieuNhapKho"));
            if (rdMaNK.Checked == true)
            {
                dv.RowFilter = String.Format(" MaNK LIKE '%{0}%'", txttimkiem.Text);
                dgvPhieuNhap.DataSource = dv;
            }
            else if (rdMaNV.Checked == true)
            {

                dv.RowFilter = String.Format("MaNV LIKE '%{0}%'", txttimkiem.Text);
                dgvPhieuNhap.DataSource = dv;
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
            PhieuNhap_Load(sender, e);
            txtMaNV.Clear();
            txtMaNK.Clear();
            txtSL.Clear();
            txttimkiem.Clear();
            DTPNgayNhap.ResetText();
            txtMaNK.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNK = txtMaNK.Text;
                string MaNV = txtMaNV.Text;
                DateTime NgayNhap = DTPNgayNhap.Value;
                string SoLuong = txtSL.Text;
                string insert = @"insert into PhieuNhapKho (MaNK,NgayNK,SoLuongNhap,MaNV) values
                        ('" + MaNK + "','" + NgayNhap + " ','" + SoLuong + " ','" + MaNV + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + MaNK, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PhieuNhap_Load(sender, e);

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

                string MaNK = txtMaNK.Text;
                string MaNV = txtMaNV.Text;
                DateTime NgayNhap = DTPNgayNhap.Value;
                string SoLuong = txtSL.Text;
                string delete = @"delete from PhieuNhapKho 
                        where MaNK='" + MaNK + "';";

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaNK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaNK, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PhieuNhap_Load(sender, e);
                    txtMaNV.Clear();
                    txtMaNK.Clear();
                    txtSL.Clear();
                    DTPNgayNhap.ResetText();
                    txtMaNK.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
