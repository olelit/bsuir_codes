namespace _3_SPP_1
{
    partial class Form7
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
            this.textBoxRu = new System.Windows.Forms.TextBox();
            this.textBoxEng = new System.Windows.Forms.TextBox();
            this.lblLft = new System.Windows.Forms.Label();
            this.lblRght = new System.Windows.Forms.Label();
            this.lblRus = new System.Windows.Forms.Label();
            this.lblEng = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRu
            // 
            this.textBoxRu.Location = new System.Drawing.Point(13, 39);
            this.textBoxRu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRu.Name = "textBoxRu";
            this.textBoxRu.Size = new System.Drawing.Size(132, 22);
            this.textBoxRu.TabIndex = 0;
            // 
            // textBoxEng
            // 
            this.textBoxEng.Location = new System.Drawing.Point(153, 39);
            this.textBoxEng.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEng.Name = "textBoxEng";
            this.textBoxEng.ReadOnly = true;
            this.textBoxEng.Size = new System.Drawing.Size(132, 22);
            this.textBoxEng.TabIndex = 1;
            // 
            // lblLft
            // 
            this.lblLft.AutoSize = true;
            this.lblLft.Enabled = false;
            this.lblLft.Location = new System.Drawing.Point(293, 42);
            this.lblLft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLft.Name = "lblLft";
            this.lblLft.Size = new System.Drawing.Size(108, 17);
            this.lblLft.TabIndex = 2;
            this.lblLft.Text = "Изменить язык";
            this.lblLft.Visible = false;
            this.lblLft.Click += new System.EventHandler(this.lblLft_Click);
            // 
            // lblRght
            // 
            this.lblRght.AutoSize = true;
            this.lblRght.Location = new System.Drawing.Point(293, 42);
            this.lblRght.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRght.Name = "lblRght";
            this.lblRght.Size = new System.Drawing.Size(108, 17);
            this.lblRght.TabIndex = 3;
            this.lblRght.Text = "Изменить язык";
            this.lblRght.Click += new System.EventHandler(this.lblRght_Click);
            // 
            // lblRus
            // 
            this.lblRus.AutoSize = true;
            this.lblRus.Location = new System.Drawing.Point(44, 20);
            this.lblRus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRus.Name = "lblRus";
            this.lblRus.Size = new System.Drawing.Size(61, 17);
            this.lblRus.TabIndex = 4;
            this.lblRus.Text = "Русский";
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Location = new System.Drawing.Point(191, 18);
            this.lblEng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(54, 17);
            this.lblEng.TabIndex = 5;
            this.lblEng.Text = "English";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(98, 79);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(4);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(100, 28);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Перевести";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 265);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.lblEng);
            this.Controls.Add(this.lblRus);
            this.Controls.Add(this.lblRght);
            this.Controls.Add(this.lblLft);
            this.Controls.Add(this.textBoxEng);
            this.Controls.Add(this.textBoxRu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form7";
            this.Text = "Вариант 6";
            this.Shown += new System.EventHandler(this.Form7_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRu;
        private System.Windows.Forms.TextBox textBoxEng;
        private System.Windows.Forms.Label lblLft;
        private System.Windows.Forms.Label lblRght;
        private System.Windows.Forms.Label lblRus;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.Button btnTranslate;
    }
}