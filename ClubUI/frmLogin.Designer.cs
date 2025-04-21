namespace ClubUI
{
    partial class frmLogin
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
            buttonLogin = new Button();
            buttonCancel = new Button();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(78, 260);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(115, 29);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "تسجيل الدخول";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(199, 260);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(113, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "إلغاء الأمر";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(78, 160);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(234, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(78, 204);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(234, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 452);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Button buttonCancel;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
    }
}