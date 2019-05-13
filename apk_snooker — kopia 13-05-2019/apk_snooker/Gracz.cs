using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apk_snooker
{
    class Gracz
    {
        private String pseudonim;
        public Gracz(String pseudonim)
        {
            this.pseudonim = pseudonim;
        }
        public string Pseudonim { get => pseudonim; set => pseudonim = value; }
    }
}
