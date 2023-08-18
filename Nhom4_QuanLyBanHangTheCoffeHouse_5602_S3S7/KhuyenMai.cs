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
    public partial class KhuyenMai : Form
    {
        public KhuyenMai()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void KhuyenMai_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinKM();
            dgvKhuyenMai.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txtMaKhuyenMai.Focus();
            dgvKhuyenMai.Columns[0].HeaderText = "Mã khuyến mãi";
            dgvKhuyenMai.Columns[1].HeaderText = "Mã hóa đơn";
            dgvKhuyenMai.Columns[2].HeaderText = "Tên chương trình";
            dgvKhuyenMai.Columns[6].HeaderText = "Điều kiện áp dụng";
            dgvKhuyenMai.Columns[5].HeaderText = "Hình thức khuyến mãi";
            dgvKhuyenMai.Columns[3].HeaderText = "Ngày bắt đầu";
            dgvKhuyenMai.Columns[4].HeaderText = "Ngày kết thúc";
            DataGridView dgv = dgvKhuyenMai;
            dgv.Columns[0].Width =150;
            dgv.Columns[1].Width = 150;
            dgv.Columns[2].Width = 200;
            dgv.Columns[3].Width = 130;
            dgv.Columns[4].Width = 115;
            dgv.Columns[5].Width = 170;
            dgv.Columns[6].Width = 170;
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }
            dgvKhuyenMai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhuyenMai.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvKhuyenMai.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
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
            dgvKhuyenMai_SelectionChanged(sender, e);
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
            dgvKhuyenMai_SelectionChanged(sender, e);
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
            dgvKhuyenMai_SelectionChanged(sender, e);
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
            dgvKhuyenMai_SelectionChanged(sender, e);
        }

        private void dgvKhuyenMai_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvKhuyenMai.CurrentCell.RowIndex;
            txtMaKhuyenMai.Text = dgvKhuyenMai.Rows[vitri].Cells[0].Value.ToString();
            txtMaHoaDon.Text = dgvKhuyenMai.Rows[vitri].Cells[1].Value.ToString();
            txtTenChuongtrinh.Text = dgvKhuyenMai.Rows[vitri].Cells[2].Value.ToString();
            DTPNgayBatDau.Text = dgvKhuyenMai.Rows[vitri].Cells[3].Value.ToString();
            DTPNgayKetThuc.Text = dgvKhuyenMai.Rows[vitri].Cells[4].Value.ToString();
            txtHTKhuyenMai.Text = dgvKhuyenMai.Rows[vitri].Cells[5].Value.ToString();
            txtDieukienapdung.Text = dgvKhuyenMai.Rows[vitri].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string MaKM = txtMaKhuyenMai.Text;
                string MaHD = txtMaHoaDon.Text;
                string TenCT = txtTenChuongtrinh.Text;
                string DieuKien = txtDieukienapdung.Text;
                string HinhThuc = txtHTKhuyenMai.Text;
                DateTime NBD = DTPNgayBatDau.Value;
                DateTime NKT = DTPNgayKetThuc.Value;
                string insert = @"insert into KhuyenMai (MaKM,MaHD,TenCTKM,NgayBDKM,NgayKTKM,HinhThucKM,DKApDung) values
                        ('" + MaKM + "','" + MaHD + " ',N'" + TenCT + " ',N'" + NBD + " ',N'" + NKT + " ',N'" + HinhThuc + " ',N'" + DieuKien + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + MaKM, "THông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhuyenMai_Load(sender, e);


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

                string MaKM = txtMaKhuyenMai.Text;
                string MaHD = txtMaHoaDon.Text;
                string TenCT = txtTenChuongtrinh.Text;
                string DieuKien = txtDieukienapdung.Text;
                string HinhThuc = txtHTKhuyenMai.Text;
                DateTime NBD = DTPNgayBatDau.Value;
                DateTime NKT = DTPNgayKetThuc.Value;
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaKM, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    string delete = @"delete from KhuyenMai 
                        where MaKM='" + MaKM + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaKM, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KhuyenMai_Load(sender, e);
                    txtMaKhuyenMai.Clear();
                    txtMaHoaDon.Clear();
                    txtTenChuongtrinh.Clear();
                    txtDieukienapdung.Clear();
                    txtHTKhuyenMai.Clear();
                    DTPNgayBatDau.ResetText();
                    DTPNgayKetThuc.ResetText();
                    txtMaKhuyenMai.Focus();
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
                string MaKM = txtMaKhuyenMai.Text;
                string MaHD = txtMaHoaDon.Text;
                string TenCT = txtTenChuongtrinh.Text;
                string DieuKien = txtDieukienapdung.Text;
                string HinhThuc = txtHTKhuyenMai.Text;
                DateTime NBD = DTPNgayBatDau.Value;
                DateTime NKT = DTPNgayKetThuc.Value;
                string update = @"update KhuyenMai set 
                   MaKM='" + MaKM + "',MaHD='" + MaHD + "',TenCTKM=N'" + TenCT + "' ,DKApDung=N'" + DieuKien + "'," +
                   "HinhThucKM=N'" + HinhThuc + "',NgayBDKM='" + NBD + "',NgayKTKM='" + NKT + "' WHERE MaKM='" + MaKM + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaKM, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KhuyenMai_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            KhuyenMai_Load(sender, e);
            txtMaKhuyenMai.Clear();
            txtMaHoaDon.Clear();
            txtTenChuongtrinh.Clear();
            txtDieukienapdung.Clear();
            txtHTKhuyenMai.Clear();
            DTPNgayBatDau.ResetText();
            DTPNgayKetThuc.ResetText();
            txtMaKhuyenMai.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from KhuyenMai"));
            if (rdMKM.Checked == true)
            {
                dv.RowFilter = String.Format(" MaKM LIKE '%{0}%'", txttimkiem.Text);
                dgvKhuyenMai.DataSource = dv;
            }
            else if (rdTCT.Checked == true)
            {

                dv.RowFilter = String.Format("TenCTKM LIKE '%{0}%'", txttimkiem.Text);
                dgvKhuyenMai.DataSource = dv;
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

        private void rdMKM_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinKM();
            dgvKhuyenMai.DataSource = bdsource;
        }

        private void rdTCT_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinKM();
            dgvKhuyenMai.DataSource = bdsource;
        }
    }
}
