using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace verimliDöseme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int OdaUzun = Convert.ToInt32(O_UzunKenar.Text);
            int OdaKısa = Convert.ToInt32(D_UzunKenar.Text);
            int DöUzun = Convert.ToInt32(O_KısaKenar.Text);
            int DöKısa = Convert.ToInt32(D_KısaKenar.Text);



            int n = 0;
            int sonuc = OdaUzun;
            int donguSayisi = 0;
            int NegativedonguSayisi = 0;

            // Verilerin geçerli sayılar olup olmadığını kontrol et
            if (OdaUzun > 0 && OdaKısa > 0 && DöUzun > 0 && DöKısa > 0)
            {
                int yenitekrarSayisi = 0;

                if (DöUzun % DöKısa == 0)
                 {
                    yenitekrarSayisi = DöUzun / DöKısa;
                }
                 else
                 {
                    yenitekrarSayisi= (DöUzun / DöKısa) + 1;
                }


            while (n < yenitekrarSayisi) 
                {
                    n++;

                    while (sonuc >= 0)
                 {
                        sonuc -= OdaKısa;
                        donguSayisi++;
                     if (sonuc <= 0)
                        {
                         sonuc += OdaUzun;
                         NegativedonguSayisi++;
                         break;
                     }
                
                  }
                }
                int artanparca = OdaUzun - sonuc;
                label3.Text = "Artan Parça Uzunluğu: " + artanparca.ToString() + "   cm";
                label4.Text = $"Parke sayısı: {donguSayisi}" + "  adet";
                //label5.Text = $"Dikey Tekrar Sayısı: {NegativedonguSayisi}";

                // Negatif sonucu Label'a yazdır

            }
            else
            {
                // Geçersiz giriş için kullanıcıyı bilgilendirin
                label3.Text = "Lütfen geçerli sayılar girin.";
                label4.Text = "";
                label5.Text = "";
            }
        }
    }
}
