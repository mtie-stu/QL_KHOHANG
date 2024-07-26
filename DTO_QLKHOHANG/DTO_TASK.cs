using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKHOHANG
{
    public class DTO_TASK
    {
        public string MaTask;
        
        public string Loaitask;
        public string MaSP;
        public string MaNV;
        public int Trangthai;
        public int Soluong;
        public string MaKeHang;
        public int Duyet; // Đổi tên biến thành chữ hoa cho phù hợp với quy tắc đặt tên  

        public string MaHang;
        public string Thoigiantao;

        public string maTask
        {
            get { return MaTask; }
            set { MaTask = value; }
        }
      
        public string loaitask
        {
            get { return Loaitask; }
            set { Loaitask = value; }
        }
        public string masp
        {
            get { return MaSP; }
            set { MaSP = value; }
        }
        public string manv
        {
            get { return MaNV; }
            set { MaNV = value; }
        }
        public int trangthai
        {
            get { return Trangthai; }
            set { Trangthai = value; }
        }
        public int soluong
        {
            get { return Soluong; }
            set { Soluong = value; }
        }
        public int duyet
        {
            get { return Duyet; }
            set { Duyet = value; }
        }
        public string mahang
        {
            get { return MaHang; }
            set { MaHang = value; }
        }
        public string thoigiantao
        {
            get { return Thoigiantao; }
            set { Thoigiantao = value; }
        }
        public DTO_TASK(string maTask, string thoigiangiao, string loaitask, string maSP, string maNV, int trangthai, int soluong, string maKeHang, int duyet, string maHang, string thoigiantao)
        {
           this. MaTask = maTask;
           
           this. Loaitask = loaitask;
            this.MaSP = maSP;
           this. MaNV = maNV;
            this.Trangthai = trangthai;
            this.Soluong = soluong;
           this. MaKeHang = maKeHang;
            this.Duyet = duyet;
           this. MaHang = maHang;
            this.Thoigiantao = thoigiantao;
        }
        public DTO_TASK( string thoigiangiao, string loaitask, string maSP, string maNV, int trangthai, int soluong, string maKeHang, int duyet, string maHang, string thoigiantao)
        {
           
            
            this.Loaitask = loaitask;
            this.MaSP = maSP;
            this.MaNV = maNV;
            this.Trangthai = trangthai;
             this.Soluong = soluong;
            this.MaKeHang = maKeHang;
            this.Duyet = duyet;
            this.MaHang = maHang;
            this.Thoigiantao = thoigiantao;
        }
        public DTO_TASK(string maSP, string maKeHang, int soluong,string maNV, string loaitask)
        { 
            this.MaSP = maSP;
            this.MaNV = maNV;
            this.Soluong = soluong;
            this.MaKeHang= maKeHang;
            this.Loaitask= loaitask;
        }
        public DTO_TASK() { }

       
    }
}
