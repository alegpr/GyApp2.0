using GyApp2._0.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace GyApp2._0
{
    public partial class frmMain : Form
    {
        // costanti
        private const float aspectRatio = 16f / 9f;   //definisce l'aspect ratio
        private static readonly string exePath = AppContext.BaseDirectory; //percorso dell'eseguibile
        private static readonly string solutionRoot = "./../../../"; //percorso cartella della soluzione
        // variabili globali
        int posizioneCorrente = 0;
        string targetPic = "./../../../Resources/"; //percorso completo cartella risorse
        string percorsoFile = Path.Combine(solutionRoot, "candidati.csv"); //percorso completo del file CSV
        // liste
        List<Candidato> elencoCandidati = new List<Candidato>();


        public frmMain()
        {
            InitializeComponent();
            AdattaProporzioni();   //adatta le proporzioni al caricamento iniziale
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CaricaCandidati(percorsoFile);
            MostraCandidato();
        }

        private void picLike_Click(object sender, EventArgs e) => GestisciScelta(true);
        private void picDislike_Click(object sender, EventArgs e) => GestisciScelta(false);

        private void frmMain_Resize(object sender, EventArgs e)
        {
            AdattaProporzioni();
        } // fine frmMain_Resize

        // !!! METODI CUSTOM !!!

        private void CaricaCandidati(string percorsoFile)
        {
            using (StreamReader sr = new StreamReader(percorsoFile))
            {
                // Salta l'intestazione
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string riga = sr.ReadLine();
                    string[] dati = riga.Split(';'); // SEPARATORE ";"

                    // Oggetto
                    Candidato c = new Candidato(
                        dati[0], // Nome
                        dati[1], // Cognome
                        dati[2], // Email
                        dati[3], // Telefono
                        dati[4], // Posizione
                        DateTime.Parse(dati[5]), // DataNascita (formato YYYY-MM-DD o DD/MM/YYYY)
                        dati[6], // Esperienza
                        dati[7], // Competenze
                        dati[8], // Lingue
                        dati[9]  // Note
                    );

                    elencoCandidati.Add(c);
                }
            }
        } // fine carica candidati

        private void MostraCandidato()
        {

            if (posizioneCorrente < elencoCandidati.Count)
            {
                var c = elencoCandidati[posizioneCorrente];

                lblNomeCompleto.Text = $"{c.Nome} {c.Cognome}";
                lblRuolo.Text = c.Posizione;
                txtDettagli.Text = $"Skills: {c.CompetenzeTecniche}\r\n" +
                                   $"Lingue: {c.LingueConosciute}\r\n" +
                                   $"Esperienza: {c.EsperienzaPrecedente}";
                // sintassi "Nome_Cognome.jpg" per le immagini
                picProfilo.ImageLocation = targetPic + $"{c.Nome}_{c.Cognome}.jpg";
            }
            else
            {
                MessageBox.Show("Hai esaminato tutti i candidati!");
            }
        } // fine mostra candidato

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
        } // fine adatta proporzioni
        private void GestisciScelta(bool piaciuto)
        {
            if (posizioneCorrente >= elencoCandidati.Count) return;

            // Salviamo la decisione su un file "match.csv"
            using (StreamWriter sw = new StreamWriter("decisioni.csv", true))
            {
                var c = elencoCandidati[posizioneCorrente];
                string esito = piaciuto ? "INTERESSATO" : "SCARTATO";
                sw.WriteLine($"{DateTime.Now};{c.Email};{esito}");
            }

            // Passiamo al prossimo candidato
            posizioneCorrente++;
            MostraCandidato();
        }
    } // fine class frmMain
} // fine namespace