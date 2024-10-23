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

namespace CollorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            byte Rvalue = (byte)rSlider.Value;
            byte Gvalue = (byte)gSlider.Value;
            byte Bvalue = (byte)bSlider.Value;
            colorArea.Background = new SolidColorBrush(Color.FromRgb(Rvalue, Gvalue, Bvalue));
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            byte Rvalue = (byte)rSlider.Value;
            byte Gvalue = (byte)gSlider.Value;
            byte Bvalue = (byte)bSlider.Value;

            MyColor myColor = new MyColor {
                Color = Color.FromRgb(Rvalue, Gvalue, Bvalue),
                Name = ToString()
            };

            
            stockList.Items.Add(myColor);
        



        }
    }
}
