namespace Pet_Care.View
{
    partial class V_Tambah_Transaksi
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
            ID_Pelanggan = new TextBox();
            Nama_Kucing = new TextBox();
            pictureBox1 = new PictureBox();
            Batal = new Button();
            Lanjut = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ID_Pelanggan
            // 
            ID_Pelanggan.BackColor = Color.FromArgb(253, 233, 218);
            ID_Pelanggan.BorderStyle = BorderStyle.None;
            ID_Pelanggan.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            ID_Pelanggan.Location = new Point(115, 332);
            ID_Pelanggan.Name = "ID_Pelanggan";
            ID_Pelanggan.Size = new Size(406, 30);
            ID_Pelanggan.TabIndex = 9;
            // 
            // Nama_Kucing
            // 
            Nama_Kucing.BackColor = Color.FromArgb(253, 233, 218);
            Nama_Kucing.BorderStyle = BorderStyle.None;
            Nama_Kucing.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Nama_Kucing.Location = new Point(115, 424);
            Nama_Kucing.Name = "Nama_Kucing";
            Nama_Kucing.Size = new Size(406, 30);
            Nama_Kucing.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(202, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseHover += pictureBox1_MouseHover;
            // 
            // Batal
            // 
            Batal.BackColor = Color.Transparent;
            Batal.BackgroundImage = Properties.Resources.Batal_Hover;
            Batal.BackgroundImageLayout = ImageLayout.Stretch;
            Batal.FlatAppearance.BorderSize = 0;
            Batal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Batal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Batal.FlatStyle = FlatStyle.Flat;
            Batal.Location = new Point(92, 505);
            Batal.Name = "Batal";
            Batal.Size = new Size(153, 54);
            Batal.TabIndex = 12;
            Batal.UseVisualStyleBackColor = false;
            Batal.Click += Batal_Click;
            Batal.MouseEnter += Batal_MouseEnter;
            Batal.MouseLeave += Batal_MouseLeave;
            Batal.MouseHover += Batal_MouseHover;
            // 
            // Lanjut
            // 
            Lanjut.BackColor = Color.Transparent;
            Lanjut.BackgroundImage = Properties.Resources.Lanjut;
            Lanjut.BackgroundImageLayout = ImageLayout.Stretch;
            Lanjut.FlatAppearance.BorderSize = 0;
            Lanjut.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Lanjut.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Lanjut.FlatStyle = FlatStyle.Flat;
            Lanjut.Location = new Point(390, 505);
            Lanjut.Name = "Lanjut";
            Lanjut.Size = new Size(153, 54);
            Lanjut.TabIndex = 13;
            Lanjut.UseVisualStyleBackColor = false;
            Lanjut.Click += Lanjut_Click;
            Lanjut.MouseEnter += Lanjut_MouseEnter;
            Lanjut.MouseLeave += Lanjut_MouseLeave;
            Lanjut.MouseHover += Lanjut_MouseHover;
            // 
            // V_Tambah_Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.Transaksi_Baru1;
            Controls.Add(Lanjut);
            Controls.Add(Batal);
            Controls.Add(pictureBox1);
            Controls.Add(Nama_Kucing);
            Controls.Add(ID_Pelanggan);
            Name = "V_Tambah_Transaksi";
            Size = new Size(623, 590);
            Load += V_Tambah_Transaksi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ID_Pelanggan;
        private TextBox Nama_Kucing;
        private PictureBox pictureBox1;
        private Button Batal;
        private Button Lanjut;
    }
}
