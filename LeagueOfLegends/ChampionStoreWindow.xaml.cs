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
using System.Windows.Shapes;

namespace LeagueOfLegends
{
    /// <summary>
    /// Interaction logic for ChampionStoreWindow.xaml
    /// </summary>
    public partial class ChampionStoreWindow : Window
    {
        public ChampionStoreWindow()
        {
            InitializeComponent();
        }

        private void BtnFaq_Click(object sender, RoutedEventArgs e)
        {
            FAQ fAQWindow = new FAQ();
            fAQWindow.Show();
            this.Close();
        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            BtnOpenMenu.Visibility = Visibility.Visible;
            BtnCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void BtnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            BtnOpenMenu.Visibility = Visibility.Collapsed;
            BtnCloseMenu.Visibility = Visibility.Visible;
        }

        private void BtnHomeIcon_Click(object sender, RoutedEventArgs e)
        {
            MainWindow HomeWindow = new MainWindow();
            HomeWindow.Show();
            this.Close();
        }

        private void BtnHomeText_Click(object sender, RoutedEventArgs e)
        {
            MainWindow HomeWindow = new MainWindow();
            HomeWindow.Show();
            this.Close();
        }

        private void BtnSkinStoreIcon_Click(object sender, RoutedEventArgs e)
        {
            SkinStoreWindow skinStoreWindow = new SkinStoreWindow();
            skinStoreWindow.Show();
            this.Close();
        }

        private void BtnSkinStoreText_Click(object sender, RoutedEventArgs e)
        {
            SkinStoreWindow skinStoreWindow = new SkinStoreWindow();
            skinStoreWindow.Show();
            this.Close();
        }

        private void BtnChampionStoreIcon_Click(object sender, RoutedEventArgs e)
        {
            ChampionStoreWindow championStoreWindow = new ChampionStoreWindow();
            championStoreWindow.Show();
            this.Close();
        }

        private void BtnChampionStoreText_Click(object sender, RoutedEventArgs e)
        {
            ChampionStoreWindow championStoreWindow = new ChampionStoreWindow();
            championStoreWindow.Show();
            this.Close();
        }

        private void BtnFreinsListIcon_Click(object sender, RoutedEventArgs e)
        {
            FriendsListWindow friendsListWindow = new FriendsListWindow();
            friendsListWindow.Show();
            this.Close();
        }

        private void BtnFreindsText_Click(object sender, RoutedEventArgs e)
        {
            FriendsListWindow friendsListWindow = new FriendsListWindow();
            friendsListWindow.Show();
            this.Close();
        }

        private void BtnPreBuildsIcon_Click(object sender, RoutedEventArgs e)
        {
            PreBuildsWindow preBuildsWindow = new PreBuildsWindow();
            preBuildsWindow.Show();
            this.Close();
        }

        private void BtnBrebuildsText_Click(object sender, RoutedEventArgs e)
        {
            PreBuildsWindow preBuildsWindow = new PreBuildsWindow();
            preBuildsWindow.Show();
            this.Close();
        }

        private void BtnMatchHistoryIcon_Click(object sender, RoutedEventArgs e)
        {
            MatchHistoryWindow matchHistoryWindow = new MatchHistoryWindow();
            matchHistoryWindow.Show();
            this.Close();
        }

        private void BtnMatchHistoryText_Click(object sender, RoutedEventArgs e)
        {
            MatchHistoryWindow matchHistoryWindow = new MatchHistoryWindow();
            matchHistoryWindow.Show();
            this.Close();
        }
    }
}
