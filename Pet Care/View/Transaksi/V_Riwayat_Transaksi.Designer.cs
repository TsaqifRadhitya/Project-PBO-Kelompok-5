namespace Pet_Care.View
{
    partial class V_Riwayat_Transaksi
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Tabel_Riwayat = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Tabel_Riwayat).BeginInit();
            SuspendLayout();
            // 
            // Tabel_Riwayat
            // 
            Tabel_Riwayat.AllowUserToAddRows = false;
            Tabel_Riwayat.AllowUserToDeleteRows = false;
            Tabel_Riwayat.AllowUserToResizeColumns = false;
            Tabel_Riwayat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 246, 245);
            dataGridViewCellStyle1.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(163, 162, 167);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 246, 245);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(163, 162, 167);
            Tabel_Riwayat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Tabel_Riwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Tabel_Riwayat.BackgroundColor = Color.FromArgb(131, 94, 146);
            Tabel_Riwayat.BorderStyle = BorderStyle.None;
            Tabel_Riwayat.CellBorderStyle = DataGridViewCellBorderStyle.None;
            Tabel_Riwayat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 49, 78);
            dataGridViewCellStyle2.Font = new Font("Montserrat SemiBold", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 225, 233);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 49, 78);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(226, 225, 233);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Tabel_Riwayat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Tabel_Riwayat.ColumnHeadersHeight = 60;
            Tabel_Riwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(163, 162, 167);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(163, 162, 167);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Tabel_Riwayat.DefaultCellStyle = dataGridViewCellStyle3;
            Tabel_Riwayat.EnableHeadersVisualStyles = false;
            Tabel_Riwayat.Location = new Point(0, 0);
            Tabel_Riwayat.Name = "Tabel_Riwayat";
            Tabel_Riwayat.ReadOnly = true;
            Tabel_Riwayat.RowHeadersVisible = false;
            Tabel_Riwayat.RowTemplate.Height = 50;
            Tabel_Riwayat.Size = new Size(850, 521);
            Tabel_Riwayat.TabIndex = 0;
            Tabel_Riwayat.CellClick += dataGridView1_CellContentClick;
            // 
            // V_Riwayat_Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.BG_Selesai;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Tabel_Riwayat);
            DoubleBuffered = true;
            Name = "V_Riwayat_Transaksi";
            Size = new Size(850, 521);
            Load += V_Riwayat_Transaksi_Load;
            ((System.ComponentModel.ISupportInitialize)Tabel_Riwayat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView Tabel_Riwayat;
    }
}
