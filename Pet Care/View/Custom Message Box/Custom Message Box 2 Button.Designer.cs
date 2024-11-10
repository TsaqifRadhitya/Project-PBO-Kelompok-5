namespace Pet_Care.View
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
            Cancel = new Button();
            Confirm = new Button();
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
            // Cancel
            // 
            Cancel.BackColor = Color.White;
            Cancel.BackgroundImage = Properties.Resources.Cancel;
            Cancel.FlatAppearance.BorderSize = 0;
            Cancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Cancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.Location = new Point(100, 173);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(150, 51);
            Cancel.TabIndex = 6;
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            Cancel.MouseEnter += Cancel_MouseEnter;
            Cancel.MouseLeave += Cancel_MouseLeave;
            Cancel.MouseHover += Cancel_MouseHover;
            // 
            // Confirm
            // 
            Confirm.BackColor = Color.White;
            Confirm.BackgroundImage = Properties.Resources.Confirm;
            Confirm.FlatAppearance.BorderSize = 0;
            Confirm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Confirm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Confirm.FlatStyle = FlatStyle.Flat;
            Confirm.Location = new Point(250, 173);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(150, 51);
            Confirm.TabIndex = 7;
            Confirm.UseVisualStyleBackColor = false;
            Confirm.Click += Confirm_Click;
            Confirm.MouseEnter += Confirm_MouseEnter;
            Confirm.MouseLeave += Confirm_MouseLeave;
            Confirm.MouseHover += Confirm_MouseHover;
            // 
            // Custom_Message_Box_2_Button
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 250);
            Controls.Add(Confirm);
            Controls.Add(Cancel);
            Controls.Add(Message);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Custom_Message_Box_2_Button";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Custom_Message_Box_2_Button";
            Load += Custom_Message_Box_2_Button_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Message;
        private Button Cancel;
        private Button Confirm;
    }
}