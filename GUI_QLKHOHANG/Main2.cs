using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace GUI_QLKHOHANG
{
    public partial class Main2 : Form
    {
        public static int session = 0; // kiểm tra tình trạng login
        public static int profile = 0;//
        public static string mail; // 
        public Main2()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void đăngXuẩtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            đăngXuẩtToolStripMenuItem.Text = null;
            session = 0;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main2_Load(object sender, EventArgs e)
        {
        }
    }
}
