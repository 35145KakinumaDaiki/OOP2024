using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
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
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(cbFavorite.Text);
                var xdoc = XDocument.Load(url);
                items = xdoc.Root.Descendants("item")
                                     .Select(item => new ItemData {
                                         Title = item.Element("title").Value,
                                         Link = item.Element("link").Value,
                                     }).ToList();

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }

            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            Uri uri = new Uri(items[lbRssTitle.SelectedIndex].Link);
            webView2.Source = uri;


        }
        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }

        private void btRegist_Click(object sender, EventArgs e) {
            if (cbFavorite.Text == "" || tbRssname.Text == "") {
                MessageBox.Show("URLまたは名称が入力されていません");
            } else if(!cbFavorite.Items.Contains((string)tbRssname.Text)) {
                cbFavorite.Items.Add((string)tbRssname.Text);
                cbFavorite.Items.Add((string)cbFavorite.Text);
                MessageBox.Show("お気に入り登録完了");
            }
            inputItemsAllClear();
        }

        private void inputItemsAllClear() {
            cbFavorite.Text = "";
            tbRssname.Text  = "";
        }
       
    }
}
