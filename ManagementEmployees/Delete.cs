using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace ManagementEmployees
{
    internal class Delete
    {
        SqlDataAdapter dataAdapter; /* Truy xuất data vào bảng */
        SqlCommand sqlCommand;

        
        public void Delete_l(string manv)
        {
            try
            {
                SqlConnection sqlConnection = Connection.GetSqlConnection();
                string getQuery = "delete from Luong where MaNV= @MaNV";

                sqlConnection.Open();
                sqlCommand = new SqlCommand(getQuery, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = manv;
                sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */


                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Du lieu khong the xoa");
            }


        }
        public void Delete_lslv(string manv)
        {
            try
            {
                SqlConnection sqlConnection = Connection.GetSqlConnection();
                string getQuery = "delete from LichSuLamViec where MaNV=@MaNV";

                sqlConnection.Open();
                sqlCommand = new SqlCommand(getQuery, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = manv;
                sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Du lieu khong the xoa");
            }


        }
        public void Delete_pl(string masopl, string masonv, DateTime ngay)
        {
            try
            {
                SqlConnection sqlConnection = Connection.GetSqlConnection();
                string getQuery = "delete from PhucLoi  where MaPL = @masopl and MaNV =@masonv and NgayThucHien=@ngay";

                sqlConnection.Open();
                sqlCommand = new SqlCommand(getQuery, sqlConnection);
                sqlCommand.Parameters.Add("@masopl", SqlDbType.VarChar).Value = masopl;
                sqlCommand.Parameters.Add("@masonv", SqlDbType.VarChar).Value = masonv;
                sqlCommand.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay.ToShortDateString();
                sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */

                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Du lieu khong the xoa");
            }
        }
        public void Delete_pb(string mapb)
        {
            try
            {
                SqlConnection sqlConnection = Connection.GetSqlConnection();
                string getQuery = "delete from PhongBan  where MaPB = @maso";
                sqlConnection.Open();

                sqlCommand = new SqlCommand(getQuery, sqlConnection);
                sqlCommand.Parameters.Add("@maso", SqlDbType.VarChar).Value = mapb;
                sqlCommand.ExecuteNonQuery();
                /* Thực hiện lệnh truy vấn */


                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Du lieu khong the xoa");
            }

        }
        public void Delete_nv(string manv)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn xóa, sẽ xóa dữ liệu liên quan ở bảng khác ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                try
                {
                    SqlConnection sqlConnection = Connection.GetSqlConnection();
                    string getQuery = "delete from NhanVien where MaNV=@MaNV";
                    string getQuery1 = "delete from PhucLoi where MaNV=@Ma";

                    sqlConnection.Open();
                    Delete_l(manv);
                    Delete_lslv(manv);


                    sqlCommand = new SqlCommand(getQuery1, sqlConnection);
                    sqlCommand.Parameters.Add("@Ma", SqlDbType.VarChar).Value = manv;
                    sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
                    sqlCommand = new SqlCommand(getQuery, sqlConnection);
                    sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = manv;
                    sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */

                    sqlConnection.Close();
                }
                catch
                {
                    MessageBox.Show("Du lieu khong the xoa");
                }
            }     

        }
        
    }
}
