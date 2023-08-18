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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinNV();
            dgvNhanVien.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            DTPNgaySinh.Format = DateTimePickerFormat.Short;
            txtMaNhanVien.Focus();
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Mã chi nhánh";
            dgvNhanVien.Columns[2].HeaderText = "Họ";
            dgvNhanVien.Columns[3].HeaderText = "Tên";
            dgvNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns[5].HeaderText = "Giới tính";
            dgvNhanVien.Columns[6].HeaderText = "Căn cước công dân";
            dgvNhanVien.Columns[7].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[8].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns[9].HeaderText = "Email";
            dgvNhanVien.Columns[10].HeaderText = "Lương";
            dgvNhanVien.Columns[11].HeaderText = "Chức vụ";

            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
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
            dgvNhanVien_SelectionChanged(sender, e);
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
            dgvNhanVien_SelectionChanged(sender, e);
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
            dgvNhanVien_SelectionChanged(sender, e);
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
            dgvNhanVien_SelectionChanged(sender, e);    
        }

        private void rdMNV_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinNV();
            dgvNhanVien.DataSource = bdsource;
        }

        private void rdTenNV_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinNV();
            dgvNhanVien.DataSource = bdsource;
        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvNhanVien.CurrentCell.RowIndex;
            txtMaNhanVien.Text = dgvNhanVien.Rows[vitri].Cells[0].Value.ToString();
            txtMachinhanh.Text = dgvNhanVien.Rows[vitri].Cells[1].Value.ToString();
            txtHoNV.Text = dgvNhanVien.Rows[vitri].Cells[2].Value.ToString();
            txtTenNhanVien.Text = dgvNhanVien.Rows[vitri].Cells[3].Value.ToString();
            DTPNgaySinh.Text = dgvNhanVien.Rows[vitri].Cells[4].Value.ToString();
            txtGioiTinh.Text = dgvNhanVien.Rows[vitri].Cells[5].Value.ToString();
            txtCCCD.Text = dgvNhanVien.Rows[vitri].Cells[6].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[vitri].Cells[7].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[vitri].Cells[8].Value.ToString();
            txtMail.Text = dgvNhanVien.Rows[vitri].Cells[9].Value.ToString();
            txtLuong.Text = dgvNhanVien.Rows[vitri].Cells[10].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[vitri].Cells[11].Value.ToString();
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {


                string Manv = txtMaNhanVien.Text;
                string Machinhanh = txtMachinhanh.Text;
                string Ho = txtHoNV.Text;
                string Ten = txtTenNhanVien.Text;
                DateTime Ngaysinh = DTPNgaySinh.Value;
                string gioitinh = txtGioiTinh.Text;
                string CCCD = txtCCCD.Text;
                string Diachi = txtDiaChi.Text;
                string SĐT = txtSDT.Text;
                string Mail = txtMail.Text;
                string Luong = txtLuong.Text;
                string ChucVu = txtChucVu.Text;
                string insert = @"insert into TBNhanVien (MaNV,MaCN,HoNV,TenNV,NgaySinh,GioiTinhNV,CCCD,DiaChi,SDT,Email,Luong,ChucVu) values
                        ('" + Manv + "','" + Machinhanh + " ',N'" + Ho + " ',N'" + Ten + " ','" + Ngaysinh + " ',N'" + gioitinh + " '" +
                        ",'" + CCCD + " ',N'" + Diachi + " ','" + SĐT + " ','" + Mail + " ','" + Luong + " ','" + ChucVu + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + Manv, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanVien_Load(sender, e);

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
                string Machinhanh = txtMachinhanh.Text;
                string Ho = txtHoNV.Text;
                string Ten = txtTenNhanVien.Text;
                string Ngaysinh = DTPNgaySinh.Text;
                string gioitinh = txtGioiTinh.Text;
                string CCCD = txtCCCD.Text;
                string Diachi = txtDiaChi.Text;
                string SĐT = txtSDT.Text;
                string Mail = txtMail.Text;
                string Luong = txtLuong.Text;
                string ChucVu = txtChucVu.Text;
                string delete = @"delete from TBNhanVien 
                        where MaNV='" + Manv + "';";

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + Manv, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + Manv, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NhanVien_Load(sender, e);
                    txtMaNhanVien.Clear();
                    txtMachinhanh.Clear();
                    txtHoNV.Clear();
                    txtTenNhanVien.Clear();
                    DTPNgaySinh.ResetText();
                    txtGioiTinh.Clear();
                    txtCCCD.Clear();
                    txtDiaChi.Clear();
                    txtSDT.Clear();
                    txtMail.Clear();
                    txtLuong.Clear();
                    txtChucVu.Clear();
                    txtMaNhanVien.Focus();
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
                string Machinhanh = txtMachinhanh.Text;
                string Ho = txtHoNV.Text;
                string Ten = txtTenNhanVien.Text;
                DateTime Ngaysinh = DTPNgaySinh.Value;
                string gioitinh = txtGioiTinh.Text;
                string CCCD = txtCCCD.Text;
                string Diachi = txtDiaChi.Text;
                string SĐT = txtSDT.Text;
                string Mail = txtMail.Text;
                string Luong = txtLuong.Text;
                string ChucVu = txtChucVu.Text;
                string update = @"update TBNhanVien set MaNV='" + Manv + "',MaCN =N'" + Machinhanh +
                    "',HoNV=N'" + Ho + "',TenNV=N'" + Ten + "',NgaySinh='" + Ngaysinh + "',GioiTinhNV=N'" + gioitinh + "'" +
                    ",CCCD='" + CCCD + "',DiaChi=N'" + Diachi + "',SDT='" + SĐT + "',Email='" + Mail + "',Luong='" + Luong + "',ChucVu='" + ChucVu + "' WHERE MaNV='" + Manv + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + Manv, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    NhanVien_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NhanVien_Load(sender, e);
            txtMaNhanVien.Clear();
            txtMachinhanh.Clear();
            txtHoNV.Clear();
            txtTenNhanVien.Clear();
            DTPNgaySinh.ResetText();
            txtGioiTinh.Clear();
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtMail.Clear();
            txttimkiem.Clear();
            txtHienhanh.Clear();
            txtTongSo.Clear();
            txtLuong.Clear();
            txtChucVu.Clear();
            txtMaNhanVien.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from TBNhanVien"));
            if (rdMNV.Checked == true)
            {
                dv.RowFilter = String.Format(" MaNV LIKE '%{0}%'", txttimkiem.Text);
                dgvNhanVien.DataSource = dv;
            }
            else if (rdTenNV.Checked == true)
            {

                dv.RowFilter = String.Format("TenNV LIKE '%{0}%'", txttimkiem.Text);
                dgvNhanVien.DataSource = dv;
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
