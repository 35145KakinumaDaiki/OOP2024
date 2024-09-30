using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Web.WebView2.Core;
using Windows.UI.Xaml.Controls;

namespace RSSReader {
    public partial class Form1 : Form {
        List<ItemData> items;
        public Form1() {
            InitializeComponent();
            

        }

        private void btGet_Click(object sender, EventArgs e) {
            var selectedFavorite = cbFavorite.SelectedItem as Class1;
            string url;

            if (selectedFavorite != null) {
                url = selectedFavorite.Url;
            } else if (!string.IsNullOrWhiteSpace(cbFavorite.Text)) { 
                url = cbFavorite.Text; 
            } else {
                MessageBox.Show("お気に入り名称か、URLが入力されていません");
                return;
            }

            try {
                webView2.Source = new Uri(url);

                using (var wc = new WebClient()) {
                    var xdoc = XDocument.Load(url);
                    items = xdoc.Root.Descendants("item")
                                     .Select(item => new ItemData {
                                         Title = item.Element("title")?.Value,
                                         Link = item.Element("link")?.Value,
                                     }).ToList();

                    lbRssTitle.Items.Clear();
                    foreach (var item in items) {
                        lbRssTitle.Items.Add(item.Title);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"エラーが発生しました: {ex.Message}");
            }
        }


        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex >= 0) {
                var selectedItem = items[lbRssTitle.SelectedIndex];
                Uri uri = new Uri(selectedItem.Link);
                webView2.Source = uri;
            }
        }
        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }

        private void btRegist_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(cbFavorite.Text) || string.IsNullOrWhiteSpace(tbRssname.Text)) {
                MessageBox.Show("URLまたは名称が入力されていません");
            } else {
                var newFavorite = new Class1 {
                    Name = tbRssname.Text,
                    Url = cbFavorite.Text
                };

                if (!cbFavorite.Items.OfType<Class1>().Any(item => item.Name == newFavorite.Name && item.Url == newFavorite.Url)) {
                    cbFavorite.Items.Add(newFavorite);
                    MessageBox.Show("お気に入り登録完了");
                } else {
                    MessageBox.Show("同じ名前のアイテムがすでに登録されています");
                }
            }
            inputItemsAllClear();
        }

        private void inputItemsAllClear() {
            cbFavorite.Text = "";
            tbRssname.Text  = "";
        }

        private void cbFavorite_SelectedIndexChanged(object sender, EventArgs e) {
            var selectedFavorite = cbFavorite.SelectedItem as Class1;
            if (selectedFavorite != null) {
                Uri uri = new Uri(selectedFavorite.Url);
                webView2.Source = uri;
            }
        }

        private void btDelete_Click(object sender, EventArgs e) {
            var selectedFavorite = cbFavorite.SelectedItem as Class1;

            if (selectedFavorite != null) {
                var result = MessageBox.Show($"'{selectedFavorite.Name}' を削除しますか？", "削除確認", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {
                    cbFavorite.Items.Remove(selectedFavorite);
                    MessageBox.Show("お気に入りが削除されました");
                }
            } else {
                MessageBox.Show("削除するお気に入りが選択されていません");
            }
        }

        
    }
}
