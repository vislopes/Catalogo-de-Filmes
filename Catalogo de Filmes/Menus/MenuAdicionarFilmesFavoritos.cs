using Catalogo_de_Filmes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Menus;

public static class MenuAdicionarFilmesFavoritos
{
    public static void Executar(List<Filme> filmesBuscados, List<Filme> filmesFavoritos)
    {
        Console.Clear();
        Console.WriteLine("🎯 Adicionar filme aos favoritos\n");

        if (!filmesBuscados.Any())
        {
            Console.WriteLine("⚠️ Nenhum filme foi buscado ainda.");
        }
        else
        {
            for (int i = 0; i < filmesBuscados.Count; i++)
            {
                var filme = filmesBuscados[i];
                Console.WriteLine($"{i + 1}. {filme.Titulo} ({filme.Ano})");
            }

            Console.Write("\nDigite o número do filme para favoritar: ");
            if (int.TryParse(Console.ReadLine(), out int escolha) &&
                escolha > 0 && escolha <= filmesBuscados.Count)
            {
                var filmeSelecionado = filmesBuscados[escolha - 1];

                if (filmesFavoritos.Any(f => f.ImdbID == filmeSelecionado.ImdbID))
                {
                    Console.WriteLine("⚠️ Este filme já está nos favoritos.");
                }
                else
                {
                    filmesFavoritos.Add(filmeSelecionado);
                    Console.WriteLine("✅ Filme adicionado aos favoritos!");
                }
            }
            else
            {
                Console.WriteLine("❌ Entrada inválida.");
            }
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }
}
