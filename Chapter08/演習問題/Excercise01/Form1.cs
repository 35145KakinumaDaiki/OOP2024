using System.Collections.ObjectModel;
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
            tbDisp.Text = date.ToString("yyyy/M/d/ HH:mm" + "\r\n" + "yyyy�NMM��dd�� HH��mm��ss�b" + "\r\n" + "ggyy�NM��d��(dddd)", culture);




        }

        private void btEx8_2_Click(object sender, EventArgs e) {


            var dateTime = DateTime.Today;
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {

                var str = string.Format("{0:yy/MM/dd}�̎��T��{1}", dateTime, (DayOfWeek)dayofweek);
                //���T�̓��t���擾
                var str2 = string.Format("{0:yy/MM/dd(ddd)}", NextWeek(dateTime, (DayOfWeek)dayofweek));

                tbDisp.Text += str + str2 + "\r\n";
            }
        }

        public static DateTime NextWeek(DateTime date, DayOfWeek dayofweek) {
            var nextweek = date.AddDays(7);
            var day = (int)dayofweek - (int)date.DayOfWeek;
            return nextweek.AddDays(day);
        }

        private void btEx8_3_Click(object sender, EventArgs e) {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            var str = String.Format("�������Ԃ�{0}�~���b�ł���", duration.TotalMilliseconds);
            tbDisp.Text = str;
        }
    }

    class TimeWatch {
        private DateTime _time;

        public void Start() {
            _time = DateTime.Now;


        }

        public TimeSpan Stop() {
            return DateTime.Now - _time;

        }
    }
}
