namespace Pet_Care.View
{
    partial class V_Ubah_Tambah_Pelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Ubah_Tambah_Pelanggan));
            Batal = new Button();
            Simpan = new Button();
            Alamat = new TextBox();
            Nomor_Telepon = new TextBox();
            Nama = new TextBox();
            Header = new Label();
            Email = new TextBox();
            SuspendLayout();
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
            Batal.Location = new Point(101, 497);
            Batal.Name = "Batal";
            Batal.Size = new Size(153, 54);
            Batal.TabIndex = 0;
            Batal.UseVisualStyleBackColor = false;
            Batal.Click += Batal_Click;
            Batal.MouseEnter += Batal_MouseEnter;
            Batal.MouseLeave += Batal_MouseLeave;
            Batal.MouseHover += Batal_MouseHover;
            // 
            // Simpan
            // 
            Simpan.BackColor = Color.Transparent;
            Simpan.BackgroundImage = Properties.Resources.Simpan_Hover;
            Simpan.BackgroundImageLayout = ImageLayout.Stretch;
            Simpan.FlatAppearance.BorderSize = 0;
            Simpan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Simpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Simpan.FlatStyle = FlatStyle.Flat;
            Simpan.Location = new Point(380, 497);
            Simpan.Name = "Simpan";
            Simpan.Size = new Size(153, 54);
            Simpan.TabIndex = 1;
            Simpan.UseVisualStyleBackColor = false;
            Simpan.Click += Simpan_Click;
            Simpan.MouseEnter += Simpan_MouseEnter;
            Simpan.MouseLeave += Simpan_MouseLeave;
            Simpan.MouseHover += Simpan_MouseHover;
            // 
            // Alamat
            // 
            Alamat.BackColor = Color.FromArgb(253, 233, 218);
            Alamat.BorderStyle = BorderStyle.None;
            Alamat.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Alamat.Location = new Point(115, 425);
            Alamat.Name = "Alamat";
            Alamat.Size = new Size(406, 30);
            Alamat.TabIndex = 2;
            // 
            // Nomor_Telepon
            // 
            Nomor_Telepon.BackColor = Color.FromArgb(253, 233, 218);
            Nomor_Telepon.BorderStyle = BorderStyle.None;
            Nomor_Telepon.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Nomor_Telepon.Location = new Point(115, 240);
            Nomor_Telepon.MaxLength = 13;
            Nomor_Telepon.Name = "Nomor_Telepon";
            Nomor_Telepon.Size = new Size(406, 30);
            Nomor_Telepon.TabIndex = 3;
            Nomor_Telepon.TextChanged += Nomor_Telepon_TextChanged;
            // 
            // Nama
            // 
            Nama.BackColor = Color.FromArgb(253, 233, 218);
            Nama.BorderStyle = BorderStyle.None;
            Nama.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Nama.Location = new Point(115, 151);
            Nama.Name = "Nama";
            Nama.Size = new Size(406, 30);
            Nama.TabIndex = 5;
            // 
            // Header
            // 
            Header.BackColor = Color.Transparent;
            Header.Font = new Font("Montserrat", 24F, FontStyle.Bold);
            Header.Location = new Point(101, 50);
            Header.Name = "Header";
            Header.Size = new Size(432, 48);
            Header.TabIndex = 6;
            Header.Text = "Tambah Pelanggan Baru";
            Header.TextAlign = ContentAlignment.TopCenter;
            // 
            // Email
            // 
            Email.BackColor = Color.FromArgb(253, 233, 218);
            Email.BorderStyle = BorderStyle.None;
            Email.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Email.Location = new Point(115, 333);
            Email.Name = "Email";
            Email.Size = new Size(406, 30);
            Email.TabIndex = 7;
            // 
            // V_Ubah_Tambah_Pelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tambah_Ubah_Pelanggan1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(623, 590);
            Controls.Add(Email);
            Controls.Add(Header);
            Controls.Add(Nama);
            Controls.Add(Nomor_Telepon);
            Controls.Add(Alamat);
            Controls.Add(Simpan);
            Controls.Add(Batal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_Ubah_Tambah_Pelanggan";
            Text = "MeowInn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Batal;
        private Button Simpan;
        private TextBox Alamat;
        private TextBox Nomor_Telepon;
        private TextBox Nama;
        private Label Header;
        private TextBox Email;
    }
}