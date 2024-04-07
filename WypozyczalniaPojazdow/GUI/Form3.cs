using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class WypozyczPojazdForm : Form
    {
        private List<Pojazd> pojazdy;

        public WypozyczPojazdForm()
        {
            InitializeComponent();
            pojazdy = CsvHelper.OdczytajPojazdyZPliku();
            WczytajDostepnePojazdy();
        }

        private void WczytajDostepnePojazdy()
        {
            comboBox1.DataSource = pojazdy.FindAll(p => p.Dostepnosc);
            comboBox1.DisplayMember = "Nazwa";
            comboBox1.ValueMember = "ID_Pojazd";
        }

        private void btnWypozycz_Click(object sender, EventArgs e)
        {

        }

        private void WyczyscPolaWypozyczenia()
        {
            comboBox1.SelectedIndex = -1;
            textBoxLD.Text = "";
        }

        private void txtLiczbaDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedPojazdID;
                if (comboBox1.SelectedValue != null && int.TryParse(comboBox1.SelectedValue.ToString(), out selectedPojazdID))
                {
                    Pojazd selectedPojazd = pojazdy.Find(p => p.ID_Pojazd == selectedPojazdID);

                    if (selectedPojazd != null && selectedPojazd.Dostepnosc)
                    {
                        int liczbaDni;
                        if (int.TryParse(textBoxLD.Text, out liczbaDni))
                        {
                            decimal cenaWypozyczenia = selectedPojazd.Cena * liczbaDni;

                            selectedPojazd.Dostepnosc = false;

                            CsvHelper.ZapiszPojazdyDoPliku(pojazdy);

                            MessageBox.Show($"Pojazd został wypożyczony na {liczbaDni} dni.\nCena wypożyczenia: {cenaWypozyczenia:C}");
                            WyczyscPolaWypozyczenia();
                            WczytajDostepnePojazdy(); // Odśwież dostępne pojazdy po wypożyczeniu
                        }
                        else
                        {
                            MessageBox.Show("Podaj poprawną liczbę dni.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wybrany pojazd jest niedostępny.");
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz poprawny pojazd.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Wystąpił błąd: Niepoprawne odwołanie do obiektu.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

