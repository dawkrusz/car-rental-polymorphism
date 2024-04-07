using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public static class CsvHelper
    {
        private const string filePath = "pojazdy.csv";

        public static List<Pojazd> OdczytajPojazdyZPliku()
        {
            List<Pojazd> pojazdy = new List<Pojazd>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines.Skip(1)) // Pomijanie nagłówka pliku CSV
                {
                    string[] values = line.Split(',');
                    if (values.Length >= 7)
                    {
                        int id = int.Parse(values[0]);
                        string marka = values[1];
                        string model = values[2];
                        string numerRejestracyjny = values[3];
                        bool dostepnosc = bool.Parse(values[4]);
                        decimal cena = decimal.Parse(values[5], CultureInfo.InvariantCulture);

                        bool.TryParse(values[6], out bool klimatyzacja);
                        bool.TryParse(values[7], out bool kaskWZestawie);
                        bool.TryParse(values[8], out bool posiadaBagaznik);

                        if (!string.IsNullOrEmpty(values[6]) && !string.IsNullOrEmpty(values[7]))
                        {
                            int iloscDrzwi = int.Parse(values[6]);
                            int liczbaMiejsc = int.Parse(values[7]);

                            Samochod samochod = new Samochod(id, marka, model, numerRejestracyjny, dostepnosc, cena, iloscDrzwi, liczbaMiejsc, klimatyzacja);
                            pojazdy.Add(samochod);
                        }
                        else
                        {
                            Motor motocykl = new Motor(id, marka, model, numerRejestracyjny, dostepnosc, cena, kaskWZestawie, posiadaBagaznik);
                            pojazdy.Add(motocykl);
                        }
                    }
                }
            }

            return pojazdy;
        }


        public static void ZapiszPojazdyDoPliku(List<Pojazd> pojazdy)
        {
            List<Pojazd> wszystkiePojazdy = OdczytajPojazdyZPliku();
            List<Pojazd> nowaListaPojazdow = new List<Pojazd>();

            foreach (Pojazd pojazd in wszystkiePojazdy)
            {
                if (!pojazdy.Any(p => p.ID_Pojazd == pojazd.ID_Pojazd))
                {
                    nowaListaPojazdow.Add(pojazd);
                }
            }

            nowaListaPojazdow.AddRange(pojazdy);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID_Pojazd,Marka,Model,NumerRejestracyjny,Dostepnosc,Cena,IloscDrzwi,LiczbaMiejsc,Klimatyzacja,KaskWZestawie,PosiadaBagaznik");

                foreach (Pojazd pojazd in nowaListaPojazdow)
                {
                    string line = $"{pojazd.ID_Pojazd},{pojazd.Marka},{pojazd.Model},{pojazd.NumerRejestracyjny},{pojazd.Dostepnosc},{pojazd.Cena}";

                    if (pojazd is Samochod samochod)
                    {
                        line += $",{samochod.IloscDrzwi},{samochod.LiczbaMiejsc},{samochod.Klimatyzacja}";
                    }
                    else if (pojazd is Motor motocykl)
                    {
                        line += $",,,{motocykl.KaskWZestawie},{motocykl.PosiadaBagaznik}";
                    }

                    writer.WriteLine(line);
                }
            }
        }




        public static void UsunPojazdZPliku(int id)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<string> noweLinie = new List<string>();

            bool rekordZnaleziony = false;

            foreach (string line in lines)
            {
                if (line.StartsWith(id + ","))
                {
                    rekordZnaleziony = true;
                    continue;
                }

                noweLinie.Add(line);
            }

            if (rekordZnaleziony)
            {
                File.WriteAllLines(filePath, noweLinie);
                MessageBox.Show("Pojazd został usunięty z pliku.");
            }
            else
            {
                MessageBox.Show("Nie znaleziono pojazdu o podanym ID.");
            }
        }

    }
}
