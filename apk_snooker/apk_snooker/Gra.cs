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
        Boolean koniec;
        public Gra()
        {
            AktualnyGracz1 = 1;
            rozpoczynaGracz = 1;
            gracz1 = new Gracz("pseudonim");
            gracz2 = new Gracz("pseudonim");
            wynikGracza1 = 0;
            wynikGracza2 = 0;
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

        public void nowaGra(String  pseudonim1, String pseudonim2, int rozpoczynaGracz)
        {
            gracz1 = new Gracz(pseudonim1);
            gracz2 = new Gracz(pseudonim2);
            AktualnyGracz1 = this.rozpoczynaGracz;
            this.rozpoczynaGracz = rozpoczynaGracz;
            Koniec = false;
            int bile_czerwone = 15;
        }

    }
}
