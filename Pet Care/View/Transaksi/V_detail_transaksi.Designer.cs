namespace Pet_Care.View.Transaksi
{
    partial class V_Detail_Transaksi
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
            exit = new Button();
            Metode_Pemabayaran = new Label();
            Tanggal = new Label();
            Nominal = new Label();
            status = new PictureBox();
            informasi = new Button();
            Layanan = new Button();
            Layanan_Tab = new PictureBox();
            Informasi_Tab = new PictureBox();
            panel_informasi = new Panel();
            Nama_Pemilik = new Label();
            Nomor_Hp = new Label();
            Alamat = new Label();
            jumlah_layanan = new Label();
            Durasi = new Label();
            Nama_Kucing = new Label();
            ((System.ComponentModel.ISupportInitialize)status).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Layanan_Tab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Informasi_Tab).BeginInit();
            panel_informasi.SuspendLayout();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Cursor = Cursors.Hand;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(566, 27);
            exit.Name = "exit";
            exit.Size = new Size(30, 30);
            exit.TabIndex = 0;
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Metode_Pemabayaran
            // 
            Metode_Pemabayaran.Font = new Font("Montserrat", 9F, FontStyle.Bold);
            Metode_Pemabayaran.ImageAlign = ContentAlignment.MiddleLeft;
            Metode_Pemabayaran.Location = new Point(109, 110);
            Metode_Pemabayaran.Name = "Metode_Pemabayaran";
            Metode_Pemabayaran.Size = new Size(157, 23);
            Metode_Pemabayaran.TabIndex = 1;
            Metode_Pemabayaran.Text = "Transfer Bank";
            // 
            // Tanggal
            // 
            Tanggal.Font = new Font("Montserrat Medium", 12F, FontStyle.Bold);
            Tanggal.ForeColor = Color.Gray;
            Tanggal.Location = new Point(256, 88);
            Tanggal.Margin = new Padding(0);
            Tanggal.Name = "Tanggal";
            Tanggal.Size = new Size(345, 35);
            Tanggal.TabIndex = 0;
            Tanggal.Text = "09/19/2023, 08:14 PM";
            Tanggal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Nominal
            // 
            Nominal.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Nominal.ImageAlign = ContentAlignment.MiddleLeft;
            Nominal.Location = new Point(29, 173);
            Nominal.Name = "Nominal";
            Nominal.Size = new Size(237, 35);
            Nominal.TabIndex = 2;
            Nominal.Text = "Rp55.500,00";
            // 
            // status
            // 
            status.Image = Properties.Resources.Status_Selesai;
            status.Location = new Point(437, 173);
            status.Name = "status";
            status.Size = new Size(135, 46);
            status.TabIndex = 3;
            status.TabStop = false;
            // 
            // informasi
            // 
            informasi.Cursor = Cursors.Hand;
            informasi.FlatAppearance.BorderSize = 0;
            informasi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            informasi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            informasi.FlatStyle = FlatStyle.Flat;
            informasi.Location = new Point(129, 263);
            informasi.Name = "informasi";
            informasi.Size = new Size(98, 16);
            informasi.TabIndex = 4;
            informasi.UseVisualStyleBackColor = true;
            informasi.Click += informasi_Click;
            // 
            // Layanan
            // 
            Layanan.Cursor = Cursors.Hand;
            Layanan.FlatAppearance.BorderSize = 0;
            Layanan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Layanan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Layanan.FlatStyle = FlatStyle.Flat;
            Layanan.Location = new Point(411, 263);
            Layanan.Name = "Layanan";
            Layanan.Size = new Size(85, 16);
            Layanan.TabIndex = 5;
            Layanan.UseVisualStyleBackColor = true;
            Layanan.Click += Layanan_Click;
            // 
            // Layanan_Tab
            // 
            Layanan_Tab.Image = Properties.Resources.Tab_Layanan;
            Layanan_Tab.Location = new Point(307, 246);
            Layanan_Tab.Name = "Layanan_Tab";
            Layanan_Tab.Size = new Size(284, 46);
            Layanan_Tab.TabIndex = 8;
            Layanan_Tab.TabStop = false;
            // 
            // Informasi_Tab
            // 
            Informasi_Tab.Image = Properties.Resources.Tab_Informasi;
            Informasi_Tab.Location = new Point(35, 246);
            Informasi_Tab.Name = "Informasi_Tab";
            Informasi_Tab.Size = new Size(284, 46);
            Informasi_Tab.TabIndex = 9;
            Informasi_Tab.TabStop = false;
            // 
            // panel_informasi
            // 
            panel_informasi.BackgroundImage = Properties.Resources.Layer_Informasi;
            panel_informasi.Controls.Add(Nama_Pemilik);
            panel_informasi.Controls.Add(Nomor_Hp);
            panel_informasi.Controls.Add(Alamat);
            panel_informasi.Controls.Add(jumlah_layanan);
            panel_informasi.Controls.Add(Durasi);
            panel_informasi.Controls.Add(Nama_Kucing);
            panel_informasi.Location = new Point(26, 303);
            panel_informasi.Name = "panel_informasi";
            panel_informasi.Size = new Size(570, 259);
            panel_informasi.TabIndex = 10;
            // 
            // Nama_Pemilik
            // 
            Nama_Pemilik.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            Nama_Pemilik.Location = new Point(313, 65);
            Nama_Pemilik.Name = "Nama_Pemilik";
            Nama_Pemilik.Size = new Size(222, 23);
            Nama_Pemilik.TabIndex = 5;
            Nama_Pemilik.Text = "Tsaqif";
            // 
            // Nomor_Hp
            // 
            Nomor_Hp.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            Nomor_Hp.Location = new Point(313, 128);
            Nomor_Hp.Name = "Nomor_Hp";
            Nomor_Hp.Size = new Size(222, 23);
            Nomor_Hp.TabIndex = 4;
            Nomor_Hp.Text = "085156360779";
            // 
            // Alamat
            // 
            Alamat.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            Alamat.Location = new Point(313, 191);
            Alamat.Name = "Alamat";
            Alamat.Size = new Size(222, 23);
            Alamat.TabIndex = 3;
            Alamat.Text = "Jl.Manggar No.127 Jember";
            // 
            // jumlah_layanan
            // 
            jumlah_layanan.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            jumlah_layanan.Location = new Point(32, 191);
            jumlah_layanan.Name = "jumlah_layanan";
            jumlah_layanan.Size = new Size(100, 23);
            jumlah_layanan.TabIndex = 2;
            jumlah_layanan.Text = "5 Layanan";
            // 
            // Durasi
            // 
            Durasi.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            Durasi.Location = new Point(32, 128);
            Durasi.Name = "Durasi";
            Durasi.Size = new Size(100, 23);
            Durasi.TabIndex = 1;
            Durasi.Text = "10 Hari";
            // 
            // Nama_Kucing
            // 
            Nama_Kucing.Font = new Font("Montserrat", 10F, FontStyle.Bold);
            Nama_Kucing.Location = new Point(32, 65);
            Nama_Kucing.Name = "Nama_Kucing";
            Nama_Kucing.Size = new Size(100, 23);
            Nama_Kucing.TabIndex = 0;
            Nama_Kucing.Text = "Dori";
            // 
            // V_Detail_Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.Detail_Transaksi;
            Controls.Add(panel_informasi);
            Controls.Add(Informasi_Tab);
            Controls.Add(Layanan_Tab);
            Controls.Add(Layanan);
            Controls.Add(informasi);
            Controls.Add(status);
            Controls.Add(Nominal);
            Controls.Add(Tanggal);
            Controls.Add(Metode_Pemabayaran);
            Controls.Add(exit);
            Name = "V_Detail_Transaksi";
            Size = new Size(623, 590);
            Load += V_Detail_Transaksi_Load;
            ((System.ComponentModel.ISupportInitialize)status).EndInit();
            ((System.ComponentModel.ISupportInitialize)Layanan_Tab).EndInit();
            ((System.ComponentModel.ISupportInitialize)Informasi_Tab).EndInit();
            panel_informasi.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button exit;
        private Label Metode_Pemabayaran;
        private Label Tanggal;
        private Label Nominal;
        private PictureBox status;
        private Button informasi;
        private Button Layanan;
        private PictureBox Layanan_Tab;
        private PictureBox Informasi_Tab;
        private Panel panel_informasi;
        private Label Durasi;
        private Label Nama_Kucing;
        private Label Nama_Pemilik;
        private Label Nomor_Hp;
        private Label Alamat;
        private Label jumlah_layanan;
    }
}
