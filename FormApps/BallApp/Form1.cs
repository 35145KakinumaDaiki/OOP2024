namespace BallApp {
    public partial class Form1 : Form {
        TennisBall tennisBall;
        SoccerBall soccerBall;
        PictureBox pb;


        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();

        }

        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            soccerBall.Move();
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
            tennisBall.Move();
            pb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {

            pb = new PictureBox();//�摜��\������R���\�[��
            pb.Size = new Size(50, 50);

            if(e.Button == MouseButtons.Left) {
                soccerBall = new SoccerBall(e.X - 25, e.Y);
                pb.Image = soccerBall.Image;
                pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Parent = this;
                timer1.Start();
            }
            
            if(e.Button == MouseButtons.Right) {
                tennisBall = new TennisBall(e.X, e.Y);
                pb.Image = tennisBall.Image;
                pb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Parent = this; 
                timer1.Start();
            }
            


           
        }
    }
}
