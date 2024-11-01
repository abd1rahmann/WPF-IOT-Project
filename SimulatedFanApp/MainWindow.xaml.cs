﻿using SimulatedFanApp.MVVM.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimulatedFanApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsRunning = false; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TopWindowBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsRunning = !IsRunning;

            var sb = (BeginStoryboard)TryFindResource("rotate-sb");

            if(IsRunning)
                sb.Storyboard.Begin();
            else
                sb.Storyboard.Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var settings = new SettingsView(); 
            this.Content = settings;
        }

        

    }
}