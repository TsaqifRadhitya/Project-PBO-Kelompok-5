namespace Pet_Care.View
{
    partial class V_Gallery_Kucing
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
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Location = new Point(69, 123);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(862, 597);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // V_Gallery_Kucing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Gallery_Kucing;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Name = "V_Gallery_Kucing";
            Size = new Size(1000, 720);
            Load += V_Gallery_Kucing_Load;
            ResumeLayout(false);
        }

        #endregion
        public FlowLayoutPanel flowLayoutPanel1;
    }
}
