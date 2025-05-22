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

namespace RuleArchitect_UI_Prototype
{
    public partial class PrototypeShellWindow : Window
    {
        public PrototypeShellWindow()
        {
            InitializeComponent();
            // Load initial page (e.g., Admin Dashboard)
            if (NavigationListBox.Items.Count > 0)
            {
                NavigationListBox.SelectedIndex = 0; // Select the first item
                NavigateToSelectedPage(); // And navigate to it
            }
        }

        private void NavigationListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigateToSelectedPage();
        }

        private void NavigateToSelectedPage()
        {
            if (PrototypeFrame == null || NavigationListBox.SelectedItem == null)
                return;

            ListBoxItem selectedItem = (ListBoxItem)NavigationListBox.SelectedItem;

            if (selectedItem == AdminNavItem)
            {
                PrototypeFrame.Navigate(new AdminDashboardPrototypePage());
            }
            else if (selectedItem == OrderReviewerNavItem)
            {
                PrototypeFrame.Navigate(new OrderReviewerDashboardPrototypePage());
            }
            else if (selectedItem == OrderProductionNavItem)
            {
                PrototypeFrame.Navigate(new OrderProductionDashboardPrototypePage());
            }
            else if (selectedItem == ProdReviewerNavItem)
            {
                PrototypeFrame.Navigate(new ProdReviewerDashboardPrototypePage());
            }
            else if (selectedItem == RulesheetsNavItem)
            {
                PrototypeFrame.Navigate(new UniversalRulesheetsPrototypePage());
            }
            // Add more cases for other navigation items like Settings, Logout etc.
        }

        // Keep these methods if you want to keep the top buttons as an alternative navigation
        // or for quick testing, otherwise, they can be removed if the ListBox is the sole navigation.
        //private void AdminDashboard_Click(object sender, RoutedEventArgs e)
        //{
        //    SelectNavItemAndNavigate(AdminNavItem, new AdminDashboardPrototypePage());
        //}

        //private void OrderReviewerDashboard_Click(object sender, RoutedEventArgs e)
        //{
        //    SelectNavItemAndNavigate(OrderReviewerNavItem, new OrderReviewerDashboardPrototypePage());
        //}

        //private void OrderProductionDashboard_Click(object sender, RoutedEventArgs e)
        //{
        //    SelectNavItemAndNavigate(OrderProductionNavItem, new OrderProductionDashboardPrototypePage());
        //}

        //private void ProdReviewerDashboard_Click(object sender, RoutedEventArgs e)
        //{
        //    SelectNavItemAndNavigate(ProdReviewerNavItem, new ProdReviewerDashboardPrototypePage());
        //}
        //private void UniversalRulesheetsView_Click(object sender, RoutedEventArgs e)
        //{
        //    SelectNavItemAndNavigate(RulesheetsNavItem, new UniversalRulesheetsPrototypePage());
        //}

        // Helper to select ListBoxItem when top button is clicked (optional)
        private void SelectNavItemAndNavigate(ListBoxItem itemToSelect, Page pageToNavigate)
        {
            if (NavigationListBox.SelectedItem != itemToSelect)
            {
                NavigationListBox.SelectedItem = itemToSelect;
            }
            else // If already selected, force navigation (SelectionChanged won't fire)
            {
                PrototypeFrame.Navigate(pageToNavigate);
            }
        }
    }
}
