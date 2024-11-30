namespace Pet_Care.View
{
    partial class V_Form_Transaksi
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
            Durasi = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Total_Pembayaran = new Label();
            Lanjut = new Button();
            Kembali = new Button();
            E_Wallet = new RadioButton();
            Tunai = new RadioButton();
            radioButton1 = new RadioButton();
            Metode_Pembayaran = new Panel();
            Metode_Pembayaran.SuspendLayout();
            SuspendLayout();
            // 
            // Durasi
            // 
            Durasi.BackColor = Color.FromArgb(253, 233, 218);
            Durasi.BorderStyle = BorderStyle.None;
            Durasi.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Durasi.Location = new Point(115, 126);
            Durasi.Name = "Durasi";
            Durasi.Size = new Size(406, 30);
            Durasi.TabIndex = 10;
            Durasi.TextChanged += ID_Pelanggan_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(92, 219);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(451, 100);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // Total_Pembayaran
            // 
            Total_Pembayaran.BackColor = Color.Transparent;
            Total_Pembayaran.Font = new Font("Montserrat", 14F, FontStyle.Bold);
            Total_Pembayaran.Location = new Point(92, 424);
            Total_Pembayaran.Name = "Total_Pembayaran";
            Total_Pembayaran.Size = new Size(451, 31);
            Total_Pembayaran.TabIndex = 0;
            Total_Pembayaran.Text = "Total Pembayaran : ";
            Total_Pembayaran.TextAlign = ContentAlignment.MiddleLeft;
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
            Lanjut.Location = new Point(390, 492);
            Lanjut.Name = "Lanjut";
            Lanjut.Size = new Size(153, 54);
            Lanjut.TabIndex = 16;
            Lanjut.UseVisualStyleBackColor = false;
            Lanjut.Click += Lanjut_Click;
            Lanjut.MouseEnter += Lanjut_MouseEnter;
            Lanjut.MouseLeave += Lanjut_MouseLeave;
            Lanjut.MouseHover += Lanjut_MouseHover;
            // 
            // Kembali
            // 
            Kembali.BackColor = Color.Transparent;
            Kembali.BackgroundImage = Properties.Resources.Kembali;
            Kembali.BackgroundImageLayout = ImageLayout.Stretch;
            Kembali.FlatAppearance.BorderSize = 0;
            Kembali.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Kembali.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Kembali.FlatStyle = FlatStyle.Flat;
            Kembali.Location = new Point(92, 492);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(153, 54);
            Kembali.TabIndex = 15;
            Kembali.UseVisualStyleBackColor = false;
            Kembali.Click += Kembali_Click;
            Kembali.MouseEnter += Kembali_MouseEnter;
            Kembali.MouseLeave += Kembali_MouseLeave;
            Kembali.MouseHover += Kembali_MouseHover;
            // 
            // E_Wallet
            // 
            E_Wallet.AutoSize = true;
            E_Wallet.BackColor = Color.Transparent;
            E_Wallet.FlatAppearance.BorderColor = Color.FromArgb(217, 217, 217);
            E_Wallet.FlatAppearance.BorderSize = 5;
            E_Wallet.FlatAppearance.CheckedBackColor = Color.FromArgb(131, 94, 146);
            E_Wallet.FlatAppearance.MouseDownBackColor = Color.Transparent;
            E_Wallet.FlatAppearance.MouseOverBackColor = Color.Transparent;
            E_Wallet.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            E_Wallet.Location = new Point(157, 17);
            E_Wallet.Name = "E_Wallet";
            E_Wallet.Size = new Size(88, 20);
            E_Wallet.TabIndex = 12;
            E_Wallet.Text = "   E-Wallet";
            E_Wallet.UseVisualStyleBackColor = false;
            // 
            // Tunai
            // 
            Tunai.AutoSize = true;
            Tunai.BackColor = Color.Transparent;
            Tunai.FlatAppearance.BorderColor = Color.FromArgb(217, 217, 217);
            Tunai.FlatAppearance.BorderSize = 5;
            Tunai.FlatAppearance.CheckedBackColor = Color.FromArgb(131, 94, 146);
            Tunai.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Tunai.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Tunai.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tunai.Location = new Point(6, 17);
            Tunai.Name = "Tunai";
            Tunai.Size = new Size(68, 20);
            Tunai.TabIndex = 11;
            Tunai.Text = "   Tunai";
            Tunai.UseVisualStyleBackColor = false;
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
            radioButton1.Location = new Point(326, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(119, 20);
            radioButton1.TabIndex = 13;
            radioButton1.Text = "   Transfer Bank";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // Metode_Pembayaran
            // 
            Metode_Pembayaran.BackColor = Color.Transparent;
            Metode_Pembayaran.Controls.Add(radioButton1);
            Metode_Pembayaran.Controls.Add(E_Wallet);
            Metode_Pembayaran.Controls.Add(Tunai);
            Metode_Pembayaran.Location = new Point(92, 347);
            Metode_Pembayaran.Name = "Metode_Pembayaran";
            Metode_Pembayaran.Size = new Size(451, 50);
            Metode_Pembayaran.TabIndex = 13;
            // 
            // V_Form_Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Transaksi_Lanjutan1;
            Controls.Add(Lanjut);
            Controls.Add(Kembali);
            Controls.Add(Total_Pembayaran);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Metode_Pembayaran);
            Controls.Add(Durasi);
            Name = "V_Form_Transaksi";
            Size = new Size(623, 590);
            Load += V_Form_Transaksi_Load;
            Metode_Pembayaran.ResumeLayout(false);
            Metode_Pembayaran.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Lanjut;
        private Button Kembali;
        private RadioButton E_Wallet;
        private RadioButton Tunai;
        private RadioButton radioButton1;
        public Label Total_Pembayaran;
        public FlowLayoutPanel flowLayoutPanel1;
        public TextBox Durasi;
        public Panel Metode_Pembayaran;
    }
}
