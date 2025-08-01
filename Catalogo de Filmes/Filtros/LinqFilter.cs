using Catalogo_de_Filmes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Catalogo_de_Filmes.Filtros
{

    internal class LinqFilter
    {
        public static void FiltroPorTitulo(List<Filme> filmes)
        {
            var todosOsFilmes = filmes.Select(titulo => titulo.Titulo).ToList();
            foreach (var titulo in todosOsFilmes)
            {
                Console.WriteLine($" - {titulo}");
            }
        }
        public static void FiltroPorAno(List<Filme> filmes)
        {
            var FilmesporAno = filmes.Select(ano => ano.Ano).ToList();
            foreach (var Ano in FilmesporAno)
            {
                Console.WriteLine($" - {Ano}");
            }
        }
        public static void FiltroPorGenero(List<Filme> filmes)
        {
            var FilmesPorGenero = filmes.Select(genero => genero.Genero).ToList();
            foreach (var genero in FilmesPorGenero)
            {
                Console.WriteLine($" - {genero}");
            }
        }
        public static void FiltroPorimdbID(List<Filme> filmes)
        {
            var FilmesPorImbID = filmes.Select(ImdbID => ImdbID.ImdbID).Distinct().ToList();
            foreach (var ImdbID in FilmesPorImbID)
            {
                Console.WriteLine($" - {ImdbID}");
            }
        }
    }
}
