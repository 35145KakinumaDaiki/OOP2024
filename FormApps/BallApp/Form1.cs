namespace BallApp {
    public partial class Form1 : Form {
        TennisBall tennisBall;
        SoccerBall soccerBall;
        PictureBox pb;


        //コンストラクタ
        public Form1() {
            InitializeComponent();

        }

        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            soccerBall.Move();
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY); 
        }

        private void timer2_Tick(object sender, EventArgs e) {
            tennisBall.Move();
            pb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY);
        }

            private void Form1_MouseClick(object sender, MouseEventArgs e) {

            pb = new PictureBox();//画像を表示するコンソール
            pb.Size = new Size(50, 50);


            if(e.Button == MouseButtons.Left) { //左クリックでサッカーボール
                soccerBall = new SoccerBall(e.X - 25, e.Y);
                pb.Image = soccerBall.Image;
                pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Parent = this;
                timer1.Start();
            } else if (e.Button == MouseButtons.Right) { //右クリックでテニスボール
                pb.Size = new Size(25, 25);
                tennisBall = new TennisBall(e.X - 12, e.Y - 12);
                pb.Image = tennisBall.Image;
                pb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Parent = this;
                
            }






        }
    }
}
