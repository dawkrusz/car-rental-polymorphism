using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Samochod : Pojazd
{
    public int IloscDrzwi { get; set; }
    public int LiczbaMiejsc { get; set; }
    public bool Klimatyzacja { get; set; }

    public Samochod() { }

    public Samochod(int id_pojazd, string marka, string model, string nrRej, bool dostepnosc, decimal cena, int ilosc_Drzwi, int liczba_Miejsc, bool klimatyzacja) : base(id_pojazd, marka, model, nrRej, dostepnosc, cena)
    {
        this.IloscDrzwi = ilosc_Drzwi;
        this.LiczbaMiejsc = liczba_Miejsc;
        this.Klimatyzacja = klimatyzacja;
    }
}


