using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Modelos;

internal class FilmesFavoritos
{
    public static class Executar
    {
        public static void ExibirFavoritos(List<Filme> favoritos)
        {
            Console.Clear();
            if (!favoritos.Any())
            {
                Console.WriteLine("📂 Nenhum filme favorito salvo.");
            }
            else
            {
                Console.WriteLine("🎥 Filmes Favoritos:");
                foreach (var filme in favoritos)
                {
                    Console.WriteLine($"- {filme.Titulo} ({filme.Ano}) | IMDb: {filme.ImdbID}");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
        }
    }
}
