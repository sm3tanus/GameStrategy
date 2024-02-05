using GameStrategy.Classes;
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

namespace GameStrategy.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListOfMyHero.xaml
    /// </summary>
    public partial class ListOfMyHero : Page
    {
        
        int countVitality = 1;
        int countInteligience = 1;
        int countDexterity = 1;
        int countPoints = 0;
        public Hero currentHero = CreateHero.currentHero;
        public ListOfMyHero()
        {
            InitializeComponent();
            
            List<Hero> list = new List<Hero>();
            list.Add(currentHero);
            ListSettings.ItemsSource = list;
            DataContext = this;
        }
        private void AddPowerBt_Click(object sender, RoutedEventArgs e)
        {
            currentHero.Power++; 
            CountPowerTb.Text = currentHero.Power.ToString();
            
        }

        private void AddVitalityBt_Click(object sender, RoutedEventArgs e)
        {
            countVitality++;
            CountVitalityTb.Text = currentHero.Vitality.ToString();
        }

        private void AddDexterityBt_Click(object sender, RoutedEventArgs e)
        {
            countDexterity++;
            CountDexterityTb.Text = currentHero.Dexterity.ToString();
        }

        private void AddInteligienceBt_Click(object sender, RoutedEventArgs e)
        {
            countInteligience++;
            CountInteligienceTb.Text = currentHero.Inteligence.ToString();
        }

        private void AddPointsBt_Click(object sender, RoutedEventArgs e)
        {
            countPoints += 1000;
            myLevelTb.Text = currentHero.LevelPoints.ToString();
        }

    }
}
