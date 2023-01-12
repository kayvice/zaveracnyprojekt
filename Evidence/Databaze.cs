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
        /// <param name="jmeno">Jméno uživatele</param>
        /// <param name="prijmeni">Přijmení uživatele</param>
        /// <param name="vek">Věk uživatele</param>
        /// <param name="telefon">Telefonní číslo uživatele</param>
        /// 
        public void PridejPojistence(string jmeno, string prijmeni, int vek, int telefon)

        {
            Pojistenec p1 = new Pojistenec(jmeno, prijmeni, vek, telefon);
            if (!pojistenci.Contains(p1))
                pojistenci.Add(new Pojistenec(jmeno, prijmeni, vek, telefon));
            else Console.WriteLine( "\n ////////////////////////////////////" +
                                    "\n Zadaný pojištěnec již v databázi je." +
                                    "\n ////////////////////////////////////" );
        }

        /// <summary>
        /// Vypíše všechny pojištěnce
        /// </summary>
        /// <returns>Všichni pojištění v databázi</returns>
        public void VypisPojistene()
        {
            foreach (Pojistenec p in pojistenci)
            {
                Console.WriteLine(p);
            }
        }


        /// <summary>
        /// Najde pojištěnce dle jména a přijmení
        /// </summary>
        /// <param name="jmeno">Jméno</param>
        /// <param name="prijmeni">Přijmení</param>
        public void NajdiPojistence(string jmeno, string prijmeni)
        {
            pojistenci.ForEach(p => Console.WriteLine(p));
        }





    }

}
