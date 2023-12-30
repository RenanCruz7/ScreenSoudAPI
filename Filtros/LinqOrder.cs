﻿using ScreenSoudAPI.Modelos;

namespace ScreenSoudAPI.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"-{artista}");
        }
    }
}
