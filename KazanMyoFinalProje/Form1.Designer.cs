namespace KazanMyoFinalProje
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
            this.giristab = new System.Windows.Forms.TabControl();
            this.ogrencigiris = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.ogr_no = new System.Windows.Forms.TextBox();
            this.ogretimgorevgiris = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sifre2 = new System.Windows.Forms.TextBox();
            this.og_tc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yoneticigiris = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.y_sifre = new System.Windows.Forms.TextBox();
            this.y_kadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.giristab.SuspendLayout();
            this.ogrencigiris.SuspendLayout();
            this.ogretimgorevgiris.SuspendLayout();
            this.yoneticigiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // giristab
            // 
            this.giristab.Controls.Add(this.ogrencigiris);
            this.giristab.Controls.Add(this.ogretimgorevgiris);
            this.giristab.Controls.Add(this.yoneticigiris);
            this.giristab.Location = new System.Drawing.Point(12, 12);
            this.giristab.Name = "giristab";
            this.giristab.SelectedIndex = 0;
            this.giristab.Size = new System.Drawing.Size(301, 121);
            this.giristab.TabIndex = 0;
            // 
            // ogrencigiris
            // 
            this.ogrencigiris.Controls.Add(this.button1);
            this.ogrencigiris.Controls.Add(this.label2);
            this.ogrencigiris.Controls.Add(this.label1);
            this.ogrencigiris.Controls.Add(this.txt_sifre);
            this.ogrencigiris.Controls.Add(this.ogr_no);
            this.ogrencigiris.Location = new System.Drawing.Point(4, 22);
            this.ogrencigiris.Name = "ogrencigiris";
            this.ogrencigiris.Padding = new System.Windows.Forms.Padding(3);
            this.ogrencigiris.Size = new System.Drawing.Size(293, 95);
            this.ogrencigiris.TabIndex = 0;
            this.ogrencigiris.Text = "Öğrenci Girişi";
            this.ogrencigiris.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Numarası";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(115, 32);
            this.txt_sifre.MaxLength = 16;
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(172, 20);
            this.txt_sifre.TabIndex = 1;
            // 
            // ogr_no
            // 
            this.ogr_no.Location = new System.Drawing.Point(115, 6);
            this.ogr_no.MaxLength = 4;
            this.ogr_no.Name = "ogr_no";
            this.ogr_no.Size = new System.Drawing.Size(172, 20);
            this.ogr_no.TabIndex = 0;
            // 
            // ogretimgorevgiris
            // 
            this.ogretimgorevgiris.Controls.Add(this.button2);
            this.ogretimgorevgiris.Controls.Add(this.label4);
            this.ogretimgorevgiris.Controls.Add(this.txt_sifre2);
            this.ogretimgorevgiris.Controls.Add(this.og_tc);
            this.ogretimgorevgiris.Controls.Add(this.label3);
            this.ogretimgorevgiris.Location = new System.Drawing.Point(4, 22);
            this.ogretimgorevgiris.Name = "ogretimgorevgiris";
            this.ogretimgorevgiris.Padding = new System.Windows.Forms.Padding(3);
            this.ogretimgorevgiris.Size = new System.Drawing.Size(293, 95);
            this.ogretimgorevgiris.TabIndex = 1;
            this.ogretimgorevgiris.Text = "Öğretim Görevlisi Girişi";
            this.ogretimgorevgiris.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // txt_sifre2
            // 
            this.txt_sifre2.Location = new System.Drawing.Point(115, 32);
            this.txt_sifre2.MaxLength = 16;
            this.txt_sifre2.Name = "txt_sifre2";
            this.txt_sifre2.PasswordChar = '*';
            this.txt_sifre2.Size = new System.Drawing.Size(172, 20);
            this.txt_sifre2.TabIndex = 2;
            // 
            // og_tc
            // 
            this.og_tc.Location = new System.Drawing.Point(115, 6);
            this.og_tc.MaxLength = 11;
            this.og_tc.Name = "og_tc";
            this.og_tc.Size = new System.Drawing.Size(172, 20);
            this.og_tc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğretim Görevlisi TC";
            // 
            // yoneticigiris
            // 
            this.yoneticigiris.Controls.Add(this.button3);
            this.yoneticigiris.Controls.Add(this.label6);
            this.yoneticigiris.Controls.Add(this.y_sifre);
            this.yoneticigiris.Controls.Add(this.y_kadi);
            this.yoneticigiris.Controls.Add(this.label5);
            this.yoneticigiris.Location = new System.Drawing.Point(4, 22);
            this.yoneticigiris.Name = "yoneticigiris";
            this.yoneticigiris.Padding = new System.Windows.Forms.Padding(3);
            this.yoneticigiris.Size = new System.Drawing.Size(293, 95);
            this.yoneticigiris.TabIndex = 2;
            this.yoneticigiris.Text = "Yönetici Girişi";
            this.yoneticigiris.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Giriş";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Yönetici Şifresi";
            // 
            // y_sifre
            // 
            this.y_sifre.Location = new System.Drawing.Point(115, 32);
            this.y_sifre.MaxLength = 16;
            this.y_sifre.Name = "y_sifre";
            this.y_sifre.PasswordChar = '*';
            this.y_sifre.Size = new System.Drawing.Size(172, 20);
            this.y_sifre.TabIndex = 2;
            // 
            // y_kadi
            // 
            this.y_kadi.Location = new System.Drawing.Point(115, 6);
            this.y_kadi.MaxLength = 10;
            this.y_kadi.Name = "y_kadi";
            this.y_kadi.Size = new System.Drawing.Size(172, 20);
            this.y_kadi.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yönetici K. Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 140);
            this.Controls.Add(this.giristab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.giristab.ResumeLayout(false);
            this.ogrencigiris.ResumeLayout(false);
            this.ogrencigiris.PerformLayout();
            this.ogretimgorevgiris.ResumeLayout(false);
            this.ogretimgorevgiris.PerformLayout();
            this.yoneticigiris.ResumeLayout(false);
            this.yoneticigiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl giristab;
        private System.Windows.Forms.TabPage ogrencigiris;
        private System.Windows.Forms.TabPage ogretimgorevgiris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox ogr_no;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sifre2;
        private System.Windows.Forms.TextBox og_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage yoneticigiris;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox y_sifre;
        private System.Windows.Forms.TextBox y_kadi;
        private System.Windows.Forms.Label label5;
    }
}

