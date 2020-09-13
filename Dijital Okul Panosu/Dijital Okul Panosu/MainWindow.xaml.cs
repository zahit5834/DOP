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
using System.Windows.Threading;

namespace Dijital_Okul_Panosu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public class saat
        {
            public int Id { get; set; }

            public string Giris { get; set; }

            public string Cikis { get; set; }
        }

        public class nobet
        {

            public string Yer { get; set; }

            public string Ogretmen { get; set; }
        }


        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.IsEnabled = true;
            timer.Tick += Timersay;
        }

        private void Timersay(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            saat_label.Content = simdi.ToLongTimeString();
            tarih_label.Content = DateTime.Today;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            etkinlik_listbox.Items.Add("Etkinlik");
            duyuru_listbox.Items.Add("BURASI ÇOK ÖNEMLİ BİR DUYURUYMUŞ GİBİ BAK ŞİMDİ ASDASF SDAFASDF SADFDSAFSADF");
            for (int i = 1; i <= 10; i++)
            {
                this.lst1.Items.Add(new saat { Id = i, Giris = "13:00", Cikis = "14:00" });
            }
            for (int i = 1; i < 5; i++)
            {
                this.nobetlist.Items.Add(new nobet { Yer = i.ToString() + ".Kat", Ogretmen = "Ali" });
            }
            this.nobetlist.Items.Add(new nobet { Yer = "Bahçe Katı", Ogretmen = "Ahmet Mithat" });
            sayac.Text = "365 Gün\n24 Saat\n60 Dakika\n60 Saniye";
            
        }
        yonetim_paneli panel = new yonetim_paneli();
        private void Window_KeyUp(object sender, KeyEventArgs bas)
        {
            if (bas.Key == Key.Escape)
            {
                Environment.Exit(0);

            }

            else if (bas.Key == Key.F3)
            {
                
                panel.Show();
                Hide();
            }
        }
    }
}
