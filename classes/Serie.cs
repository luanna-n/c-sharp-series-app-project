using System;
    
namespace AppSeries
{
    public class Serie : EntidadeBase
    //serie ta herdando (:) da EntidadeBase
    {
        //Atributos

        private Genero Genero { get; set; }
        //genero é um enum

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        private bool Excluido { get; set; }
        //cuidado com exclusao que exclui MESMO
        //MARCAR QUE INFORMACAO FOI EXCLUIDA

         //Métodos de construtor
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            //Environment.NewLine pega como o sistema interpreta uma nova linha
            //Ai não precisa ficar procurando ver se é /n /r/n
            //Já pega de acordo com o sistema operacional
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir() {
            this.Excluido = true;
        }
    }
}