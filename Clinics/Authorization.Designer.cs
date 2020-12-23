namespace Clinics
{
    partial class Authorization
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
            this.PasswordErrorLbl = new System.Windows.Forms.Label();
            this.LogOnBtn = new System.Windows.Forms.Button();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // PasswordErrorLbl
            // 
            this.PasswordErrorLbl.AutoSize = true;
            this.PasswordErrorLbl.Location = new System.Drawing.Point(11, 92);
            this.PasswordErrorLbl.Name = "PasswordErrorLbl";
            this.PasswordErrorLbl.Size = new System.Drawing.Size(0, 20);
            this.PasswordErrorLbl.TabIndex = 2;
            // 
            // LogOnBtn
            // 
            this.LogOnBtn.Location = new System.Drawing.Point(13, 120);
            this.LogOnBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogOnBtn.Name = "LogOnBtn";
            this.LogOnBtn.Size = new System.Drawing.Size(101, 31);
            this.LogOnBtn.TabIndex = 3;
            this.LogOnBtn.Text = "Войти";
            this.LogOnBtn.UseVisualStyleBackColor = true;
            this.LogOnBtn.Click += new System.EventHandler(this.LogOnBtn_Click);
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Location = new System.Drawing.Point(120, 120);
            this.RegistrationBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(106, 31);
            this.RegistrationBtn.TabIndex = 4;
            this.RegistrationBtn.Text = "Регистрация";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(88, 16);
            this.LoginTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(138, 27);
            this.LoginTB.TabIndex = 5;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(88, 58);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(138, 27);
            this.PasswordTB.TabIndex = 6;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 180);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.LogOnBtn);
            this.Controls.Add(this.PasswordErrorLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Activated += new System.EventHandler(this.Authorization_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PasswordErrorLbl;
        private System.Windows.Forms.Button LogOnBtn;
        private System.Windows.Forms.Button RegistrationBtn;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
    }
}