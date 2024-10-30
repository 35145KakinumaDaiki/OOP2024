
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
            currentColor.Name = GetColorList()
                                .Where(c => c.Color.R == (byte)rSlider.Value &&
                                            c.Color.G == (byte)gSlider.Value &&
                                            c.Color.B == (byte)bSlider.Value)
                                .Select(c => c.Name)
                                .FirstOrDefault();
            colorArea.Background = new SolidColorBrush(currentColor.Color);
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {


            if (!stockList.Items.Contains((MyColor)currentColor)) {
                stockList.Items.Insert(0, currentColor);
            } else {
                MessageBox.Show("既に登録済みです", "ColorCheker", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedIndex != -1) {
                var selectedColor = (MyColor)stockList.SelectedItem;
                colorArea.Background = new SolidColorBrush(selectedColor.Color);
                selectColor(selectedColor);
            }
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

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            if (stockList.SelectedIndex != -1) {
                stockList.Items.RemoveAt(stockList.SelectedIndex);
            } else {
                MessageBox.Show("削除したい項目を選択して下さい");
            }
        }
    }
}
