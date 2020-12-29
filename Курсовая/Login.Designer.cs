namespace Курсовая
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signIn_Login = new System.Windows.Forms.Button();
            this.loginTextBox_Login = new System.Windows.Forms.TextBox();
            this.passwordTextBox_Login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вітаємо, шановний користувачу!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логін";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // signIn_Login
            // 
            this.signIn_Login.Location = new System.Drawing.Point(157, 199);
            this.signIn_Login.Name = "signIn_Login";
            this.signIn_Login.Size = new System.Drawing.Size(75, 23);
            this.signIn_Login.TabIndex = 3;
            this.signIn_Login.Text = "Увійти";
            this.signIn_Login.UseVisualStyleBackColor = true;
            this.signIn_Login.Click += new System.EventHandler(this.signIn_Login_Click);
            // 
            // loginTextBox_Login
            // 
            this.loginTextBox_Login.Location = new System.Drawing.Point(128, 72);
            this.loginTextBox_Login.Name = "loginTextBox_Login";
            this.loginTextBox_Login.Size = new System.Drawing.Size(204, 20);
            this.loginTextBox_Login.TabIndex = 4;
            // 
            // passwordTextBox_Login
            // 
            this.passwordTextBox_Login.Location = new System.Drawing.Point(128, 132);
            this.passwordTextBox_Login.Name = "passwordTextBox_Login";
            this.passwordTextBox_Login.Size = new System.Drawing.Size(204, 20);
            this.passwordTextBox_Login.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 266);
            this.Controls.Add(this.passwordTextBox_Login);
            this.Controls.Add(this.loginTextBox_Login);
            this.Controls.Add(this.signIn_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Вхід";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signIn_Login;
        private System.Windows.Forms.TextBox loginTextBox_Login;
        private System.Windows.Forms.TextBox passwordTextBox_Login;
    }
}