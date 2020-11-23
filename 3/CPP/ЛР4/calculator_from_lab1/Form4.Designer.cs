namespace _3_SPP_1
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnMult = new System.Windows.Forms.Button();
            this.BtnDvd = new System.Windows.Forms.Button();
            this.BtnRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 22);
            this.textBox1.TabIndex = 0;
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(38, 65);
            this.BtnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(48, 42);
            this.BtnPlus.TabIndex = 1;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(94, 65);
            this.BtnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(49, 42);
            this.BtnMinus.TabIndex = 2;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.Location = new System.Drawing.Point(38, 111);
            this.BtnMult.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(49, 42);
            this.BtnMult.TabIndex = 3;
            this.BtnMult.Text = "x";
            this.BtnMult.UseVisualStyleBackColor = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // BtnDvd
            // 
            this.BtnDvd.Location = new System.Drawing.Point(95, 111);
            this.BtnDvd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDvd.Name = "BtnDvd";
            this.BtnDvd.Size = new System.Drawing.Size(48, 42);
            this.BtnDvd.TabIndex = 4;
            this.BtnDvd.Text = "/";
            this.BtnDvd.UseVisualStyleBackColor = true;
            this.BtnDvd.Click += new System.EventHandler(this.BtnDvd_Click);
            // 
            // BtnRes
            // 
            this.BtnRes.Location = new System.Drawing.Point(65, 161);
            this.BtnRes.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRes.Name = "BtnRes";
            this.BtnRes.Size = new System.Drawing.Size(51, 42);
            this.BtnRes.TabIndex = 5;
            this.BtnRes.Text = "=";
            this.BtnRes.UseVisualStyleBackColor = true;
            this.BtnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 236);
            this.Controls.Add(this.BtnRes);
            this.Controls.Add(this.BtnDvd);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Вариант 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnMult;
        private System.Windows.Forms.Button BtnDvd;
        private System.Windows.Forms.Button BtnRes;
    }
}