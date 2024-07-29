using DTO_QLKHOHANG
;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
using System.Net.Mail;
using DAL_QLKHOHANG;

namespace DAL_QLBanHang
{
    public class DAL_NhanVien : DBConnect
    {
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            try
            {
                //Kết nối 
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DangNhap";
                cmd.Parameters.AddWithValue("Email", nv.EmailNv);
                cmd.Parameters.AddWithValue("MatKhau", nv.MatKhau);
                // Query và kiểm tra
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool NhanVienQuenMatKhau(string email)
        {
            try
            {
                //Kết nối 
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "QuenMatKhau";
                cmd.Parameters.AddWithValue("Email", email);

                // Query và kiểm tra
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool TaoMatKhau(string email, string matKhauMoi)
        {
            try
            {
                //Kết nối 
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TaoMatKhauMoi";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("MatKhau", matKhauMoi);

                // Query và kiểm tra
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable VaiTroNhanVien(string email)
        {
            try
            {
                //Kết nối 
                _conn.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[LayVaiTroNV]";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Connection = _conn;

                DataTable dtNhanVien = new DataTable();
                dtNhanVien.Load(cmd.ExecuteReader());
                return dtNhanVien;

            }

            finally
            {
                _conn.Close();
            }

        }

        public bool UpdateMatKhau(string email, string matkhaucu, string matkhaumoi)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThayDoiMatKhau";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("@opwd", matkhaucu);
                cmd.Parameters.AddWithValue("@npwd", matkhaumoi);

                //Query và kiẻm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally { _conn.Close(); }
        }

        // Lấy danh sách nhân viên
        public bool DanhSachNV()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DanhSachNV";
               
                //Query và kiẻm tra
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            finally { _conn.Close(); }
        }

        // Thêm nhân viên



        // Sửa nhân viên 





    }
}
