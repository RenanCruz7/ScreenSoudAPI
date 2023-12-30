using System.Text.Json.Serialization;

namespace ScreenSoudAPI.Modelos;

internal class Musica
{
    [JsonPropertyName("song")] //Anotação
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]    
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Genero: {Genero}");
    }
}
