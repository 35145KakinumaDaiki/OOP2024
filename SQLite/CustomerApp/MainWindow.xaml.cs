using CustomerApp.Objects;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.Data.Odbc;

namespace CustomerApp {
    public partial class MainWindow : Window {
        private List<Customer> _customers;
        private byte[] _selectedImageData = null; // 画像データを一時的に保持

        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {

            if (string.IsNullOrWhiteSpace(NameTextBox.Text)) {
                MessageBox.Show("名前を入力してください", "入力エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                return; // 処理を中止
            }

            // 顧客データの作成
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                ImageData = _selectedImageData  // 画像のバイト配列を設定
            };

            // SQLiteに保存
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
            MessageBox.Show("顧客情報を追加しました");
            // 顧客リストを更新
            ReadDatabase();

            // 入力フィールドと画像をクリア
            ClearForm();
        }

        private void ClearForm() {
            // 名前、電話番号、住所、画像のクリア
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            AddressTextBox.Clear();
            CustomerImage.Source = null;  // 画像表示のクリア
            _selectedImageData = null;   // 画像データのクリア
        }

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();
                CustomerListView.ItemsSource = _customers;
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

            NameTextBox.Text = selectedCustomer.Name;
            PhoneTextBox.Text = selectedCustomer.Phone;
            AddressTextBox.Text = selectedCustomer.Address;
            CustomerImage.Source = selectedCustomer.ImageSource;
        }

        // OpenImageButton で画像を選択
        private void OpenImageButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == true) {
                string imagePath = openFileDialog.FileName;

                // 画像をバイト配列に変換
                _selectedImageData = File.ReadAllBytes(imagePath);

                // 画像を表示
                var bitmap = new BitmapImage();
                using (var stream = new MemoryStream(_selectedImageData)) {
                    bitmap.BeginInit();
                    bitmap.StreamSource = stream;
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.EndInit();
                }
                CustomerImage.Source = bitmap;
            }
        }

        // ClearButton で画像をクリア
        private void ClearButton_Click(object sender, RoutedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer != null) {
                selectedCustomer.ImageData = null;
                CustomerImage.Source = null;

                using (var connection = new SQLiteConnection(App.databasePass)) {
                    connection.CreateTable<Customer>();
                    connection.Update(selectedCustomer);
                }

                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
            }

            // 画像データをクリア
            _selectedImageData = null;
        }

        // UpdateButton で顧客情報を更新
        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedCustomer = CustomerListView.SelectedItem as Customer;
            if (selectedCustomer == null) {
                MessageBox.Show("更新する顧客を選択してください");
                return;
            }

            selectedCustomer.Name = NameTextBox.Text;
            selectedCustomer.Phone = PhoneTextBox.Text;
            selectedCustomer.Address = AddressTextBox.Text;
            selectedCustomer.ImageData = _selectedImageData;

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(selectedCustomer);
            }

            ReadDatabase();
        }

        // 検索時にリストをフィルタリング
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        // 削除ボタンで顧客を削除
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
    }
}
