using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        Musica.ExibirDetalhesMuitasMusicas(musicas, 20);

        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");

        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Calvin Harris");

        LinqFilter.FiltrarMusicasPorAno(musicas, 2006);

        LinqFilter.FiltrarPeloTom(musicas, "C#");


        //var musicasPreferidasDoEsdras = new MusicasPreferidas("Esdras");
        //musicasPreferidasDoEsdras.AdicionarMusicasFavoritas(musicas[45]);
        //musicasPreferidasDoEsdras.AdicionarMusicasFavoritas(musicas[35]);
        //musicasPreferidasDoEsdras.AdicionarMusicasFavoritas(musicas[196]);
        //musicasPreferidasDoEsdras.AdicionarMusicasFavoritas(musicas[213]);
        //musicasPreferidasDoEsdras.AdicionarMusicasFavoritas(musicas[209]);

        //musicasPreferidasDoEsdras.ExibirMusicasFavoritas();

        //musicasPreferidasDoEsdras.GerarAqrquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}

//using (HttpClient client1 = new HttpClient())
//{
//    try
//    {
//        string resposta = await client1.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
//        var got = JsonSerializer.Deserialize<Got>(resposta)!;
//        got.ExibirDetalhes();
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Temos um problema: {ex.Message}");
//    }
//}