namespace Pet_Care.View
{
    partial class V_Transaksi
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
            Panel_Transaksi = new Panel();
            Berlangsung = new Button();
            Tambah_Transaksi = new Button();
            Selesai = new Button();
            SuspendLayout();
            // 
            // Panel_Transaksi
            // 
            Panel_Transaksi.BackColor = Color.Transparent;
            Panel_Transaksi.Location = new Point(75, 199);
            Panel_Transaksi.Name = "Panel_Transaksi";
            Panel_Transaksi.Size = new Size(850, 521);
            Panel_Transaksi.TabIndex = 0;
            // 
            // Berlangsung
            // 
            Berlangsung.BackColor = Color.Transparent;
            Berlangsung.BackgroundImage = Properties.Resources.Berlangsung_Focus;
            Berlangsung.FlatAppearance.BorderSize = 0;
            Berlangsung.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Berlangsung.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Berlangsung.FlatStyle = FlatStyle.Flat;
            Berlangsung.Location = new Point(75, 155);
            Berlangsung.Name = "Berlangsung";
            Berlangsung.Size = new Size(142, 44);
            Berlangsung.TabIndex = 1;
            Berlangsung.UseVisualStyleBackColor = false;
            Berlangsung.Click += Berlangsung_Click;
            Berlangsung.MouseHover += Berlangsung_MouseHover;
            // 
            // Tambah_Transaksi
            // 
            Tambah_Transaksi.BackColor = Color.Transparent;
            Tambah_Transaksi.BackgroundImage = Properties.Resources.Tambah_Transaksi;
            Tambah_Transaksi.FlatAppearance.BorderSize = 0;
            Tambah_Transaksi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Tambah_Transaksi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Tambah_Transaksi.FlatStyle = FlatStyle.Flat;
            Tambah_Transaksi.Location = new Point(753, 154);
            Tambah_Transaksi.Name = "Tambah_Transaksi";
            Tambah_Transaksi.Size = new Size(171, 48);
            Tambah_Transaksi.TabIndex = 3;
            Tambah_Transaksi.UseVisualStyleBackColor = false;
            Tambah_Transaksi.Click += Tambah_Transaksi_Click;
            Tambah_Transaksi.MouseEnter += Tambah_Transaksi_MouseEnter;
            Tambah_Transaksi.MouseLeave += Tambah_Transaksi_MouseLeave;
            Tambah_Transaksi.MouseHover += Tambah_Transaksi_MouseHover;
            // 
            // Selesai
            // 
            Selesai.BackColor = Color.Transparent;
            Selesai.BackgroundImage = Properties.Resources.Selesai;
            Selesai.FlatAppearance.BorderSize = 0;
            Selesai.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Selesai.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Selesai.FlatStyle = FlatStyle.Flat;
            Selesai.Location = new Point(215, 155);
            Selesai.Name = "Selesai";
            Selesai.Size = new Size(142, 44);
            Selesai.TabIndex = 4;
            Selesai.UseVisualStyleBackColor = false;
            Selesai.Click += Selesai_Click;
            Selesai.MouseHover += Selesai_MouseHover;
            // 
            // V_Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Transaksi1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Selesai);
            Controls.Add(Panel_Transaksi);
            Controls.Add(Berlangsung);
            Controls.Add(Tambah_Transaksi);
            DoubleBuffered = true;
            Name = "V_Transaksi";
            Size = new Size(1000, 720);
            ResumeLayout(false);
        }

        #endregion
        private Button Berlangsung;
        private Button Tambah_Transaksi;
        private Button Selesai;
        public Panel Panel_Transaksi;
    }
}
