using System.Globalization;
namespace Excercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var date = new DateTime(2019,1,15,19,48,32);
            tbDisp.Text = date.ToString("f" + "\r\n" );
            tbDisp.Text = date.ToString("yyyy”NMMŒŽdd“ú HHŽžmm•ªss•b" + "\r\n");

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var datOfweek = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
            tbDisp.Text = date.ToString("ggyy”NMŒŽd“ú(dddd)", culture);

        }
    }
}
