namespace Wypozalnia
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWyswietlSamochody = new System.Windows.Forms.Button();
            this.btnWyswietlMotory = new System.Windows.Forms.Button();
            this.btnDodajPojazd = new System.Windows.Forms.Button();
            this.btnWypozycz = new System.Windows.Forms.Button();
            this.listBoxSamochody = new System.Windows.Forms.ListBox();
            this.listBoxMotory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnWyswietlSamochody
            // 
            this.btnWyswietlSamochody.Location = new System.Drawing.Point(607, 34);
            this.btnWyswietlSamochody.Name = "btnWyswietlSamochody";
            this.btnWyswietlSamochody.Size = new System.Drawing.Size(138, 23);
            this.btnWyswietlSamochody.TabIndex = 0;
            this.btnWyswietlSamochody.Text = "Wyswietl samochody";
            this.btnWyswietlSamochody.UseVisualStyleBackColor = true;
            this.btnWyswietlSamochody.Click += new System.EventHandler(this.btnWyswietlSamochody_Click_1);
            // 
            // btnWyswietlMotory
            // 
            this.btnWyswietlMotory.Location = new System.Drawing.Point(607, 362);
            this.btnWyswietlMotory.Name = "btnWyswietlMotory";
            this.btnWyswietlMotory.Size = new System.Drawing.Size(125, 23);
            this.btnWyswietlMotory.TabIndex = 1;
            this.btnWyswietlMotory.Text = "Wyswietl motory";
            this.btnWyswietlMotory.UseVisualStyleBackColor = true;
            this.btnWyswietlMotory.Click += new System.EventHandler(this.btnWyswietlMotory_Click_1);
            // 
            // btnDodajPojazd
            // 
            this.btnDodajPojazd.Location = new System.Drawing.Point(298, 693);
            this.btnDodajPojazd.Name = "btnDodajPojazd";
            this.btnDodajPojazd.Size = new System.Drawing.Size(109, 47);
            this.btnDodajPojazd.TabIndex = 2;
            this.btnDodajPojazd.Text = "Przejdz do dodawania i usuwania";
            this.btnDodajPojazd.UseVisualStyleBackColor = true;
            this.btnDodajPojazd.Click += new System.EventHandler(this.btnDodajPojazd_Click_1);
            // 
            // btnWypozycz
            // 
            this.btnWypozycz.Location = new System.Drawing.Point(911, 693);
            this.btnWypozycz.Name = "btnWypozycz";
            this.btnWypozycz.Size = new System.Drawing.Size(102, 47);
            this.btnWypozycz.TabIndex = 3;
            this.btnWypozycz.Text = "Przejdz do wypozyczen";
            this.btnWypozycz.UseVisualStyleBackColor = true;
            this.btnWypozycz.Click += new System.EventHandler(this.btnWypozycz_Click_1);
            // 
            // listBoxSamochody
            // 
            this.listBoxSamochody.FormattingEnabled = true;
            this.listBoxSamochody.Location = new System.Drawing.Point(61, 76);
            this.listBoxSamochody.Name = "listBoxSamochody";
            this.listBoxSamochody.Size = new System.Drawing.Size(1201, 251);
            this.listBoxSamochody.TabIndex = 4;
            this.listBoxSamochody.SelectedIndexChanged += new System.EventHandler(this.listBoxSamochody_SelectedIndexChanged);
            // 
            // listBoxMotory
            // 
            this.listBoxMotory.FormattingEnabled = true;
            this.listBoxMotory.Location = new System.Drawing.Point(61, 422);
            this.listBoxMotory.Name = "listBoxMotory";
            this.listBoxMotory.Size = new System.Drawing.Size(1201, 225);
            this.listBoxMotory.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1311, 756);
            this.Controls.Add(this.listBoxMotory);
            this.Controls.Add(this.listBoxSamochody);
            this.Controls.Add(this.btnWypozycz);
            this.Controls.Add(this.btnDodajPojazd);
            this.Controls.Add(this.btnWyswietlMotory);
            this.Controls.Add(this.btnWyswietlSamochody);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWyswietlSamochody;
        private System.Windows.Forms.Button btnWyswietlMotory;
        private System.Windows.Forms.Button btnDodajPojazd;
        private System.Windows.Forms.Button btnWypozycz;
        private System.Windows.Forms.ListBox listBoxSamochody;
        private System.Windows.Forms.ListBox listBoxMotory;
    }
}

