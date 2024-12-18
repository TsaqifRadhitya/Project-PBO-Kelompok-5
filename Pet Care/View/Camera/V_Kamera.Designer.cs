﻿namespace Pet_Care.View
{
    partial class V_Kamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Kamera));
            frame_foto = new PictureBox();
            Shutter = new Button();
            Exit = new Button();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)frame_foto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // frame_foto
            // 
            frame_foto.Location = new Point(5, 50);
            frame_foto.Name = "frame_foto";
            frame_foto.Size = new Size(990, 557);
            frame_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            frame_foto.TabIndex = 0;
            frame_foto.TabStop = false;
            frame_foto.Paint += frame_foto_Paint;
            // 
            // Shutter
            // 
            Shutter.BackColor = Color.Transparent;
            Shutter.BackgroundImage = Properties.Resources.Shutter;
            Shutter.BackgroundImageLayout = ImageLayout.Zoom;
            Shutter.Enabled = false;
            Shutter.FlatAppearance.BorderSize = 0;
            Shutter.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Shutter.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Shutter.FlatStyle = FlatStyle.Flat;
            Shutter.Location = new Point(452, 608);
            Shutter.Name = "Shutter";
            Shutter.Size = new Size(96, 91);
            Shutter.TabIndex = 1;
            Shutter.UseVisualStyleBackColor = false;
            Shutter.Click += Shutter_Click;
            Shutter.MouseEnter += Shutter_MouseEnter;
            Shutter.MouseLeave += Shutter_MouseLeave;
            Shutter.MouseHover += Shutter_MouseHover;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Transparent;
            Exit.BackgroundImage = Properties.Resources.Close_camera;
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Location = new Point(880, 12);
            Exit.Name = "Exit";
            Exit.Size = new Size(108, 32);
            Exit.TabIndex = 2;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            Exit.MouseEnter += Exit_MouseEnter;
            Exit.MouseLeave += Exit_MouseLeave;
            Exit.MouseHover += Exit_MouseHover;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.drop_down;
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 35);
            panel1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 29);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // V_Kamera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Foto2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 700);
            Controls.Add(panel1);
            Controls.Add(Exit);
            Controls.Add(Shutter);
            Controls.Add(frame_foto);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_Kamera";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kamera";
            Load += Kamera_Load;
            ((System.ComponentModel.ISupportInitialize)frame_foto).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button Shutter;
        public PictureBox frame_foto;
        private Button Exit;
        private Panel panel1;
        private ComboBox comboBox1;
    }
}