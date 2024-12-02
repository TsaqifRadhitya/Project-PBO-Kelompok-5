namespace Pet_Care.View.Transaksi
{
    partial class V_Send_Message
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
            foto = new PictureBox();
            Pesan = new RichTextBox();
            Kirim = new Button();
            Batal = new Button();
            ((System.ComponentModel.ISupportInitialize)foto).BeginInit();
            SuspendLayout();
            // 
            // foto
            // 
            foto.BackColor = Color.Transparent;
            foto.Cursor = Cursors.Hand;
            foto.Location = new Point(127, 79);
            foto.Name = "foto";
            foto.Size = new Size(362, 204);
            foto.SizeMode = PictureBoxSizeMode.StretchImage;
            foto.TabIndex = 1;
            foto.TabStop = false;
            foto.Click += foto_Click;
            // 
            // Pesan
            // 
            Pesan.BackColor = Color.FromArgb(253, 233, 218);
            Pesan.BorderStyle = BorderStyle.None;
            Pesan.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Pesan.Location = new Point(76, 344);
            Pesan.Name = "Pesan";
            Pesan.Size = new Size(468, 127);
            Pesan.TabIndex = 12;
            Pesan.Text = "";
            // 
            // Kirim
            // 
            Kirim.BackColor = Color.Transparent;
            Kirim.BackgroundImage = Properties.Resources.Kirim;
            Kirim.BackgroundImageLayout = ImageLayout.Stretch;
            Kirim.Cursor = Cursors.Hand;
            Kirim.FlatAppearance.BorderSize = 0;
            Kirim.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Kirim.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Kirim.FlatStyle = FlatStyle.Flat;
            Kirim.Location = new Point(416, 506);
            Kirim.Name = "Kirim";
            Kirim.Size = new Size(153, 54);
            Kirim.TabIndex = 18;
            Kirim.UseVisualStyleBackColor = false;
            Kirim.Click += Kirim_Click;
            Kirim.MouseEnter += Kirim_MouseEnter;
            Kirim.MouseLeave += Kirim_MouseLeave;
            // 
            // Batal
            // 
            Batal.BackColor = Color.Transparent;
            Batal.BackgroundImage = Properties.Resources.Batal_Hover;
            Batal.BackgroundImageLayout = ImageLayout.Stretch;
            Batal.Cursor = Cursors.Hand;
            Batal.FlatAppearance.BorderSize = 0;
            Batal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Batal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Batal.FlatStyle = FlatStyle.Flat;
            Batal.Location = new Point(55, 506);
            Batal.Name = "Batal";
            Batal.Size = new Size(153, 54);
            Batal.TabIndex = 17;
            Batal.UseVisualStyleBackColor = false;
            Batal.Click += Kembali_Click;
            Batal.MouseEnter += Batal_MouseEnter;
            Batal.MouseLeave += Batal_MouseLeave;
            // 
            // V_Send_Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pesan;
            Controls.Add(Kirim);
            Controls.Add(Batal);
            Controls.Add(Pesan);
            Controls.Add(foto);
            Name = "V_Send_Message";
            Size = new Size(623, 590);
            ((System.ComponentModel.ISupportInitialize)foto).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public PictureBox foto;
        public RichTextBox Pesan;
        private Button Kirim;
        private Button Batal;
    }
}
