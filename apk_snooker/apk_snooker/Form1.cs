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
        bool poprzedniaczerwona; //przyjmuje true albo false, dla zapamiętania ostatnich ustawień podczas klinkięcia opcji więcej 
        bool poprzedniazolta;
        bool poprzedniazielona;
        Gra aktualnaGra;
        public Form1()
        {
            InitializeComponent();
            aktualnaGra = new Gra();
            this.BackColor = Color.FromArgb(62, 148, 0);
            pudlo.BackColor = Color.FromArgb(119, 215, 100);
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //Blokuje możliwość zmiany rozmiaru okienka
            PanelKonc.BackColor = Color.FromArgb(62, 148, 0);
            PozostaleGB.BackColor = Color.FromArgb(62, 148, 0); //zminia kolor tła na kolor RGB
            nowaGra();
            breakv1.Height = 0;
            breakv2.Height = 0;
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
            PozostaleGB.Visible = false;
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
            if (aktualnaGra.RozpoczynaGracz == 2)
            {
                aktualnaGra.AktualnyGracz = 2;
                wskaznik1.Visible = false;
                wskaznik2.Visible = true;
            }
            else
            {
                aktualnaGra.AktualnyGracz = 1;
                wskaznik1.Visible = true;
                wskaznik2.Visible = false;
            }
        }

        private void ResztaHide()
        {
            PozostaleGB.Visible = false;
            FaulBile.Visible = false;
            WolnaBilaGB.Visible = false;
            WieleCzerwonychGB.Visible = false;
            FaulButton.Visible = true;
            WieleCzerwButton.Visible = true;
            WolnBilaButton.Visible = true;
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
            if (aktualnaGra.Break1 >= 40)
            {
                this.timerbreak1.Enabled = true;
            }
            else if (aktualnaGra.Break2 >= 40)
            {
                this.timerbreak2.Enabled = true;
            }
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
            if (aktualnaGra.Break1 >= 40)
            {
                this.timerbreak1.Enabled = true;
            }
            else if (aktualnaGra.Break2 >= 40)
            {
                this.timerbreak2.Enabled = true;
            }
        }

        private void Ostatnia_Zolta()
        {
            czerwona.Enabled = false;
            czerwona.BackgroundImage = Properties.Resources.bila_czerwona_cb;
            zolta.Enabled = true;
            zolta.BackgroundImage = Properties.Resources.bila_żółta;
            zielona.Enabled = false;
            zielona.BackgroundImage = Properties.Resources.bila_zielona_cb;
            brazowa.Enabled = false;
            brazowa.BackgroundImage = Properties.Resources.bila_brązowa_cb;
            niebieska.Enabled = false;
            niebieska.BackgroundImage = Properties.Resources.bila_niebieska_cb;
            rozowa.Enabled = false;
            rozowa.BackgroundImage = Properties.Resources.bila_różowa_cb;
            czarna.Enabled = false;
            czarna.BackgroundImage = Properties.Resources.bila_czarna_cb;
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

        private void CzyKoniecFrame()
        {
            if (aktualnaGra.CzyKtosWygrywaFrame())
            {
                if (aktualnaGra.AktualnyGracz == 2)
                {
                    MessageBox.Show("Frame wygrywa " + aktualnaGra.Gracz2.Pseudonim);
                    aktualnaGra.WynikGracza2 += 1;
                }
                if (aktualnaGra.AktualnyGracz == 1)
                {
                    MessageBox.Show("Frame wygrywa " + aktualnaGra.Gracz1.Pseudonim);
                    aktualnaGra.WynikGracza1 += 1;
                }
                PanelKoncowy();
                wyncal1.Text = aktualnaGra.WynikGracza1.ToString();
                wyncal2.Text = aktualnaGra.WynikGracza2.ToString();
            }
        }

        private void WolnaBila()
        {
            if (aktualnaGra.AktualnyGracz == 1 && aktualnaGra.Faul2 == true)
            {
                aktualnaGra.PunktyGracza1 += 1;
                aktualnaGra.Break1 += 1;
                wbijkolor();
                aktualnaGra.Faul2 = false;
            }
            else if (aktualnaGra.AktualnyGracz == 2 && aktualnaGra.Faul1 == true)
            {
                aktualnaGra.PunktyGracza2 += 1;
                aktualnaGra.Break2 += 1;
                wbijkolor();
                aktualnaGra.Faul1 = false;
            }
            else
            {
                MessageBox.Show("Musi to być tura przeciwnika");
            }
        }

        private void listaczerwonych()
        {
            WieleCzerwonychGB.Visible = true;
            FaulButton.Visible = false;
            WieleCzerwButton.Visible = false;
            WolnBilaButton.Visible = false;
            listBox1.BeginUpdate();
            for (int x = 1; x <= aktualnaGra.Bce; x++)
            {
                if(x==1) listBox1.Items.Add(x.ToString() + " czerwona");
                if(x>1 && x<5) listBox1.Items.Add(x.ToString() + " czerwone");
                if(x>=5) listBox1.Items.Add(x.ToString() + " czerwonych");
            }
            listBox1.EndUpdate();
        }

        private void WCAkceptujLista()
        {
            string wybrane = listBox1.SelectedItem.ToString(); //przypisuje do stringa wartość wybraną w listbox1
            if (wybrane == "1 czerwona")
            {
                if (aktualnaGra.Bce >= 1) //sprawdza, czy ilość wybrana jest mniejsza od liczby bil czerwonych
                {
                    if (aktualnaGra.AktualnyGracz == 1) //spradza, kto teraz gra
                    {
                        aktualnaGra.PunktyGracza1 += 1;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 1;
                    }
                    aktualnaGra.Bcz -= 1;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "2 czerwone")
            {
                if (aktualnaGra.Bce >= 2)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 2;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 2;
                    }
                    aktualnaGra.Bcz -= 2;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "3 czerwone")
            {
                if (aktualnaGra.Bce >= 3)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 3;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 3;
                    }
                    aktualnaGra.Bcz -= 3;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "4 czerwone")
            {
                if (aktualnaGra.Bce >= 4)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 4;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 4;
                    }
                    aktualnaGra.Bcz -= 4;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "5 czerwonych")
            {
                if (aktualnaGra.Bce >= 5)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 5;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 5;
                    }
                    aktualnaGra.Bce -= 5;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "6 czerwonych")
            {
                if (aktualnaGra.Bce >= 6)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 6;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 6;
                    }
                    aktualnaGra.Bce -= 6;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "7 czerwonych")
            {
                if (aktualnaGra.Bce >= 7)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 7;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 7;
                    }
                    aktualnaGra.Bce -= 7;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "8 czerwonych")
            {
                if (aktualnaGra.Bce >= 8)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 8;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 8;
                    }
                    aktualnaGra.Bce -= 8;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "9 czerwonych")
            {
                if (aktualnaGra.Bce >= 9)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 9;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 9;
                    }
                    aktualnaGra.Bce -= 9;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "10 czerwonych")
            {
                if (aktualnaGra.Bce >= 10)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 10;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 10;
                    }
                    aktualnaGra.Bce -= 10;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "11 czerwonych")
            {
                if (aktualnaGra.Bce >= 11)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 11;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 11;
                    }
                    aktualnaGra.Bce -= 11;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "12 czerwonych")
            {
                if (aktualnaGra.Bce >= 12)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 12;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 12;
                    }
                    aktualnaGra.Bce -= 12;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "13 czerwonych")
            {
                if (aktualnaGra.Bce >= 13)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 13;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 13;
                    }
                    aktualnaGra.Bce -= 13;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "14 czerwonych")
            {
                if (aktualnaGra.Bce >= 14)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 14;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 14;
                    }
                    aktualnaGra.Bce -= 14;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
                }
            }
            if (wybrane == "15 czerwonych")
            {
                if (aktualnaGra.Bce >= 15)
                {
                    if (aktualnaGra.AktualnyGracz == 1)
                    {
                        aktualnaGra.PunktyGracza1 += 15;
                    }
                    else
                    {
                        aktualnaGra.PunktyGracza2 += 15;
                    }
                    aktualnaGra.Bce -= 15;
                }
                else
                {
                    MessageBox.Show("Wybrana liczba przewyższa liczbę bil czerwnych aktualnie znajdujących się na stole.");
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
        }

        private void pudlo_Click(object sender, EventArgs e)
        {
            aktualnaGra.pudlo();
            if (!aktualnaGra.CzyKtosWygrywaFrame())
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
            lbreak1.Text = "0";
            lbreak2.Text = "0";
            CzyKoniecFrame();
        }

        private void czerwona_Click(object sender, EventArgs e)
        {
            aktualnaGra.wbitaCzerwona();
            if (aktualnaGra.AktualnyGracz == 1)
            {
                wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
                lbreak1.Text = aktualnaGra.Break1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
                lbreak2.Text = aktualnaGra.Break2.ToString();
            }
            wbijkolor();
        }

        private void zolta_Click(object sender, EventArgs e)
        {
            aktualnaGra.wbitaZolta();
            if (aktualnaGra.AktualnyGracz == 1)
            {
                wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
                lbreak1.Text = aktualnaGra.Break1.ToString();
            }
            if (aktualnaGra.AktualnyGracz == 2)
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
                lbreak2.Text = aktualnaGra.Break2.ToString();
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
                lbreak1.Text = aktualnaGra.Break1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
                lbreak2.Text = aktualnaGra.Break2.ToString();
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
                lbreak1.Text = aktualnaGra.Break1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
                lbreak2.Text = aktualnaGra.Break2.ToString();
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
                lbreak1.Text = aktualnaGra.Break1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
                lbreak2.Text = aktualnaGra.Break2.ToString();
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
                lbreak1.Text = aktualnaGra.Break1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
                lbreak2.Text = aktualnaGra.Break2.ToString();
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
                lbreak1.Text = aktualnaGra.Break1.ToString();
            }
            else
            {
                wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
                lbreak2.Text = aktualnaGra.Break2.ToString();
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
            CzyKoniecFrame();
        }

        private void cd_Click_1(object sender, EventArgs e)
        {
            Kontynuuj();
        }

        private void koniecgry_Click(object sender, EventArgs e)
        {
            if (aktualnaGra.WynikGracza1 > aktualnaGra.WynikGracza2)
            {
                MessageBox.Show("Grę wygrywa " + aktualnaGra.Gracz1.Pseudonim);
                Application.Exit();
            }
            if (aktualnaGra.WynikGracza1 < aktualnaGra.WynikGracza2)
            {
                MessageBox.Show("Grę wygrywa " + aktualnaGra.Gracz2.Pseudonim);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Regulamin snookera nie zezwala na remis");
            }
        }

        private void Reszta_Click(object sender, EventArgs e)
        {
            PozostaleGB.Visible = true;
            FaulBile.Visible = false;
            WolnaBilaGB.Visible = false;
            WieleCzerwonychGB.Visible = false;
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
            ResztaHide();
        }

        private void PoddMecz_Click(object sender, EventArgs e)
        {
            if (aktualnaGra.AktualnyGracz == 1)
            {
                MessageBox.Show("Grę wygrywa " + aktualnaGra.Gracz2.Pseudonim);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Grę wygrywa " + aktualnaGra.Gracz1.Pseudonim);
                Application.Exit();
            }
        }

        private void PoddFrame_Click(object sender, EventArgs e)
        {
            aktualnaGra.PoddajFrame();
            CzyKoniecFrame();
        }

        private void FaulButton_Click(object sender, EventArgs e)
        {
            FaulBile.Visible = true;
            FaulButton.Visible = false;
            WieleCzerwButton.Visible = false;
            WolnBilaButton.Visible = false;
        }

        private void FaulZa4_MouseCaptureChanged(object sender, EventArgs e)
        {
            aktualnaGra.Faulza4();
            ResztaHide();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
        }

        private void FaulZa5_MouseCaptureChanged(object sender, EventArgs e)
        {
            aktualnaGra.Faulza5();
            ResztaHide();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
        }

        private void FaulZa6_MouseCaptureChanged(object sender, EventArgs e)
        {
            aktualnaGra.Faulza6();
            ResztaHide();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
        }

        private void FaulZa7_MouseCaptureChanged(object sender, EventArgs e)
        {
            aktualnaGra.Faulza7();
            ResztaHide();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
        }

        private void WolnBilaButton_Click(object sender, EventArgs e)
        {
            if (aktualnaGra.AktualnyGracz == 1 && aktualnaGra.Faul2 == true)
            {
                WolnaBilaGB.Visible = true;
                FaulButton.Visible = false;
                WieleCzerwButton.Visible = false;
                WolnBilaButton.Visible = false;
            }
            else if (aktualnaGra.AktualnyGracz == 1 && aktualnaGra.Faul1 == true)
            {
                MessageBox.Show("Musi to być tura przeciwnika");
            }
            else if (aktualnaGra.AktualnyGracz == 2 && aktualnaGra.Faul1 == true)
            {
                WolnaBilaGB.Visible = true;
                FaulButton.Visible = false;
                WieleCzerwButton.Visible = false;
                WolnBilaButton.Visible = false;
            }
            else if (aktualnaGra.AktualnyGracz == 2 && aktualnaGra.Faul2 == true)
            {
                MessageBox.Show("Musi to być tura przeciwnika");
            }
            else
            {
                MessageBox.Show("Wpierw musi nastąpić faul");
            }
        }

        private void ZoltaWB_Click(object sender, EventArgs e)
        {
            ResztaHide();
            WolnaBila();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            lbreak1.Text = aktualnaGra.Break1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            lbreak2.Text = aktualnaGra.Break2.ToString();
            aktualnaGra.Faul1 = false;
            aktualnaGra.Faul2 = false;
        }

        private void ZielonaWB_Click(object sender, EventArgs e)
        {
            ResztaHide();
            WolnaBila();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            lbreak1.Text = aktualnaGra.Break1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            lbreak2.Text = aktualnaGra.Break2.ToString();
            aktualnaGra.Faul1 = false;
            aktualnaGra.Faul2 = false;
        }

        private void BrazowaWB_Click(object sender, EventArgs e)
        {
            ResztaHide();
            WolnaBila();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            lbreak1.Text = aktualnaGra.Break1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            lbreak2.Text = aktualnaGra.Break2.ToString();
            aktualnaGra.Faul1 = false;
            aktualnaGra.Faul2 = false;
        }

        private void NiebieskaWB_Click(object sender, EventArgs e)
        {
            ResztaHide();
            WolnaBila();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            lbreak1.Text = aktualnaGra.Break1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            lbreak2.Text = aktualnaGra.Break2.ToString();
            aktualnaGra.Faul1 = false;
            aktualnaGra.Faul2 = false;
        }

        private void RozowaWB_Click(object sender, EventArgs e)
        {
            ResztaHide();
            WolnaBila();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            lbreak1.Text = aktualnaGra.Break1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            lbreak2.Text = aktualnaGra.Break2.ToString();
            aktualnaGra.Faul1 = false;
            aktualnaGra.Faul2 = false;
        }

        private void CzarnaWB_Click(object sender, EventArgs e)
        {
            ResztaHide();
            WolnaBila();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            lbreak1.Text = aktualnaGra.Break1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            lbreak2.Text = aktualnaGra.Break2.ToString();
            aktualnaGra.Faul1 = false;
            aktualnaGra.Faul2 = false;
        }

        private void WieleCzerwButton_Click(object sender, EventArgs e)
        {
            listaczerwonych();
        }

        private void WCAkceptuj_Click(object sender, EventArgs e)
        {
            WCAkceptujLista();
            wynpart1.Text = aktualnaGra.PunktyGracza1.ToString();
            wynpart2.Text = aktualnaGra.PunktyGracza2.ToString();
            ResztaHide();
            wbijkolor();
        }

        private void WCAnuluj_Click(object sender, EventArgs e)
        {
            ResztaHide();
        }

        private void timerbreak1_Tick(object sender, EventArgs e)
        {
            if(aktualnaGra.Break1 >= 40)
            {
                breakv1.Height += 27;
            }
        }

        private void timerbreak2_Tick(object sender, EventArgs e)
        {
            if (aktualnaGra.Break2 >= 40)
            {
                breakv2.Height += 27;
            }
        }
    }
}