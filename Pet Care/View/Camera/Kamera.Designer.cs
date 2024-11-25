namespace Pet_Care.View
{
    partial class Kamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kamera));
            pictureBox1 = new PictureBox();
            Shutter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 562);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Shutter
            // 
            Shutter.BackColor = Color.Transparent;
            Shutter.BackgroundImage = Properties.Resources.Shutter;
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
            // Kamera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Foto;
            ClientSize = new Size(1000, 700);
            Controls.Add(Shutter);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Kamera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kamera";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Shutter;
    }
}