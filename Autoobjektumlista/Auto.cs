using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoobjektumlista
{
    class Auto
    {
        private string rendszam;
        private string tipus;
        bool magyar;
        bool nemet;
        bool angol;
        bool kulfoldi;
        int teljesitmeny;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public bool Magyar { get => magyar; set => magyar = value; }
        public bool Nemet { get => nemet; set => nemet = value; }
        public bool Angol { get => angol; set => angol = value; }
        public bool Kulfoldi { get => kulfoldi; set => kulfoldi = value; }
        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }

        public Auto(string rendszam, string tipus, bool magyar, bool nemet, bool angol, bool kulfoldi, int teljesitmeny)
        {
            Rendszam = rendszam;
            Tipus = tipus;
            Magyar = magyar;
            Nemet = nemet;
            Angol = angol;
            Kulfoldi = kulfoldi;
            Teljesitmeny = teljesitmeny;
        }
        public override string ToString()
        {
            return rendszam + " (" + tipus + ")";
        }
    }
}
