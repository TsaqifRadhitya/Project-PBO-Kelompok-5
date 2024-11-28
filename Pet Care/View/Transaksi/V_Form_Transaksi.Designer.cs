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
            ID_Pelanggan = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioButton2 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            Total_Pembayaran = new Label();
            Lanjut = new Button();
            Kembali = new Button();
            E_Wallet = new RadioButton();
            Tunai = new RadioButton();
            radioButton1 = new RadioButton();
            Metode_Pembayaran = new Panel();
            flowLayoutPanel1.SuspendLayout();
            Metode_Pembayaran.SuspendLayout();
            SuspendLayout();
            // 
            // ID_Pelanggan
            // 
            ID_Pelanggan.BackColor = Color.FromArgb(253, 233, 218);
            ID_Pelanggan.BorderStyle = BorderStyle.None;
            ID_Pelanggan.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            ID_Pelanggan.Location = new Point(115, 126);
            ID_Pelanggan.Name = "ID_Pelanggan";
            ID_Pelanggan.Size = new Size(406, 30);
            ID_Pelanggan.TabIndex = 10;
            ID_Pelanggan.TextChanged += ID_Pelanggan_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(radioButton2);
            flowLayoutPanel1.Controls.Add(radioButton4);
            flowLayoutPanel1.Controls.Add(radioButton3);
            flowLayoutPanel1.Location = new Point(92, 219);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(451, 100);
            flowLayoutPanel1.TabIndex = 14;
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
            radioButton2.Location = new Point(3, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(119, 20);
            radioButton2.TabIndex = 16;
            radioButton2.Text = "   Transfer Bank";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.FlatAppearance.BorderColor = Color.FromArgb(217, 217, 217);
            radioButton4.FlatAppearance.BorderSize = 5;
            radioButton4.FlatAppearance.CheckedBackColor = Color.FromArgb(131, 94, 146);
            radioButton4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            radioButton4.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton4.Location = new Point(128, 3);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 20);
            radioButton4.TabIndex = 14;
            radioButton4.Text = "   Tunai";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.FlatAppearance.BorderColor = Color.FromArgb(217, 217, 217);
            radioButton3.FlatAppearance.BorderSize = 5;
            radioButton3.FlatAppearance.CheckedBackColor = Color.FromArgb(131, 94, 146);
            radioButton3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            radioButton3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            radioButton3.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(202, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(89, 20);
            radioButton3.TabIndex = 15;
            radioButton3.Text = "   E_Wallet";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // Total_Pembayaran
            // 
            Total_Pembayaran.BackColor = Color.Transparent;
            Total_Pembayaran.Font = new Font("Montserrat", 14F, FontStyle.Bold);
            Total_Pembayaran.Location = new Point(92, 424);
            Total_Pembayaran.Name = "Total_Pembayaran";
            Total_Pembayaran.Size = new Size(451, 31);
            Total_Pembayaran.TabIndex = 0;
            Total_Pembayaran.Text = "Total Pembayaran : Rp.100.000,00";
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
            E_Wallet.Size = new Size(89, 20);
            E_Wallet.TabIndex = 12;
            E_Wallet.Text = "   E_Wallet";
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
            Controls.Add(ID_Pelanggan);
            Name = "V_Form_Transaksi";
            Size = new Size(623, 590);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            Metode_Pembayaran.ResumeLayout(false);
            Metode_Pembayaran.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ID_Pelanggan;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Total_Pembayaran;
        private Button Lanjut;
        private Button Kembali;
        private RadioButton E_Wallet;
        private RadioButton Tunai;
        private RadioButton radioButton1;
        private Panel Metode_Pembayaran;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}
