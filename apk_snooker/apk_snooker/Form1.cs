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
            nowaGra();
            aktualnaGra = new Gra();
        }
        private void nowaGra()
        {
            bileView.Visible = false;
            wskaznik1.Visible = false;
            wskaznik2.Visible = false;
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
                MessageBox.Show("Witam w Snookcount, aplikacji pomagającej zliczać punkty w snookerze. Rzyczę miłej zabawy.");
                newGame.Visible = false;
                bileView.Visible = true;
            }
            else
            {
                MessageBox.Show("Pola z nazwami graczy muszą być uzupełnione!");
            }
        }
    }
}