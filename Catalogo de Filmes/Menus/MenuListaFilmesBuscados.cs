using Catalogo_de_Filmes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Menus;

    public static class MenuListaFilmesBuscados
    {
    public static void ExibirListaOrdenadaPorTitulo(List<Filme> filmes)
    {
        var ordenados = filmes.OrderBy(f => f.Titulo).ToList();

        Console.Clear();
        Console.WriteLine("🎬 Filmes ordenados por título:");
        foreach (var filme in ordenados)
        {
            Console.WriteLine($"- {filme.Titulo} | IMDb: {filme.ImdbID}");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }

    internal static void Exibir(List<Filme> filmesBuscados, List<Filme> filmesFavoritos)
    {
        Console.Clear();
    }
}



