using BUS_QLKHOHANG;
using DTO_QLKHOHANG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLKHOHANG
{
    public partial class NHANVIEN : Form
    {
        BUS_NHANVIEN busnv = new BUS_NHANVIEN();
        public NHANVIEN()
        {
            InitializeComponent();
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadGridView_NhanVien()
        {
            dgvnhanvien.DataSource = busnv.DanhSachNV();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ResetValues()
        {
            txt_CCCD.Text = null;
            txt_Email.Text = null;  
            txt_nhanvien.Text = null;
            txt_SoDt.Text = null;   
        }
    }
}
