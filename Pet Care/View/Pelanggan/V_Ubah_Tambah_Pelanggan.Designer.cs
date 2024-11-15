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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Batal
            // 
            Batal.BackColor = Color.Transparent;
            Batal.BackgroundImage = Properties.Resources.Batal;
            Batal.FlatAppearance.BorderSize = 0;
            Batal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Batal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Batal.FlatStyle = FlatStyle.Flat;
            Batal.Location = new Point(101, 466);
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
            Simpan.BackgroundImage = Properties.Resources.Simpan;
            Simpan.FlatAppearance.BorderSize = 0;
            Simpan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Simpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Simpan.FlatStyle = FlatStyle.Flat;
            Simpan.Location = new Point(380, 466);
            Simpan.Name = "Simpan";
            Simpan.Size = new Size(153, 54);
            Simpan.TabIndex = 1;
            Simpan.UseVisualStyleBackColor = false;
            Simpan.Click += Simpan_Click;
            Simpan.MouseEnter += Simpan_MouseEnter;
            Simpan.MouseLeave += Simpan_MouseLeave;
            Simpan.MouseHover += Simpan_MouseHover;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(116, 367);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(406, 16);
            textBox1.TabIndex = 2;
            // 
            // V_Ubah_Tambah_Pelanggan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tambah_Ubah_Pelanggan;
            ClientSize = new Size(623, 590);
            Controls.Add(textBox1);
            Controls.Add(Simpan);
            Controls.Add(Batal);
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
        private TextBox textBox1;
    }
}