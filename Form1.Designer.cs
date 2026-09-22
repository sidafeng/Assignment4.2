namespace Assignment4._2
{
    partial class Form1
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
            lblHeading = new Label();
            lblUserName = new Label();
            lblPw = new Label();
            txtUserName = new TextBox();
            txtPw = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Goudy Stout", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(46, 68);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(704, 51);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Teacher's Portal";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(250, 160);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(110, 25);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name:";
            // 
            // lblPw
            // 
            lblPw.AutoSize = true;
            lblPw.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblPw.Location = new Point(263, 223);
            lblPw.Name = "lblPw";
            lblPw.Size = new Size(97, 25);
            lblPw.TabIndex = 2;
            lblPw.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(366, 161);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(366, 221);
            txtPw.Name = "txtPw";
            txtPw.PasswordChar = '*';
            txtPw.Size = new Size(125, 27);
            txtPw.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(303, 301);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(171, 66);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPw);
            Controls.Add(txtUserName);
            Controls.Add(lblPw);
            Controls.Add(lblUserName);
            Controls.Add(lblHeading);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblUserName;
        private Label lblPw;
        private TextBox txtUserName;
        private TextBox txtPw;
        private Button btnLogin;
    }
}
