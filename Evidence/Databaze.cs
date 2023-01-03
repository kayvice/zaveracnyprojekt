using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    class Databaze
    {

        List<Pojistenec> pojistenci = new List<Pojistenec>();

        /// <summary>
        /// Přidání nového pojištěnce do databáze
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="vek"></param>
        /// <param name="telefon"></param>
        public void PridejPojistence(string jmeno, string prijmeni, int vek, int telefon)
        {
            pojistenci.Add(new Pojistenec(jmeno, prijmeni, vek, telefon));
        }

        /// <summary>
        /// Vypiše všechny pojištěnce
        /// </summary>
        /// <returns></returns>
        public void VypisPojistene()
        {
            foreach (Pojistenec p in pojistenci)
            {
                Console.WriteLine(p);
            }
        }



        public void NajdiPojistence(string jmeno, string prijmeni)
        {
            for (int i = 0; i < pojistenci.Count; i++)
            if ((pojistenci[i].Jmeno == jmeno)&&(pojistenci[i].Prijmeni == prijmeni))
                    Console.WriteLine(pojistenci[i]);
        }





    }

}
