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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private BindingSource bdsource = new BindingSource();
        private DataTable data = new DataTable();
        private void Menu_Load(object sender, EventArgs e)
        {
            bdsource.DataSource = KN.ThongtinMN();
            dgvMenu.DataSource = bdsource;
            txtHienhanh.Text = (bdsource.Position + 1).ToString();
            txtTongSo.Text = bdsource.Count.ToString();
            txtMamon.Focus();
            dgvMenu.Columns[0].HeaderText = "Mã món ăn";
            dgvMenu.Columns[1].HeaderText = "Tên món ăn";
            dgvMenu.Columns[2].HeaderText = "Giá món ăn";
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.RowsDefaultCellStyle.BackColor = Color.LemonChiffon;
            dgvMenu.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSeaGreen;
        }


        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            int vitri = dgvMenu.CurrentCell.RowIndex;
            txtMamon.Text = dgvMenu.Rows[vitri].Cells[0].Value.ToString();
            txtmonan.Text = dgvMenu.Rows[vitri].Cells[1].Value.ToString();
            txtGiamon.Text = dgvMenu.Rows[vitri].Cells[2].Value.ToString();
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
            dgvMenu_SelectionChanged(sender, e);
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
            dgvMenu_SelectionChanged(sender, e);
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
            dgvMenu_SelectionChanged(sender, e);
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
            dgvMenu_SelectionChanged(sender, e);
        }

        private void rdMaMon_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinMN();
            dgvMenu.DataSource = bdsource;
        }

        private void rdTenMon_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinMN();
            dgvMenu.DataSource = bdsource;
        }

        private void rdGiaMon_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Clear();
            txttimkiem.Focus();
            bdsource.DataSource = KN.ThongtinMN();
            dgvMenu.DataSource = bdsource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                string MaMon = txtMamon.Text;
                string TenMon = txtmonan.Text;
                string Giamon = txtGiamon.Text;
                string insert = @"insert into TBMenu (MaMon,TenMon,GiaMon) values
                        ('" + MaMon + "',N'" + TenMon + " ',N'" + Giamon + " ');";
                KN.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm thành công " + MaMon, "THông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Menu_Load(sender, e);


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

                int vitri = dgvMenu.CurrentCell.RowIndex;
                string MaMon = dgvMenu.Rows[vitri].Cells[0].Value.ToString();
                string TenMon = dgvMenu.Rows[vitri].Cells[1].Value.ToString();
                txtGiamon.Text = dgvMenu.Rows[vitri].Cells[2].Value.ToString();
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn xóa " + MaMon, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    string delete = @"delete from TBMenu 
                        where MaMon='" + MaMon + "';";
                    KN.EXECUTENONQUERY(delete);
                    MessageBox.Show("Xóa thành công " + MaMon + " " + TenMon, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu_Load(sender, e);
                    txtmonan.Clear();
                    txtMamon.Clear();
                    txtGiamon.Clear();
                    txtMamon.Focus();
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

                string MaMon = txtMamon.Text;
                string TenMon = txtmonan.Text;
                string Giamon = txtGiamon.Text;
                DialogResult thongbao;
                thongbao = (MessageBox.Show("Bạn có muốn sửa " + MaMon, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information));
                if (thongbao == DialogResult.Yes)
                {
                    string update = @"update TBMenu set MaMon = '" + MaMon +
                    "',TenMon=N'" + TenMon + "',GiaMon=N'" + Giamon + "' WHERE MaMon='" + MaMon + "';";
                    KN.EXECUTENONQUERY(update);
                    MessageBox.Show("Sửa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select * from TBMenu"));
            if (rdMaMon.Checked == true)
            {
                dv.RowFilter = String.Format(" MaMon LIKE '%{0}%'", txttimkiem.Text);
                dgvMenu.DataSource = dv;
            }
            else
            {
                if (rdTenMon.Checked == true)
                {
                    dv.RowFilter = String.Format(" TenMon LIKE '%{0}%'", txttimkiem.Text);
                    dgvMenu.DataSource = dv;
                }
                else
                {
                    if (rdGiaMon.Checked == true)
                    {
                        dv.RowFilter = String.Format(" GiaMon LIKE '%{0}%'", txttimkiem.Text);
                        dgvMenu.DataSource = dv;
                    }
                }

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
            Menu_Load(sender, e);
            txtmonan.Clear();
            txtMamon.Clear();
            txttimkiem.Clear();
            txtGiamon.Clear();
            txtMamon.Focus();
        }
    }
}
