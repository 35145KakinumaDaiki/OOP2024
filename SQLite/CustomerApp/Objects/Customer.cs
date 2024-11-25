using SQLite;
using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace CustomerApp.Objects {
    public class Customer {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        // 画像データ（byte[]型）
        public byte[] ImageData { get; set; }

        // ImageSource プロパティ
        [Ignore]
        public BitmapImage ImageSource {
            get {
                if (ImageData != null && ImageData.Length > 0) {
                    var bitmap = new BitmapImage();
                    using (var stream = new MemoryStream(ImageData)) {
                        bitmap.BeginInit();
                        bitmap.StreamSource = stream;
                        bitmap.CacheOption = BitmapCacheOption.OnLoad;
                        bitmap.EndInit();
                    }
                    return bitmap;
                }
                return null;  // 画像がない場合は null を返す
            }
        }

        public override string ToString() {
            return $"{Id}   {Name}   {Phone}  {Address}";
        }
    }
}
