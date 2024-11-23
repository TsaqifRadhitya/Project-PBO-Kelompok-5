namespace Pet_Care.View
{
    partial class V_Ubah_Tambah_Layanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Ubah_Tambah_Layanan));
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            Simpan = new Button();
            Batal = new Button();
            Header = new Label();
            Nama_Layanan = new TextBox();
            Harga = new TextBox();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.FlatAppearance.BorderColor = Color.FromArgb(217, 217, 217);
            radioButton1.FlatAppearance.BorderSize = 5;
            radioButton1.FlatAppearance.CheckedBackColor = Color.FromArgb(131, 94, 146);
            radioButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            radioButton1.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(100, 324);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(170, 20);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "   Satu Kali Pembayaran";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.FlatAppearance.BorderColor = Color.FromArgb(217, 217, 217);
            radioButton2.FlatAppearance.BorderSize = 5;
            radioButton2.FlatAppearance.CheckedBackColor = Color.FromArgb(131, 94, 146);
            radioButton2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            radioButton2.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(389, 324);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 20);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "   Berdasarkan Hari";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // Simpan
            // 
            Simpan.BackColor = Color.Transparent;
            Simpan.BackgroundImage = Properties.Resources.Simpan_Hover;
            Simpan.FlatAppearance.BorderSize = 0;
            Simpan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Simpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Simpan.FlatStyle = FlatStyle.Flat;
            Simpan.Location = new Point(379, 371);
            Simpan.Name = "Simpan";
            Simpan.Size = new Size(153, 54);
            Simpan.TabIndex = 3;
            Simpan.UseVisualStyleBackColor = false;
            Simpan.Click += Simpan_Click;
            Simpan.MouseEnter += Simpan_MouseEnter;
            Simpan.MouseLeave += Simpan_MouseLeave;
            Simpan.MouseHover += Simpan_MouseHover;
            // 
            // Batal
            // 
            Batal.BackColor = Color.Transparent;
            Batal.BackgroundImage = Properties.Resources.Batal_Hover;
            Batal.FlatAppearance.BorderSize = 0;
            Batal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Batal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Batal.FlatStyle = FlatStyle.Flat;
            Batal.Location = new Point(100, 371);
            Batal.Name = "Batal";
            Batal.Size = new Size(153, 54);
            Batal.TabIndex = 2;
            Batal.UseVisualStyleBackColor = false;
            Batal.Click += Batal_Click;
            Batal.MouseEnter += Batal_MouseEnter;
            Batal.MouseLeave += Batal_MouseLeave;
            Batal.MouseHover += Batal_MouseHover;
            // 
            // Header
            // 
            Header.BackColor = Color.Transparent;
            Header.Font = new Font("Montserrat", 24F, FontStyle.Bold);
            Header.Location = new Point(81, 43);
            Header.Name = "Header";
            Header.Size = new Size(432, 48);
            Header.TabIndex = 7;
            Header.Text = "Tambah Pelanggan Baru";
            Header.TextAlign = ContentAlignment.TopCenter;
            // 
            // Nama_Layanan
            // 
            Nama_Layanan.BackColor = Color.FromArgb(253, 233, 218);
            Nama_Layanan.BorderStyle = BorderStyle.None;
            Nama_Layanan.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Nama_Layanan.Location = new Point(108, 151);
            Nama_Layanan.Name = "Nama_Layanan";
            Nama_Layanan.Size = new Size(406, 30);
            Nama_Layanan.TabIndex = 9;
            // 
            // Harga
            // 
            Harga.BackColor = Color.FromArgb(253, 233, 218);
            Harga.BorderStyle = BorderStyle.None;
            Harga.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Harga.Location = new Point(108, 240);
            Harga.Name = "Harga";
            Harga.Size = new Size(406, 30);
            Harga.TabIndex = 8;
            Harga.TextChanged += Harga_TextChanged;
            // 
            // V_Ubah_Tambah_Layanan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tambah_Ubah_Layanan1;
            ClientSize = new Size(623, 453);
            Controls.Add(Nama_Layanan);
            Controls.Add(Harga);
            Controls.Add(Header);
            Controls.Add(Simpan);
            Controls.Add(Batal);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_Ubah_Tambah_Layanan";
            StartPosition = FormStartPosition.Manual;
            Text = "MeowInn";
            Load += V_Ubah_Tambah_Layanan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button Simpan;
        private Button Batal;
        private Label Header;
        private TextBox Nama_Layanan;
        private TextBox Harga;
    }
}