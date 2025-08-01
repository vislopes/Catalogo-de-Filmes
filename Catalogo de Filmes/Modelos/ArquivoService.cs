using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Modelos;
public static class ArquivoService
{
        private const string CaminhoArquivo = "favoritos.json";
    public static void SalvarFavoritos(List<Filme> filmes)
    {
        try
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(filmes, options);
            File.WriteAllText(CaminhoArquivo, json);
            Console.WriteLine("✅ Favoritos salvos com sucesso.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Erro ao salvar favoritos: {ex.Message}");
        }
    }

        public static List<Filme> CarregarFavoritos()
        {
            if (!File.Exists(CaminhoArquivo))
            {
            Console.WriteLine("📂 Nenhum arquivo de favoritos encontrado. Iniciando vazio.");
            return new List<Filme>();
            }

            try
            {
                string json = File.ReadAllText(CaminhoArquivo); 
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                return JsonSerializer.Deserialize<List<Filme>>(json, options) ?? new List<Filme>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar favoritos: {ex.Message}");
                return new List<Filme>();
            }
        }
}




