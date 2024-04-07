using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Wypozyczalnia : IWypozyczalnia
{
    private List<Samochod> samochody;
    private List<Motor> motory;

    public Wypozyczalnia()
    {
        samochody = new List<Samochod>();
        motory = new List<Motor>();
    }

    public List<Samochod> WyswietlSamochody()
    {
        return samochody;
    }

    public List<Motor> WyswietlMotory()
    {
        return motory;
    }

    public void DodajPojazd(Pojazd pojazd)
    {
        pojazd.ID_Pojazd = ++ostatnieID;
        if (pojazd is Samochod)
        {
            samochody.Add(pojazd as Samochod);
        }
        else if (pojazd is Motor)
        {
            motory.Add(pojazd as Motor);
        }
    }

    public void WypozyczPojazd(int id, int iloscDni)
    {
        Samochod samochod = samochody.Find(s => s.ID_Pojazd == id);
        Motor motor = motory.Find(m => m.ID_Pojazd == id);

        if (samochod != null)
        {
            samochod.Dostepnosc = false;
            decimal cena = samochod.Cena * iloscDni;
            // Wyświetl informację o koszcie wypożyczenia samochodu
        }
        else if (motor != null)
        {
            motor.Dostepnosc = false;
            decimal cena = motor.Cena * iloscDni;
            // Wyświetl informację o koszcie wypożyczenia motocykla
        }
    }

   
    public int ostatnieID = 0;
    public int OdczytajOstatnieID()
    {
        if (File.Exists("pojazdy.csv"))
        {
            using (StreamReader reader = new StreamReader("pojazdy.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 1)
                    {
                        if (int.TryParse(parts[0], out int idPojazd))
                        {
                            ostatnieID = Math.Max(ostatnieID, idPojazd);
                        }
                    }
                }
            }
        }
        return ostatnieID;
    }

}
