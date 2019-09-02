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

        /* Space tuşu ile değer alarak time methodu ile flappyBird nesnesini yukarı / aşağı taşınmasını sağlamak için */
        public int birdTopCount = 0;

        /* Bir oyun başlayıp bitme sürecinde her bir pipeden geçişde alınan 1 puanı tutmak için*/
        public int gameScore = 0;

        /* Oyundan çıkış yapılmadığı sürece her yeni oyunda en yüksek elde edilen puanı tutmak için*/
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

            /* Oyun açıldığında tema müziğinin çalınması sağlanır. */
            PlayThemeSound();
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
                    PlaySound("point");
                }
                else if (pcbFlappyBird.Left >= pcbPipeTop2.Right && pcbFlappyBird.Left - 10 <= pcbPipeTop2.Right)
                {
                    gameScore++;
                    lblGameScore.Text = gameScore.ToString();
                    PlaySound("point");
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
                    int rndTop = rnd.Next(500, 750); 
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
                    int rndTop = rnd.Next(500, 750);
                    int fark = pcbPipeBottom2.Top - rndTop;
                    pcbPipeBottom2.Top = rndTop;
                    pcbPipeTop2.Top -= fark;

                }

            }
        }

        /*Start butonuna basıldığında oyunun başlaması için nesnelerin düzenlemesi yapılır */
        private void StartGame()
        {

            /* Oyun puanı yeniden başlatılması için gameScore global değişkeninin değeri 0 olarak atanır. */
            gameScore = 0;

            /* Oyun sırasında herbir pipe nesnesi geçişinde kazanılan 1 puan oyuncuya gösterimi sağlanır*/
            lblGameScore.Text = "0";

            /* Oyun başlaması için flappyBird ve pipe nesnelerinin pozisyonları ve gizlilikleri düzenlenir. */
            PipesReset();

            /* Oyun başladıktan sonra btnStart ve lblHelp nesneleri gizlenir. */
            btnStart.Visible = false;
            lblHelp.Visible = false;

            /* Oyun başladıktan sonra btnRestart ve pnlBoard nesneleri gizlenir. */
            btnRestart.Visible = false;
            pnlBoard.Visible = false;

            /* Eğer, bir önceki sonlanan oyun sırasında pcbFlappyBird nesnesini hareket ettirmek için arttırılıp / azaltılan birdTopCount değeri var ise yeniden 0 olarak atanır.*/
            birdTopCount = 0;

            /* Oyun algoritmasının devreye alınması sağlanır. */
            gameTimer.Start();
        }

        /*Oyun bittiğinde oyun bitiş bilgisini vererek oyunun yeniden başlaması için nesnelerin düzenlemesi yapılır */
        private void EndGame()
        {
            /* Oyun bittiğinde oyuncu için bilgi mesajı verilir. Timer Tick methodu durdurulur*/
            PlaySound("hit");

            lblGameScore.Text = "Game Over";

            gameTimer.Stop();


            System.Threading.Thread.Sleep(1000);

            if (gameScore > gameBestScore)
            {
                gameBestScore = gameScore;
            }

            /* Oyun bitim işleminde ekrandaki oyun nesneleri gizlenerek puan tablosunun gösterimi sağlanır.*/

            PlaySound("die");

            pcbPipeTop1.Visible = false;
            pcbPipeBottom1.Visible = false;
            pcbPipeTop2.Visible = false;
            pcbPipeBottom2.Visible = false;
            btnRestart.Visible = true;             
            pcbFlappyBird.Visible = false;

            lblBoardScore.Text = gameScore.ToString();
            lblBoardBest.Text = gameBestScore.ToString();

            pnlBoard.Visible = true;

            /* Oyun puan tablosu gösteriminde tema müziği çalınır*/
            PlayThemeSound();

        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            /*Oyun açılışında space tuşu ile oyunu başlatır*/
            if (btnStart.Visible)
            {
                StartGame();
            }

            /* GameTimer_Tick methodunda pcbFlappyBird nesnesinin top pozisyonu birdTopCount değeri kadar arttırılmaktadır. */
            /* Negatif değere sahip olunduğunda pcbFlappyBird nesnesinin top pozisyonu azalır ve yukarı doğru hareketi sağlanmış olur.*/
            /* Bu işlemde her basımda hızlı yukarı çıkma sağlanır.*/

            if (e.KeyCode == Keys.Space)
            {
                birdTopCount = -15;
                PlaySound("jump");

            }
        }

        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            
            /* GameTimer_Tick methodunda pcbFlappyBird nesnesinin top pozisyonu birdTopCount değeri kadar arttırılmaktadır. */
            /* Pozitif sabit değere sahip olunduğunda pcbFlappyBird nesnesinin top pozisyonu artar ve aşağı doğru hareketi sağlanmış olur.*/
            /* Bu işlemde tuşa basılmadığında sabit hızla aşağı inme sağlanır. */
            if (e.KeyCode == Keys.Space)
            {
                birdTopCount = 15;
            }
        }

        private void BtnStart_MouseClick(object sender, MouseEventArgs e)
        {
            /* Oyunun başlaması için gerekli olan işlemlerin yapılması için EndGame methodu çağrılır.*/
            StartGame();
        }

        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            /* Fare ile üzerine gelindiğinde 2 pixel üst (top) pozisyonu arttırılarak aşağı doğru hareket sağlanır*/
            btnStart.Top += 2;
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            /* Fare ile üzerine gelindiğinde 2 pixel üst (top) pozisyonu azaltılarak aşağı yukarı hareket sağlanır*/
            btnStart.Top -= 2;
        }

        private void BtnRestart_MouseClick(object sender, MouseEventArgs e)
        {
            /* Oyunun yeniden başlaması için gerekli olan işlemlerin yapılması için EndGame methodu çağrılır.*/
            StartGame();
        }

        private void BtnRestart_MouseEnter(object sender, EventArgs e)
        {
            /* Fare ile üzerine gelindiğinde 2 pixel üst (top) pozisyonu arttırılarak aşağı doğru hareket sağlanır*/
            btnRestart.Top += 2;
        }

        private void BtnRestart_MouseLeave(object sender, EventArgs e)
        {
            /* Fare ile üzerine gelindiğinde 2 pixel üst (top) pozisyonu azaltılarak aşağı yukarı hareket sağlanır*/
            btnRestart.Top -= 2;
        }

        /*
         * Form nesnesi kapatıldığında FontCollection tarafından kullanılan kaynakları "Dispose" methodu ile serbest bırakır. 
         */
        private void FrmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            pfc.Dispose();
        }

        /*
         Oyun başlatılmasına nesnelerin hazırlanmasını sağlar.
         Form üzerinde nesnelerin pozisyonları belirlenir. Gizlikleri kaldırılır.
         Oyun Başlat ve Yeniden Başlat işlemlerinde kullanılır.
         */
        private void PipesReset()
        {
            pcbPipeTop1.Location = new System.Drawing.Point(602, -535);
            pcbPipeBottom1.Location = new System.Drawing.Point(602, 500);
            pcbPipeTop2.Location = new System.Drawing.Point(1000, -335);
            pcbPipeBottom2.Location = new System.Drawing.Point(1000, 700);
            pcbFlappyBird.Location = new System.Drawing.Point(345, 271);

            pcbPipeTop1.Visible = true;
            pcbPipeBottom1.Visible = true;
            pcbPipeTop2.Visible = true;
            pcbPipeBottom2.Visible = true;
            pcbFlappyBird.Visible = true;
        }
        
        private void PlaySound(string soundName)
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

        private void PlayThemeSound()
        {
            SoundPlayer sound = new SoundPlayer(Properties.Resources.ThemeSound);
            sound.PlayLooping();
        }


    }
}
