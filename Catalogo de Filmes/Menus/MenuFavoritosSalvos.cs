using Catalogo_de_Filmes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Menus;

internal class MenuFavoritosSalvos
{
    internal static void Exibir(List<Filme> filmesFavoritos)
    {
        Console.Clear();
    }

        public static void Executar(List<Filme> filmesFavoritos)
        {
            Console.Clear();
            Console.WriteLine("Filmes Favoritos");

            if (!filmesFavoritos.Any())
            {
                Console.WriteLine("Nenhum filme salvo.");
            }
            else
            {
                Console.WriteLine($"\nMúsicas salvas:\n");
                foreach (var filme in filmesFavoritos)
                {
                    Console.WriteLine($"🎬 {filme.Titulo} ({filme.Ano}) | IMDb: {filme.Avaliacao}");
                    Console.WriteLine("------------------------------");
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }
}
