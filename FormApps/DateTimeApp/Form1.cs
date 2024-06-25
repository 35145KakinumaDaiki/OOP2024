namespace DateTimeApp {
    public partial class old : Form {
        public old() {
            InitializeComponent();
        }

        public void btDateCount_Click(object sender, EventArgs e) {

            var Today = DateTime.Today;
            TimeSpan diff = Today - dtpBirthday.Value;

            tbDisp.Text = (diff.Days + 1) + "“ú–Ú";
        }
        public void btDaybefore_Click(object sender, EventArgs e) {
            var Today = DateTime.Today;
            var future = Today.AddDays((double)nudDay.Value);

        }

        private void btDayafter_Click(object sender, EventArgs e) {

        }
    }
}
