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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
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
            Tambah.BackgroundImageLayout = ImageLayout.Stretch;
            Tambah.Cursor = Cursors.Hand;
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
            // 
            // Tabel_Layanan
            // 
            Tabel_Layanan.AllowUserToAddRows = false;
            Tabel_Layanan.AllowUserToDeleteRows = false;
            Tabel_Layanan.AllowUserToResizeColumns = false;
            Tabel_Layanan.AllowUserToResizeRows = false;
            Tabel_Layanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabel_Layanan.BackgroundColor = Color.FromArgb(253, 233, 218);
            Tabel_Layanan.BorderStyle = BorderStyle.None;
            Tabel_Layanan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Tabel_Layanan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(131, 94, 146);
            dataGridViewCellStyle1.Font = new Font("Montserrat", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(131, 94, 146);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(131, 94, 146);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Tabel_Layanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Tabel_Layanan.ColumnHeadersHeight = 40;
            Tabel_Layanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(253, 233, 218);
            dataGridViewCellStyle2.Font = new Font("Montserrat Medium", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(253, 233, 218);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Tabel_Layanan.DefaultCellStyle = dataGridViewCellStyle2;
            Tabel_Layanan.EnableHeadersVisualStyles = false;
            Tabel_Layanan.GridColor = Color.FromArgb(202, 185, 174);
            Tabel_Layanan.Location = new Point(6, 56);
            Tabel_Layanan.Name = "Tabel_Layanan";
            Tabel_Layanan.ReadOnly = true;
            Tabel_Layanan.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Tabel_Layanan.RowHeadersVisible = false;
            Tabel_Layanan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Tabel_Layanan.RowTemplate.Height = 30;
            Tabel_Layanan.ScrollBars = ScrollBars.Vertical;
            Tabel_Layanan.Size = new Size(847, 479);
            Tabel_Layanan.TabIndex = 0;
            Tabel_Layanan.CellContentClick += dataGridView1_CellContentClick;
            // 
            // V_Layanan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Layanan1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "V_Layanan";
            Size = new Size(1000, 720);
            Load += V_Layanan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Tabel_Layanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Tambah;
        public DataGridView Tabel_Layanan;
    }
}
