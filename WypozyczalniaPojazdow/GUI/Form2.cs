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


namespace Wypozalnia.GUI
{
    public partial class Form2 : Form
    {
        private List<Pojazd> pojazdy;


        public Form2()
        {
            InitializeComponent();
            pojazdy = CsvHelper.OdczytajPojazdyZPliku();
        }

        private void btnDodajSamochod_Click(object sender, EventArgs e)
        {


        }

        private void btnDodajMotor_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }


        private void WyczyscPolaSamochodu()
        {
            txtMarka.Text = "";
            txtModel.Text = "";
            txtNumerRejestracyjny.Text = "";
            txtCena.Text = "";
            txtIloscDrzwi.Text = "";
            txtLiczbaMiejsc.Text = "";
            chkKlimatyzacja.Checked = false;
        }

        private void WyczyscPolaMotocykla()
        {
            txtMarka.Text = "";
            txtModel.Text = "";
            txtNumerRejestracyjny.Text = "";
            txtCena.Text = "";
            chkKaskWZestawie.Checked = false;
            chkPosiadaBagaznik.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var wypozyczalnia = new Wypozyczalnia();
                int id = wypozyczalnia.OdczytajOstatnieID();
                int id_pojazd = ++id;
                string marka = txtMarka.Text;
                string model = txtModel.Text;
                string numerRejestracyjny = txtNumerRejestracyjny.Text;
                bool dostepnosc = true; // Samochód jest dostępny po dodaniu
                decimal cena = decimal.Parse(txtCena.Text);
                int iloscDrzwi = int.Parse(txtIloscDrzwi.Text);
                int liczbaMiejsc = int.Parse(txtLiczbaMiejsc.Text);
                bool klimatyzacja = chkKlimatyzacja.Checked;

                Samochod samochod1 = new Samochod(id_pojazd, marka, model, numerRejestracyjny, dostepnosc, cena, iloscDrzwi, liczbaMiejsc, klimatyzacja);
                pojazdy.Add(samochod1);

                CsvHelper.ZapiszPojazdyDoPliku(pojazdy);

                pojazdy.Clear();

                MessageBox.Show("Samochód został dodany.");
                WyczyscPolaSamochodu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas dodawania samochodu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var wypozyczalnia = new Wypozyczalnia();
                int id = wypozyczalnia.OdczytajOstatnieID();
                int id_pojazd = ++id;
                string marka = txtMarka.Text;
                string model = txtModel.Text;
                string numerRejestracyjny = txtNumerRejestracyjny.Text;
                bool dostepnosc = true; // Motocykl jest dostępny po dodaniu
                decimal cena = decimal.Parse(txtCena.Text);
                bool kaskWZestawie = chkKaskWZestawie.Checked;
                bool posiadaBagaznik = chkPosiadaBagaznik.Checked;

                Motor motor1 = new Motor(id_pojazd, marka, model, numerRejestracyjny, dostepnosc, cena, kaskWZestawie, posiadaBagaznik);
                pojazdy.Add(motor1);

                CsvHelper.ZapiszPojazdyDoPliku(pojazdy);

                pojazdy.Clear();

                MessageBox.Show("Motocykl został dodany.");
                WyczyscPolaMotocykla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas dodawania motocykla: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);

                CsvHelper.UsunPojazdZPliku(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas usuwania pojazdu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
