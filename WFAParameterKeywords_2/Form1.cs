using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAParameterKeywords_2
{
    public partial class Form1 : Form
    {


        /*
            Biz normal şartlarda bir metoda parametre verdigimizde, argüman olarak bu istenen parametreyi bir degişken olarak atadıgımızda C# arka tarafta argüman tip kategorisine göre iki secenekten birini secer...

        1 => Deger Yoluyla Göndermek (Pass by Value)
        2 => Referans Yoluyla Göndermek (Pass by Reference)

        Eger siz , argümanınıza deger tipinde veya deger tipi gibi davranan tipte bir deger verirseniz ve ek bir müdahalede bulunmazsanız C# hemen bir güvenlik önlemi alır ve Deger Yoluyla Gönderme'yi secer... Bu da su anlama gelir...Argüman olarak verilen degişkenin arka tarafta bir kopyası cıkartılır...Metot, kendi icerisinde parametre üzerinden yaptıgı tüm işlemleri kendisine gelen o kopya üzerinden yapar...Dolayısıyla degişkenimizin orijinal hali güvende olur ve degişmez...

        Ancak siz degişkeninizin orijinal halinin degişmesini de isteyebilirsiniz...Bu durumda yardımınıza ref parametre keyword'u kosar...

        **ref**
        *
        *ref parametre keyword'u kullanmak ilgili degerin referans adresine hitap et demektir...Referans yoluyla gönderme durumunu ref keyword'u ile saglayabilirsiniz. Bu durumda C# hükmü özellikle size bırakır...Eger argüman olarak göndereceginiz bir degişken bu degişim işleminden sonra programdaki ilgili yasam alanlarının tamamı boyunca(orijinal hali degişsin) degişsin istiyorsanız bu yöntemi kullanmanız gerekir...Referans yolu ile parametre verebilmek icin bir metotta su syntax izlenmelidir
        *
        *public void GercektenDegisir(ref int sayi)
        *{
        * sayi = 1000;
        *}
        *
        *
        *Üst taraftaki syntax'taki benim parametremin basına ref keyword'unu vermem, programa ben buraya gelecek degerin orijinal adresine hitap etmek istiyorum demektir...Program bunu anlar ve metot icerisinde yapılan her işlem ilgili degerin RAM'deki referans adresi(orijinal adresi) üzerinden yapılır...Ancak metodu cagırırken de ref keyword'u kullanmalısınız...ref keyword'u ile verilecek degişkenlerin ilk ataması yapılmak zorundadır...Yoksa unassigned local variable hatası alırsınız...
         
         
         //ilkel tipler  ,     kompleks tipler
         
         deger tipleri   ,     referans tipleri


        ilkel tipler tek bir deger ile ifade edilebilen tiplerdir...Bazı tipler ilkel tip olamasa bile onlar gibi davranıp tek bir degerle ifade edilebilir...


        kompleks tipler tek bir deger ile ifade edilemeyen tiplerdir...
         
         
         
         
         
         
         */



        public Form1()
        {
            InitializeComponent();
        }

       

        public void Degistir(int veri)
        {
            veri = 1000;
        }


        public void GercektenDegistir(ref int veri)
        {
            veri = 1000;
        }



        public void RenkDegistir(Button b)
        {
            b.BackColor = Color.Red;
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            int a =1 ;

           

            

            //Degistir(a); //Bu metodun a'yı degiştiremedigini gözlemleyeceksiniz

            GercektenDegistir(ref a);

            MessageBox.Show(a.ToString());

            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            RenkDegistir(button1);
        }
    }
}
