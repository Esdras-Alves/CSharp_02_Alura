using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        //seleciono somente a propriedade Genero 
        var todosOsGenerosMusicais = musicas.Select(musica => musica.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista (List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno (List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano).ToList(); // var musicasDoAno = musicas.Where(musica => musica.Ano == ano).Select(musica => musica.Nome).ToList();
        Console.WriteLine($"Músicas do ano {ano}");
        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica.Nome}");   
        }
    }

    public static void FiltrarPeloTom(List<Musica> musicas, string tom)
    {
        var musicasDoTom = musicas.Where(musica => musica.Tonalidade.Equals(tom)).ToList();
        Console.WriteLine($"Músicas da Tonalidade {tom}");
        foreach (var musica in musicasDoTom)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
