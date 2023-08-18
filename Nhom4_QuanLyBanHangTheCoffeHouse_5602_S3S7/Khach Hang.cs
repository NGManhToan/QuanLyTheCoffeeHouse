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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinKH();
            dgvKhachHang.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            DTPNgaySinh.Format = DateTimePickerFormat.Short;
            DTPNĐK.Format = DateTimePickerFormat.Short;
            txtMaKhachHang.Focus();
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Mã chi nhánh";
            dgvKhachHang.Columns[2].HeaderText = "Họ";
            dgvKhachHang.Columns[3].HeaderText = "Tên";
            dgvKhachHang.Columns[4].HeaderText = "Ngày sinh";
            dgvKhachHang.Columns[6].HeaderText = "Giới tính";
            dgvKhachHang.Columns[6].HeaderText = "Địa chỉ"; 
            dgvKhachHang.Columns[7].HeaderText = "Số điện thoại";
            dgvKhachHang.Columns[8].HeaderText = "Email";
            dgvKhachHang.Columns[9].HeaderText = "Ngày đăng ký";
            dgvKhachHang.Columns[10].HeaderText = "Căn cước công dân";
            dgvKhachHang.Columns[11].HeaderText = "Tổng điểm";
            dgvKhachHang.Columns[12].HeaderText = "Thành viên";
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.RowsDefaultCellStyle.BackColor =Color.LemonChiffon;
            dgvKhachHang.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
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
            dgvKhachHang_SelectionChanged(sender, e);
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
            dgvKhachHang_SelectionChanged(sender, e);
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
            dgvKhachHang_SelectionChanged(sender, e);
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
            dgvKhachHang_SelectionChanged(sender, e);
        }

        private void rdMaKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinKH();
            dgvKhachHang.DataSource = bdsource;

        }

        private void rdTenKhachHang_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinKH();
            dgvKhachHang.DataSource = bdsource;
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvKhachHang.CurrentCell.RowIndex;
            txtMaKhachHang.Text = dgvKhachHang.Rows[vitri].Cells[0].Value.ToString();
            txtMachinhanh.Text = dgvKhachHang.Rows[vitri].Cells[1].Value.ToString();
            txtHoKhachHang.Text = dgvKhachHang.Rows[vitri].Cells[2].Value.ToString();
            txtTenKhachHang.Text = dgvKhachHang.Rows[vitri].Cells[3].Value.ToString();
            DTPNgaySinh.Text = dgvKhachHang.Rows[vitri].Cells[4].Value.ToString();
            txtGioiTinh.Text = dgvKhachHang.Rows[vitri].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[vitri].Cells[6].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[vitri].Cells[7].Value.ToString();
            txtMail.Text = dgvKhachHang.Rows[vitri].Cells[8].Value.ToString();
            DTPNĐK.Text = dgvKhachHang.Rows[vitri].Cells[9].Value.ToString();
            txtCCCD.Text = dgvKhachHang.Rows[vitri].Cells[10].Value.ToString();
            txtDiemHienTai.Text = dgvKhachHang.Rows[vitri].Cells[11].Value.ToString();
            txtBacThanhVien.Text = dgvKhachHang.Rows[vitri].Cells[12].Value.ToString();
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {


                string MaKH = txtMaKhachHang.Text;
                string Machinhanh = txtMachinhanh.Text;
                string Ho = txtHoKhachHang.Text;
                string Ten = txtTenKhachHang.Text;
                DateTime Ngaysinh = DTPNgaySinh.Value;
                string gioitinh = txtGioiTinh.Text;
                string CCCD = txtCCCD.Text;
                string Diachi = txtDiaChi.Text;
                string SĐT = txtSDT.Text;
                string Mail = txtMail.Text;
                string Diem = txtDiemHienTai.Text;
                string Bac = txtBacThanhVien.Text;
                DateTime Ngaydangky = DTPNĐK.Value;
                string insert = @"insert into TBKhachHang (MaKH,MaCN,HoKH,TenKH,NgaySinh,GioiTinh,DiaChi,SDT,Email,NgayDK,CCCD,TongDiem,ThanhVien) values
                        ('" + MaKH + "','" + Machinhanh + " ',N'" + Ho + " ',N'" + Ten + " ','" + Ngaysinh + " ',N'" + gioitinh + " '" +
                        ",N'" + Diachi + " ','" + SĐT + " ','" + Mail + " ','" + Ngaydangky + " ','" + CCCD + " ',N'" + Diem + " ',N'" + Bac + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + MaKH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhachHang_Load(sender, e);

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
                string Machinhanh = txtMachinhanh.Text;
                string Ho = txtHoKhachHang.Text;
                string Ten = txtTenKhachHang.Text;
                DateTime Ngaysinh = DTPNgaySinh.Value;
                string gioitinh = txtGioiTinh.Text;
                string CCCD = txtCCCD.Text;
                string Diachi = txtDiaChi.Text;
                string SĐT = txtSDT.Text;
                string Mail = txtMail.Text;
                string Diem = txtDiemHienTai.Text;
                string Bac = txtBacThanhVien.Text;
                DateTime Ngaydangky = DTPNĐK.Value;
                string delete = @"delete from TBKhachHang 
                        where MaKH='" + MaKH + "';";

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaKH, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaKH, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KhachHang_Load(sender, e);
                    txtMaKhachHang.Clear();
                    txtMachinhanh.Clear();
                    txtHoKhachHang.Clear();
                    txtTenKhachHang.Clear();
                    DTPNgaySinh.ResetText();
                    txtGioiTinh.Clear();
                    txtCCCD.Clear();
                    txtDiaChi.Clear();
                    txtSDT.Clear();
                    txtMail.Clear();
                    DTPNĐK.ResetText();
                    txtDiemHienTai.Clear();
                    txtBacThanhVien.Clear();
                    txtMaKhachHang.Focus();
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
                string MaKH = txtMaKhachHang.Text;
                string Machinhanh = txtMachinhanh.Text;
                string Ho = txtHoKhachHang.Text;
                string Ten = txtTenKhachHang.Text;
                DateTime Ngaysinh = DTPNgaySinh.Value;
                string gioitinh = txtGioiTinh.Text;
                string CCCD = txtCCCD.Text;
                string Diachi = txtDiaChi.Text;
                string SĐT = txtSDT.Text;
                string Mail = txtMail.Text;
                string Diem = txtDiemHienTai.Text;
                string Bac = txtBacThanhVien.Text;
                DateTime Ngaydangky = DTPNĐK.Value;
                string update = @"update TBKhachHang set MaKH='" + MaKH + "',MaCN =N'" + Machinhanh +
                    "',HoKH=N'" + Ho + "',TenKH=N'" + Ten + "',NgaySinh='" + Ngaysinh + "',GioiTinh=N'" + gioitinh + "'" +
                    ",CCCD='" + CCCD + "',DiaChi=N'" + Diachi + "',SDT='" + SĐT + "',Email='" + Mail + "',NgayDK='" + Ngaydangky + "',TongDiem='" + Diem + "',ThanhVien=N'" + Bac + "' WHERE MaKH='" + MaKH + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaKH, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    KhachHang_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            KhachHang_Load(sender, e);
            txtMaKhachHang.Clear();
            txtMachinhanh.Clear();
            txtHoKhachHang.Clear();
            txtTenKhachHang.Clear();
            DTPNgaySinh.ResetText();
            txtGioiTinh.Clear();
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtMail.Clear();
            DTPNĐK.ResetText();
            txtDiemHienTai.Clear();
            txtBacThanhVien.Clear();
            txtMaKhachHang.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from TBKhachHang"));
            if (rdMaKhachHang.Checked == true)
            {
                dv.RowFilter = String.Format(" MaKh LIKE '%{0}%'", txttimkiem.Text);
                dgvKhachHang.DataSource = dv;
            }
            else if (rdTenKhachHang.Checked == true)
            {

                dv.RowFilter = String.Format("TenKH LIKE '%{0}%'", txttimkiem.Text);
                dgvKhachHang.DataSource = dv;
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
