using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using Catalogo_de_Filmes.Modelos;

namespace Catalogo_de_Filmes.Modelos;


public static class FilmeService
{
    public static readonly HttpClient client = new();

    public static async Task<Filme?> BuscarFilmePorTituloAsync(string titulo)
    {
        try
        {
            string chaveApi = "c323f251";
            string url = $"http://www.omdbapi.com/?t={Uri.EscapeDataString(titulo)}&apikey={chaveApi}";

            string resposta = await client.GetStringAsync(url);

            if (resposta.Contains("\"Response\":\"False\""))
                return null;

            var filme = JsonSerializer.Deserialize<Filme>(resposta, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return filme;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
            return null;
        }
    }
}

