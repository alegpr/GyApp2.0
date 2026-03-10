using System;
using System.Windows.Forms;

namespace GyApp2._0
{
    public partial class frmMain : Form
    {
        private const float aspectRatio = 16f / 9f;   //definisce l'aspect ratio
        public frmMain()
        {
            InitializeComponent();
            AdattaProporzioni();   //adatta le proporzioni al caricamento iniziale
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            AdattaProporzioni();
        }

        // !!! METODI CUSTOM !!!

        // Metodi Scale-AutoSize
        private void AdattaProporzioni()
        {
            
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; //riportalo a dimensione normale
            }

            int targetHeight = (int)(this.Width * aspectRatio);

            //non permettere che l'altezza superi l'80% dello schermo
            int maxHeight = (int)(Screen.PrimaryScreen.Bounds.Height * 0.8);

            if (targetHeight > maxHeight)
            {
                targetHeight = maxHeight;
                this.Width = (int)(targetHeight / aspectRatio); //ricalcola la larghezza per non rompere il ratio
            }

            if (this.Height != targetHeight)
            {
                this.Size = new System.Drawing.Size(this.Width, targetHeight);
            }
        }
    }
}
