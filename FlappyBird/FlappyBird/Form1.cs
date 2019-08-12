using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class frmGame : Form
    {
        /*özel yazı tipi koleksiyonu için PrivateFontCollection sınıfından FontFamily koleksiyonu eklenir.*/
        public PrivateFontCollection pfc = new PrivateFontCollection();

        public int birdTopCount = 0;
        public int gameScore = 0;
        public int gameBestScore = 0;


        public frmGame()
        {
            InitializeComponent();
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            /*Resources eklenmiş olan özel yazı tipini oyun çalışmaya başladığı an çalıştığı sürece RAM de tutulması sağlanır.*/
            int fontLength = Properties.Resources.flappyfont.Length;
            byte[] fontdata = Properties.Resources.flappyfont;
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);

            /*frmGame üzerine eklenen label elementlerinin font ayarına yüklenen PrivateFontCollection parametresi atanır */
            lblGameScore.Font = new Font(pfc.Families[0], lblGameScore.Font.Size);
            lblHelp.Font = new Font(pfc.Families[0], lblHelp.Font.Size);
            lblBoardScore.Font = new Font(pfc.Families[0], lblBoardScore.Font.Size);
            lblBoardScoreText.Font = new Font(pfc.Families[0], lblBoardScoreText.Font.Size);
            lblBoardBest.Font = new Font(pfc.Families[0], lblBoardBest.Font.Size);
            lblBoardBestText.Font = new Font(pfc.Families[0], lblBoardBestText.Font.Size);


        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            /* gameTimer her çalıştığında pcbFlappyBird nesnesinin diğer nesneler ile aynı pozisyona sahip olup olmadığı kontrol edilir.*/
            /* Aynı pozisyon durumunda oyun sonlanır*/
            if ((pcbPipeTop1.Bottom + birdTopCount) >= pcbGround.Bounds.Top)
            {
                EndGame();
            }
            else if (pcbFlappyBird.Bounds.IntersectsWith(pcbPipeBottom1.Bounds))
            {
                EndGame();
            }
            else if (pcbFlappyBird.Bounds.IntersectsWith(pcbPipeTop1.Bounds))
            {
                EndGame();
            }
            else if (pcbFlappyBird.Bounds.IntersectsWith(pcbPipeBottom2.Bounds))
            {
                EndGame();
            }
            else if (pcbFlappyBird.Bounds.IntersectsWith(pcbPipeTop2.Bounds))
            {
                EndGame();
            }
            else
            {

                /* pcbFlappyBird pozisyon kontrollerinde oyun sonlanmadı ise en az 1 pipe nesnesinden geçmiş olduğu kabul edilir.*/
                /* pipe nesnesinden geçme durumunda 1 puan kazanılır. "Point" ses kaydı çalınır. */

                if (pcbFlappyBird.Left >= pcbPipeTop1.Right && pcbFlappyBird.Left - 10 <= pcbPipeTop1.Right)
                {
                    gameScore++;
                    lblGameScore.Text = gameScore.ToString();
                    playSound("point");
                }
                else if (pcbFlappyBird.Left >= pcbPipeTop2.Right && pcbFlappyBird.Left - 10 <= pcbPipeTop2.Right)
                {
                    gameScore++;
                    lblGameScore.Text = gameScore.ToString();
                    playSound("point");
                }


                /* Pipe nesnelerinden geçen pcbFlappyBird nesnesinin top pozisyonu, space tuşu ile değer atanan "birdTopCount" değeri kadar arttırılır. */
                /* Bu şekilde pcbFlappyBird nesnesinin yer çekimine doğru hareketi sağlanır. */
                pcbFlappyBird.Top += birdTopCount;



                /* Pipe nesnelerinin sol (left) pozisyonlarını 10 pixel azaltılır.*/
                /* Bu şekilde pipe nesnelerinin yer çekimine yatay hareketi sağlanır. */
                pcbPipeBottom1.Left -= 10;
                pcbPipeTop1.Left -= 10;

                pcbPipeBottom2.Left -= 10;
                pcbPipeTop2.Left -= 10;


                /* Pipe nesnelerinin yatay hareketi esnasında "frmGame" nesnesinin sol pozisyonundan küçük olup olmadığı (ekrandan kaybolup kaybolmadığı) kontrol edilir.*/
                Random rnd = new Random();

                /* frmGame nesnesinin sol pozisyonu 0 değerlidir. Bir nesnenin form nesnesinin sol hizasını geçip geçmediği negatif (-) değer alması ile kontrol edilir. */

                /* Bir pipenin form ekranından kaybolması için kendi genişliği kadar 0 değerini geçmiş olması kabul edilir. */
                /* Pipe ekrandan kaybolmuş ise form elementinin genişliği kadar sol (left) değeri verilir. Bu şekilde ekranının sol hizasından çıkarak sağ hizasından tekrar ekranda görünmesi sağlanır*/
                if (pcbPipeBottom1.Left < -pcbPipeBottom1.Width)
                {

                    pcbPipeBottom1.Left = this.Size.Width;
                    pcbPipeTop1.Left = this.Size.Width;

                    /* Her kaydırma işleminde pipe nesnelerinin yükseklikleri değişiklik göstermelidir. Bu şekilde oyundaki engellerin değişimi sağlanarak oyuna akıcılık kazandırılmış olur. */
                    int rndTop = rnd.Next(400, 750); 
                    int fark = pcbPipeBottom1.Top - rndTop;
                    pcbPipeBottom1.Top = rndTop;
                    pcbPipeTop1.Top -= fark;

                }

                /* ikinci pipe nesnesinin birinci pipe nesnesinin bulunduğu pozisyona göre biraz daha geride ekranda görüntülenmesi sağlanır. */
                /* Bu şekilde oyun esnasında engellerin mantıklı dizilmesi sağlanır. */
                if (pcbPipeBottom2.Left < -pcbPipeBottom2.Width)
                {
                    /* İkinci pipe nesnesi birinci pipe nesnesinden değişen bir uzaklıkta yer alması sağlanır */
                    int rndDistance = rnd.Next(450, 590);
                    pcbPipeBottom2.Left = pcbPipeBottom1.Left + rndDistance;
                    pcbPipeTop2.Left = pcbPipeBottom1.Left + rndDistance;

                    /* Her kaydırma işleminde pipe nesnelerinin yükseklikleri değişiklik göstermelidir. Bu şekilde oyundaki engellerin değişimi sağlanarak oyuna akıcılık kazandırılmış olur. */
                    int rndTop = rnd.Next(400, 750);
                    int fark = pcbPipeBottom2.Top - rndTop;
                    pcbPipeBottom2.Top = rndTop;
                    pcbPipeTop2.Top -= fark;

                }

            }
        }

        private void EndGame()
        {
            playSound("hit");

            lblGameScore.Text = "Game Over";

            gameTimer.Stop();


            System.Threading.Thread.Sleep(1000);

            if (gameScore > gameBestScore)
            {
                gameBestScore = gameScore;
            }

            playSound("die");

            pcbPipeTop1.Visible = false;
            pcbPipeBottom1.Visible = false;
            pcbPipeTop2.Visible = false;
            pcbPipeBottom2.Visible = false;
            btnRestart.Visible = true;
            pcbFlappyBird.Visible = false;

            lblBoardScore.Text = gameScore.ToString();
            lblBoardBest.Text = gameBestScore.ToString();

            pnlBoard.Visible = true;


            playThemeSound();

        }

        private void playSound(string soundName)
        {
            SoundPlayer sound = new SoundPlayer();

            switch (soundName)
            {
                case "jump":
                    sound.Stream = Properties.Resources.JumpSound;
                    break;
                case "point":
                    sound.Stream = Properties.Resources.PointSound;
                    break;
                case "die":
                    sound.Stream = Properties.Resources.DieSound;
                    break;
                case "hit":
                    sound.Stream = Properties.Resources.HitSound;
                    break;
            }

            sound.Play();
        }

        private void playThemeSound()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.ThemeSound);
            sound.PlayLooping();
        }

    }
}
