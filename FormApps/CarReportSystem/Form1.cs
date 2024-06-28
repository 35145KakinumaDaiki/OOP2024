using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();


        //コンストラクタ
        public Form1() {
            InitializeComponent();
            dgvCarreport.DataSource = listCarReports;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarname.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,


            };
            listCarReports.Add(carReport);
        }

        //選択されているメーカー名を列挙型で返す。
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return CarReport.MakerGroup.トヨタ;
            else if (rbNissan.Checked)
                return CarReport.MakerGroup.日産;
            else if (rbHonda.Checked)
                return CarReport.MakerGroup.ホンダ;
            else if (rbSubaru.Checked)
                return CarReport.MakerGroup.スバル;
            else if (rbImport.Checked)
                return CarReport.MakerGroup.輸入車;
            else
                return CarReport.MakerGroup.その他;

        }
        //指定したメーカーのラジオボタンをセット
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            
        }



        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            //dgvCarreport.Columns["Picture"].Visible = false;//画像表示しない
        }

        private void dgvCarreport_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarreport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvCarreport.CurrentRow.Cells["Author"].Value;

            cbCarname.Text = (string)dgvCarreport.CurrentRow.Cells["Carname"].Value;
            tbReport.Text = (string)dgvCarreport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvCarreport.CurrentRow.Cells["Picture"].Value;
        }
    }
}
