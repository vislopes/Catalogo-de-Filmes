using Catalogo_de_Filmes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Menus;

internal class MenuBuscarFilme
{
    public static async Task BuscarFilme(List<Filme> filmesBuscados, List<Filme> filmesFavoritos)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Digite o título do filme (ou 0 para voltar): ");
            string titulo = Console.ReadLine()!;

            if (titulo == "0") break;

            if (string.IsNullOrWhiteSpace(titulo))
            {
                Console.WriteLine("⚠️ Título inválido.");
                Console.ReadKey();
                continue;
            }

            var filme = await FilmeService.BuscarFilmePorTituloAsync(titulo);

            if (filme == null)
            {
                Console.WriteLine("❌ Filme não encontrado.");
            }
            else
            {
                Console.WriteLine($"\n🎬 Título: {filme.Titulo}");
                Console.WriteLine($"📅 Ano: {filme.Ano}");
                Console.WriteLine($"⭐ IMDb: {filme.Avaliacao}");
                Console.WriteLine($"🎭 Gênero: {filme.Genero}");

                if (!filmesBuscados.Any(f => f.ImdbID == filme.ImdbID))
                    filmesBuscados.Add(filme);

                Console.Write("Adicionar aos favoritos? (s/n): ");
                string resposta = Console.ReadLine()!.ToLower();
                if (resposta == "s" && !filmesFavoritos.Any(f => f.ImdbID == filme.ImdbID))
                {
                    filmesFavoritos.Add(filme);
                    Console.WriteLine("✅ Adicionado aos favoritos!");
                }
                else if (resposta == "s")
                {
                    Console.WriteLine("⚠️ Já está nos favoritos.");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
