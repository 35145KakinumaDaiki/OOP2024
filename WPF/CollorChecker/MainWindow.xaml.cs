using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        MyColor currentColor; //現在設定している色情報

        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値を設定（起動時すぐにストックボタンが押された場合の対応）
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);
            colorSelectComboBox.DataContext = GetColorList();
        }
        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        //スライドを動かすと呼ばれるイベントハンドラ
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(currentColor.Color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {


            if (!stockList.Items.Contains((MyColor)currentColor)) {
                stockList.Items.Insert(0,currentColor);
            } else {
                MessageBox.Show("既に登録済みです", "ColorCheker", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);

            selectColor((MyColor)stockList.Items[stockList.SelectedIndex]);
        }

        private void selectColor(MyColor color) {
            rSlider.Value = color.Color.R;
            gSlider.Value = color.Color.G;
            bSlider.Value = color.Color.B;
        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
           var tempcurrentColor = (MyColor)((ComboBox)sender).SelectedItem;
            //各スライダーの値を設定する
            selectColor(tempcurrentColor);
            currentColor.Name = tempcurrentColor.Name;
        }
    }
}
