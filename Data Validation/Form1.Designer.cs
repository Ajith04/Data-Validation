namespace Data_Validation
{
    partial class frmloginpage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtusername = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtpassword = new TextBox();
            label4 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(212, 81);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(144, 23);
            txtusername.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(139, 178);
            button1.Name = "button1";
            button1.Size = new Size(154, 40);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(73, 76);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 0;
            label2.Text = "User Name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(73, 119);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 0;
            label3.Text = "Password : ";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(212, 124);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(144, 23);
            txtpassword.TabIndex = 2;
            txtpassword.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(138, 248);
            label4.Name = "label4";
            label4.Size = new Size(158, 19);
            label4.TabIndex = 3;
            label4.Text = "You haven't an account?";
            // 
            // button2
            // 
            button2.BackColor = Color.CadetBlue;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(123, 270);
            button2.Name = "button2";
            button2.Size = new Size(185, 36);
            button2.TabIndex = 4;
            button2.Text = "Create an account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmloginpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(433, 474);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmloginpage";
            Text = "Login Page";
            Load += frmloginpage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtusername;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtpassword;
        private Label label4;
        private Button button2;
    }
}
