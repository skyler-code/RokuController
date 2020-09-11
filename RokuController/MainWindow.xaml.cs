using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ControllerLogic;
using RokuDataObjects;

namespace Roku_Controller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly RokuManager rokuManager = new RokuManager();

        public MainWindow()
        {
            InitializeComponent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            cmbRokus.ItemsSource = rokuManager.RokuList;
            cmbRokus.SelectedItem = rokuManager.SelectedRoku;
            lstApps.ItemsSource = rokuManager.SelectedRoku.Apps;
        }


        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Play);
        }

        private void cmbRokus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newSelectedRoku = (Roku)cmbRokus.SelectedItem;
            rokuManager.SelectedRoku = newSelectedRoku;
            lstApps.ItemsSource = newSelectedRoku.Apps;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Back);
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Home);
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Up);
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Left);
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Right);
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Select);
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Down);
        }

        private void btnReplay_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.InstantReplay);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Info);
        }

        private void btnRev_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Rev);
        }

        private void btnFwd_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.Fwd);
        }

        private void btnVolUp_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.VolumeUp);
        }

        private void btnVolDown_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.VolumeDown);
        }

        private void btnVolMute_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.VolumeMute);
        }

        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
            rokuManager.PressButton(KeyCode.PowerOff);
        }

        private void lstApps_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var row = sender as DataGridRow;
            var selectedApp = row.Item as RokuApp;
            rokuManager.LaunchApp(selectedApp);
        }
    }
}
