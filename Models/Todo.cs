namespace apicSharp.Models
{
    public class Todo
    {
        public long id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public bool status { get; set; }

        public void AlterarStatus()
        {
            this.status = !this.status;
        }

        public Todo()
        {

        }
        public Todo( string titulo, string descricao, bool status)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.status = status;
        }
    }
}