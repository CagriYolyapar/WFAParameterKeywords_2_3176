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
    public partial class Form4 : Form
    {

        /*
         
             params

        Metodun alacagı parametre sayısı belli degilse params keyword'u bize yardım eder...

        Params, bir parametre kümesinde kendisinden sonra baska bir parametre istemez
         
         
         */


        public Form4()
        {
            InitializeComponent();
        }


        public int SayilariTopla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            return toplam;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           Text =  SayilariTopla(1,2,3,4).ToString();
        }
    }
}
