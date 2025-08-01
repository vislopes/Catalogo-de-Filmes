using Catalogo_de_Filmes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Menus;

internal class MenuSair 
{
    internal static void Sair(List<Filme> filmesFavoritos)
    {
        Console.Clear();
    }

    public static class Executar
    {
        public static void Sair(List<Filme> filmesFavoritos)
        {
            ArquivoService.SalvarFavoritos(filmesFavoritos);

            Console.Clear();
            Console.WriteLine("👋 Obrigado por usar o Catálogo de Filmes.");
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();
        }
    }
}
