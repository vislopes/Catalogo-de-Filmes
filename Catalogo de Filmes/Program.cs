using Catalogo_de_Filmes.Modelos;
using Catalogo_de_Filmes.Menus; 
using System.Text.Json;

class Program
{
    static async Task Main(string[] args)
    {
        List<Filme> filmesBuscados = new();
        List<Filme> filmesFavoritos = ArquivoService.CarregarFavoritos();

        await MenuPrincipal(filmesBuscados, filmesFavoritos);
    }

    static async Task MenuPrincipal(List<Filme> filmesBuscados, List<Filme> filmesFavoritos)
    {
        string opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("=== 🎬 Catálogo de Filmes ===\n");
            Console.WriteLine("1 - Buscar filme");
            Console.WriteLine("2 - Ver lista de filmes buscados");
            Console.WriteLine("3 - Filtrar ou ordenar filmes");
            Console.WriteLine("4 - Adicionar filme aos favoritos");
            Console.WriteLine("5 - Ver favoritos salvos");
            Console.WriteLine("0 - Sair");
            Console.Write("\nDigite a opção desejada: ");
            opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    await MenuBuscarFilme.BuscarFilme(filmesBuscados, filmesFavoritos);
                    break;

                case "2":
                    MenuListaFilmesBuscados.Exibir(filmesBuscados, filmesFavoritos);
                    break;

                case "3":
                    MenuFiltrarFilmes.Executar(filmesBuscados);
                    break;

                case "4":
                    MenuAdicionarFilmesFavoritos.Executar(filmesBuscados, filmesFavoritos); 
                    break;

                case "5":
                    MenuFavoritosSalvos.Exibir(filmesFavoritos); 
                    break;

                case "0":
                    MenuSair.Sair(filmesFavoritos); 
                    break;

                default:
                    Console.WriteLine("⚠️ Opção inválida!");
                    Console.ReadKey();
                    break;
            }

        } while (opcao != "0");
    }
}

