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

namespace AngelControl {
    /// <summary>
    /// Interaction logic for RS232Window.xaml
    /// </summary>
    public partial class RS232Window : Window {
        public RS232Window() {
            InitializeComponent();
            EditEnable(true);
        }

        public RS232Window(bool enable) {
            InitializeComponent();
            EditEnable(enable);
        }

        private void ImagePortRefresh_MouseDown(object sender, MouseButtonEventArgs e) {
            //MessageBox.Show("");
            //RotateTransform rotate = new RotateTransform(360);
            //imagePortRefresh.RenderTransform = rotate;
        }

        private void EditEnable(bool enable) {
            buttonOpen.IsEnabled = enable;
            comboBoxPorts.IsEnabled = enable;
            comboBoxParity.IsEnabled = enable;
            comboBoxStopBits.IsEnabled = enable;
            comboBoxHandshake.IsEnabled = enable;
            comboBoxBaudRate.IsEnabled = enable;
            comboBoxReadTime.IsEnabled = enable;
            comboBoxWriteTime.IsEnabled = enable;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

        }

        public void PortsUpdate() {

        }
    }
}
