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

namespace WPFAPP
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }


        private void mnuBtnHome_Click(object sender, RoutedEventArgs e)
        {
            StartPageFrame.Source = new Uri("HomePage.xaml", UriKind.Relative);
        }

        private void mnuBtnNew_Click(object sender, RoutedEventArgs e)
        {
            StartPageFrame.Source = new Uri("NewPage.xaml", UriKind.Relative);
        }

        private void mnuBtnTemplates_Click(object sender, RoutedEventArgs e)
        {
            StartPageFrame.Source = new Uri("TemplatesPage.xaml", UriKind.Relative);
        }

        private void mnuBtnSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuBtnCollapse_Click(object sender, RoutedEventArgs e)
        {
            StartMainGrid.ColumnDefinitions[0].Width = new GridLength(40);
            mnuBtnCollapse.Visibility = Visibility.Hidden;
            mnuBtnExpand.Visibility = Visibility.Visible;
            mnuBtnExpand.Padding=new Thickness(10);
            mnuBtnSettings.Padding = new Thickness(10);
            mnuBtnTemplates.Padding = new Thickness(10);
            mnuBtnNew.Padding = new Thickness(10);
            mnuBtnLibrary.Padding = new Thickness(10);
            mnuBtnHome.Padding = new Thickness(10);
            mnuSeparator.Margin = new Thickness(5,0,5,0);
        }

        private void mnuBtnExpand_Click(object sender, RoutedEventArgs e)
        {
            StartMainGrid.ColumnDefinitions[0].Width = new GridLength(180);
            mnuBtnExpand.Visibility = Visibility.Hidden;
            mnuBtnCollapse.Visibility = Visibility.Visible;
            mnuBtnSettings.Padding = new Thickness(20,10,10,10);
            mnuBtnTemplates.Padding = new Thickness(20, 10, 10, 10);
            mnuBtnNew.Padding = new Thickness(20, 10, 10, 10);
            mnuBtnLibrary.Padding = new Thickness(20, 10, 10, 10);
            mnuBtnHome.Padding = new Thickness(20, 10, 10, 10);
            mnuSeparator.Margin = new Thickness(15,0,15,0);
        }

        private void mnuBtnLibrary_Click(object sender, RoutedEventArgs e)
        {
            StartPageFrame.Source = new Uri("OpenPage.xaml", UriKind.Relative);
        }
    }
}
