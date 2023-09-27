using screen_sound.Modelos;
using System.Text.Json;
using screen_sound.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;
        //musicas[1000].ExibirDetalhesDaMusica();

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPeloAno(musicas, 2012);

        var musicasPreferidasDaThayna = new MusicasPreferidas("Thayna");
        musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[2]);
        musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[3]);
        musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[5]);

        musicasPreferidasDaThayna.ExibirMusicasFavoritas();

        musicasPreferidasDaThayna.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}