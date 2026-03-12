namespace GyApp2._0
{
    public class Candidato
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Posizione { get; set; }
        public DateTime DataNascita { get; set; }
        public string EsperienzaPrecedente { get; set; }
        public string CompetenzeTecniche { get; set; }
        public string LingueConosciute { get; set; }
        public string NoteAggiuntive { get; set; }

        // Costruttore
        public Candidato(string nome, string cognome, string email, string telefono, string posizione,
                         DateTime dataNascita, string esperienzaPrecedente,
                         string competenzeTecniche, string lingueConosciute,
                         string noteAggiuntive)
        {
            Nome = nome;
            Cognome = cognome;
            Email = email;
            Telefono = telefono;
            Posizione = posizione;
            DataNascita = dataNascita;
            EsperienzaPrecedente = esperienzaPrecedente;
            CompetenzeTecniche = competenzeTecniche;
            LingueConosciute = lingueConosciute;
            NoteAggiuntive = noteAggiuntive;

        }
    }
}