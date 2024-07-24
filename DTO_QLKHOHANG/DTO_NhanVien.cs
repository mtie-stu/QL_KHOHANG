using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKHOHANG
{
    public class DTO_NhanVien
    {
        private string MANV;
        private string DIACHI;
        private int VAITRO;
        private string EMAIL;
        private string TENNV;
        private int SDT;
        private string CCCD;
        private string TINHTRANG;
        private string ANHNV;
        private string MATKHAU;
        public string TenNhanVien
        {
            get { return TENNV; }
            set { TENNV = value; }
        }

        public string DiaChi
        {
            get { return DIACHI; }
            set { DIACHI = value; }
        }

        public int VaiTro
        {
            get { return VAITRO; }
            set { VAITRO = value; }
        }
        public string MatKhau{
            get { return MATKHAU; }
            set { MATKHAU = value; }
            }
        public string EmailNv
        {
            get { return EMAIL; }
            set { EMAIL = value; }
        }

        public string MANHANVIEN
        {
            get { return MANV; }
            set { MANV = value; }
        }

        public string TinhTrang
        {
            get { return TINHTRANG; }
            set { TINHTRANG = value; }
        }
       

        public DTO_NhanVien(string emailnv, string tenNv, string diaChi, int vaiTro, string tinhTrang, string matKhau)
        {
            this.TENNV = tenNv;
            this.DIACHI = diaChi;
            this.VAITRO = vaiTro;
            this.EMAIL = emailnv;
            this.TinhTrang = tinhTrang;
            this.MATKHAU = matKhau;
        }

        public DTO_NhanVien(string emailnv, string tenNv, string diaChi, int vaiTro, string tinhTrang)
        {
            this.TENNV = tenNv;
            this.DIACHI = diaChi;
            this.VAITRO = vaiTro;
            this.EMAIL = emailnv;
            this.TINHTRANG = tinhTrang;
        }

        public DTO_NhanVien() { }
    }
}
