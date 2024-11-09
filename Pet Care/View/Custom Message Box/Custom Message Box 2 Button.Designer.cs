namespace Pet_Care.View.Custom_Message_Box
{
    partial class Custom_Message_Box_2_Button
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
            Message = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Message
            // 
            Message.BackColor = Color.Transparent;
            Message.Font = new Font("Montserrat SemiBold", 18F, FontStyle.Bold);
            Message.Location = new Point(12, 88);
            Message.Name = "Message";
            Message.Size = new Size(476, 66);
            Message.TabIndex = 5;
            Message.Text = "Message";
            Message.TextAlign = ContentAlignment.TopCenter;
            Message.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            button1.Location = new Point(100, 173);
            button1.Name = "button1";
            button1.Size = new Size(150, 51);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(256, 173);
            button2.Name = "button2";
            button2.Size = new Size(150, 51);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Custom_Message_Box_2_Button
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 250);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Message);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Custom_Message_Box_2_Button";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Custom_Message_Box_2_Button";
            ResumeLayout(false);
        }

        #endregion

        private Label Message;
        private Button button1;
        private Button button2;
    }
}