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
        Hero selectedHero;
        public ListOfMyHero()
        {
            InitializeComponent();
            List<Hero> list = CRUD.GetHero();
            ListSettings.ItemsSource = list;
            DataContext = this;
        }
        private void AddPowerBt_Click(object sender, RoutedEventArgs e)
        {
            if (selectedHero.StarPoints > 0)
            {
                selectedHero.Power++;
                selectedHero.StarPoints--;
                CountPowerTb.Text = selectedHero.Power.ToString();
                CountPointsTb.Text = selectedHero.StarPoints.ToString();
            }
        }

        private void AddVitalityBt_Click(object sender, RoutedEventArgs e)
        {
            if(selectedHero.StarPoints > 0)
            {
                selectedHero.Vitality++;
                selectedHero.StarPoints--;
                CountVitalityTb.Text = selectedHero.Vitality.ToString();
                CountPointsTb.Text = selectedHero.StarPoints.ToString();
            }
        }

        private void AddDexterityBt_Click(object sender, RoutedEventArgs e)
        {
            if (selectedHero.StarPoints > 0)
            {
                selectedHero.Dexterity++;
                selectedHero.StarPoints--;
                CountDexterityTb.Text = selectedHero.Dexterity.ToString();
                CountPointsTb.Text = selectedHero.StarPoints.ToString();
            }
            
        }

        private void AddInteligienceBt_Click(object sender, RoutedEventArgs e)
        {
            if (selectedHero.StarPoints > 0)
            {
                selectedHero.Intelligence++;
                selectedHero.StarPoints--;
                CountInteligienceTb.Text = selectedHero.Intelligence.ToString();
                CountPointsTb.Text = selectedHero.StarPoints.ToString();
            }
        }

        private void AddPointsBt_Click(object sender, RoutedEventArgs e)
        {
            selectedHero.LevelPoints += 500;
            myLevelTb.Text = selectedHero.Level.ToString();
            Exp.Text = selectedHero.LevelPoints.ToString();
            CountPointsTb.Text = selectedHero.StarPoints.ToString();
        }

        private void ListSettings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedHero = ListSettings.SelectedItem as Hero;
            myLevelTb.Text = selectedHero.Level.ToString();
            CountDexterityTb.Text = selectedHero.Dexterity.ToString();
            CountInteligienceTb.Text = selectedHero.Intelligence.ToString();
            CountPowerTb.Text = selectedHero.Power.ToString();
            CountVitalityTb.Text = selectedHero.Vitality.ToString();
        }
    }
}
