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
        private int poddajframe;
        private int bce = 15; //bile czerwone
        private int bzo = 7; //bila żółta
        private int bzi = 7; //bila zielona
        private int bbr = 7; //bila brązowa
        private int bni = 7; //bila niebieska
        private int bro = 7; //bila różowa
        private int bcz = 7; //bila czarna
        private int break1 = 0;
        private int break2 = 0;
        Boolean faul1;
        Boolean faul2;
        Boolean koniecframe;
        Boolean koniecmecz;
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
        public bool Koniecmecz { get => koniecmecz; set => koniecmecz = value; }
        public int AktualnyGracz1 { get => aktualnyGracz; set => aktualnyGracz = value; }
        public int PunktyGracza1 { get => punktyGracza1; set => punktyGracza1 = value; }
        public int PunktyGracza2 { get => punktyGracza2; set => punktyGracza2 = value; }
        public int Poddajframe { get => poddajframe; set => poddajframe = value; }
        public int Bce { get => bce; set => bce = value; }
        public int Bzo { get => bzo; set => bzo = value; }
        public int Bzi { get => bzi; set => bzi = value; }
        public int Bbr { get => bbr; set => bbr = value; }
        public int Bni { get => bni; set => bni = value; }
        public int Bro { get => bro; set => bro = value; }
        public int Bcz { get => bcz; set => bcz = value; }
        public int Break1 { get => break1; set => break1 = value; }
        public int Break2 { get => break2; set => break2 = value; }
        public bool Faul1 { get => faul1; set => faul1 = value; }
        public bool Faul2 { get => faul2; set => faul2 = value; }

        public void nowaGra(String pseudonim1, String pseudonim2, int rozpoczynaGracz)
        {
            gracz1 = new Gracz(pseudonim1);
            gracz2 = new Gracz(pseudonim2);
            AktualnyGracz1 = this.rozpoczynaGracz;
            this.rozpoczynaGracz = rozpoczynaGracz;
            Koniecmecz = false;
            faul1 = false;
            faul2 = false;
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
        public void Rozpoczyna()
        {
            if (RozpoczynaGracz == 1)
            {
                RozpoczynaGracz = 2;
            }
            else if (RozpoczynaGracz == 2)
            {
                RozpoczynaGracz = 1;
            }
        }
        public void PoddajFrame()
        {
            if(aktualnyGracz == 1)
            {
                AktualnyGracz = 2;
            }
            else
            {
                aktualnyGracz = 1;
            }
            bce = 0;
            bzo = 0;
            bzi = 0;
            bbr = 0;
            bni = 0;
            bro = 0;
            bcz = 0;
            koniecframe = CzyKtosWygrywaFrame();
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
            koniecframe = CzyKtosWygrywaFrame();
        }
        public void wbitaZolta()
        {
            if (AktualnyGracz == 1 && bzo >= 6)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 2;
                }
                else if (bce == 0)
                {
                    punktyGracza1 += 2;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
            if (AktualnyGracz == 2 && bzo >= 6)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 2;
                }
                else if (bce == 0)
                {
                    punktyGracza2 += 2;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
        }
        public void wbitaZielona()
        {
            if (AktualnyGracz == 1 && bzi >= 5)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 3;
                }
                else if (bce == 0)
                {
                    punktyGracza1 += 3;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
            if (AktualnyGracz == 2 && bzi >= 5)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 3;
                }
                else if (bce == 0)
                {
                    punktyGracza2 += 3;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
        }
        public void wbitaBrazowa()
        {
            if (AktualnyGracz == 1 && bbr >= 4)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 4;
                }
                else if (bce == 0)
                {
                    punktyGracza1 += 4;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
            if (AktualnyGracz == 2 && bbr >= 4)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 4;
                }
                else if (bce == 0)
                {
                    punktyGracza2 += 4;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
        }
        public void wbitaNiebieska()
        {
            if (AktualnyGracz == 1 && bni >= 3)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 5;
                }
                else if (bce == 0)
                {
                    punktyGracza1 += 5;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
            if (AktualnyGracz == 2 && bni >= 3)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 5;
                }
                else if (bce == 0)
                {
                    punktyGracza2 += 5;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
        }
        public void wbitaRozowa()
        {
            if (AktualnyGracz == 1 && bro >= 2)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 6;
                }
                else if (bce == 0)
                {
                    punktyGracza1 += 6;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
            if (AktualnyGracz == 2 && bro >= 2)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 6;
                }
                else if (bce == 0)
                {
                    punktyGracza2 += 6;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
        }
        public void wbitaCzarna()
        {
            if (AktualnyGracz == 1 && bcz >= 1)
            {
                if (bce > 0)
                {
                    punktyGracza1 += 7;
                }
                else if (bce == 0)
                {
                    punktyGracza1 += 7;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
            if (AktualnyGracz == 2 && bcz >= 1)
            {
                if (bce > 0)
                {
                    punktyGracza2 += 7;
                }
                else if (bce == 0)
                {
                    punktyGracza2 += 7;
                    bzo -= 1;
                    bzi -= 1;
                    bbr -= 1;
                    bni -= 1;
                    bro -= 1;
                    bcz -= 1;
                }
            }
            koniecframe = CzyKtosWygrywaFrame();
            Koniecmecz = CzyKtosWygrywaMecz();
        }
        public void Faulza4()
        {
            if (aktualnyGracz == 1)
            {
                punktyGracza2 += 4;
                Faul1 = CzyKtosSfaulowal();
            }
            else
            {
                punktyGracza1 += 4;
                Faul2 = CzyKtosSfaulowal();
            }
        }
        public void Faulza5()
        {
            if (aktualnyGracz == 1)
            {
                punktyGracza2 += 5;
                Faul1 = CzyKtosSfaulowal();
            }
            else
            {
                punktyGracza1 += 5;
                Faul2 = CzyKtosSfaulowal();
            }
        }
        public void Faulza6()
        {
            if (aktualnyGracz == 1)
            {
                punktyGracza2 += 6;
                Faul1 = CzyKtosSfaulowal();
            }
            else
            {
                punktyGracza1 += 6;
                Faul2 = CzyKtosSfaulowal();
            }
        }
        public void Faulza7()
        {
            if (aktualnyGracz == 1)
            {
                punktyGracza2 += 7;
                faul1 = CzyKtosSfaulowal();
            }
            else
            {
                punktyGracza1 += 7;
                faul2 = CzyKtosSfaulowal();
            }
            
        }
        public Boolean CzyKtosSfaulowal()
        {
            return true;
        }
        public Boolean CzyKtosWygrywaFrame()
        {
            if (bce <= 0 && bzo <= 0 && bzi <= 0 && bbr <= 0 && bni <= 0 && bro <= 0 && bcz <= 0)
            {
                return true;
            }
            return false;
        }
        public Boolean CzyKtosWygrywaMecz()
        {
            return true;
        }
    }
}
