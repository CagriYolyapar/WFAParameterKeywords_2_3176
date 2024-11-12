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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int viskiFiyati = 100;

        //Amerika'ya 10 liralık zam, İskocya'ya 20 liralık zam , İngiltere'ye 30 liralık zam


        public void OzelFiyatBelirle(string ulke,ref int urunFiyati)
        {
            urunFiyati = 100;
            switch (ulke)
            {
                case "Amerika":
                    urunFiyati += 10;
                    break;
                case "Ingiltere":
                    urunFiyati += 30;
                    break;
                case "Iskocya":
                    urunFiyati += 20;
                    break;
            }
        }

        public void RaporVer(string ulke)
        {
            MessageBox.Show($"{ulke} fiyatu su deger üzerinden gercekleşmiştir => {viskiFiyati}");
        }

        private void BtnIngiltere_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "Amerika":
                    OzelFiyatBelirle("Amerika",ref viskiFiyati);
                    RaporVer("Amerika");
                    break;
                case "Ingiltere":
                    OzelFiyatBelirle("Ingiltere",ref viskiFiyati);
                    RaporVer("Ingiltere");
                    break;
                case "Iskocya":
                    OzelFiyatBelirle("Iskocya",ref viskiFiyati);
                    RaporVer("Iskocya");
                    break;
            }
        }
    }
}
