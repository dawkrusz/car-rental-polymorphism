using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IWypozyczalnia
{
    List<Samochod> WyswietlSamochody();
    List<Motor> WyswietlMotory();
    void DodajPojazd(Pojazd pojazd);
    void WypozyczPojazd(int id, int iloscDni);
}

