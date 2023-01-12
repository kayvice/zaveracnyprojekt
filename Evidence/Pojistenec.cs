using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class Pojistenec
   {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Telefon { get; set; }
        public int Vek { get; set; }

        public Pojistenec(string jmeno, string prijmeni, int vek, int telefon)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.Vek = vek;
            this.Telefon = telefon;
        }

        public override string ToString()
        {
            return Jmeno + "\t" + Prijmeni + "\t" + Vek + "\t" + Telefon;
        }


        //Kouknout
        public override bool Equals(object obj)
        {
            return obj is Pojistenec pojistenec &&
                   Jmeno == pojistenec.Jmeno &&
                   Prijmeni == pojistenec.Prijmeni &&
                   Telefon == pojistenec.Telefon &&
                   Vek == pojistenec.Vek;

        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Jmeno, Prijmeni, Telefon, Vek);
        }
    }

}
