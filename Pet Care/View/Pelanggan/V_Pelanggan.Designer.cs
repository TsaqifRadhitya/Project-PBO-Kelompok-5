namespace Pet_Care.View
{
    partial class V_Pelanggan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SearchBar = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            button2 = new Button();
            id = new Label();
            button1 = new Button();
            label1 = new Label();
            Nomor_Hp = new Label();
            Nama = new Label();
            Tambah_Pelanggan = new Button();
            Search = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBar
            // 
            SearchBar.BackColor = Color.White;
            SearchBar.BorderStyle = BorderStyle.None;
            SearchBar.Font = new Font("Montserrat SemiBold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBar.ForeColor = Color.FromArgb(210, 218, 221);
            SearchBar.Location = new Point(549, 58);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(321, 25);
            SearchBar.TabIndex = 0;
            SearchBar.Text = "Search";
            SearchBar.TextChanged += SearchBar_TextChanged;
            SearchBar.Enter += SearchBar_Enter;
            SearchBar.Leave += SearchBar_Leave;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(15, 166);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(985, 554);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Red_card;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(id);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Nomor_Hp);
            panel1.Controls.Add(Nama);
            panel1.Location = new Point(26, 26);
            panel1.Margin = new Padding(26);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 260);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Montserrat", 8F);
            label2.Location = new Point(15, 206);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 5;
            label2.Text = "tsaqifradhitya@gmail.com";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(153, 15);
            button2.Name = "button2";
            button2.Size = new Size(20, 20);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            id.Font = new Font("Montserrat", 11F);
            id.Location = new Point(14, 161);
            id.Margin = new Padding(0);
            id.Name = "id";
            id.Size = new Size(158, 22);
            id.TabIndex = 3;
            id.Text = "#1";
            id.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(15, 15);
            button1.Name = "button1";
            button1.Size = new Size(14, 18);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Montserrat", 11F);
            label1.Location = new Point(14, 223);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(158, 22);
            label1.TabIndex = 2;
            label1.Text = "Jl.Manggar No.127";
            // 
            // Nomor_Hp
            // 
            Nomor_Hp.Font = new Font("Montserrat", 11F);
            Nomor_Hp.Location = new Point(14, 183);
            Nomor_Hp.Margin = new Padding(0);
            Nomor_Hp.Name = "Nomor_Hp";
            Nomor_Hp.Size = new Size(158, 22);
            Nomor_Hp.TabIndex = 1;
            Nomor_Hp.Text = "085156360779";
            // 
            // Nama
            // 
            Nama.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Nama.Location = new Point(0, 128);
            Nama.Margin = new Padding(0);
            Nama.Name = "Nama";
            Nama.Size = new Size(188, 38);
            Nama.TabIndex = 0;
            Nama.Text = "Tsaqif";
            Nama.TextAlign = ContentAlignment.TopCenter;
            // 
            // Tambah_Pelanggan
            // 
            Tambah_Pelanggan.BackColor = Color.Transparent;
            Tambah_Pelanggan.BackgroundImage = Properties.Resources.Tambah_Pelanggan_Hover1;
            Tambah_Pelanggan.BackgroundImageLayout = ImageLayout.Stretch;
            Tambah_Pelanggan.FlatAppearance.BorderColor = Color.Black;
            Tambah_Pelanggan.FlatAppearance.BorderSize = 0;
            Tambah_Pelanggan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Tambah_Pelanggan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Tambah_Pelanggan.FlatStyle = FlatStyle.Flat;
            Tambah_Pelanggan.Location = new Point(40, 116);
            Tambah_Pelanggan.Name = "Tambah_Pelanggan";
            Tambah_Pelanggan.Size = new Size(169, 39);
            Tambah_Pelanggan.TabIndex = 2;
            Tambah_Pelanggan.UseVisualStyleBackColor = false;
            Tambah_Pelanggan.Click += Tambah_Pelanggan_Click;
            Tambah_Pelanggan.MouseEnter += Tambah_Pelanggan_MouseEnter;
            Tambah_Pelanggan.MouseLeave += Tambah_Pelanggan_MouseLeave;
            Tambah_Pelanggan.MouseHover += Tambah_Pelanggan_MouseHover;
            // 
            // Search
            // 
            Search.BackColor = Color.Transparent;
            Search.FlatAppearance.BorderSize = 0;
            Search.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Search.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Search.FlatStyle = FlatStyle.Flat;
            Search.Location = new Point(894, 58);
            Search.Name = "Search";
            Search.Size = new Size(30, 30);
            Search.TabIndex = 3;
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            Search.MouseHover += Search_MouseHover;
            // 
            // V_Pelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pelanggan2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Search);
            Controls.Add(Tambah_Pelanggan);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SearchBar);
            DoubleBuffered = true;
            Name = "V_Pelanggan";
            Size = new Size(1000, 720);
            Load += V_Pelanggan_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBar;
        private Panel panel1;
        private Label Nomor_Hp;
        private Label Nama;
        private Label label1;
        public FlowLayoutPanel flowLayoutPanel1;
        private Label id;
        private Button button1;
        private Button button2;
        private Button Tambah_Pelanggan;
        private Button Search;
        private Label label2;
    }
}
