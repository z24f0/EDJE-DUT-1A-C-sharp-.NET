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

namespace projet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Jeux> mesJeux = new List<Jeux>()
            {
                new Jeux { Nom = "Super Mario Galaxy", Date = "2009", ImageName="/images/champi.png"},
                new Jeux { Nom = "Super Smash Bros", Date = "2012", ImageName="/images/champi 1 up.png"},
                new Jeux { Nom = "xdcfgvh n", Date = "1992", ImageName="/images/champi feu.png"},
                new Jeux { Nom = "iouiuvcy", Date = "1999", ImageName="/images/champi glace.png"},
                new Jeux { Nom = "wrxtcytvuybin", Date = "2000", ImageName="/images/wiimote.png"},
                new Jeux { Nom = "oiuhnbvfde", Date = "2000", ImageName="/images/champi.png"},
                new Jeux { Nom = "zsxcfgvhyujn", Date = "2012", ImageName="/images/champi.png"},
                new Jeux { Nom = "poiuygf", Date = "2016", ImageName="/images/champi.png"},
                new Jeux { Nom = "aqsxcghuio", Date = "2011", ImageName="/images/champi.png"},
                new Jeux { Nom = "oakzjsnbdju", Date = "2011", ImageName="/images/champi.png"},
                new Jeux { Nom = "pzndhdbeh", Date = "2011", ImageName="/images/champi.png"},
                new Jeux { Nom = "scvhiop", Date = "2003", ImageName="/images/champi.png"},
                new Jeux { Nom = "petrbnckmd", Date = "2009", ImageName="/images/champi.png"},
                new Jeux { Nom = "oaijhzeygdvbjk", Date = "2009", ImageName="/images/champi.png"},
                new Jeux { Nom = "oihadidihz", Date = "1099", ImageName="/images/champi.png"},
                new Jeux { Nom = "iagzblzda", Date = "2005", ImageName="/images/champi.png"},
                new Jeux { Nom = "pzzzoozp", Date = "2006", ImageName="/images/champi.png"},
                new Jeux { Nom = "pajdoadozpdjpzzdz", Date = "2003", ImageName="/images/champi.png"},
                new Jeux { Nom = "iu gluaglizb", Date = "2019", ImageName="/images/champi.png"}
            };

            maListeJeux.ItemsSource = mesJeux;

        }

    }
}
