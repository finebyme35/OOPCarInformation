using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPCarInformation.Cars;

namespace OOPCarInformation
{
    public partial class Form1 : Form
    {
        private CarInformation car = new CarInformation();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            //string result = "";
            //result += tbMarka.Text + "\n";
            //result += tbModel.Text + "\n";
            //result += nudKapiSayisi.Value + "\n";
            //result += tbBeygirGücü.Text + "\n";
            //result += cbArabaTürü.Text + "\n";
            //result += tbMaksimumHiz.Text + "\n";
            //result += cbCekis.Text + "\n";
            //result += tbSifirdanYuzeHizlanma.Text + "\n";
            //result += tbAgirlik.Text + "\n";
            //result += tbMotorHacmi.Text + "\n";
            car.Id = Convert.ToInt32(nudId.Value);
            car.Marka = tbMarka.Text;
            car.Model = tbModel.Text;
            car.KapiSayisi = Convert.ToByte(nudKapiSayisi.Value);
            car.BeygirGücü = short.Parse(tbBeygirGücü.Text);
            if(cbArabaTürü.SelectedIndex == 0)
                car.ArabaTürü = CarKinds.Binek;
            else
            {
                car.ArabaTürü = CarKinds.Ticari;
            }

            car.MaksimumHiz = short.Parse(tbMaksimumHiz.Text);
            car.Cekis = cbCekis.Text;
            car.SifirdanYüzeHizlanma = double.Parse(tbSifirdanYuzeHizlanma.Text);
            car.Agirlik = double.Parse(tbAgirlik.Text);
            car.MotorHacmi = Convert.ToDouble(tbMotorHacmi.Text);

            //CarInformation car1 = new CarInformation()
                //{
                //    Marka = tbMarka.Text,
                //    Model = tbModel.Text,
                //    KapiSayisi = Convert.ToByte(nudKapiSayisi.Value),
                //    BeygirGücü = short.Parse(tbBeygirGücü.Text),
                //    ArabaTürü = CarKinds.Ticari,
                //    MaksimumHiz = short.Parse(tbMaksimumHiz.Text),
                //    Cekis = Convert.ToByte(cbCekis.Text),
                //    SifirdanYüzeHizlanma = double.Parse(tbSifirdanYuzeHizlanma.Text),
                //    Agirlik = double.Parse(tbAgirlik.Text),
                //    MotorHacmi = Convert.ToDouble(tbMotorHacmi.Text),
                //};
                //Form2 form2 = new Form2();
                //form2.ShowDialog();
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbArabaTürü.SelectedIndex = 0;
            cbCekis.SelectedIndex = 0;
        }

        private void bGöster_Click(object sender, EventArgs e)
        {
           
            lSonucId.Text += car.Id;
            lSonucMarka.Text += car.Marka;
            lSonucModel.Text += car.Model + " Model";
            lSonucKapiSayisi.Text += car.KapiSayisi + " Kapılı";
            lSonucBeygirGücü.Text += car.BeygirGücü + " Beygir";
            lSonucArabaTürü.Text += car.ArabaTürü;
            lSonucMaksimumHiz.Text += car.MaksimumHiz + " Km/S";
            lSonucCekis.Text += car.Cekis;
            lSonucSifirdanYüzeHizlanma.Text += car.SifirdanYüzeHizlanma + " Saniye";
            lSonucAgirlik.Text += car.Agirlik + " Kg";
            lSonucMotorHacmi.Text += car.MotorHacmi + " Cm3";
        }
    }
}
