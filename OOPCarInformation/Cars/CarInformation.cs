using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCarInformation.Cars
{
    public class CarInformation
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }
        public short BeygirGücü { get; set; }
        public CarKinds ArabaTürü { get; set; }
        public short MaksimumHiz { get; set; }
        public string Cekis { get; set; }
        public  double SifirdanYüzeHizlanma { get; set; }
        public double Agirlik { get; set; }
        public double MotorHacmi { get; set; }
    }
}
