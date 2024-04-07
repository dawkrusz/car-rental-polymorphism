using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Pojazd
{
    public int ID_Pojazd { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string NumerRejestracyjny { get; set; }
    public bool Dostepnosc { get; set; }
    public decimal Cena { get; set; }

    public Pojazd() { }

    public Pojazd(int id_pojazd, string marka, string model, string nrRej, bool dostepnosc, decimal cena)
    {
        this.ID_Pojazd = id_pojazd;
        this.Marka = marka;
        this.Model = model;
        this.NumerRejestracyjny = nrRej;
        this.Dostepnosc = dostepnosc;
        this.Cena = cena;
    }
}