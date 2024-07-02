using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();


        //�R���X�g���N�^
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

        //�I������Ă��郁�[�J�[����񋓌^�ŕԂ��B
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return CarReport.MakerGroup.�g���^;
            else if (rbNissan.Checked)
                return CarReport.MakerGroup.���Y;
            else if (rbHonda.Checked)
                return CarReport.MakerGroup.�z���_;
            else if (rbSubaru.Checked)
                return CarReport.MakerGroup.�X�o��;
            else if (rbImport.Checked)
                return CarReport.MakerGroup.�A����;
            else
                return CarReport.MakerGroup.���̑�;

        }
        //�w�肵�����[�J�[�̃��W�I�{�^�����Z�b�g
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.���Y:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.�z���_:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.�A����:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.���̑�:
                    rbOther.Checked = true;
                    break;
            }
        }



        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarreport.Columns["Picture"].Visible = false;//�摜�\�����Ȃ�
        }

        private void dgvCarreport_Click(object sender, EventArgs e) {
            if (dgvCarreport.Rows.Count == 0) return;
            dtpDate.Value = (DateTime)dgvCarreport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvCarreport.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dgvCarreport.CurrentRow.Cells["Maker"].Value);
            cbCarname.Text = (string)dgvCarreport.CurrentRow.Cells["Carname"].Value;
            tbReport.Text = (string)dgvCarreport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image?)dgvCarreport.CurrentRow.Cells["Picture"].Value;
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            listCarReports.RemoveAt(dgvCarreport.CurrentRow.Index);
            
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            listCarReports[dgvCarreport.CurrentRow.Index] = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarname.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,

                
            };
            dgvCarreport.Refresh();//�f�[�^�O���b�g�r���[�̕ύX          
        }
    }
}
