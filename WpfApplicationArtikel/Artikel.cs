using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplicationArtikel
{
    class Artikel
    {
        private String artNr;
        private String artBez;
        private int bestand;
        private int bestellbestand;
        private decimal einkaufspreis;
        private decimal verkaufspreis;
        private int bestellmenge;

        public string ArtNr
        {
            get
            {
                return artNr;
            }

            set
            {
                artNr = value;
            }
        }

        public string ArtBez
        {
            get
            {
                return artBez;
            }

            set
            {
                artBez = value;
            }
        }

        public int Bestand
        {
            get
            {
                return bestand;
            }

            set
            {
                bestand = value;
            }
        }

        public int Bestellbestand
        {
            get
            {
                return bestellbestand;
            }

            set
            {
                bestellbestand = value;
            }
        }

        public decimal Einkaufspreis
        {
            get
            {
                return einkaufspreis;
            }

            set
            {
                einkaufspreis = value;
            }
        }

        public decimal Verkaufspreis
        {
            get
            {
                return verkaufspreis;
            }

            set
            {
                verkaufspreis = value;
            }
        }

        public int Bestellmenge
        {
            get
            {
                return bestellmenge;
            }

            set
            {
                bestellmenge = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", this.ArtBez);
        }

        public int nachbestellen()
        {
            this.Bestand += Bestellmenge;
            return this.Bestand;
        }
        public int verkaufen(int mng)
        {
            this.Bestand -= mng;
            return this.Bestand;
        }

    }
}
