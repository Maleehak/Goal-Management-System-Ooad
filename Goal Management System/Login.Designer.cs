namespace Proooooooooooject
{
    partial class Login
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
            this.btnSUlogin = new System.Windows.Forms.Button();
            this.lblPLogIn = new System.Windows.Forms.Label();
            this.btnForgetPassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.txtPLogIn = new System.Windows.Forms.TextBox();
            this.txtusrLogIn = new System.Windows.Forms.TextBox();
            this.btnlogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSUlogin
            // 
            this.btnSUlogin.Location = new System.Drawing.Point(315, 301);
            this.btnSUlogin.Name = "btnSUlogin";
            this.btnSUlogin.Size = new System.Drawing.Size(75, 23);
            this.btnSUlogin.TabIndex = 16;
            this.btnSUlogin.Text = "Sign up";
            this.btnSUlogin.UseVisualStyleBackColor = true;
            this.btnSUlogin.Click += new System.EventHandler(this.btnSUlogin_Click);
            // 
            // lblPLogIn
            // 
            this.lblPLogIn.AutoSize = true;
            this.lblPLogIn.Location = new System.Drawing.Point(132, 146);
            this.lblPLogIn.Name = "lblPLogIn";
            this.lblPLogIn.Size = new System.Drawing.Size(53, 13);
            this.lblPLogIn.TabIndex = 15;
            this.lblPLogIn.Text = "Password";
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.Location = new System.Drawing.Point(315, 254);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(96, 32);
            this.btnForgetPassword.TabIndex = 14;
            this.btnForgetPassword.Text = "Forget Password";
            this.btnForgetPassword.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Location = new System.Drawing.Point(126, 81);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(60, 13);
            this.lblUserLogin.TabIndex = 12;
            this.lblUserLogin.Text = "User Name";
            // 
            // txtPLogIn
            // 
            this.txtPLogIn.Location = new System.Drawing.Point(225, 141);
            this.txtPLogIn.Name = "txtPLogIn";
            this.txtPLogIn.Size = new System.Drawing.Size(100, 20);
            this.txtPLogIn.TabIndex = 11;
            // 
            // txtusrLogIn
            // 
            this.txtusrLogIn.Location = new System.Drawing.Point(225, 74);
            this.txtusrLogIn.Name = "txtusrLogIn";
            this.txtusrLogIn.Size = new System.Drawing.Size(100, 20);
            this.txtusrLogIn.TabIndex = 10;
            // 
            // btnlogIn
            // 
            this.btnlogIn.Location = new System.Drawing.Point(215, 204);
            this.btnlogIn.Name = "btnlogIn";
            this.btnlogIn.Size = new System.Drawing.Size(75, 32);
            this.btnlogIn.TabIndex = 9;
            this.btnlogIn.Text = "Log In";
            this.btnlogIn.UseVisualStyleBackColor = true;
            this.btnlogIn.Click += new System.EventHandler(this.btnlogIn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 429);
            this.Controls.Add(this.btnSUlogin);
            this.Controls.Add(this.lblPLogIn);
            this.Controls.Add(this.btnForgetPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserLogin);
            this.Controls.Add(this.txtPLogIn);
            this.Controls.Add(this.txtusrLogIn);
            this.Controls.Add(this.btnlogIn);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSUlogin;
        private System.Windows.Forms.Label lblPLogIn;
        private System.Windows.Forms.Button btnForgetPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.TextBox txtPLogIn;
        private System.Windows.Forms.TextBox txtusrLogIn;
        private System.Windows.Forms.Button btnlogIn;
    }
}