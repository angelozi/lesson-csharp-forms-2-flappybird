using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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
    }
}
