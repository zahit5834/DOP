using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Dijital_Okul_Panosu
{
    /// <summary>
    /// yonetim_paneli.xaml etkileşim mantığı
    /// </summary>
    public partial class yonetim_paneli : Window
    {
        

        public yonetim_paneli()
        {
            InitializeComponent();
        }

        private void Window_KeyUp(object sender, KeyEventArgs bas)
        {
            MainWindow window = new MainWindow();
            if (bas.Key == Key.F3)
            {
                window.Show();
                Hide();
            }
            if (bas.Key == Key.Escape)
            {
                Environment.Exit(0);

            }
        }

        private void duyuru_suresi_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(duyuru_suresi_tb.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece rakam Kullanınız.");
                duyuru_suresi_tb.Text = duyuru_suresi_tb.Text.Remove(duyuru_suresi_tb.Text.Length - 1);
            }
        }
        public void hide_all()
        {
            duyuru_grid.Visibility                  = Visibility.Hidden;
            etkinlik_grid.Visibility                = Visibility.Hidden;
            kacgun_kaldi_grid.Visibility            = Visibility.Hidden;
            tarihte_bugun_grid.Visibility           = Visibility.Hidden;
            gunun_sozu_grid.Visibility              = Visibility.Hidden;
            raporlu_ogretmenler_grid.Visibility     = Visibility.Hidden;
            nobet_listesi_grid.Visibility           = Visibility.Hidden;
            ders_saatleri_grid.Visibility           = Visibility.Hidden;
            manset_fotolari_grid.Visibility         = Visibility.Hidden;
            ogretmen_list_grid.Visibility           = Visibility.Hidden;
        }
        private void duyuru_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            duyuru_grid.Visibility = Visibility.Visible;

        }

        private void etkinlik_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            etkinlik_grid.Visibility = Visibility.Visible;
        }

        private void kac_gun_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            kacgun_kaldi_grid.Visibility = Visibility.Visible;
        }

        private void tarihte_bugun_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            tarihte_bugun_grid.Visibility = Visibility.Visible;
        }

        private void gunun_sozu_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            gunun_sozu_grid.Visibility = Visibility.Visible;
        }

        private void raporlu_ogretmenler_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            raporlu_ogretmenler_grid.Visibility = Visibility.Visible;
        }

        private void nobet_listesi_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            nobet_listesi_grid.Visibility = Visibility.Visible;
        }

        private void ders_saatleri_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            ders_saatleri_grid.Visibility = Visibility.Visible;
        }

        private void manset_foto_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            manset_fotolari_grid.Visibility = Visibility.Visible;
        }

        private void ogretmen_listesi_Click(object sender, RoutedEventArgs e)
        {
            hide_all();
            ogretmen_list_grid.Visibility = Visibility.Visible;
        }
    }
}
