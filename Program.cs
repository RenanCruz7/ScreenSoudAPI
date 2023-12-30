using ScreenSoudAPI.Modelos;
using System.Text.Json;
using ScreenSoudAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGenerosMusicais(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas,"XXXTENTACION");

        var musicasPreferidasRenan = new MusicasPreferidas("Renan");
        musicasPreferidasRenan.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasRenan.AdicionarMusicasFavoritas(musicas[2]);
        musicasPreferidasRenan.AdicionarMusicasFavoritas(musicas[3]);
        musicasPreferidasRenan.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasRenan.AdicionarMusicasFavoritas(musicas[5]);
        musicasPreferidasRenan.AdicionarMusicasFavoritas(musicas[6]);

        musicasPreferidasRenan.ExibirMusicasFavoritas();

        musicasPreferidasRenan.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
