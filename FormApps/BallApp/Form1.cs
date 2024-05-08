namespace BallApp {
    public partial class Form1 : Form {
        Obj ball;
        PictureBox pb;


        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();

        }

        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            ball.Move();
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY); 
        }

       

            private void Form1_MouseClick(object sender, MouseEventArgs e) {

            pb = new PictureBox();//�摜��\������R���\�[��
           


            if(e.Button == MouseButtons.Left) { //���N���b�N�ŃT�b�J�[�{�[��
                pb.Size = new Size(50, 50);
                ball = new SoccerBall(e.X - 25, e.Y);
                
            } else if (e.Button == MouseButtons.Right) { //�E�N���b�N�Ńe�j�X�{�[��
                pb.Size = new Size(25, 25);
                ball = new TennisBall(e.X - 12, e.Y - 12);
            
            }
            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();






        }
    }
}
