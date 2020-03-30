using AngelControl.Reader;
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

namespace AngelControl {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void WindowMain_Loaded(object sender, RoutedEventArgs e) {
            if (!RS232.OpenLast()) {
                RS232Window rS232Window = new RS232Window();
                rS232Window.ShowDialog();
            }
        }

        private void WindowMain_Closed(object sender, EventArgs e) {
            RS232.AppClose();
        }

        private void ButtonRS232Status_Click(object sender, RoutedEventArgs e) {
            RS232Window rS232Window = new RS232Window(!RS232.isOpen());
            rS232Window.ShowDialog();
        }
    }
}
