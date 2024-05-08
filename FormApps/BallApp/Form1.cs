namespace BallApp {
    public partial class Form1 : Form {
      

        //Listコレクション
        private List<Obj> balls = new List<Obj>();//ホールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>();//表示用


        //コンストラクタ
        public Form1() {
            InitializeComponent();

        }

        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void timer1_Tick(object sender, EventArgs e) {
            //ball.Move();
            //.Location = new Point((int)ball.PosX, (int)ball.PosY); 
            for(int i = 0; i < balls.Count; i++) {
                balls[i].Move();
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
        }

       

            private void Form1_MouseClick(object sender, MouseEventArgs e) {

            PictureBox pb = new PictureBox();//画像を表示するコンソール
            Obj ball = null;

            if(e.Button == MouseButtons.Left) { //左クリックでサッカーボール
                pb.Size = new Size(50, 50);
                ball = new SoccerBall(e.X - 25, e.Y);
                
            } else if (e.Button == MouseButtons.Right) { //右クリックでテニスボール
                pb.Size = new Size(25, 25);
                ball = new TennisBall(e.X - 12, e.Y - 12);
            
            }
            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();

            balls.Add(ball);
            pbs.Add(pb);



        }
    }
}
