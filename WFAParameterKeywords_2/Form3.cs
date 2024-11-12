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
    /*
       Biz, degişkenlerimizi actıgımızda ya RAM'de tanımlama yaparız ya da hem tanımlama hem atama yaparız...Eger sadece tanımlama yaparsak RAM'de bu degişkenin(local alanda isek) tanımı bir yere referans etmeyecektir...Dolayısıyla bu sürecte degiskeni ( atama operasyonu haricindeki bir işlemde) kullanmaya calısırsak sadece alanı acmaya hazır oldugumuz, degeri atamadıgımız icin use of unassigned local variable hatası alırız...

    Eger hem tanımlama hem de atama yaparsak RAM'de alan acılmıs, icerisine de bir deger verilmiş olur...ref, bu degeri olan yapıları kolayca yakalayarak onları degiştirebilir...Ancak eger alanın degeri atanmamıssa ref'in yakalayabileegi bir yapı olmadıgından dolayı engellenirsiniz...Ancak siz her daim var olan bir degişkeninizi degiştirmek istemeyebilirsiniz..Bu noktada ref kullanamayacagınızdan dolayı deger fırlatma yöntemini tercih etmelisiniz ( out keyword'u)..Bununla birlikte acılmıs olan bir yapıyı out keyword'u ile birlikte kullanmaya calısırsanız out , onun var olan yapısını gözardı ederek onu ezer ve kendisi yeni bir tane acar...out'un görevi bir metot icerisinden dısarıya deger fırlatmak ve degşiken olusturmaktır...O yüzden acılmıs olan ve degeri olan yapıları degiştireceksiniz out potansiyel olarak bunu yapabilse de perfromansı düsürecektir...O gibi durumlarda dogru olan ref kullanmaktır...


    out parametre keyword'u ile tanımladıgınız bir parametrenin metot icerisinde fırlatacagı degerin kesinlikle belirtilmesi gerekir...Yoksa syntax hatası alırsınız...


    Parametre keyword'lerinin metodun deger döndürüp döndürmemesiyle alakası yoktur...Bir metot geriye deger döndürmedigi halde deger fırlatabilir...Bir metot geriye deger döndürdügü halde de deger fırlatabilir...Bir metot istedigi kadar deger fırlatabilir ama sadece tek bir deger döndürebilir...

    Bir metodun geriye deger döndürüp döndürmemesi ile veya geriye dönüs tipi ile parametresinin alakası yoktur...
     
     
     
     
     
     */
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        public void Firlat(out int sayi)
        {
            sayi = 10;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

           

            Firlat(out int a);

            

        }
    }
}
