namespace Pet_Care.View.Splash_Screen
{
    partial class Splash_Screen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_Screen));
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Frame_1;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 300);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splash_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 300);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Splash_Screen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MeowInn";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}