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
    public partial class MAIN : Form
    {
        public static int session = 0; // kiểm tra tình trạng login
        public static int profile = 0;//
        public static string mail; // 
        Form1 dn;


        public MAIN()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        // CheckExistForm để kiẻm tra xem 1 form với tên nào đó đã hiển thị trong 
        // Form Cha (frmMain) chưa? => Trả về True (đã hiển thị) hoặc False (nếu chưa hiển thị)
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // ActiveChildForm dùng để kích hoạt hiện thị lên trên 
        // cùng các trong số các form con nếu nó đã hiện mà ko phải tạo thể hiện mới
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        public void frm_DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Refresh();
            MAIN_Load(sender, e);
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dn = new Form1();
                if (!CheckExistForm("frm_DangNhap"))
                {
                    dn.MdiParent = this;
                    dn.Show();
                    dn.FormClosed += new FormClosedEventHandler(frm_DangNhap_FormClosed);
                }
                else
                {
                    ActiveChildForm("frm_DangNhap");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }


        private void VaiTroNv()
        {
            nhânViênToolStripMenuItem1.Visible = false;
            thốngToolStripMenuItem.Visible = false;
        }

        // thiết lập lại phân quyền khi load form main
        private void ResetValue()
        {
            if (session == 1)
            {
                menuStrip1.Text = "Chào " + MAIN.mail;
                nhânViênToolStripMenuItem1.Visible = true;
                nhânViênToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Enabled = true;
                thốngToolStripMenuItem.Visible = true;
                hồSơNhânViênToolStripMenuItem.Visible = true;
                sảnPhẩmToolStripMenuItem1.Enabled = true;
                kệHàngToolStripMenuItem1.Enabled=true;
                taskToolStripMenuItem1.Enabled=true;
                thốngToolStripMenuItem.Enabled=true;
                lờiNgõToolStripMenuItem.Enabled=true;
                hóaĐơnToolStripMenuItem.Enabled=true;
                đăngNhậpToolStripMenuItem.Enabled= true;
                if (int.Parse(dn.vaitro) == 2)
                {
                    VaiTroNv();
                }

            }
            else
            {


                nhânViênToolStripMenuItem1.Visible = false;
                nhânViênToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Enabled = true;
                thốngToolStripMenuItem.Visible = true;
                hồSơNhânViênToolStripMenuItem.Visible = true;
                sảnPhẩmToolStripMenuItem1.Enabled = true;
                kệHàngToolStripMenuItem1.Enabled = true;
                taskToolStripMenuItem1.Enabled = true;
                thốngToolStripMenuItem.Enabled = true;
                lờiNgõToolStripMenuItem.Enabled = true;
                hóaĐơnToolStripMenuItem.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = true;
            }
        }

        private void FrmMain_QLBanHang_Load(object sender, EventArgs e)
        {
            ResetValue();
            if (profile == 1) // Nếu vừa cập nhật mật khẩu thì 
                              // phải login lại, mục 'thông tin nhân viên ẩn'
            {
                menuStrip1.Text = null;
                profile = 0;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void FrmThongTinNV_FormClosed(object sender, EventArgs e)
        {
            this.Refresh();
            FrmMain_QLBanHang_Load(sender, e);
        }
        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Text = null;
            session = 0;
            ResetValue();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            đăngXuấtToolStripMenuItem.Text = null;
            session = 0;
            ResetValue();
        }

        private void thốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NHANVIEN nHANVIEN = new NHANVIEN();
            nHANVIEN.Show();
        }



        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hồSơNhânViênToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            USER  thongTinNV = new USER(MAIN.mail);
            thongTinNV.Show();        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kệHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void taskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Task task = new Task();
            task.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lờiNgõToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
