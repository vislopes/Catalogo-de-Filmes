using Catalogo_de_Filmes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Menus;

internal class MenuFiltrarFilmes 
{
    public static void Exibir(List<Filme> filmes)
    {
        Console.Clear();
        Console.Write("Digite um gênero para filtrar (ex: Action, Drama): ");
        string genero = Console.ReadLine()!;

        var filtrados = filmes
            .Where(f => f.Genero?.ToLower().Contains(genero.ToLower()) == true)
            .ToList();

        Console.Clear();
        if (!filtrados.Any())
        {
            Console.WriteLine($"⚠️ Nenhum filme encontrado com gênero \"{genero}\".");
        }
        else
        {
            Console.WriteLine($"🎭 Filmes com gênero \"{genero}\":\n");
            foreach (var filme in filtrados)
                Console.WriteLine($"🎬 {filme.Titulo} | Gênero: {filme.Genero}");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar.");
        Console.ReadKey();
    }

    internal static void Executar(List<Filme> filmesBuscados)
    {
        Console.Clear();
    }
}

