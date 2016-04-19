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



namespace HallintaPaneeli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string Username = "Jukka";
        string Password = "abc123";

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string getUsername = txtUsername.Text;
            string getPassword = passwordBox.Password;

            if (getUsername == Username && getPassword == Password)
            {
                spLogin.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#009c00"));
                testiTuloste(true);
            }
            else
            {
                tbMessage.Text = "Login credentials are invalid";
                spLogin.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
                testiTuloste(false);
            }
        }

        private void testiJuttu()
        {
            tbMessage.Text = "NAPPI TOIMI SAATANA";
        }


        private void testiTuloste(Boolean logged)
        {
            if (logged == true)
            {
                testiJuttu();
                btnRemove.Visibility = Visibility.Visible;
                btnLogout.Visibility = Visibility.Visible;
                btnKayttajat.Visibility = Visibility.Visible;
                btnKetjut.Visibility = Visibility.Visible;
                tbMessage.Text = "Login Succesful";
            }
        }

        private void btnHaeKayttaja_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnHaeKetjut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
