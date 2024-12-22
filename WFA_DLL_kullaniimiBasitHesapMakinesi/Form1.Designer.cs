namespace WFA_DLL_kullaniimiBasitHesapMakinesi
{
    partial class Form1
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
            this.label1_sayi1 = new System.Windows.Forms.Label();
            this.label2_sayi2 = new System.Windows.Forms.Label();
            this.textBox1_sayi1 = new System.Windows.Forms.TextBox();
            this.textBox2_sayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4_sonuc = new System.Windows.Forms.Label();
            this.button1_topla = new System.Windows.Forms.Button();
            this.button2_cikar = new System.Windows.Forms.Button();
            this.button3_carpma = new System.Windows.Forms.Button();
            this.button4_bolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_sayi1
            // 
            this.label1_sayi1.AutoSize = true;
            this.label1_sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_sayi1.Location = new System.Drawing.Point(57, 51);
            this.label1_sayi1.Name = "label1_sayi1";
            this.label1_sayi1.Size = new System.Drawing.Size(63, 17);
            this.label1_sayi1.TabIndex = 0;
            this.label1_sayi1.Text = "Sayı 1 :";
            // 
            // label2_sayi2
            // 
            this.label2_sayi2.AutoSize = true;
            this.label2_sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2_sayi2.Location = new System.Drawing.Point(57, 93);
            this.label2_sayi2.Name = "label2_sayi2";
            this.label2_sayi2.Size = new System.Drawing.Size(63, 17);
            this.label2_sayi2.TabIndex = 0;
            this.label2_sayi2.Text = "Sayı 2 :";
            // 
            // textBox1_sayi1
            // 
            this.textBox1_sayi1.Location = new System.Drawing.Point(158, 51);
            this.textBox1_sayi1.Name = "textBox1_sayi1";
            this.textBox1_sayi1.Size = new System.Drawing.Size(100, 22);
            this.textBox1_sayi1.TabIndex = 1;
            // 
            // textBox2_sayi2
            // 
            this.textBox2_sayi2.Location = new System.Drawing.Point(158, 93);
            this.textBox2_sayi2.Name = "textBox2_sayi2";
            this.textBox2_sayi2.Size = new System.Drawing.Size(100, 22);
            this.textBox2_sayi2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sonuç : ";
            // 
            // label4_sonuc
            // 
            this.label4_sonuc.AutoSize = true;
            this.label4_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4_sonuc.Location = new System.Drawing.Point(155, 139);
            this.label4_sonuc.Name = "label4_sonuc";
            this.label4_sonuc.Size = new System.Drawing.Size(23, 17);
            this.label4_sonuc.TabIndex = 4;
            this.label4_sonuc.Text = "...";
            // 
            // button1_topla
            // 
            this.button1_topla.Location = new System.Drawing.Point(244, 139);
            this.button1_topla.Name = "button1_topla";
            this.button1_topla.Size = new System.Drawing.Size(55, 48);
            this.button1_topla.TabIndex = 5;
            this.button1_topla.Text = "+";
            this.button1_topla.UseVisualStyleBackColor = true;
            this.button1_topla.Click += new System.EventHandler(this.button1_topla_Click);
            // 
            // button2_cikar
            // 
            this.button2_cikar.Location = new System.Drawing.Point(322, 138);
            this.button2_cikar.Name = "button2_cikar";
            this.button2_cikar.Size = new System.Drawing.Size(55, 48);
            this.button2_cikar.TabIndex = 5;
            this.button2_cikar.Text = "-";
            this.button2_cikar.UseVisualStyleBackColor = true;
            this.button2_cikar.Click += new System.EventHandler(this.button2_cikar_Click);
            // 
            // button3_carpma
            // 
            this.button3_carpma.Location = new System.Drawing.Point(244, 203);
            this.button3_carpma.Name = "button3_carpma";
            this.button3_carpma.Size = new System.Drawing.Size(55, 48);
            this.button3_carpma.TabIndex = 5;
            this.button3_carpma.Text = "x";
            this.button3_carpma.UseVisualStyleBackColor = true;
            this.button3_carpma.Click += new System.EventHandler(this.button3_carpma_Click);
            // 
            // button4_bolme
            // 
            this.button4_bolme.Location = new System.Drawing.Point(322, 203);
            this.button4_bolme.Name = "button4_bolme";
            this.button4_bolme.Size = new System.Drawing.Size(55, 48);
            this.button4_bolme.TabIndex = 5;
            this.button4_bolme.Text = "/";
            this.button4_bolme.UseVisualStyleBackColor = true;
            this.button4_bolme.Click += new System.EventHandler(this.button4_bolme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.button4_bolme);
            this.Controls.Add(this.button3_carpma);
            this.Controls.Add(this.button2_cikar);
            this.Controls.Add(this.button1_topla);
            this.Controls.Add(this.label4_sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2_sayi2);
            this.Controls.Add(this.textBox1_sayi1);
            this.Controls.Add(this.label2_sayi2);
            this.Controls.Add(this.label1_sayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_sayi1;
        private System.Windows.Forms.Label label2_sayi2;
        private System.Windows.Forms.TextBox textBox1_sayi1;
        private System.Windows.Forms.TextBox textBox2_sayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4_sonuc;
        private System.Windows.Forms.Button button1_topla;
        private System.Windows.Forms.Button button2_cikar;
        private System.Windows.Forms.Button button3_carpma;
        private System.Windows.Forms.Button button4_bolme;
    }
}

