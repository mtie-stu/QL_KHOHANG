
using DAL_QLBanHang;
using DAL_QLKHOHANG;
using DTO_QLKHOHANG;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace BUS_QLKHOHANG
{
    public class BUS_NHANVIEN
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            return dalNhanVien.NhanVienDangNhap(nv);
        }

        // encrypt pass
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }

        public bool NhanVienQuenMK(string email)
        {
            return dalNhanVien.NhanVienQuenMatKhau(email);
        }

        public bool TaoMatKhau(string email, string password)
        {
            return dalNhanVien.TaoMatKhau(email, password);
        }

        public DataTable VaiTroNhanVien(string email)
        {
            return dalNhanVien.VaiTroNhanVien(email);
        }

        public bool UpdateMatKhau(string email, string matkhaucu, string matkhaumoi)
        {
            return dalNhanVien.UpdateMatKhau(email, matkhaucu, matkhaumoi);
        }
        public bool DanhSachNV()
        {
            return dalNhanVien.DanhSachNV();
        }

    }
}
