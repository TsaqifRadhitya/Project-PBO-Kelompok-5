namespace Pet_Care.View
{
    partial class V_Transaksi_Berlangsung
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            button1 = new Button();
            Selesai = new Button();
            Delete = new Button();
            Harga = new Label();
            pictureBox1 = new PictureBox();
            Pesan = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(850, 521);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.BG_Card;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Selesai);
            panel1.Controls.Add(Delete);
            panel1.Controls.Add(Harga);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Pesan);
            panel1.Location = new Point(21, 21);
            panel1.Margin = new Padding(21, 21, 0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 248);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Detail;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(215, 17);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // Selesai
            // 
            Selesai.BackgroundImage = Properties.Resources.Selesai_Card;
            Selesai.FlatAppearance.BorderSize = 0;
            Selesai.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Selesai.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Selesai.FlatStyle = FlatStyle.Flat;
            Selesai.Location = new Point(136, 186);
            Selesai.Name = "Selesai";
            Selesai.Size = new Size(114, 44);
            Selesai.TabIndex = 2;
            Selesai.UseVisualStyleBackColor = true;
            Selesai.Click += Selesai_Click;
            Selesai.MouseEnter += Selesai_MouseEnter;
            Selesai.MouseLeave += Selesai_MouseLeave;
            Selesai.MouseHover += Selesai_MouseHover;
            // 
            // Delete
            // 
            Delete.BackgroundImage = Properties.Resources.Cancel1;
            Delete.FlatAppearance.BorderSize = 0;
            Delete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Delete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Location = new Point(214, 149);
            Delete.Name = "Delete";
            Delete.Size = new Size(32, 32);
            Delete.TabIndex = 3;
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            Delete.MouseEnter += Delete_MouseEnter;
            Delete.MouseLeave += Delete_MouseLeave;
            Delete.MouseHover += Delete_MouseHover;
            // 
            // Harga
            // 
            Harga.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Harga.Location = new Point(12, 153);
            Harga.Name = "Harga";
            Harga.Size = new Size(195, 23);
            Harga.TabIndex = 1;
            Harga.Text = "Total : Rp50.000,00";
            Harga.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Test_Picture;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Pesan
            // 
            Pesan.BackgroundImage = Properties.Resources.Message;
            Pesan.FlatAppearance.BorderSize = 0;
            Pesan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Pesan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Pesan.FlatStyle = FlatStyle.Flat;
            Pesan.Location = new Point(12, 186);
            Pesan.Name = "Pesan";
            Pesan.Size = new Size(114, 44);
            Pesan.TabIndex = 1;
            Pesan.UseVisualStyleBackColor = true;
            Pesan.MouseEnter += Pesan_MouseEnter;
            Pesan.MouseLeave += Pesan_MouseLeave;
            Pesan.MouseHover += Pesan_MouseHover;
            // 
            // V_Transaksi_Berlangsung
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.BG_Berlangsung;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Name = "V_Transaksi_Berlangsung";
            Size = new Size(850, 521);
            Load += V_Transaksi_Berlangsung_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button Delete;
        private Button Selesai;
        private Label Harga;
        private Button Pesan;
        private Button button1;
        public FlowLayoutPanel flowLayoutPanel1;
    }
}
