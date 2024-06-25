using System.Globalization;
namespace Excercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var date = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var datOfweek = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
            tbDisp.Text = date.ToString("yyyy/M/d/ HH:mm" + "\r\n" + "yyyy年MM月dd日 HH時mm分ss秒" + "\r\n" + "ggyy年M月d日(dddd)", culture);
            

           

        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            static DateTime NextDay(DateTime date,DayOfWeek dayOfWeek) {
                var days = (int)dayOfWeek - (int)(date.DayOfWeek);
                if (days <= 0)
                    days += 7;
                return date.AddDays(days);
            }
        }
    }
}
