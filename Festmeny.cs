using System;
using System.Collections.Generic;
using System.Text;

namespace MuzeumApp
{
    public class Festmeny : mutargy
    {
        public int KorEvekben { get; set;  }
        
        public Festmeny(string azonosito, int becsultErtek, int KorEvekben) : base(azonosito, becsultErtek)
        {
            KorEvekben = KorEvekben;

        }

        public override int BiztositasDij()
        {
            return base.BiztositasDij() + KorEvekben * 500;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Kor: {KorEvekben} év";
        }

    }
}
