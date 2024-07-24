using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLKHOHANG;
namespace GUI_QLKHOHANG
{
    public partial class USER : Form
    {
        string stremail; // nhận email từ frmMain
        BUS_NHANVIEN busNV = new BUS_NHANVIEN();
        Form1 dn = new Form1();
        public USER(string email)
        {
            InitializeComponent();
            stremail = email;
            txt_Email.Text = stremail;
            txt_Email.Enabled = false;
        }
       

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void USER_Load(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_PassOLd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_PasNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_XaCNhanPassNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (TXT_PassOLd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT_PassOLd.Focus();
                return;
            }
            else if (txt_PasNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_PasNew.Focus();
                return;
            }
            else if (txt_XaCNhanPassNew.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_XaCNhanPassNew.Focus();
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn đổi mật khẩu", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //do something if Yes
                    string matkhaumoi = busNV.encryption(txt_PasNew.Text);
                    string matkhaucu = busNV.encryption(TXT_PassOLd.Text);
                    if (busNV.UpdateMatKhau(txt_Email.Text, matkhaucu, matkhaumoi))
                    {
                        MAIN.profile = 1;
                        MAIN.session = 0; // đưa về tình trạng chưa đăng nhập
                        dn.SendMail(stremail, txt_XaCNhanPassNew.Text);
                        MessageBox.Show("Cập nhật mật khẩu thành công, bạn cần phải đăng nhập lại");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng, Cập nhật mật khẩu không thành công");
                        TXT_PassOLd.Text = null;
                        txt_PasNew.Text = null;
                        txt_XaCNhanPassNew.Text = null;
                    }
                }
                else
                {
                    // do somgthing is NO
                    TXT_PassOLd.Text = null;
                    txt_PasNew.Text = null;
                    txt_XaCNhanPassNew.Text = null;
                }
            }
        }
    }
}
