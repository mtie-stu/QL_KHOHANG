using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLKHOHANG
{
    public class DTO_TASK
    {
        public string MaTask { get; set; }
        public string Thoigiangiao { get; set; }
        public string Loaitask { get; set; }
        public string MaSP { get; set; }
        public string MaNV { get; set; }
        public int Trangthai { get; set; }
        public int Soluong { get; set; }
        public string MaKeHang { get; set; }
        public int Duyet { get; set; } // Đổi tên biến thành chữ hoa cho phù hợp với quy tắc đặt tên  

        public string MaHang { get; set; }
        public string Thoigiantao { get; set; }

        public DTO_TASK(string maTask, string thoigiangiao, string loaitask, string maSP, string maNV, int trangthai, int soluong, string maKeHang, int duyet, string maHang, string thoigiantao)
        {
           this. MaTask = maTask;
            this.Thoigiangiao = thoigiangiao;
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
           
            this.Thoigiangiao = thoigiangiao;
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
        public DTO_TASK() { }
    }
}
