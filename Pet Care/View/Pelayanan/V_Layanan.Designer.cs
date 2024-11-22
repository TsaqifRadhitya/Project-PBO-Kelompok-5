namespace Pet_Care.View
{
    partial class V_Layanan
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
            panel1 = new Panel();
            Tambah = new Button();
            Tabel_Layanan = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Tabel_Layanan).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.BG_Tabel;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(Tambah);
            panel1.Controls.Add(Tabel_Layanan);
            panel1.Location = new Point(75, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 544);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Tambah
            // 
            Tambah.BackgroundImage = Properties.Resources.Tambah;
            Tambah.FlatAppearance.BorderSize = 0;
            Tambah.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Tambah.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Tambah.FlatStyle = FlatStyle.Flat;
            Tambah.Location = new Point(686, 8);
            Tambah.Name = "Tambah";
            Tambah.Size = new Size(161, 48);
            Tambah.TabIndex = 1;
            Tambah.UseVisualStyleBackColor = true;
            Tambah.Click += Tambah_Click;
            Tambah.MouseEnter += Tambah_MouseEnter;
            Tambah.MouseLeave += Tambah_MouseLeave;
            Tambah.MouseHover += Tambah_MouseHover;
            // 
            // Tabel_Layanan
            // 
            Tabel_Layanan.AllowUserToAddRows = false;
            Tabel_Layanan.AllowUserToDeleteRows = false;
            Tabel_Layanan.AllowUserToResizeColumns = false;
            Tabel_Layanan.AllowUserToResizeRows = false;
            Tabel_Layanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabel_Layanan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Tabel_Layanan.BackgroundColor = Color.FromArgb(253, 233, 218);
            Tabel_Layanan.BorderStyle = BorderStyle.None;
            Tabel_Layanan.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Tabel_Layanan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Tabel_Layanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Tabel_Layanan.GridColor = Color.White;
            Tabel_Layanan.Location = new Point(6, 56);
            Tabel_Layanan.Name = "Tabel_Layanan";
            Tabel_Layanan.ReadOnly = true;
            Tabel_Layanan.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Tabel_Layanan.RowHeadersVisible = false;
            Tabel_Layanan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Tabel_Layanan.Size = new Size(847, 479);
            Tabel_Layanan.TabIndex = 0;
            Tabel_Layanan.CellContentClick += dataGridView1_CellContentClick;
            // 
            // V_Layanan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Layanan1;
            Controls.Add(panel1);
            Name = "V_Layanan";
            Size = new Size(1000, 720);
            Load += V_Layanan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabel_Layanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView Tabel_Layanan;
        private Button Tambah;
    }
}
