namespace Clinics
{
    partial class ServiceChoosing
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
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceSelector = new System.Windows.Forms.ComboBox();
            this.ClinicSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckTB = new System.Windows.Forms.TextBox();
            this.CapchaTB = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите услугу:";
            // 
            // ServiceSelector
            // 
            this.ServiceSelector.FormattingEnabled = true;
            this.ServiceSelector.Location = new System.Drawing.Point(158, 10);
            this.ServiceSelector.Name = "ServiceSelector";
            this.ServiceSelector.Size = new System.Drawing.Size(238, 23);
            this.ServiceSelector.TabIndex = 1;
            this.ServiceSelector.SelectedIndexChanged += new System.EventHandler(this.ServiceSelector_SelectedIndexChanged);
            // 
            // ClinicSelector
            // 
            this.ClinicSelector.Enabled = false;
            this.ClinicSelector.FormattingEnabled = true;
            this.ClinicSelector.Location = new System.Drawing.Point(158, 36);
            this.ClinicSelector.Name = "ClinicSelector";
            this.ClinicSelector.Size = new System.Drawing.Size(238, 23);
            this.ClinicSelector.TabIndex = 2;
            this.ClinicSelector.SelectedIndexChanged += new System.EventHandler(this.ClinicSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите клинику:";
            // 
            // DateSelector
            // 
            this.DateSelector.Enabled = false;
            this.DateSelector.FormattingEnabled = true;
            this.DateSelector.Location = new System.Drawing.Point(158, 62);
            this.DateSelector.Name = "DateSelector";
            this.DateSelector.Size = new System.Drawing.Size(238, 23);
            this.DateSelector.TabIndex = 4;
            this.DateSelector.SelectedIndexChanged += new System.EventHandler(this.DateSelector_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите дату:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена за услугу:";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(158, 98);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.ReadOnly = true;
            this.PriceTB.Size = new System.Drawing.Size(100, 23);
            this.PriceTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите текст:";
            // 
            // CheckTB
            // 
            this.CheckTB.Enabled = false;
            this.CheckTB.Location = new System.Drawing.Point(13, 163);
            this.CheckTB.Name = "CheckTB";
            this.CheckTB.Size = new System.Drawing.Size(100, 23);
            this.CheckTB.TabIndex = 9;
            this.CheckTB.TextChanged += new System.EventHandler(this.CheckTB_TextChanged);
            // 
            // CapchaTB
            // 
            this.CapchaTB.Location = new System.Drawing.Point(132, 163);
            this.CapchaTB.Name = "CapchaTB";
            this.CapchaTB.ReadOnly = true;
            this.CapchaTB.Size = new System.Drawing.Size(100, 23);
            this.CapchaTB.TabIndex = 10;
            this.CapchaTB.Text = "d1fr3zKtd4kE";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(13, 193);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(383, 23);
            this.OkBtn.TabIndex = 11;
            this.OkBtn.Text = "Подтвердить запись и согласиться с ценой";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ServiceChoosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 230);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.CapchaTB);
            this.Controls.Add(this.CheckTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClinicSelector);
            this.Controls.Add(this.ServiceSelector);
            this.Controls.Add(this.label1);
            this.Name = "ServiceChoosing";
            this.Text = "Выбор услуги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServiceSelector;
        private System.Windows.Forms.ComboBox ClinicSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DateSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CheckTB;
        private System.Windows.Forms.TextBox CapchaTB;
        private System.Windows.Forms.Button OkBtn;
    }
}

