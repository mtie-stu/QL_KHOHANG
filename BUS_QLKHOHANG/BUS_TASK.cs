using DAL_QLKHOHANG;
using DTO_QLKHOHANG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLKHOHANG
{
    public class BUS_TASK
    {
        DAL_TASK daltask = new DAL_TASK();
        public bool InsertTask (DTO_TASK task)
        {
            return daltask.InsertTask (task);
        }
        public bool AdminDuyetTask(DTO_TASK task)
        {
            return daltask.AdminDuyetTask (task);
        }
        public DataTable XemTaskChuaDuyet(DTO_TASK task)
        {
            return daltask.XemTaskChuaDuyet(task);
        }
        public DataTable spThongKeKehangTheoMaSP()
        {
            return daltask.spThongKeKehangTheoMaSP();
        }
        public DataTable spThongKeNhapXuatTheoMaNV()
        {
            return daltask.spThongKeNhapXuatTheoMaNV();
        }
      
     
    }
}
