namespace DateTimeApp {
    public partial class old : Form {
        public old() {
            InitializeComponent();
        }

        public void btDateCount_Click(object sender, EventArgs e) {

            var Today = DateTime.Today;
            TimeSpan diff = Today - dtpDate.Value;

            tbDisp.Text = (diff.Days + 1) + "“ú–Ú";
        }


        private void btDayafter_Click(object sender, EventArgs e) {
            var future = dtpDate.Value.AddDays((double)nudDay.Value);
            tbDisp.Text = future.ToString();
        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            var past = dtpDate.Value.AddDays((double)-nudDay.Value);
            tbDisp.Text = past.ToString();
        }

        private void btAge_Click(object sender, EventArgs e) {
            var Today = DateTime.Today;
            var birthday = dtpDate.Value;
            var age = Today.Year - birthday.Year;
            if (Today < birthday.AddYears(age)) {
                age--;
            }
            tbDisp.Text = age.ToString();

        }
    }
}
