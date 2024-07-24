using DTO_QLKHOHANG;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLKHOHANG
{
    public class DAL_TASK : DBConnect
    {
        public bool InsertTask(DTO_TASK task)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertTask";
                cmd.Parameters.AddWithValue("MaTask", task.MaTask);
                cmd.Parameters.AddWithValue("ThoiGian", task.Thoigiantao);
                cmd.Parameters.AddWithValue("Loaitask", task.Loaitask);
                cmd.Parameters.AddWithValue("MaSP", task.MaSP);
                cmd.Parameters.AddWithValue("MaNV", task.MaNV);
                cmd.Parameters.AddWithValue("TrangThai", task.Trangthai);
                cmd.Parameters.AddWithValue("Soluong", task.Soluong);
                cmd.Parameters.AddWithValue("MaKeHang", task.MaKeHang);
                cmd.Parameters.AddWithValue("Duyet", task.Duyet);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }

        public bool AdminDuyetTask(DTO_TASK task)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AdminDuyetTask";
                cmd.Parameters.AddWithValue("MaTask", task.MaTask);
                cmd.Parameters.AddWithValue("ThoiGian", task.Thoigiantao);
                cmd.Parameters.AddWithValue("Loaitask", task.Loaitask);
                cmd.Parameters.AddWithValue("MaSP", task.MaSP);
                cmd.Parameters.AddWithValue("MaNV", task.MaNV);
                cmd.Parameters.AddWithValue("TrangThai", task.Trangthai);
                cmd.Parameters.AddWithValue("Soluong", task.Soluong);
                cmd.Parameters.AddWithValue("MaKeHang", task.MaKeHang);
                cmd.Parameters.AddWithValue("Duyet", task.Duyet);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }

        public DataTable GetTasksByUser()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetTasksByUser";
                cmd.Connection = _conn;
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;


            }
            finally { _conn.Close(); }
            
        }
        public DataTable spThongKeKehangTheoMaSP()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spThongKeKehangTheoMaSP";
                cmd.Connection = _conn;
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;


            }
            finally { _conn.Close(); }

        }
        public DataTable spThongKeNhapXuatTheoMaNV()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spThongKeNhapXuatTheoMaNV";
                cmd.Connection = _conn;
                DataTable dtHang = new DataTable();
                dtHang.Load(cmd.ExecuteReader());
                return dtHang;


            }
            finally { _conn.Close(); }

        }
    } 

   

}

