using CarRentalSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozalnia.GUI;


namespace Wypozalnia
{
    public partial class Form1 : Form
    {
        private IWypozyczalnia wypozyczalnia;

        private List<Pojazd> pojazdy;

        public Form1()
        {
            InitializeComponent();
            wypozyczalnia = new Wypozyczalnia();
            pojazdy = CsvHelper.OdczytajPojazdyZPliku();
        }

        private void btnWyswietlSamochody_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWyswietlMotory_Click(object sender, EventArgs e)
        {

            
        }

        private void btnDodajPojazd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUsunPojazd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWypozycz_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajPojazd_Click_1(object sender, EventArgs e)
        {

            Form2 form = new Form2();

            form.ShowDialog();

            listBoxSamochody.Items.Clear();
            listBoxMotory.Items.Clear();
        }

        private void btnWypozycz_Click_1(object sender, EventArgs e)
        {
            WypozyczPojazdForm form = new WypozyczPojazdForm();

            form.ShowDialog();

            listBoxSamochody.Items.Clear();
            listBoxMotory.Items.Clear();
        }

        private void btnWyswietlSamochody_Click_1(object sender, EventArgs e)
        {
            List<Pojazd> pojazdy = CsvHelper.OdczytajPojazdyZPliku();
            List<Samochod> samochody = pojazdy.FindAll(p => p is Samochod).ConvertAll(p => (Samochod)p);

            listBoxSamochody.Items.Clear();

            foreach (Samochod samochod in samochody)
            {
                listBoxSamochody.Items.Add($"ID: {samochod.ID_Pojazd}, Marka: {samochod.Marka}, Model: {samochod.Model}, Numer rejestracyjny: {samochod.NumerRejestracyjny}, " +
                    $"Dostępność: {samochod.Dostepnosc}, Cena: {samochod.Cena:C}, Ilość drzwi: {samochod.IloscDrzwi}, Liczba miejsc: {samochod.LiczbaMiejsc}, " +
                    $"Klimatyzacja: {samochod.Klimatyzacja}");
            }
            
        }

        private void btnWyswietlMotory_Click_1(object sender, EventArgs e)
        {
            List<Pojazd> pojazdy = CsvHelper.OdczytajPojazdyZPliku();
            List<Motor> motory = pojazdy.FindAll(p => p is Motor).ConvertAll(p => (Motor)p);

            listBoxMotory.Items.Clear();

            foreach (Motor motor in motory)
            {
                listBoxMotory.Items.Add($"ID: {motor.ID_Pojazd}, Marka: {motor.Marka}, Model: {motor.Model}, Numer rejestracyjny: {motor.NumerRejestracyjny}, " +
                    $"Dostępność: {motor.Dostepnosc}, Cena: {motor.Cena:C}, Kask w zestawie: {motor.KaskWZestawie}, Posiada bagażnik: {motor.PosiadaBagaznik}");
            }
        }

        private void listBoxSamochody_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

