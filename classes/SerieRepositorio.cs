using System;
using System.Collections.Generic;
using AppSeries.interfaces;

namespace AppSeries
{
    public class SerieRepositorio : IRepositorio<Serie>
    //essa classe implementa uma interface que implementa um repositorio de series
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {//pega o objeto e joga naquela posicao na lista
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            //implementa o envio de e-mail, quando excluir, se for o caso
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}