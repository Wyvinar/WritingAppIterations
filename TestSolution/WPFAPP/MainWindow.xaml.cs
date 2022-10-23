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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Button Click Events
        /// <summary>
        /// Has a whole load of button click stuff :)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void clsWndwBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mxmsWndwBtn_Click(object sender, RoutedEventArgs e)
        {
            mxmsWndwBtn.Visibility = Visibility.Hidden;
            rstrDwnWndwBtn.Visibility = Visibility.Visible;
            this.WindowState= System.Windows.WindowState.Maximized;
        }

        private void rstrDwnWndwBtn_Click(object sender, RoutedEventArgs e)
        {
            mxmsWndwBtn.Visibility = Visibility.Visible;
            rstrDwnWndwBtn.Visibility = Visibility.Hidden;
            this.WindowState = System.Windows.WindowState.Normal;
        }

        private void mnmsWndwBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        #endregion

        
    }
}
