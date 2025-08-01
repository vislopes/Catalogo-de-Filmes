using Catalogo_de_Filmes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Menus;

public static class Menu
{
    public static async Task MenuPrincipal(List<Filme> filmesBuscados, List<Filme> filmesFavoritos)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Catálogo de Filmes =====");
            Console.WriteLine("1 - Buscar filme");
            Console.WriteLine("2 - Ver filmes buscados");
            Console.WriteLine("3 - Ver favoritos salvos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    await MenuBuscarFilme.BuscarFilme(filmesBuscados, filmesFavoritos);
                    break;
                case "2":
                    MenuListaFilmesBuscados.Exibir(filmesBuscados, filmesFavoritos);
                    break;
                case "3":
                    MenuFavoritosSalvos.Exibir(filmesFavoritos);
                    break;
                case "0":
                    MenuSair.Sair(filmesFavoritos); // Deve salvar favoritos
                    return;
                default:
                    Console.WriteLine("⚠️ Opção inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
