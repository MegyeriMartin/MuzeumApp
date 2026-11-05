using System;
using System.Collections.Generic;
using System.Text;

namespace MuzeumApp
{
    public class mutargy
    {
        public string Azonosito { get; set; }
        protected int becsultErtek;
        private static int osszesMutargySzama = 0;
        public static int OsszesMutargySzama
        {
            get
            {
                return osszesMutargySzama;
            }
        }
        public int BecsultErtek
        {
            get
            {
                return becsultErtek;
            }
            set
            {
                if (value <= 0)
                {
                    becsultErtek = 50000;
                }
                else
                {
                    becsultErtek = value;
                }
            }
        }
        public mutargy(string azonosito, int becsultErtek)
        {
            Azonosito = azonosito;
            BecsultErtek = becsultErtek;
            osszesMutargySzama++;
        }

        public virtual int BiztositasDij()
        {
            return (int)(BecsultErtek * 0.02);
        }

        public override string ToString()
        {
            return $"Műtárgy {Azonosito}, Becsült érték {becsultErtek} Ft, Biztosítás: {BiztositasDij()} Ft";
        }
    }
}
