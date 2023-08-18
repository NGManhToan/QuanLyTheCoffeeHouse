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
    public partial class CSDL : Form
    {
        public CSDL()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinHD();
            dgvHoaDon.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txtMaHoaDon.Focus();
            dgvHoaDon.Columns[2].HeaderText = "Mã khách hàng";
            dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns[1].HeaderText = "Mã nhân viên";
            dgvHoaDon.Columns[3].HeaderText = "Ngày lập hóa đơn";
            dgvHoaDon.Columns[4].HeaderText = "Phương thức thanh toán";
            dgvHoaDon.Columns[5].HeaderText = "Tổng số tiền";
            DataGridView dgv = dgvHoaDon;

            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
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
            dgvHoaDon_SelectionChanged(sender, e);
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
            dgvHoaDon_SelectionChanged(sender, e);
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
            dgvHoaDon_SelectionChanged(sender, e);
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
            dgvHoaDon_SelectionChanged(sender, e);
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvHoaDon.CurrentCell.RowIndex;
            txtMaHoaDon.Text = dgvHoaDon.Rows[vitri].Cells[0].Value.ToString();
            txtMaNV.Text = dgvHoaDon.Rows[vitri].Cells[1].Value.ToString();
            txtMaKhachHang.Text = dgvHoaDon.Rows[vitri].Cells[2].Value.ToString();
            DTpNgayLapHD.Text = dgvHoaDon.Rows[vitri].Cells[3].Value.ToString();
            txtHinhthucTT.Text = dgvHoaDon.Rows[vitri].Cells[4].Value.ToString();
            txtTongSoTien.Text = dgvHoaDon.Rows[vitri].Cells[5].Value.ToString();

        }

        private void rdMHD_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinHD();
            dgvHoaDon.DataSource = bdsource;
        }

        private void rdNLHD_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinHD();
            dgvHoaDon.DataSource = bdsource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string MaKH = txtMaKhachHang.Text;
                string MaHD = txtMaHoaDon.Text;
                string MaNV = txtMaNV.Text;
                string HinhThuc = txtHinhthucTT.Text;
                DateTime NLHD = DTpNgayLapHD.Value;
                string TongTien = txtTongSoTien.Text;
                string insert = @"insert into TBHoaDon (MaHD,MaNV,MaKH,NgayLapHD,PTTT,TongSoTien) values
                        ('" + MaHD + "','" + MaNV + " ','" + MaKH + " ','" + NLHD + " ',N'" + HinhThuc + " ','" + TongTien + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + MaHD, "THông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HoaDon_Load(sender, e);


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

                string MaKH = txtMaKhachHang.Text;
                string MaHD = txtMaHoaDon.Text;
                string MaNV = txtMaNV.Text;
                string HinhThuc = txtHinhthucTT.Text;
                DateTime NLHD = DTpNgayLapHD.Value;
                string TongTien = txtTongSoTien.Text;
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaHD, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    string delete = @"delete from TBHoaDon 
                        where MaHD='" + MaHD + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaHD, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HoaDon_Load(sender, e);
                    txtMaNV.Clear();
                    txtMaHoaDon.Clear();
                    txtMaKhachHang.Clear();
                    txtHinhthucTT.Clear();
                    DTpNgayLapHD.ResetText();
                    txtTongSoTien.Clear();
                    txtMaHoaDon.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string MaKH = txtMaKhachHang.Text;
                string MaHD = txtMaHoaDon.Text;
                string MaNV = txtMaNV.Text;
                string HinhThuc = txtHinhthucTT.Text;
                DateTime NLHD = DTpNgayLapHD.Value;
                string TongTien = txtTongSoTien.Text;
                string update = @"update TBHoaDon set 
                   MaHD='" + MaHD + "',MaKH='" + MaKH + "',MaNV='" + MaNV + "' ,PTTT=N'" + HinhThuc + "'," +
                   "NgayLapHD='" + NLHD + "',TongSoTien='" + TongTien + "' WHERE MaHD='" + MaHD + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaHD, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HoaDon_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HoaDon_Load(sender, e);
            txtMaNV.Clear();
            txtMaHoaDon.Clear();
            txtMaKhachHang.Clear();
            txtHinhthucTT.Clear();
            DTpNgayLapHD.ResetText();
            txttimkiem.Clear();
            txtTongSoTien.Clear();
            txtMaHoaDon.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from TBHoaDon"));
            if (rdMKH.Checked == true)
            {
                dv.RowFilter = String.Format("MaKH LIKE '%{0}%'", txttimkiem.Text);
                dgvHoaDon.DataSource = dv;
            }
            else if (rdMHD.Checked == true)
            {

                dv.RowFilter = String.Format("MaHD LIKE '%{0}%'", txttimkiem.Text);
                dgvHoaDon.DataSource = dv;
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
