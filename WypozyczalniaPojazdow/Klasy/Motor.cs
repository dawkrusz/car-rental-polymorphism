using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Motor : Pojazd
{
    public bool KaskWZestawie { get; set; }
    public bool PosiadaBagaznik { get; set; }

    public Motor() { }

    public Motor(int id_pojazd, string marka, string model, string nrRej, bool dostepnosc, decimal cena, bool kaskWZestawie, bool posiadaBagaznik) : base(id_pojazd, marka, model, nrRej, dostepnosc, cena)
    {
        this.KaskWZestawie = kaskWZestawie;
        this.PosiadaBagaznik = posiadaBagaznik;
    }
}
