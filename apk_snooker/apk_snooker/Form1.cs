using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apk_snooker
{
    public partial class Form1 : Form
    {
        bool poprzedniaczerwona;
        bool poprzedniazolta;
        bool poprzedniazielona;
        Gra aktualnaGra;
        public Form1()
        {
            InitializeComponent();
            aktualnaGra = new Gra();
            this.BackColor = Color.FromArgb(62, 148, 0);
            pudlo.BackColor = Color.FromArgb(119, 215, 100);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            PanelKonc.BackColor = Color.FromArgb(62, 148, 0);
            PozostaleGB.BackColor = Color.FromArgb(62, 148, 0);
            nowaGra();
        }
        private void nowaGra()
        {
            bileView.Visible = false;
            PanelKonc.Visible = false;
            PozostaleGB.Visible = false;
            zolta.BackgroundImage = Properties.Resources.bila_żółta_cb;
            zielona.BackgroundImage = Properties.Resources.bila_zielona_cb;
            brazowa.BackgroundImage = Properties.Resources.bila_brązowa_cb;
            niebieska.BackgroundImage = Properties.Resources.bila_niebieska_cb;
            rozowa.BackgroundImage = Properties.Resources.bila_różowa_cb;
            czarna.BackgroundImage = Properties.Resources.bila_czarna_cb;
        }
        public void Kontynuuj()
        {
            bileView.Visible = true;
            PanelKonc.Visible = false;
            aktualnaGra.Bce = 15;
            aktualnaGra.Bzo = 7;
            aktualnaGra.Bzi = 7;
            aktualnaGra.Bbr = 7;
            aktualnaGra.Bni = 7;
            aktualnaGra.Bro = 7;
            aktualnaGra.Bcz = 7;
            //tu kod do eksportu do xml :)

            aktualnaGra.PunktyGracza1 = 0;
            wynpart1.Text = "0";
            wynpart2.Text = "0";
            aktualnaGra.PunktyGracza2 = 0;
            wbijczerwona();
            aktualnaGra.Rozpoczyna();
            if (aktualnaGra.AktualnyGracz == 2)
            {
                wskaznik1.Visible = false;
                wskaznik2.Visible = true;
            }
            else
            {
                wskaznik1.Visible = true;
                wskaznik2.Visible = false;
            }
        }
        private void wbijczerwona()
        {
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona;
            czerwona.Enabled = true;
            zolta.BackgroundImage = Properties.Resources.bila_żółta_cb;
            zolta.Enabled = false;
            zielona.BackgroundImage = Properties.Resources.bila_zielona_cb;
            zielona.Enabled = false;
            brazowa.BackgroundImage = Properties.Resources.bila_brązowa_cb;
            brazowa.Enabled = false;
            niebieska.BackgroundImage = Properties.Resources.bila_niebieska_cb;
            niebieska.Enabled = false;
            rozowa.BackgroundImage = Properties.Resources.bila_różowa_cb;
            rozowa.Enabled = false;
            czarna.BackgroundImage = Properties.Resources.bila_czarna_cb;
            czarna.Enabled = false;
            liczby();
        }
        private void wbijkolor()
        {
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona_cb;
            czerwona.Enabled = false;
            zolta.BackgroundImage = Properties.Resources.bila_żółta;
            zolta.Enabled = true;
            zielona.BackgroundImage = Properties.Resources.bila_zielona;
            zielona.Enabled = true;
            brazowa.BackgroundImage = Properties.Resources.bila_brązowa;
            brazowa.Enabled = true;
            niebieska.BackgroundImage = Properties.Resources.bila_niebieska;
            niebieska.Enabled = true;
            rozowa.BackgroundImage = Properties.Resources.bila_różowa;
            rozowa.Enabled = true;
            czarna.BackgroundImage = Properties.Resources.bila_czarna;
            czarna.Enabled = true;
            liczby();
        }
        private void Ostatnia_Zolta()
        {
            czerwona.Enabled = false;
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona_cb;
            zolta.Enabled = true;
            zolta.BackgroundImage = Properties.Resources.bila_żółta;
            zielona.Enabled = false;
            brazowa.Enabled = false;
            niebieska.Enabled = false;
            rozowa.Enabled = false;
            czarna.Enabled = false;
        }
        private void Ostatnia_Zielona()
        {
            czerwona.Enabled = false;
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona_cb;
            zolta.Enabled = false;
            zolta.BackgroundImage = Properties.Resources.bila_żółta_cb;
            zielona.Enabled = true;
            zielona.BackgroundImage = Properties.Resources.bila_zielona;
            brazowa.Enabled = false;
            niebieska.Enabled = false;
            rozowa.Enabled = false;
            czarna.Enabled = false;
        }
        private void Ostatnia_Brazowa()
        {
            czerwona.Enabled = false;
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona_cb;
            zolta.Enabled = false;
            zielona.Enabled = false;
            zielona.BackgroundImage = Properties.Resources.bila_zielona_cb;
            brazowa.Enabled = true;
            brazowa.BackgroundImage = Properties.Resources.bila_brązowa;
            niebieska.Enabled = false;
            rozowa.Enabled = false;
            czarna.Enabled = false;
        }
        private void Ostatnia_Niebieska()
        {
            czerwona.Enabled = false;
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona_cb;
            zolta.Enabled = false;
            zielona.Enabled = false;
            brazowa.Enabled = false;
            brazowa.BackgroundImage = Properties.Resources.bila_brązowa_cb;
            niebieska.Enabled = true;
            niebieska.BackgroundImage = Properties.Resources.bila_niebieska;
            rozowa.Enabled = false;
            czarna.Enabled = false;
        }
        private void Ostatnia_Rozowa()
        {
            czerwona.Enabled = false;
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona_cb;
            zolta.Enabled = false;
            zielona.Enabled = false;
            brazowa.Enabled = false;
            niebieska.Enabled = false;
            niebieska.BackgroundImage = Properties.Resources.bila_niebieska_cb;
            rozowa.Enabled = true;
            rozowa.BackgroundImage = Properties.Resources.bila_różowa;
            czarna.Enabled = false;
        }
        private void Ostatnia_Czarna()
        {
            czerwona.Enabled = false;
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona_cb;
            zolta.Enabled = false;
            zielona.Enabled = false;
            brazowa.Enabled = false;
            niebieska.Enabled = false;
            rozowa.Enabled = false;
            rozowa.BackgroundImage = Properties.Resources.bila_różowa_cb;
            czarna.Enabled = true;
            czarna.BackgroundImage = Properties.Resources.bila_czarna;
        }
        private void PanelKoncowy()
        {
            PanelKonc.Visible = true;
            bileView.Visible = false;
        }
        public void CzyKoniecBreak()
        {
            if (aktualnaGra.Koniecframe)
            {
                if (aktualnaGra.AktualnyGracz == 2)
                {
                    MessageBox.Show("Frame wygrywa " + aktualnaGra.Gracz2.Pseudonim);
                    aktualnaGra.Frame2 += 1;
                }
                if (aktualnaGra.AktualnyGracz == 1)
                {
                    MessageBox.Show("Frame wygrywa " + aktualnaGra.Gracz1.Pseudonim);
                    aktualnaGra.Frame1 += 1;
                }
                PanelKoncowy();
                wyncal1.Text = aktualnaGra.Frame1.ToString();
                wyncal2.Text = aktualnaGra.Frame2.ToString();
            }
        }
        private void liczby()
        {
            label6.Text = aktualnaGra.Bce.ToString();
            label7.Text = aktualnaGra.Bzo.ToString();
            label9.Text = aktualnaGra.Bzi.ToString();
            label11.Text = aktualnaGra.Bbr.ToString();
            label13.Text = aktualnaGra.Bni.ToString();
            label15.Text = aktualnaGra.Bro.ToString();
            label17.Text = aktualnaGra.Bcz.ToString();
        }
        private void NowaGra_Click(object sender, EventArgs e)
        {
            if (gracz1.Text != "" && gracz2.Text != "")
            {
                MessageBox.Show("Witam w Snookcount, aplikacji pomagającej zliczać punkty w snookerze. Życzę miłej zabawy.");
                newGame.Visible = false;
                bileView.Visible = true;
                gracz1.Enabled = false;
                gracz2.Enabled = false;
                wskaznik1.Visible = true;
                if (aktualnaGra.RozpoczynaGracz == 1)
                {
                    aktualnaGra.nowaGra(gracz1.Text, gracz2.Text, 1);
                }
                else
                {
                    aktualnaGra.nowaGra(gracz1.Text, gracz2.Text, 2);
                }
            }
            else
            {
                MessageBox.Show("Pola z nazwami graczy muszą być uzupełnione!");
            }
            liczby();
        }
        private void pudlo_Click(object sender, EventArgs e)
        {
            aktualnaGra.pudlo();
            if (!aktualnaGra.Koniecframe)
            {
                if (aktualnaGra.AktualnyGracz == 2)
                {
                    wskaznik1.Visible = false;
                    wskaznik2.Visible = true;
                }
                else
                {
                    wskaznik1.Visible = true;
                    wskaznik2.Visible = false;
                }
                if (aktualnaGra.Bcz > 0)
                {
                    wbijczerwona();
                }
                else
                {
                    wbijkolor();
                }
                if (aktualnaGra.Bzo == 6)
                {
                    Ostatnia_Zolta();
                }
                if (aktualnaGra.Bzi == 5)
                {
                    Ostatnia_Zielona();
                }
                if (aktualnaGra.Bbr == 4)
                {
                    Ostatnia_Brazowa();
                }
                if (aktualnaGra.Bni == 3)
                {
                    Ostatnia_Niebieska();
                }
                if (aktualnaGra.Bro == 2)
                {
                    Ostatnia_Rozowa();
                }
                if (aktualnaGra.Bcz == 1)
                {
                    Ostatnia_Czarna();
                }
            }
            CzyKoniecBreak();
        }
        private void czerwona_Click(object sender, EventArgs e)
        {
            aktualnaGra.wbitaCzerwona();
            if (aktualnaGra.AktualnyGracz == 1)
            {
                wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            }
            wbijkolor();
        }
        private void zolta_Click(object sender, EventArgs e)
        {
            aktualnaGra.wbitaZolta();
            if (aktualnaGra.AktualnyGracz == 1)
            {
                wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            }
            if (aktualnaGra.Bzo >= 7)
            {
                wbijczerwona();
                czerwona.Enabled = true;
            }
            if (aktualnaGra.Bzo == 6)
            {
                Ostatnia_Zolta();
            }
            else if (aktualnaGra.Bzo < 6)
            {
                zolta.BackgroundImage = Properties.Resources.bila_żółta_cb;
                zolta.Enabled = false;
            }
            if (aktualnaGra.Bzi == 5)
            {
                Ostatnia_Zielona();
            }
        }
        private void zielona_Click(object sender, EventArgs e)
        {
            aktualnaGra.wbitaZielona();
            if (aktualnaGra.AktualnyGracz == 1)
            {
                wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            }
            if (aktualnaGra.Bzi > 5)
            {
                wbijczerwona();
                czerwona.Enabled = true;
            }
            else if (aktualnaGra.Bzi < 5)
            {
                zielona.BackgroundImage = Properties.Resources.bila_zielona_cb;
                zielona.Enabled = false;
            }
            if (aktualnaGra.Bzo == 6)
            {
                Ostatnia_Zolta();
            }
            if (aktualnaGra.Bbr == 4)
            {
                Ostatnia_Brazowa();
            }
        }
        private void brazowa_Click(object sender, EventArgs e)
        {
            aktualnaGra.wbitaBrazowa();
            if (aktualnaGra.AktualnyGracz == 1)
            {
                wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            }
            if (aktualnaGra.Bbr > 4)
            {
                wbijczerwona();
                czerwona.Enabled = true;
            }
            else if (aktualnaGra.Bbr < 4)
            {
                brazowa.BackgroundImage = Properties.Resources.bila_brązowa_cb;
                brazowa.Enabled = false;
            }
            if (aktualnaGra.Bzo == 6)
            {
                Ostatnia_Zolta();
            }
            if (aktualnaGra.Bni == 3)
            {
                Ostatnia_Niebieska();
            }
        }
        private void niebieska_Click(object sender, EventArgs e)
        {
            aktualnaGra.wbitaNiebieska();
            if (aktualnaGra.AktualnyGracz == 1)
            {
                wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            }
            if (aktualnaGra.Bni > 3)
            {
                wbijczerwona();
                czerwona.Enabled = true;
            }
            else if (aktualnaGra.Bni < 3)
            {
                niebieska.BackgroundImage = Properties.Resources.bila_niebieska_cb;
                niebieska.Enabled = false;
            }
            if (aktualnaGra.Bzo == 6)
            {
                Ostatnia_Zolta();
            }
            if (aktualnaGra.Bro == 2)
            {
                Ostatnia_Rozowa();
            }
        }
        private void rozowa_Click(object sender, EventArgs e)
        {
            aktualnaGra.wbitaRozowa();
            if (aktualnaGra.AktualnyGracz == 1)
            {
                wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            }
            if (aktualnaGra.Bro > 2)
            {
                wbijczerwona();
                czerwona.Enabled = true;
            }
            else if (aktualnaGra.Bro < 2)
            {
                rozowa.BackgroundImage = Properties.Resources.bila_różowa_cb;
                rozowa.Enabled = false;
            }
            if (aktualnaGra.Bzo == 6)
            {
                Ostatnia_Zolta();
            }
            if (aktualnaGra.Bcz == 1)
            {
                Ostatnia_Czarna();
            }
        }
        private void czarna_Click(object sender, EventArgs e)
        {
            aktualnaGra.wbitaCzarna();
            if (aktualnaGra.AktualnyGracz == 1)
            {
                wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            }
            if (aktualnaGra.Bcz > 1)
            {
                wbijczerwona();
                czerwona.Enabled = true;
            }
            else if (aktualnaGra.Bcz < 1)
            {
                czarna.BackgroundImage = Properties.Resources.bila_czarna_cb;
                czarna.Enabled = false;
            }
            if (aktualnaGra.Bzo == 6)
            {
                Ostatnia_Zolta();
            }
            CzyKoniecBreak();
        }
        private void cd_Click_1(object sender, EventArgs e)
        {
            Kontynuuj();
        }
        private void koniecgry_Click(object sender, EventArgs e)
        {
            if (aktualnaGra.Koniecmecz)
            {
                if (aktualnaGra.WynikGracza1 > aktualnaGra.WynikGracza2)
                {
                    MessageBox.Show("Grę wygrywa " + aktualnaGra.Gracz1.Pseudonim);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Grę wygrywa " + aktualnaGra.Gracz2.Pseudonim);
                    Application.Exit();
                }
            }
        }
        private void Reszta_Click(object sender, EventArgs e)
        {
            PozostaleGB.Visible = true;
            if (czerwona.Enabled == true)
            {
                poprzedniaczerwona = true;
            }
            if (zolta.Enabled == true)
            {
                poprzedniazolta = true;
            }
            if (zielona.Enabled == true)
            {
                poprzedniazielona = true;
            }
            czerwona.Enabled = false;
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona_cb;
            zolta.Enabled = false;
            zolta.BackgroundImage = Properties.Resources.bila_żółta_cb;
            zielona.Enabled = false;
            zielona.BackgroundImage = Properties.Resources.bila_zielona_cb;
        }
        private void Reszta2_Click(object sender, EventArgs e)
        {
            PozostaleGB.Visible = false;
            if (poprzedniaczerwona == true)
            {
                czerwona.Enabled = true;
                czerwona.BackgroundImage = Properties.Resources.bila_czerwona;
            }
            if (poprzedniazolta == true)
            {
                zolta.Enabled = true;
                zolta.BackgroundImage = Properties.Resources.bila_żółta;
            }
            if (poprzedniazielona == true)
            {
                zielona.Enabled = true;
                zielona.BackgroundImage = Properties.Resources.bila_zielona;
            }
            poprzedniaczerwona = false;
            poprzedniazolta = false;
            poprzedniazielona = false;
        }
    }
}