using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplicationArtikel
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Artikel> alleArtikel = null;
        public MainWindow()
        {
            alleArtikel = new List<Artikel>();
            InitializeComponent();
            Artikel artikel1 = new Artikel { ArtNr = "100", ArtBez = "Tisch", Bestand = 50, Bestellbestand = 20, Bestellmenge = 50, Einkaufspreis = 50.00m, Verkaufspreis = 100.00m };
            Artikel artikel2 = new Artikel { ArtNr = "200", ArtBez = "Sessel", Bestand = 20, Bestellbestand = 5, Bestellmenge = 20, Einkaufspreis = 150.00m, Verkaufspreis = 220.00m };
            Artikel artikel3 = new Artikel { ArtNr = "300", ArtBez = "Lampe", Bestand = 100, Bestellbestand = 20, Bestellmenge = 70, Einkaufspreis = 60.00m, Verkaufspreis = 80.00m };
            Artikel artikel4 = new Artikel { ArtNr = "400", ArtBez = "Sofa", Bestand = 15, Bestellbestand = 3, Bestellmenge = 10, Einkaufspreis = 300.00m, Verkaufspreis = 500.00m };
            Artikel artikel5 = new Artikel { ArtNr = "500", ArtBez = "Regal", Bestand = 70, Bestellbestand = 25, Bestellmenge = 60, Einkaufspreis = 40.00m, Verkaufspreis = 50.00m };

            alleArtikel.Add(artikel1);
            alleArtikel.Add(artikel2);
            alleArtikel.Add(artikel3);
            alleArtikel.Add(artikel4);
            alleArtikel.Add(artikel5);

            combobox_artikel.ItemsSource = alleArtikel;
            
        }

        private void button_kaufen_Click(object sender, RoutedEventArgs e)
        {
            int menge = Convert.ToInt32(textbox_menge.Text);
            Artikel a = (Artikel)combobox_artikel.SelectedItem;
            if(menge > a.Bestand)
            {
                a.Bestand = a.nachbestellen();
                textblock_status.Text = "Bestand zu niedrig...Nachbestellung ausgeführt";
                textbox_bestand.Text = a.Bestand.ToString();
            }
            else
            {
                a.verkaufen(menge);
                textblock_status.Text = "Vielen Dank für Ihren Einkauf";
                textbox_bestand.Text = a.Bestand.ToString();
                menge = 0;
                textbox_menge.Text = "";
            }
        }
    }
}
