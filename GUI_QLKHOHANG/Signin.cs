using BUS_QLKHOHANG;
using DTO_QLKHOHANG;
using System;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace GUI_QLKHOHANG
{
    public partial class Form1 : Form
    {
        BUS_NHANVIEN busNV = new BUS_NHANVIEN();

        public string vaitro { set; get; }// đăng nhập thành công, kiểm tra vai trò
        public string matkhau { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        bool KiemTraDauVao()
        {

            if (txtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn vui lòng Mật Khẩu ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPass.Focus();
                return false;
            }

            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn vui lòng nhập tên tài khoản", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.EmailNv = txtEmail.Text;
                nv.MatKhau = busNV.encryption(txtPass.Text);

                if (busNV.NhanVienDangNhap(nv))
                {
                    // Đăng nhập thành công
                    MAIN.mail = nv.EmailNv; // Lưu email vào biến static trong MAIN
                    DataTable dt = busNV.VaiTroNhanVien(nv.EmailNv);
                    vaitro = dt.Rows[0][0].ToString();
                    MessageBox.Show("Đăng nhập thành công");
                    MAIN.session = 1;
                   
                    // Ẩn form đăng nhập
                    MAIN mAIN = new MAIN();
                    mAIN.Show(); // Hiển thị form MAIN

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu");
                    txtEmail.Text = "";
                    txtPass.Text = "";
                    txtEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower();
            }
            return builder.ToString();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void SendMail(string emailnv, string MatKhau)
        {
            try
            {
                MailMessage Msg = new MailMessage();
                Msg.Body = "Chào anh/ chị. Mật khẩu mới: " + MatKhau;
                Msg.To.Add(emailnv);
                Msg.From = new MailAddress("tiendttps38069@gmail.com");
                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;

                client.Credentials = new NetworkCredential("tiendttps38069@gmail.com", "rjaq qhcy xcag pwvl");
                client.Send(Msg);
                MessageBox.Show("Gửi mail thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtEmail.Text.Trim() != "")
                {
                    string emailnv = txtEmail.Text.Trim();

                    // Kiểm tra xem email có tồn tại trong CSDL không
                    if (busNV.NhanVienQuenMK(emailnv))
                    {
                        // Sinh mật khẩu mới ngẫu nhiên
                        StringBuilder builder = new StringBuilder();
                        builder.Append(RandomString(4, true));
                        builder.Append(RandomNumber(1000, 9999));
                        builder.Append(RandomString(2, false));
                        string matkhaumoi = busNV.encryption(builder.ToString());

                        // Cập nhật mật khẩu mới vào CSDL
                        busNV.TaoMatKhau(emailnv, matkhaumoi);

                        // Gửi email chứa mật khẩu mới đến địa chỉ email của người dùng
                        SendMail(emailnv, builder.ToString());

                        MessageBox.Show("Đã gửi email chứa mật khẩu mới đến địa chỉ email của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Email không tồn tại trong hệ thống, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập địa chỉ email để nhận thông tin khôi phục mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LuuTK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_NhanVien nv = new DTO_NhanVien();
                nv.EmailNv = txtEmail.Text;
                nv.MatKhau = busNV.encryption(txtPass.Text);

                if (busNV.NhanVienDangNhap(nv))
                {
                    // Đăng nhập thành công
                    MAIN.mail = nv.EmailNv; // Lưu email vào biến static trong MAIN

                    // Lưu thông tin vào tệp tin
                    string path = "account.txt";
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(txtEmail.Text); // Lưu email
                        sw.WriteLine(txtPass.Text);  // Lưu mật khẩu
                                                     // Có thể lưu thêm các thông tin khác cần thiết
                    }

                    DataTable dt = busNV.VaiTroNhanVien(nv.EmailNv);
                    Form1.ActiveForm.Hide(); // Ẩn form đăng nhập
                    MAIN mAIN = new MAIN();
                    mAIN.Show(); // Hiển thị form MAIN
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công, kiểm tra lại email hoặc mật khẩu");
                    txtEmail.Text = "";
                    txtPass.Text = "";
                    txtEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                an.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (txtPass.PasswordChar == '*')
            {
                Hien.BringToFront();
                txtPass.PasswordChar = '\0';
            }
           
        }
    }
}



