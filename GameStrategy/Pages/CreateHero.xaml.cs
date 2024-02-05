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
    /// Логика взаимодействия для CreateHero.xaml
    /// </summary>
    public partial class CreateHero : Page
    {
        public static Hero currentHero;
        public CreateHero()
        {
            InitializeComponent();
            ListHeroes.ItemsSource = CRUD.GetHero();
            DataContext = this;
        }

        private void ListHeroes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentHero = ListHeroes.SelectedItem as Hero;
            NavigationService.Navigate(new ListOfMyHero());
        }
    }
}
