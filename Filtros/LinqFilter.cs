using ScreenSoudAPI.Modelos;

namespace ScreenSoudAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"-{genero}");
        }
    }

    public static void FiltrarArtistaPorGenerosMusicais(List<Musica>musicas, string genero)
    {
        var artistaPorGenerMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

        foreach(var artista in artistaPorGenerMusical)
        {
            Console.WriteLine($"-{artista}");
        }
    }


    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"-{musica.Nome}");
        }
    }
}
