using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Got
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    [JsonPropertyName("culture")]
    public string? Cultura { get; set; }
    [JsonPropertyName("born")]
    public string? Nascimento { get; set; }
    [JsonPropertyName("aliases")]
    public string[]? Apelidos { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cultura: {Cultura}");
        Console.WriteLine($"Nascimento: {Nascimento}");
        Console.WriteLine("Apelidos: ");
        foreach (var item in Apelidos!) { Console.WriteLine($"- {item}"); }
    }
}
