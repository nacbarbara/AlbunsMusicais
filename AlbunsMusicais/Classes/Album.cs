using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbunsMusicais.Classes
{
    public class Album
    {
        public int Numero { get; set; }

        public string NomeAlbum { get; set; }

        public string Artista { get; set; }

        public int AnoLancamento { get; set; }

        public string Produtora { get; set; }

        public List<string> Genero { get; set; }

        public string Descricao { get; set; }

        public List<string> Faixas { get; set; }

        public string Capa{ get; set; }

        public Album()
        {
            Genero = new List<string>();

            Faixas = new List<string>();
        }

    }
}
