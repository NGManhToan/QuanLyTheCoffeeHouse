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
    public partial class ChiNhanh : Form
    {
        public ChiNhanh()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void ChiNhanh_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinCN();
            dgvChiNhanh.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txtMaCN.Focus();
            dgvChiNhanh.Columns[0].HeaderText = "Mã chi nhánh";
            dgvChiNhanh.Columns[1].HeaderText = "Tên chi nhánh";
            dgvChiNhanh.Columns[2].HeaderText = "Địa chỉ";
            DataGridView dgv = dgvChiNhanh;
            {
                dgv.Columns[0].Width = 250;
                dgv.Columns[1].Width = 250;
                dgv.Columns[2].Width = 495;


            }
            if (bdsource.Position == 0)
            {
                btnDau.Enabled = false;
                btnTruoc.Enabled = false;
            }
            dgvChiNhanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiNhanh.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvChiNhanh.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
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
            dgvChiNhanh_SelectionChanged(sender, e);
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
            dgvChiNhanh_SelectionChanged(sender, e);
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
            dgvChiNhanh_SelectionChanged(sender, e);
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
            dgvChiNhanh_SelectionChanged(sender, e);
        }

        private void rdCN_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinCN();
            dgvChiNhanh.DataSource = bdsource;
            
        }

        private void rdTenCN_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinCN();
            dgvChiNhanh.DataSource = bdsource;
            
        }

        private void dgvChiNhanh_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvChiNhanh.CurrentCell.RowIndex;
            txtMaCN.Text = dgvChiNhanh.Rows[vitri].Cells[0].Value.ToString();
            txtTenCN.Text = dgvChiNhanh.Rows[vitri].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvChiNhanh.Rows[vitri].Cells[2].Value.ToString();
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string MaCN = txtMaCN.Text;
                string TenCN = txtTenCN.Text;
                string DiaChi = txtDiaChi.Text;
                string insert = @"insert into TBChiNhanh (MaCN,TenCN,DiaChi) values
                        ('" + MaCN + "','" + TenCN + " ','" + DiaChi + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + MaCN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChiNhanh_Load(sender, e);

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

                string MaCN = txtMaCN.Text;
                string TenCN = txtTenCN.Text;
                string DiaChi = txtDiaChi.Text;
                string delete = @"delete from TBChiNhanh 
                        where MaCN='" + MaCN + "';";

                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaCN, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaCN, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChiNhanh_Load(sender, e);
                    txtMaCN.Clear();
                    txtTenCN.Clear();
                    txtDiaChi.Clear();
                    txtMaCN.Focus();
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
                string MaCN = txtMaCN.Text;
                string TenCN = txtTenCN.Text;
                string DiaChi = txtDiaChi.Text;
                string update = @"update  TBChiNhanh set MaCN='" + MaCN + "',DiaChi = N'" + DiaChi +
                    "',TenCN=N'" + TenCN + "'WHERE MaCN='" + MaCN + "';";
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaCN, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChiNhanh_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        
        
            private void btnLamMoi_Click(object sender, EventArgs e)
            {
                ChiNhanh_Load(sender, e);
                txtMaCN.Clear();
                txtTenCN.Clear();
                txtDiaChi.Clear();
                txtHienhanh.Clear();
                txtTongSo.Clear();
                txttimkiem.Clear();
                txtMaCN.Focus();
            }
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            DataView dv = new DataView(KN.Executequery(@"select * from TBChiNhanh"));
            if (rdCN.Checked == true)
            {
                dv.RowFilter = String.Format(" MaCN LIKE '%{0}%'", txttimkiem.Text);
                dgvChiNhanh.DataSource = dv;

            }
            else if (rdTenCN.Checked == true)
            {

                dv.RowFilter = String.Format("TenCN LIKE '%{0}%'", txttimkiem.Text);
                dgvChiNhanh.DataSource = dv;

            }
        }
    }
}