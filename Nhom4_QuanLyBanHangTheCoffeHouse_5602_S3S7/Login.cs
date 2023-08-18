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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        KetNoi KN = new KetNoi();
        private void Login_Load(object sender, EventArgs e)
        {
            
        }


        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtDangNhap.Text;
            string matkhau = txtPass.Text;

            string select = @"select *from DangNhap where TenTK='" + taikhoan + "' and MK='" + matkhau + "'";
            SqlCommand cmd = new SqlCommand(select, KN.GetConnect());
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmMain main = new FrmMain();
                    this.Hide();
                    main.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công! \nKiểm tra lại tên tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = (MessageBox.Show("Bạn có muốn thoát ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                if(thongbao==DialogResult.No)
                {
                    Login lg = new Login();
                    lg.Visible = true;
                }
            }
                
        }

        private void AnPass_Click(object sender, EventArgs e)
        {
            if(txtPass.PasswordChar=='*')
            {
                HienPass.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void HienPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                AnPass.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }
    }
}
