using Catalogo_de_Filmes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Filtros;
internal class LinqOrder
{
    public static List<Filme> OrdenarPorTitulo(List<Filme> filmes)
    {
        return filmes.OrderBy(f => f.Titulo).ToList();
    }
    public static List<Filme> OrdenarPorAvaliacao(List<Filme> filmes)
    {
        return filmes.OrderByDescending(f =>
        {
            return f.Avaliacao;
        }).ToList();
    }
}
