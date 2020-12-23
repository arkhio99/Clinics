namespace Clinics
{
    partial class HelloForm
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
            this.HelloPB = new System.Windows.Forms.PictureBox();
            this.StartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HelloPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в сервис  по оформлению визитов в сеть клиник.";
            // 
            // HelloPB
            // 
            this.HelloPB.Location = new System.Drawing.Point(113, 12);
            this.HelloPB.Name = "HelloPB";
            this.HelloPB.Size = new System.Drawing.Size(287, 325);
            this.HelloPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelloPB.TabIndex = 1;
            this.HelloPB.TabStop = false;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(204, 373);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(94, 29);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Начать";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.HelloPB);
            this.Controls.Add(this.label1);
            this.Name = "HelloForm";
            this.Text = "Приветствие";
            ((System.ComponentModel.ISupportInitialize)(this.HelloPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HelloPB;
        private System.Windows.Forms.Button StartBtn;
    }
}