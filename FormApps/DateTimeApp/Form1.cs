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


        private void btDayafter_Click(object sender, EventArgs e) {
            var Today = DateTime.Today;
            var future = Today.AddDays((double)nudDay.Value);
            tbDisp.Text = future.ToString();
        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            var Today = DateTime.Today;
            var past = Today.AddDays((double)-nudDay.Value);
            tbDisp.Text = past.ToString();
        }
    }
}
