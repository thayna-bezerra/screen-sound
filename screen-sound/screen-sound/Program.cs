using screen_sound.Modelos;
using System.Text.Json;
using screen_sound.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;
        musicas[1].ExibirDetalhesDaMusica();

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPeloAno(musicas, 2012);

        //var musicasPreferidasDaThayna = new MusicasPreferidas("Thayna");
        //musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[980]);
        //musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[513]);
        //musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[1024]);
        //musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[999]);
        //musicasPreferidasDaThayna.AdicionarMusicasFavoritas(musicas[37]);

        //musicasPreferidasDaThayna.ExibirMusicasFavoritas();

        //musicasPreferidasDaThayna.GerarArquivoJson();
        //musicasPreferidasDaThayna.GerarDocumentoTXT();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}