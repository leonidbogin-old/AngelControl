using System;
using System.Collections.Generic;
using System.IO.Ports;
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
            PortsUpdate();
        }

        private void EditEnable(bool enable) {
            //buttonOpen.IsEnabled = enable;
            comboBoxPorts.IsEnabled = enable;
            comboBoxParity.IsEnabled = enable;
            comboBoxStopBits.IsEnabled = enable;
            comboBoxHandshake.IsEnabled = enable;
            comboBoxBaudRate.IsEnabled = enable;
            comboBoxDataBits.IsEnabled = enable;
            comboBoxReadTime.IsEnabled = enable;
            comboBoxWriteTime.IsEnabled = enable;
            if (enable) {
                buttonOpen.Content = "Подключить";
            } else {
                buttonOpen.Content = "Отключить";
                comboBoxPorts.Foreground = new SolidColorBrush(Color.FromArgb(255, 136, 136, 136));
                comboBoxParity.Foreground = new SolidColorBrush(Color.FromArgb(255, 136, 136, 136));
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            PortsUpdate();
            comboBoxPorts.SelectedItem = Properties.Settings.Default.RS232PortName;
            comboBoxParity.Text = Properties.Settings.Default.RS232Parity.ToString();
            comboBoxStopBits.Text = Properties.Settings.Default.RS232StopBits.ToString();
            comboBoxHandshake.Text = Properties.Settings.Default.RS232Handshake.ToString();
            comboBoxBaudRate.Text = Properties.Settings.Default.RS232BaudRate.ToString();
            comboBoxDataBits.Text = Properties.Settings.Default.RS232DataBits.ToString();
            comboBoxReadTime.Text = Properties.Settings.Default.RS232ReadTimeout.ToString();
            comboBoxWriteTime.Text = Properties.Settings.Default.RS232WriteTimeout.ToString();
        }

        public void PortsUpdate() {
            comboBoxPorts.Items.Clear();
            foreach (string portname in System.IO.Ports.SerialPort.GetPortNames()) {
                ComboBoxItem comboBoxItem = new ComboBoxItem {
                    Content = portname
                };
                comboBoxPorts.Items.Add(comboBoxItem); 
            }
            if (comboBoxPorts.Items.Count > 0) {
                comboBoxPorts.SelectedIndex = comboBoxPorts.Items.Count - 1;
            }
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e) {
            if (Reader.RS232.isOpen()) {
                Reader.RS232.Close();
                EditEnable(!Reader.RS232.isOpen());
            } else {
                if (RS232Open()) {
                    this.DialogResult = true;
                    this.Close();
                } else {
                    MessageBox.Show("Ошибка при открытии порта. Проверьте выставленные параметры считывателя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private bool RS232Open() {
            int error = 0;
            if (comboBoxPorts.SelectedIndex < 0) {
                MessageBox.Show("'PortName' не выбран.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                error++;
            }
            if (!int.TryParse(comboBoxBaudRate.Text, out int baudRate)) {
                MessageBox.Show("Значение в 'BaudRate' должно быть числом.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                error++;
            }
            if (!int.TryParse(comboBoxDataBits.Text, out int databits)) {
                MessageBox.Show("Значение в 'DataBits' должно быть числом.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                error++;
            }
            Handshake handshake = Convert.Handshake(comboBoxHandshake.Text);
            Parity parity = Convert.Parity(comboBoxParity.Text);
            StopBits stopbits = Convert.StopBits(comboBoxStopBits.Text);
            int readtimeout = 0;
            if (!int.TryParse(comboBoxReadTime.Text, out readtimeout)) {
                MessageBox.Show("Значение в 'ReadTime' должно быть числом.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                error++;
            }
            int writetimeout = 0;
            if (!int.TryParse(comboBoxWriteTime.Text, out writetimeout)) {
                MessageBox.Show("Значение в 'WriteTime' должно быть числом.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                error++;
            }

            Reader.RS232Parameters rfid = new Reader.RS232Parameters() {
                PortName = comboBoxPorts.Text,
                BaudRate = baudRate,
                DataBits = databits,
                Handshake = handshake,
                Parity = parity,
                StopBits = stopbits,
                ReadTimeout = readtimeout,
                WriteTimeout = writetimeout,
            };
            if (error == 0) {
                if (Reader.RS232.Open(rfid)) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        public static class Convert {
            public static Handshake Handshake(string str) {
                Handshake handshake;
                switch (str) {
                    case "None": handshake = System.IO.Ports.Handshake.None; break;
                    case "RequestToSend": handshake = System.IO.Ports.Handshake.RequestToSend; break;
                    case "RequestToSendXOnXOff": handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff; break;
                    case "XOnXOff": handshake = System.IO.Ports.Handshake.XOnXOff; break;
                    default: handshake = System.IO.Ports.Handshake.None; break;
                }
                return handshake;
            }

            public static Parity Parity(string str) {
                Parity parity;
                switch (str) {
                    case "None": parity = System.IO.Ports.Parity.None; break;
                    case "Even": parity = System.IO.Ports.Parity.Even; break;
                    case "Mark": parity = System.IO.Ports.Parity.Mark; break;
                    case "Odd": parity = System.IO.Ports.Parity.Odd; break;
                    case "Space": parity = System.IO.Ports.Parity.Space; break;
                    default: parity = System.IO.Ports.Parity.None; break;
                }
                return parity;
            }

            public static StopBits StopBits(string str) {
                StopBits stopBits;
                switch (str) {
                    case "None": stopBits = System.IO.Ports.StopBits.None; break;
                    case "One": stopBits = System.IO.Ports.StopBits.One; break;
                    case "OnePointFive": stopBits = System.IO.Ports.StopBits.OnePointFive; break;
                    case "Two": stopBits = System.IO.Ports.StopBits.Two; break;
                    default: stopBits = System.IO.Ports.StopBits.None; break;
                }
                return stopBits;
            }
        }
    }
}
