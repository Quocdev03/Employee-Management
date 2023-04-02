using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ManagementEmployees
{
    internal class Modify
    {
        SqlDataAdapter dataAdapter; /* Truy xuất data vào bảng */
        SqlCommand sqlCommand; /* Truy vấn và cập nhật tới cơ sở dử liệu */

        public DataTable getAllNhanVien()
        {
            DataTable dataTable = new DataTable();
            string getQuery = "Select MaNV , MaPB as MA_PB , MaCV ,HoTen,NgaySinh ,GioiTinh , DiaChi ,SoDienThoai From NhanVien";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(getQuery, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }



        public bool insert_nv(NhanVien nhanVien)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "insert into NhanVien values (@MaNV, @MaPB, @MaCV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(getQuery, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = nhanVien.MaNv;
                sqlCommand.Parameters.Add("@MaPB", SqlDbType.VarChar).Value = nhanVien.MaPB;
                sqlCommand.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = nhanVien.MaCV;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nhanVien.HoTen;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanVien.NgaySinh.ToShortDateString(); /* Lấy ngày tháng năm */
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.GioiTinh;
                sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.DiaChi;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.Int).Value = nhanVien.SoDienThoai;
                sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
            }
            catch
            {
                return false;

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public void update_nv(NhanVien nhanVien, string masothem)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "update NhanVien set MaNv = @MaNV, MaPB = @MaPB, MaCV = @MaCV, HoTen = @HoTen, NgaySinh = @NgaySinh ,GioiTinh = @GioiTinh, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai where MaNv = @maso";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(getQuery, sqlConnection);
            sqlCommand.Parameters.Add("@maso", SqlDbType.VarChar).Value = masothem;
            sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = nhanVien.MaNv;
            sqlCommand.Parameters.Add("@MaPB", SqlDbType.VarChar).Value = nhanVien.MaPB;
            sqlCommand.Parameters.Add("@MaCV", SqlDbType.VarChar).Value = nhanVien.MaCV;
            sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nhanVien.HoTen;
            sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = nhanVien.NgaySinh.ToShortDateString(); /* Lấy ngày tháng năm */
            sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nhanVien.GioiTinh;
            sqlCommand.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhanVien.DiaChi;
            sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.Int).Value = nhanVien.SoDienThoai;
            sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
        }




        public DataTable getAllPhongBan()
        {
            DataTable dataTable = new DataTable();
            string getQuery = "Select * From PhongBan";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(getQuery, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert_pb(PhongBan phongban)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "insert into PhongBan values (@MaPB, @TenPb, @SoDienThoai)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(getQuery, sqlConnection);
                sqlCommand.Parameters.Add("@MaPB", SqlDbType.VarChar).Value = phongban.MaPB;
                sqlCommand.Parameters.Add("@TenPb", SqlDbType.VarChar).Value = phongban.TenPB;
                sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.Int).Value = phongban.SoDienThoai;
                sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
            }
            catch
            {
                return false;

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public void update_pb(PhongBan phongban, string masothem)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "update PhongBan set MaPB = @MaPB,TenPB = @TenPb, SoDienThoai = @SoDienThoai  where MaPB = @maso";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(getQuery, sqlConnection);
            sqlCommand.Parameters.Add("@maso", SqlDbType.VarChar).Value = masothem;
            sqlCommand.Parameters.Add("@MaPB", SqlDbType.VarChar).Value = phongban.MaPB;
            sqlCommand.Parameters.Add("@TenPb", SqlDbType.VarChar).Value = phongban.TenPB;
            sqlCommand.Parameters.Add("@SoDienThoai", SqlDbType.Int).Value = phongban.SoDienThoai;
            sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
        }


        public DataTable getAllLuong()
        {
            DataTable dataTable = new DataTable();
            string getQuery = "Select * From Luong";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(getQuery, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert_l(Luong luong)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "insert into Luong values (@MaNV, @ngaycap ,@luongCoban, @luongPhuCap,@luongThuong)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(getQuery, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = luong.MaNV;
                sqlCommand.Parameters.Add("@ngaycap",SqlDbType.DateTime).Value = luong.NgayCap.ToShortDateString();
                sqlCommand.Parameters.Add("@luongCoBan", SqlDbType.Float).Value = luong.LuongCoBan;
                sqlCommand.Parameters.Add("@luongThuong", SqlDbType.Float).Value = luong.LuongThuong;
                sqlCommand.Parameters.Add("@luongPhuCap", SqlDbType.Float).Value = luong.LuongPhuCap;
                sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
            }
            catch
            {
                return false;

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public void update_l(Luong luong, string masothem)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "update Luong set MaNV = @MaNV, NgayCap = @ngaycap ,LuongCoBan = @luongCoBan, LuongThuong = @luongThuong ,LuongPhuCap =@luongPhuCap  where MaNV = @maso";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(getQuery, sqlConnection);
            sqlCommand.Parameters.Add("@maso", SqlDbType.VarChar).Value = masothem;
            sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = luong.MaNV;
            sqlCommand.Parameters.Add("@ngaycap",SqlDbType.DateTime).Value = luong.NgayCap.ToLongDateString();
            sqlCommand.Parameters.Add("@luongCoBan", SqlDbType.Float).Value = luong.LuongCoBan;
            sqlCommand.Parameters.Add("@luongThuong", SqlDbType.Float).Value = luong.LuongThuong;
            sqlCommand.Parameters.Add("@luongPhuCap", SqlDbType.Float).Value = luong.LuongPhuCap;
            sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
        }




        public DataTable getAllLichSuLamViec()
        {
            DataTable dataTable = new DataTable();
            string getQuery = "Select * From LichSuLamViec";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(getQuery, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert_lslv(LichSuLamViec lslv)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "insert into LichSuLamViec values (@MaNV, @NgayBD, @NgayKT)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(getQuery, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = lslv.MaNv;
                sqlCommand.Parameters.Add("@NgayBD", SqlDbType.DateTime).Value = lslv.NgayBatDau.ToShortDateString();
                sqlCommand.Parameters.Add("@NgayKT", SqlDbType.DateTime).Value = lslv.NgayKetThuc.ToShortDateString();
                sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
            }
            catch
            {
                return false;

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public void update_lslv(LichSuLamViec lslv, string masothem)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "update LichSuLamViec set MaNV = @MaNV,NgayBD = @NgayBD, NgayKT = @NgayKT where MaNV = @maso";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(getQuery, sqlConnection);
            sqlCommand.Parameters.Add("@maso", SqlDbType.VarChar).Value = masothem;
            sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = lslv.MaNv;
            sqlCommand.Parameters.Add("@NgayBD", SqlDbType.DateTime).Value = lslv.NgayBatDau.ToShortDateString();
            sqlCommand.Parameters.Add("@NgayKT", SqlDbType.DateTime).Value = lslv.NgayKetThuc.ToShortDateString();
            sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
        }




        public DataTable getAllPhucLoi()
        {
            DataTable dataTable = new DataTable();
            string getQuery = "Select MaPL as Mapl , MaNV as Ma_nv, NgayThucHien as ngaythuchien , NoiDung as noidung , Loai as HinhThuc From PhucLoi";

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(getQuery, sqlConnection);
                dataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }
            return dataTable;
        }
        public bool insert_pl(PhucLoi phucloi)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "insert into PhucLoi values (@MaPL, @MaNV, @ngaythuchien,@Noidung,@Loai)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(getQuery, sqlConnection);
                sqlCommand.Parameters.Add("@MaPL", SqlDbType.VarChar).Value = phucloi.MaPL;
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = phucloi.MaNV;
                sqlCommand.Parameters.Add("@ngaythuchien", SqlDbType.DateTime).Value =phucloi.NgayThucHien.ToShortDateString();
                sqlCommand.Parameters.Add("@Noidung", SqlDbType.VarChar).Value = phucloi.NoiDung;
                sqlCommand.Parameters.Add("@Loai", SqlDbType.VarChar).Value = phucloi.Loai;
                sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
            }
            catch
            {
                return false;

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public void update_pl(PhucLoi phucloi, string masopl, string masonv,DateTime ngay)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "update PhucLoi set MaPl = @MaPL , MaNV =@MaNV , NgayThucHien =@ngaythuchien, NoiDung =@Noidung, Loai =@Loai where MaPL = @masopl and MaNV =@masonv and NgayThucHien=@ngay";
            sqlConnection.Open();
            sqlCommand = new SqlCommand(getQuery, sqlConnection);
            sqlCommand.Parameters.Add("@masopl", SqlDbType.VarChar).Value = masopl;
            sqlCommand.Parameters.Add("@masonv", SqlDbType.VarChar).Value = masonv;
            sqlCommand.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay.ToShortDateString();
            sqlCommand.Parameters.Add("@MaPL", SqlDbType.VarChar).Value = phucloi.MaPL;
            sqlCommand.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = phucloi.MaNV;
            sqlCommand.Parameters.Add("@ngaythuchien", SqlDbType.DateTime).Value = phucloi.NgayThucHien.ToShortDateString();
            sqlCommand.Parameters.Add("@Noidung", SqlDbType.VarChar).Value = phucloi.NoiDung;
            sqlCommand.Parameters.Add("@Loai", SqlDbType.VarChar).Value = phucloi.Loai;
            sqlCommand.ExecuteNonQuery(); /* Thực hiện lệnh truy vấn */
        }

        public void Connect()
        {
            


        }


    }
}


