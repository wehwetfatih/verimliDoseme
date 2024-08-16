namespace verimliDöseme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.O_UzunKenar = new System.Windows.Forms.TextBox();
            this.D_UzunKenar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.O_KısaKenar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.D_KısaKenar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oda Kısa Kenar Uzunluğu1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Döşeme Uzun Kenar Uzunluğu";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(489, 68);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 2;
            // 
            // O_UzunKenar
            // 
            this.O_UzunKenar.Location = new System.Drawing.Point(72, 110);
            this.O_UzunKenar.Name = "O_UzunKenar";
            this.O_UzunKenar.Size = new System.Drawing.Size(100, 22);
            this.O_UzunKenar.TabIndex = 4;
            // 
            // D_UzunKenar
            // 
            this.D_UzunKenar.Location = new System.Drawing.Point(72, 227);
            this.D_UzunKenar.Name = "D_UzunKenar";
            this.D_UzunKenar.Size = new System.Drawing.Size(100, 22);
            this.D_UzunKenar.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Artan Parça:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Parke İhtiyacı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "......";
            // 
            // O_KısaKenar
            // 
            this.O_KısaKenar.Location = new System.Drawing.Point(271, 110);
            this.O_KısaKenar.Name = "O_KısaKenar";
            this.O_KısaKenar.Size = new System.Drawing.Size(100, 22);
            this.O_KısaKenar.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Oda Uzun Kenar Uzunluğu 2";
            // 
            // D_KısaKenar
            // 
            this.D_KısaKenar.Location = new System.Drawing.Point(271, 227);
            this.D_KısaKenar.Name = "D_KısaKenar";
            this.D_KısaKenar.Size = new System.Drawing.Size(100, 22);
            this.D_KısaKenar.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Döşeme Kısa Kenar Uzunluğu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.D_KısaKenar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.O_KısaKenar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.D_UzunKenar);
            this.Controls.Add(this.O_UzunKenar);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox O_UzunKenar;
        private System.Windows.Forms.TextBox D_UzunKenar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox O_KısaKenar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox D_KısaKenar;
        private System.Windows.Forms.Label label7;
    }
}

