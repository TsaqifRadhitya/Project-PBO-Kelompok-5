namespace Pet_Care.View
{
    partial class V_Main_Menu
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
            Logout = new Button();
            panel1 = new Panel();
            Dashboard = new Button();
            Transaksi = new Button();
            Pelanggan = new Button();
            Layanan = new Button();
            Secret = new Button();
            SuspendLayout();
            // 
            // Logout
            // 
            Logout.BackColor = Color.Transparent;
            Logout.BackgroundImage = Properties.Resources.Log_Out;
            Logout.BackgroundImageLayout = ImageLayout.Stretch;
            Logout.Cursor = Cursors.Hand;
            Logout.FlatAppearance.BorderSize = 0;
            Logout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Logout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Location = new Point(38, 601);
            Logout.Name = "Logout";
            Logout.Size = new Size(208, 50);
            Logout.TabIndex = 0;
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += button1_Click;
            Logout.MouseEnter += button1_MouseEnter;
            Logout.MouseLeave += button1_MouseLeave;
            // 
            // panel1
            // 
            panel1.Location = new Point(280, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 720);
            panel1.TabIndex = 1;
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.Transparent;
            Dashboard.BackgroundImage = Properties.Resources.Dasboard_Focus;
            Dashboard.BackgroundImageLayout = ImageLayout.Stretch;
            Dashboard.Cursor = Cursors.Hand;
            Dashboard.FlatAppearance.BorderSize = 0;
            Dashboard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Dashboard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Dashboard.FlatStyle = FlatStyle.Flat;
            Dashboard.Location = new Point(24, 220);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(256, 51);
            Dashboard.TabIndex = 2;
            Dashboard.UseVisualStyleBackColor = false;
            Dashboard.Click += Dashboard_Click;
            Dashboard.MouseEnter += Dashboard_MouseEnter;
            Dashboard.MouseLeave += Dashboard_MouseLeave;
            // 
            // Transaksi
            // 
            Transaksi.BackColor = Color.Transparent;
            Transaksi.BackgroundImage = Properties.Resources.Transaksi;
            Transaksi.BackgroundImageLayout = ImageLayout.Stretch;
            Transaksi.Cursor = Cursors.Hand;
            Transaksi.FlatAppearance.BorderSize = 0;
            Transaksi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Transaksi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Transaksi.FlatStyle = FlatStyle.Flat;
            Transaksi.Location = new Point(24, 309);
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(256, 51);
            Transaksi.TabIndex = 3;
            Transaksi.UseVisualStyleBackColor = false;
            Transaksi.Click += Transaksi_Click;
            Transaksi.MouseEnter += Transaksi_MouseEnter;
            Transaksi.MouseLeave += Transaksi_MouseLeave;
            // 
            // Pelanggan
            // 
            Pelanggan.BackColor = Color.Transparent;
            Pelanggan.BackgroundImage = Properties.Resources.Pelanggan;
            Pelanggan.BackgroundImageLayout = ImageLayout.Stretch;
            Pelanggan.Cursor = Cursors.Hand;
            Pelanggan.FlatAppearance.BorderSize = 0;
            Pelanggan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Pelanggan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Pelanggan.FlatStyle = FlatStyle.Flat;
            Pelanggan.Location = new Point(24, 398);
            Pelanggan.Name = "Pelanggan";
            Pelanggan.Size = new Size(256, 51);
            Pelanggan.TabIndex = 4;
            Pelanggan.UseVisualStyleBackColor = false;
            Pelanggan.Click += Pelanggan_Click;
            Pelanggan.MouseEnter += Pelanggan_MouseEnter;
            Pelanggan.MouseLeave += Pelanggan_MouseLeave;
            // 
            // Layanan
            // 
            Layanan.BackColor = Color.Transparent;
            Layanan.BackgroundImage = Properties.Resources.Layanan;
            Layanan.BackgroundImageLayout = ImageLayout.Stretch;
            Layanan.Cursor = Cursors.Hand;
            Layanan.FlatAppearance.BorderSize = 0;
            Layanan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Layanan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Layanan.FlatStyle = FlatStyle.Flat;
            Layanan.Location = new Point(24, 487);
            Layanan.Name = "Layanan";
            Layanan.Size = new Size(256, 51);
            Layanan.TabIndex = 5;
            Layanan.UseVisualStyleBackColor = false;
            Layanan.Click += Layanan_Click;
            Layanan.MouseEnter += Layanan_MouseEnter;
            Layanan.MouseLeave += Layanan_MouseLeave;
            // 
            // Secret
            // 
            Secret.BackColor = Color.Transparent;
            Secret.Cursor = Cursors.Hand;
            Secret.FlatAppearance.BorderSize = 0;
            Secret.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Secret.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Secret.FlatStyle = FlatStyle.Flat;
            Secret.Location = new Point(35, 55);
            Secret.Name = "Secret";
            Secret.Size = new Size(49, 40);
            Secret.TabIndex = 6;
            Secret.UseVisualStyleBackColor = false;
            Secret.Click += Secret_Click;
            // 
            // V_Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Dash_Board;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Secret);
            Controls.Add(Layanan);
            Controls.Add(Pelanggan);
            Controls.Add(Transaksi);
            Controls.Add(Dashboard);
            Controls.Add(panel1);
            Controls.Add(Logout);
            DoubleBuffered = true;
            Name = "V_Main_Menu";
            Size = new Size(1280, 720);
            Load += V_Main_Menu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Logout;
        public Panel panel1;
        public Button Dashboard;
        public Button Transaksi;
        public Button Pelanggan;
        public Button Layanan;
        public Button Secret;
    }
}
