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
        Gra aktualnaGra;
        public Form1()
        {
            InitializeComponent();
            aktualnaGra = new Gra();
            this.BackColor = Color.FromArgb(62, 148, 0);
            pudlo.BackColor = Color.FromArgb(62, 148, 0);
            nowaGra();
        }
        private void nowaGra()
        {
            bileView.Visible = false;
            czerwona.Visible = true;
            zolta.Visible = false;
            zielona.Visible = false;
            brazowa.Visible = false;
            niebieska.Visible = false;
            rozowa.Visible = false;
            czarna.Visible = false;
        }
        private void wbijczerwona()
        {
            czerwona.Visible = true;
            zolta.Visible = false;
            zielona.Visible = false;
            brazowa.Visible = false;
            niebieska.Visible = false;
            rozowa.Visible = false;
            czarna.Visible = false;
        }
        public void CzyKoniecGry()
        {
            if (aktualnaGra.Koniec)
            {
                if (aktualnaGra.AktualnyGracz == 1)
                {
                    MessageBox.Show("Mecz wygrywa" + aktualnaGra.Gracz1.Pseudonim);
                }
                else
                {
                    MessageBox.Show("Mecz wygrywa" + aktualnaGra.Gracz2.Pseudonim);
                }
            }
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
            }
            else
            {
                MessageBox.Show("Pola z nazwami graczy muszą być uzupełnione!");
            }
            
        }
        private void pudlo_Click(object sender, EventArgs e)
        {
            aktualnaGra.pudlo();
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
            czerwona.Visible = true;
            wbijczerwona();
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
            czerwona.Visible = false;
            zolta.Visible = true;
            zielona.Visible = true;
            brazowa.Visible = true;
            niebieska.Visible = true;
            rozowa.Visible = true;
            czarna.Visible = true;
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
            czerwona.Enabled = true;
            wbijczerwona();
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
            czerwona.Enabled = true;
            wbijczerwona();
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
            czerwona.Enabled = true;
            wbijczerwona();
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
            czerwona.Enabled = true;
            wbijczerwona();
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
            czerwona.Enabled = true;
            wbijczerwona();
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
            czerwona.Enabled = true;
            wbijczerwona();
        }
    }
}