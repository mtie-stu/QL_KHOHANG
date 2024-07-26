namespace GUI_QLKHOHANG
{
    partial class Task
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_MaKeHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnduyet = new Guna.UI2.WinForms.Guna2Button();
            this.txt_SoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_task = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.Cb_LoaiTask = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btndeclineduyet = new Guna.UI2.WinForms.Guna2Button();
            this.btnluu = new Guna.UI2.WinForms.Guna2Button();
            this.Cb_Nhanvien = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MaKeHang
            // 
            this.txt_MaKeHang.Animated = true;
            this.txt_MaKeHang.BorderColor = System.Drawing.Color.Blue;
            this.txt_MaKeHang.BorderRadius = 12;
            this.txt_MaKeHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaKeHang.DefaultText = "";
            this.txt_MaKeHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaKeHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaKeHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKeHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKeHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKeHang.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Italic);
            this.txt_MaKeHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_MaKeHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKeHang.Location = new System.Drawing.Point(207, 135);
            this.txt_MaKeHang.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaKeHang.Name = "txt_MaKeHang";
            this.txt_MaKeHang.PasswordChar = '\0';
            this.txt_MaKeHang.PlaceholderForeColor = System.Drawing.Color.Navy;
            this.txt_MaKeHang.PlaceholderText = "Mã Kệ Hàng ";
            this.txt_MaKeHang.SelectedText = "";
            this.txt_MaKeHang.Size = new System.Drawing.Size(136, 28);
            this.txt_MaKeHang.TabIndex = 95;
            // 
            // btnduyet
            // 
            this.btnduyet.BorderRadius = 12;
            this.btnduyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnduyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnduyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnduyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnduyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnduyet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnduyet.ForeColor = System.Drawing.Color.White;
            this.btnduyet.Location = new System.Drawing.Point(793, 425);
            this.btnduyet.Margin = new System.Windows.Forms.Padding(2);
            this.btnduyet.Name = "btnduyet";
            this.btnduyet.Size = new System.Drawing.Size(140, 28);
            this.btnduyet.TabIndex = 94;
            this.btnduyet.Text = "Duyệt";
            this.btnduyet.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Animated = true;
            this.txt_SoLuong.BorderColor = System.Drawing.Color.Blue;
            this.txt_SoLuong.BorderRadius = 12;
            this.txt_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoLuong.DefaultText = "";
            this.txt_SoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoLuong.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Italic);
            this.txt_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_SoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoLuong.Location = new System.Drawing.Point(476, 77);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.PasswordChar = '\0';
            this.txt_SoLuong.PlaceholderForeColor = System.Drawing.Color.Navy;
            this.txt_SoLuong.PlaceholderText = "Số Lượng";
            this.txt_SoLuong.SelectedText = "";
            this.txt_SoLuong.Size = new System.Drawing.Size(138, 28);
            this.txt_SoLuong.TabIndex = 93;
            // 
            // btnthem
            // 
            this.btnthem.BorderRadius = 12;
            this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(793, 347);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(140, 28);
            this.btnthem.TabIndex = 90;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dgv_task
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_task.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_task.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_task.ColumnHeadersHeight = 18;
            this.dgv_task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.TenNV,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_task.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_task.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_task.Location = new System.Drawing.Point(97, 219);
            this.dgv_task.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_task.Name = "dgv_task";
            this.dgv_task.RowHeadersVisible = false;
            this.dgv_task.RowHeadersWidth = 51;
            this.dgv_task.RowTemplate.Height = 24;
            this.dgv_task.Size = new System.Drawing.Size(626, 331);
            this.dgv_task.TabIndex = 86;
            this.dgv_task.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_task.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_task.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_task.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_task.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_task.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_task.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_task.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_task.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_task.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_task.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_task.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_task.ThemeStyle.HeaderStyle.Height = 18;
            this.dgv_task.ThemeStyle.ReadOnly = false;
            this.dgv_task.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_task.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_task.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_task.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_task.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_task.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_task.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_task.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_task_CellContentClick);
            this.dgv_task.Click += new System.EventHandler(this.dgv_task_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MaSP";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "TenSP";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DVT";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "MoTa";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "HinhAnh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(770, 37);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(209, 180);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 85;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(390, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 82;
            this.label1.Text = "Tạo Task";
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Animated = true;
            this.txt_MaSP.BorderColor = System.Drawing.Color.Blue;
            this.txt_MaSP.BorderRadius = 12;
            this.txt_MaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaSP.DefaultText = "";
            this.txt_MaSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaSP.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Italic);
            this.txt_MaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txt_MaSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaSP.Location = new System.Drawing.Point(207, 73);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.PasswordChar = '\0';
            this.txt_MaSP.PlaceholderForeColor = System.Drawing.Color.Navy;
            this.txt_MaSP.PlaceholderText = "Mã Sản Phẩm ";
            this.txt_MaSP.SelectedText = "";
            this.txt_MaSP.Size = new System.Drawing.Size(136, 32);
            this.txt_MaSP.TabIndex = 81;
            // 
            // Cb_LoaiTask
            // 
            this.Cb_LoaiTask.BackColor = System.Drawing.Color.Transparent;
            this.Cb_LoaiTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_LoaiTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_LoaiTask.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_LoaiTask.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_LoaiTask.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cb_LoaiTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cb_LoaiTask.ItemHeight = 30;
            this.Cb_LoaiTask.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.Cb_LoaiTask.Location = new System.Drawing.Point(478, 127);
            this.Cb_LoaiTask.Name = "Cb_LoaiTask";
            this.Cb_LoaiTask.Size = new System.Drawing.Size(136, 36);
            this.Cb_LoaiTask.TabIndex = 96;
            this.Cb_LoaiTask.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // btndeclineduyet
            // 
            this.btndeclineduyet.BorderRadius = 12;
            this.btndeclineduyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndeclineduyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndeclineduyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndeclineduyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndeclineduyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btndeclineduyet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btndeclineduyet.ForeColor = System.Drawing.Color.White;
            this.btndeclineduyet.Location = new System.Drawing.Point(793, 457);
            this.btndeclineduyet.Margin = new System.Windows.Forms.Padding(2);
            this.btndeclineduyet.Name = "btndeclineduyet";
            this.btndeclineduyet.Size = new System.Drawing.Size(140, 28);
            this.btndeclineduyet.TabIndex = 97;
            this.btndeclineduyet.Text = " Từ chối duyệt";
            // 
            // btnluu
            // 
            this.btnluu.BorderRadius = 12;
            this.btnluu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnluu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnluu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnluu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnluu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnluu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.Location = new System.Drawing.Point(793, 381);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(140, 28);
            this.btnluu.TabIndex = 98;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // Cb_Nhanvien
            // 
            this.Cb_Nhanvien.BackColor = System.Drawing.Color.Transparent;
            this.Cb_Nhanvien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cb_Nhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Nhanvien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_Nhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cb_Nhanvien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cb_Nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Cb_Nhanvien.ItemHeight = 30;
            this.Cb_Nhanvien.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.Cb_Nhanvien.Location = new System.Drawing.Point(797, 490);
            this.Cb_Nhanvien.Name = "Cb_Nhanvien";
            this.Cb_Nhanvien.Size = new System.Drawing.Size(136, 36);
            this.Cb_Nhanvien.TabIndex = 99;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 563);
            this.Controls.Add(this.Cb_Nhanvien);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btndeclineduyet);
            this.Controls.Add(this.Cb_LoaiTask);
            this.Controls.Add(this.txt_MaKeHang);
            this.Controls.Add(this.btnduyet);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgv_task);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaSP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Task";
            this.Load += new System.EventHandler(this.KEHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_task)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_MaKeHang;
        private Guna.UI2.WinForms.Guna2Button btnduyet;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoLuong;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaSP;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_LoaiTask;
        private Guna.UI2.WinForms.Guna2Button btndeclineduyet;
        private Guna.UI2.WinForms.Guna2Button btnluu;
        private Guna.UI2.WinForms.Guna2ComboBox Cb_Nhanvien;
    }
}