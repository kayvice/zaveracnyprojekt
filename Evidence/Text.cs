using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence
{
    internal class Text
    {
        private Databaze databaze;
        
        public Text()
        {
            databaze = new Databaze();
        }

       
        //Spojit s VypisMozneUkony
        public void TextUvodni()
        {
            Console.WriteLine();
            Console.Write("-------------------------------\nEvidence pojištěných\n-------------------------------");
        }

        public void VypisMozneUkony()
        {
            Console.Write("\n \nVyberte si akci:" +
                          "\n 1 - Přidat nového pojištěnce" +
                          "\n 2 - Vyhledat pojištěného dle jména a přijmení" +
                          "\n 3 - Vypsat všechny pojištěné" +
                          "\n 4 - Konec");
        }

        private string ZjistiJmeno()
        {
            Console.WriteLine("\n\nNapište své jméno: ");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
                Console.WriteLine("Chybné zadání, zadejte své jméno znovu");
            return jmeno;
        }

        private string ZjistiPrijmeni()
        {
            Console.WriteLine("Napište své přijmení: ");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
                Console.WriteLine("Chybné zadání, zadejte své přijmení znovu");
            return prijmeni;
        }

        private int ZjistiVek()
        {
            Console.WriteLine("Napište svůj věk: ");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Chybné zadání, zadejte svůj věk znovu: ");
            return vek;
        }

        private int ZjistiTelefon()
        {
            Console.WriteLine("Napište své telefonní číslo: ");
            int telefon;
            while (!int.TryParse(Console.ReadLine(), out telefon))
                Console.WriteLine("Chybné zadání, zadejte své telefonní číslo znovu: ");
            return telefon;
        }


        public void ZapisNovehoPojistence()
        {
            string jmeno = ZjistiJmeno();
            string prijmeni = ZjistiPrijmeni();
            int vek = ZjistiVek();
            int telefon = ZjistiTelefon();
            
            databaze.PridejPojistence(jmeno, prijmeni, vek, telefon);
        }

        public void VypisPojistene()
        {
            databaze.VypisPojistene();
        }

        /// <summary>
        /// Hledání pojištěnce dle jména
        /// </summary>
        /// <returns>Jméno</returns>
        private string JmenoHledaneho()
        {
            Console.WriteLine("\n\nNapište jméno hledaného pojištěnce: ");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
                Console.WriteLine("Chybné zadání, zadejte své jméno znovu");
            return jmeno;
        }
        /// <summary>
        /// Hledání pojištěnce dle přijmení
        /// </summary>
        /// <returns>Přijmení</returns>
        private string PrijmeniHledaneho()
        {
            Console.WriteLine("Napište přijmení hledaného pojištěnce: ");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
                Console.WriteLine("Chybné zadání, zadejte své přijmení znovu");
            return prijmeni;
        }

        /// <summary>
        /// Hledání pojištěnce dle jmena i přijmení
        /// </summary>
        public void VyhledejPojistence()
        {
            string jmeno = JmenoHledaneho();
            string prijmeni = PrijmeniHledaneho();

            databaze.NajdiPojistence(jmeno, prijmeni);
        }











    }
}
