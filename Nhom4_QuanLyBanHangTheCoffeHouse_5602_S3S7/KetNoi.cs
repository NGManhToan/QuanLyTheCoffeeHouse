    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Quanlyquancoffe
{
    class KetNoi
    {
        private string strCon = "Data Source=DESKTOP-KHCJL5O;Initial Catalog=Thecoffehouse;Integrated Security=True";
        public SqlConnection GetConnect()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            return sqlCon;
        }
        public int EXECUTENONQUERY(string query)
        {
            int data = 0;
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                data = cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            return data;
        }
        public DataTable ThongtinNV()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBNhanVien", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinPC()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBPhuCap", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinTK()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from DangNhap", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinCN()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBChiNhanh", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinPN()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from PhieuNhapKho", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinMN()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBMenu", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinGM()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBGiaMon", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinKH()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBKhachHang", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinKM()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from KhuyenMai", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinHD()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from TBHoaDon", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinCTPNK()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from CTPhieuNhapKho", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinPX()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from PhieuXuatKho", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable ThongtinCTPXK()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from CTPhieuXuatKho", GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        public DataTable Executequery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter laydulieu = new SqlDataAdapter(cmd);
                laydulieu.Fill(data);
                sqlCon.Close();
            }
            return data;
        }
    }
}
