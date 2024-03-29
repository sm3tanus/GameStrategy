﻿using GameStrategy.Classes;
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
        public static string type_class;
        public ListOfMyHero(string type)
        {
            InitializeComponent();
            type_class = type;
            List<Hero> list = CRUD.GetHero(type);
            ListSettings.ItemsSource = list;
            DataContext = this;
        }
        private void AddPowerBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedHero.StarPoints > 0)
                {
                    selectedHero.Power++;
                    selectedHero.StarPoints--;
                    CountPowerTb.Text = selectedHero.Power.ToString();
                    CountPointsTb.Text = selectedHero.StarPoints.ToString();
                }
            }
            catch {
                MessageBox.Show("Выберите героя!", "Невозможно изменить", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddVitalityBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(selectedHero.StarPoints > 0)
                    {
                        selectedHero.Vitality++;
                        selectedHero.StarPoints--;
                        CountVitalityTb.Text = selectedHero.Vitality.ToString();
                        CountPointsTb.Text = selectedHero.StarPoints.ToString();
                    }
            }
            catch
            {
                MessageBox.Show("Выберите героя!", "Невозможно изменить", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void AddDexterityBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                    if (selectedHero.StarPoints > 0)
                        {
                            selectedHero.Dexterity++;
                            selectedHero.StarPoints--;
                            CountDexterityTb.Text = selectedHero.Dexterity.ToString();
                            CountPointsTb.Text = selectedHero.StarPoints.ToString();
                        }
            }
            catch
            {
                MessageBox.Show("Выберите героя!", "Невозможно изменить", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddInteligienceBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedHero.StarPoints > 0)
                    {
                        selectedHero.Intelligence++;
                        selectedHero.StarPoints--;
                        CountInteligienceTb.Text = selectedHero.Intelligence.ToString();
                        CountPointsTb.Text = selectedHero.StarPoints.ToString();
                    }
            }
            catch
            {
                MessageBox.Show("Выберите героя!", "Невозможно изменить", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void AddPointsBt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                selectedHero.LevelPoints += 500;
                myLevelTb.Text = selectedHero.Level.ToString();
                Exp.Text = selectedHero.LevelPoints.ToString();
                CountPointsTb.Text = selectedHero.StarPoints.ToString();
            }
            catch
            {
                MessageBox.Show("Выберите героя!", "Невозможно изменить", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void ListSettings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                selectedHero = ListSettings.SelectedItem as Hero;
                myLevelTb.Text = selectedHero.Level.ToString();
                CountDexterityTb.Text = selectedHero.Dexterity.ToString();
                CountInteligienceTb.Text = selectedHero.Intelligence.ToString();
                CountPowerTb.Text = selectedHero.Power.ToString();
                CountVitalityTb.Text = selectedHero.Vitality.ToString();
                CountPointsTb.Text = selectedHero.StarPoints.ToString();
            }
            catch
            {
                MessageBox.Show("Выберите героя!", "Невозможно изменить", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void SaveBt_Click(object sender, RoutedEventArgs e)
        {
            CRUD.UpdateRogue(selectedHero as Rogue);
        }

        private void AddHeroBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CreateHero());
        }

    }
}
