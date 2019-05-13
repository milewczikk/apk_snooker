using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apk_snooker
{
    class Gra
    {
        private Gracz gracz1;
        private Gracz gracz2;
        private int wynikGracza1;
        private int punktyGracza1;
        private int wynikGracza2;
        private int punktyGracza2;
        private int aktualnyGracz;
        private int rozpoczynaGracz;
        private int bce = 15; //bile czerwone
        private int bzo = 1; //bila żółta
        private int bzi = 1; //bila zielona
        private int bbr = 1; //bila brązowa
        private int bni = 1; //bila niebieska
        private int bro = 1; //bila różowa
        private int bcz = 1; //bila czarna
        Boolean koniec;
        public Gra()
        {
            AktualnyGracz1 = 1;
            rozpoczynaGracz = 1;
            gracz1 = new Gracz("pseudonim");
            gracz2 = new Gracz("pseudonim");
            wynikGracza1 = 0;
            wynikGracza2 = 0;
            punktyGracza1 = 0;
            punktyGracza2 = 0;
            
        }

        public Gracz Gracz1 { get => gracz1; set => gracz1 = value; }
        public Gracz Gracz2 { get => gracz2; set => gracz2 = value; }
        public int WynikGracza1 { get => wynikGracza1; set => wynikGracza1 = value; }
        public int WynikGracza2 { get => wynikGracza2; set => wynikGracza2 = value; }
        public int AktualnyGracz { get => aktualnyGracz; set => aktualnyGracz = value; }
        public int RozpoczynaGracz { get => rozpoczynaGracz; set => rozpoczynaGracz = value; }
        public bool Koniec { get => koniec; set => koniec = value; }
        public int AktualnyGracz1 { get => aktualnyGracz; set => aktualnyGracz = value; }
        public int PunktyGracza1 { get => punktyGracza1; set => punktyGracza1 = value; }
        public int PunktyGracza2 { get => punktyGracza2; set => punktyGracza2 = value; }
        public int Bce { get => bce; set => bce = value; }
        public int Bzo { get => bzo; set => bzo = value; }
        public int Bzi { get => bzi; set => bzi = value; }
        public int Bbr { get => bbr; set => bbr = value; }
        public int Bni { get => bni; set => bni = value; }
        public int Bro { get => bro; set => bro = value; }
        public int Bcz { get => bcz; set => bcz = value; }

        public void nowaGra(String pseudonim1, String pseudonim2, int rozpoczynaGracz)
        {
            gracz1 = new Gracz(pseudonim1);
            gracz2 = new Gracz(pseudonim2);
            AktualnyGracz1 = this.rozpoczynaGracz;
            this.rozpoczynaGracz = rozpoczynaGracz;
            Koniec = false;
            
            Random rnd = new Random();
        }
        public void pudlo()
        {
            if (AktualnyGracz == 1)
            {
                AktualnyGracz = 2;
            }
            else if (AktualnyGracz == 2)
            {
                AktualnyGracz = 1;
            }
        }
        public void wbitaCzerwona()
        {
            if (AktualnyGracz == 1 && bce > 0)
            {
                bce -= 1;
                punktyGracza1 += 1;
            }
            else if (AktualnyGracz == 2 && bce > 0)
            {
                bce -= 1;
                punktyGracza2 += 1;
            }
            
        }
        public void wbitaZolta()
        {
            if (AktualnyGracz == 1 && bzo == 1)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 2;
                }
                else if (bce == 0 && bzo == 1)
                {
                    punktyGracza1 += 2;
                    bzo -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bzo == 1)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 4;
                }
                else if (bce == 0 && bzo == 1)
                {
                    punktyGracza1 += 2;
                    bzo -= 1;
                }
            }
            else if (AktualnyGracz == 1 && bzi == 1)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 0;
                    bzo -= 1;
                }
                else
                {
                    bzo -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bzo == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 2;
                    bzi -= 1;
                }
                else
                {
                    bzo -= 1;
                }
            }
        }
        public void wbitaZielona()
        {
            if (AktualnyGracz == 1 && bzi == 1)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 3;
                }
                else if (bce == 0 && bzi == 1)
                {
                    punktyGracza1 += 3;
                    bzi -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bzi == 1)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 3;
                }
                else if (bce == 0 && bzi == 1)
                {
                    punktyGracza1 += 3;
                    bzi -= 1;
                }
            }
            else if (AktualnyGracz == 1 && bzi == 1)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 3;
                    bzi -= 1;
                }
                else
                {
                    bzi -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bzi == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 3;
                    bzi -= 1;
                }
                else
                {
                    bzi -= 1;
                }
            }
        }
        public void wbitaBrazowa()
        {
            if (AktualnyGracz == 1 && bbr == 1)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 4;
                }
                else if (bce == 0 && bbr == 1)
                {
                    punktyGracza1 += 4;
                    bbr -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bbr == 1)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 4;
                }
                else if (bce == 0 && bbr == 1)
                {
                    punktyGracza1 += 4;
                    bbr -= 1;
                }
            }
            else if (AktualnyGracz == 1 && bbr == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 4;
                    bbr -= 1;
                }
                else
                {
                    bbr -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bbr == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 4;
                    bbr -= 1;
                }
                else
                {
                    bbr -= 1;
                }
            }
        }
        public void wbitaNiebieska()
        {
            if (AktualnyGracz == 1 && bni == 1)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 5;
                }
                else if (bce == 0 && bni == 1)
                {
                    punktyGracza1 += 5;
                    bni -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bni == 1)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 5;
                }
                else if (bce == 0 && bni == 1)
                {
                    punktyGracza1 += 5;
                    bni -= 1;
                }
            }
            else if (AktualnyGracz == 1 && bni == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 5;
                    bni -= 1;
                }
                else
                {
                    bni -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bni == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 5;
                    bni -= 1;
                }
                else
                {
                    bni -= 1;
                }
            }
        }
        public void wbitaRozowa()
        {
            if (AktualnyGracz == 1 && bro == 1)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 6;
                }
                else if (bce == 0 && bro == 1)
                {
                    punktyGracza1 += 6;
                    bro -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bro == 1)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 6;
                }
                else if (bce == 0 && bro == 1)
                {
                    punktyGracza1 += 6;
                    bro -= 1;
                }
            }
            else if (AktualnyGracz == 1 && bro == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 6;
                    bro -= 1;
                }
                else
                {
                    bro -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bro == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 6;
                    bro -= 1;
                }
                else
                {
                    bro -= 1;
                }
            }
        }
        public void wbitaCzarna()
        {
            if (AktualnyGracz == 1 && bcz == 1)
            {
                if (bce>0)
                {
                    punktyGracza1 += 7;
                }
                else if (bce==0 && bcz == 1)
                {
                    punktyGracza1 += 7;
                    bcz -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bcz == 1)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 7;
                }
                else if (bce == 0 && bcz == 1)
                {
                    punktyGracza1 += 7;
                    bcz -= 1;
                }
            }
            else if (AktualnyGracz == 1 && bcz == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 7;
                    bcz -= 1;
                }
                else
                {
                    bcz -= 1;
                }
            }
            else if (AktualnyGracz == 2 && bcz == 0)
            {
                if (bce == 0)
                {
                    punktyGracza1 += 7;
                    bcz -= 1;
                }
                else
                {
                    bcz -= 1;
                }
            }
        }
        public Boolean CzyKtosWygrywa()
        {
            if (bce == 0 && bzo == 0 && bzi == 0 && bbr == 0 && bni == 0 && bro == 0 && bcz == 0)
            {
                return true;
            }
            return true;
        }
    }
}
