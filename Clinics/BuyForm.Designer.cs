namespace Clinics
{
    partial class BuyForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.TermTB = new System.Windows.Forms.TextBox();
            this.CvcTB = new System.Windows.Forms.TextBox();
            this.CardTB = new System.Windows.Forms.TextBox();
            this.FILbl = new System.Windows.Forms.TextBox();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер карты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CVC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок действия карты:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя и фамилия:";
            // 
            // TermTB
            // 
            this.TermTB.Location = new System.Drawing.Point(145, 79);
            this.TermTB.MaxLength = 5;
            this.TermTB.Name = "TermTB";
            this.TermTB.Size = new System.Drawing.Size(50, 23);
            this.TermTB.TabIndex = 4;
            // 
            // CvcTB
            // 
            this.CvcTB.Location = new System.Drawing.Point(145, 45);
            this.CvcTB.MaxLength = 3;
            this.CvcTB.Name = "CvcTB";
            this.CvcTB.Size = new System.Drawing.Size(50, 23);
            this.CvcTB.TabIndex = 5;
            // 
            // CardTB
            // 
            this.CardTB.Location = new System.Drawing.Point(145, 13);
            this.CardTB.MaxLength = 16;
            this.CardTB.Name = "CardTB";
            this.CardTB.Size = new System.Drawing.Size(174, 23);
            this.CardTB.TabIndex = 6;
            // 
            // FILbl
            // 
            this.FILbl.Location = new System.Drawing.Point(145, 113);
            this.FILbl.Name = "FILbl";
            this.FILbl.Size = new System.Drawing.Size(174, 23);
            this.FILbl.TabIndex = 7;
            // 
            // BuyBtn
            // 
            this.BuyBtn.Location = new System.Drawing.Point(145, 143);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(174, 25);
            this.BuyBtn.TabIndex = 8;
            this.BuyBtn.Text = "Оплатить";
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // BuyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 176);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.FILbl);
            this.Controls.Add(this.CardTB);
            this.Controls.Add(this.CvcTB);
            this.Controls.Add(this.TermTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuyForm";
            this.Text = "Оплата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TermTB;
        private System.Windows.Forms.TextBox CvcTB;
        private System.Windows.Forms.TextBox CardTB;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.TextBox FILbl;
    }
}