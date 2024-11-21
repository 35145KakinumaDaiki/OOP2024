using CustomerApp.Objects;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text)) {
                MessageBox.Show("名前を入力してください", "入力エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                return; // 処理を中止
            }

            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                // 画像パスではなく、画像をbyte配列として保存
                ImageData = (CustomerListView.SelectedItem as Customer)?.ImageData
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
            ReadDatabase(); // ListView表示
        }


        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            //ReadDatabase();
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer == null) {
                MessageBox.Show("更新する顧客を選択してください");
                return;
            }


            selectedCustomer.Name = NameTextBox.Text;
            selectedCustomer.Phone = PhoneTextBox.Text;
            selectedCustomer.Address = AddressTextBox.Text;

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(selectedCustomer);
            }

            ReadDatabase();
        }
        //ListView表示
        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();
                
                CustomerListView.ItemsSource = _customers;

            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);

                ReadDatabase();

            }

        }
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer == null) {
                NameTextBox.Clear();
                PhoneTextBox.Clear();
                AddressTextBox.Clear();
                CustomerImage.Source = null;
                return;
            }

            // 顧客情報が選択されている場合、テキストボックスに情報を表示
            NameTextBox.Text = selectedCustomer.Name;
            PhoneTextBox.Text = selectedCustomer.Phone;
            AddressTextBox.Text = selectedCustomer.Address;

            // 顧客に画像データが設定されている場合、その画像を表示
            if (selectedCustomer.ImageData != null && selectedCustomer.ImageData.Length > 0) {
                var imageStream = new MemoryStream(selectedCustomer.ImageData);
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = imageStream;
                bitmap.EndInit();

                CustomerImage.Source = bitmap;
            } else {
                // 画像データが設定されていない場合は、画像をクリア
                CustomerImage.Source = null;
            }
        }


        private void OpenImageButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == true) {
                string imagePath = openFileDialog.FileName;

                // 画像をbyte配列に変換
                byte[] imageData = ConvertImageToByteArray(imagePath);

                // ImageDataを更新
                var selectedCustomer = CustomerListView.SelectedItem as Customer;
                if (selectedCustomer != null) {
                    selectedCustomer.ImageData = imageData;
                }

                // 画像を表示
                var bitmap = new BitmapImage(new Uri(imagePath));
                CustomerImage.Source = bitmap;
            }
        }


        private void ClearButton_Click(object sender, RoutedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                // 画像をクリアする
                selectedCustomer.ImageData = null;

                // 画像表示をクリアする
                CustomerImage.Source = null;

                // データベースを更新
                using (var connection = new SQLiteConnection(App.databasePass)) {
                    connection.CreateTable<Customer>();
                    connection.Update(selectedCustomer);
                }

                // UIの更新
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
            }
        }
        private byte[] ConvertImageToByteArray(string imagePath) {
            // 画像をbyte配列に変換
            var image = new BitmapImage(new Uri(imagePath));
            using (var memoryStream = new MemoryStream()) {
                // 画像をMemoryStreamに保存
                BitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(image));
                encoder.Save(memoryStream);

                // MemoryStreamからbyte配列を取得
                return memoryStream.ToArray();
            }
        }

    }
}
 