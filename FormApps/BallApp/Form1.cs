namespace BallApp {
    public partial class Form1 : Form {
        private double posX;  //x���W
        private double posY;  //y���W
        private double moveX; //�ړ��ʁix�����j
        private double moveY;  //�ړ���(y����)



        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();

            moveX = moveY = 22;
        }
        //�t�H�[�����ŏ��Ƀ��[�h�����Ƃ���x�������s�����
        private void Form1_Load(object sender, EventArgs e) {
            //this.BackColor = Color.White;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            //���݈ʒu��\��
            this.Text = pbBall.Location.ToString();

            if(pbBall.Location.X >= 740 || pbBall.Location.X < 0) {
                moveX = -moveX;
            }




            if (pbBall.Location.Y >= 515 || pbBall.Location.Y < 0) {
                moveY = -moveY;
            }

            

            posX += moveX;
            posY += moveY;

            pbBall.Location = new Point((int)posX, (int)posY);

            
        }

    }
}
