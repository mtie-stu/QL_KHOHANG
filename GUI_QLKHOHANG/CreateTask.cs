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
    public partial class Task : Form
    {
       BUS_TASK bustask = new BUS_TASK();
        string stremail = MAIN.mail; // nhận mail từ Frmmain
        string checkUrlImage; // kiểm tra hình khi cập nhật
        string fileName; // tên file
        string fileSavePath; // url store image
        string fileAddress; // url load images
        public Task()
        {
            InitializeComponent();
        }

        private void KEHANG_Load(object sender, EventArgs e)//KEHANG-->Task
        {
            LoadGridView_Task();
            ResetValue();
            LoadDataComboBox();
            LoadDataNhanVienCB();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadDataComboBox()
        {
            DataTable types = bustask.LoaiTask();
            Cb_LoaiTask.DataSource = types;
            Cb_LoaiTask.DisplayMember = "LoaiTask";
            Cb_LoaiTask.ValueMember = "LoaiTask";
        }
        public void LoadDataNhanVienCB()
        {
            DataTable types = bustask.LoaiTask();
            Cb_Nhanvien.DataSource = types;
            Cb_Nhanvien.DisplayMember = "NhanVienCB";
            Cb_Nhanvien.ValueMember = "NhanVienCB";
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        public Task(string email)
        {
            stremail = email;
        }
        DTO_TASK task = new DTO_TASK();
        private void LoadGridView_Task()
        {
            dgv_task.DataSource = bustask.GetTaskByUser(task);
            dgv_task.Columns[0].HeaderText = "Mã Task";
            dgv_task.Columns[1].HeaderText = "Mã Sản Phẩm";
            dgv_task.Columns[2].HeaderText = "Mã Kệ Hàng";
            dgv_task.Columns[3].HeaderText = "Số Lượng";
            dgv_task.Columns[4].HeaderText = "Trạng Thái ";
           
        }
        private void ResetValue()
        {
            txt_MaSP.Text = null;
            txt_MaKeHang.Text = null;
            txt_SoLuong.Text = null;
            btnduyet.Enabled = false;
            btnthem.Enabled = false;
            btndeclineduyet.Enabled = false;
            Cb_LoaiTask.Enabled = false;
            Cb_Nhanvien.Enabled = false; 
        }

        
        private void dgv_task_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_task_Click(object sender, EventArgs e)
        {
            string saveDirectory = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            if (dgv_task.Rows.Count > 1)
            {
                btnluu.Enabled = false; ;
                btnthem.Enabled = false;
                btnduyet.Enabled = true;
                btndeclineduyet.Enabled = true;
                txt_MaKeHang.Enabled = true;
                txt_MaSP.Enabled = true;
                txt_SoLuong.Enabled = true;
                txt_MaSP.Focus();
                
                txt_MaKeHang.Text = dgv_task.CurrentRow.Cells["MaKeHang"].Value.ToString();
                txt_MaSP.Text = dgv_task.CurrentRow.Cells["MaSP"].Value.ToString();
                txt_SoLuong.Text = dgv_task.CurrentRow.Cells["SoLuong"].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("Bảng không tồn tại dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Cb_Nhanvien.Enabled = true;
            Cb_LoaiTask.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            btnduyet.Enabled = false;
            btndeclineduyet.Enabled =   false;
            txt_MaKeHang.Enabled = true;
            txt_MaSP.Enabled = true;
            txt_SoLuong.Enabled=true; txt_MaKeHang.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            int intSoLuong;
            bool isInt = int.TryParse(txt_SoLuong.Text.Trim(), out intSoLuong);
            if (txt_MaKeHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã kệ hàng ");
                txt_MaKeHang.Focus();
            }
            else if (txt_MaSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm ");
                txt_MaSP.Focus();
            }
            else if (!isInt || int.Parse(txt_SoLuong.Text) < 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng ");
                txt_SoLuong.Focus();
            }
            else if (Cb_LoaiTask.SelectedIndex == -1) // Nếu không có mục nào được chọn  
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                Cb_LoaiTask.Focus(); // Đưa con trỏ về ComboBox  
            }
            else if (Cb_Nhanvien.SelectedIndex == -1) // Nếu không có mục nào được chọn  
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm.");
                Cb_Nhanvien.Focus(); // Đưa con trỏ về ComboBox  
            } 
            else
            {
                DTO_TASK dto_task = new DTO_TASK(txt_MaSP.Text,txt_MaKeHang.Text,int.Parse(txt_SoLuong.Text),Cb_Nhanvien.Text,Cb_LoaiTask.Text);
                if (bustask.InsertTask(dto_task))
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    ResetValue();
                    LoadGridView_Task(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm ko thành công");
                }
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
