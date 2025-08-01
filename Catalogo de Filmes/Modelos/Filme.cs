using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Catalogo_de_Filmes.Modelos
{
    public class Filme
    {
        private string titulo;

        public Filme(string titulo)
        {
            this.titulo = titulo;
        }

        [JsonPropertyName("title")]
        public StringInfo Titulo { get; set; }

        [JsonPropertyName("year")]
        public int Ano { get; set; }

        [JsonPropertyName("cast")]
        public List<string> Elenco { get; set; }

        [JsonPropertyName("director")]
        public string? Diretor { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        [JsonPropertyName("plot")]
        public string? Sinopse { get; set; }

        [JsonPropertyName("imdbRating")]
        public double Avaliacao { get; set; }

        [JsonPropertyName("runtime")]
        public string? Duracao { get; set; }

        [JsonPropertyName("language")]
        public string? Idioma { get; set; }

        [JsonPropertyName("country")]
        public string? Pais { get; set; }

        [JsonPropertyName("awards")]
        public string? Premios { get; set; }

        [JsonPropertyName("type")]
        public string? Tipo { get; set; }

        [JsonPropertyName("imdbID")]
        public string? ImdbID { get; set; }

        public void ExibirDetalhesDoFilme()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"ID: {ImdbID}");
            Console.WriteLine($"Ano de lnçamento: {Ano}");
            Console.WriteLine($"Elenco: {Elenco}");
            Console.WriteLine($"Diretor: {Diretor}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Sinopse: {Sinopse}");
            Console.WriteLine($"Avaliação: {Avaliacao}");
            Console.WriteLine($"Duração: {Duracao}");
            Console.WriteLine($"Idioma: {Idioma}");
            Console.WriteLine($"País: {Pais}");
            Console.WriteLine($"Prêmios: {Premios}");
            Console.WriteLine($"Tipo: {Tipo}");

        }
    }
}
