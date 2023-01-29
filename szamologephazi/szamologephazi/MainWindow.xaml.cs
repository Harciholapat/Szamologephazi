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

namespace szamologephazi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Osszead_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{aSzam.Text} + {bSzam.Text} = {Convert.ToDouble(aSzam) + Convert.ToDouble(bSzam)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            Eredmenyek.Items.Add(eredmeny);
        }

        private void Kivon_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny1 = $"{aSzam.Text} - {bSzam.Text} = {Convert.ToDouble(aSzam) - Convert.ToDouble(bSzam)}";
            MessageBox.Show("A kivonás eredménye: " + eredmeny1);
            Eredmenyek.Items.Add(eredmeny1);
        }

        private void Szoroz_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny2 = $"{aSzam.Text} * {bSzam.Text} = {Convert.ToDouble(aSzam) * Convert.ToDouble(bSzam)}";
            MessageBox.Show("A szorzás eredménye: " + eredmeny2);
            Eredmenyek.Items.Add(eredmeny2);
        }

        private void Oszt_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToDouble(bSzam) == 0)
            {
                MessageBox.Show("0-val nem osztunk");
            }
            else
            {
                String eredmeny3 = $"{aSzam.Text} / {bSzam.Text} = {Convert.ToDouble(aSzam) / Convert.ToDouble(bSzam)}";
                MessageBox.Show("Az osztás eredménye: " + eredmeny3);
                Eredmenyek.Items.Add(eredmeny3);
            }
        }
    }
}
