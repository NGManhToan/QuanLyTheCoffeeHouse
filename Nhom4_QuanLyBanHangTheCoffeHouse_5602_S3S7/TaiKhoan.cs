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
    public partial class TaiKhoan : Form
    {
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        public TaiKhoan()
        {
            InitializeComponent();
        }

        

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinTK();
            dgvTaiKhoan.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txttentaikhoan.Focus();
            DataGridView dgv = dgvTaiKhoan;
            {
                dgvTaiKhoan.Columns[0].HeaderText = "Tên tài khoản";
                dgvTaiKhoan.Columns[1].HeaderText = "Mật khẩu";
            }
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.RowsDefaultCellStyle.BackColor =Color.LemonChiffon;
            dgvTaiKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }


        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvTaiKhoan.CurrentCell.RowIndex;
            txttentaikhoan.Text = dgvTaiKhoan.Rows[vitri].Cells[0].Value.ToString();
            txtmatkhau.Text = dgvTaiKhoan.Rows[vitri].Cells[1].Value.ToString();
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
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
            dgvTaiKhoan_SelectionChanged(sender, e);
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
            dgvTaiKhoan_SelectionChanged(sender, e);
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
            dgvTaiKhoan_SelectionChanged(sender, e);
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
            dgvTaiKhoan_SelectionChanged(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string TenTK = txttentaikhoan.Text;
                string Matkhau = txtmatkhau.Text;

                string insert = @"insert into DangNhap (TenTK,MK) values
                        ('" + TenTK + "','" + Matkhau + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + TenTK, "THông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiKhoan_Load(sender, e);


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

                int vitri = dgvTaiKhoan.CurrentCell.RowIndex;
                string TenTK = dgvTaiKhoan.Rows[vitri].Cells[0].Value.ToString();
                string Matkhau = dgvTaiKhoan.Rows[vitri].Cells[1].Value.ToString();
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + TenTK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    string delete = @"delete from DangNhap 
                        where TenTK='" + TenTK + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + TenTK + " " + Matkhau, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiKhoan_Load(sender, e);
                    txttentaikhoan.Clear();
                    txtmatkhau.Clear();
                    txttentaikhoan.Focus();
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

                string TenTK = txttentaikhoan.Text;
                string Matkhau = txtmatkhau.Text;
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + TenTK, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    string update = @"update DangNhap set TenTK = N'" + TenTK +
                    "',MK='" + Matkhau + "' WHERE TenTK='" + TenTK + "';";
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiKhoan_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TaiKhoan_Load(sender, e);
            txttentaikhoan.Clear();
            txtmatkhau.Clear();
            txttimkiem.Clear();
            txttentaikhoan.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from DangNhap"));
            dv.RowFilter = String.Format(" TenTK LIKE '%{0}%'", txttimkiem.Text);
            dgvTaiKhoan.DataSource = dv;
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
