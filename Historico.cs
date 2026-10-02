public class PartidaRegistrada
{
    public string Time1 { get; set; } = string.Empty;
    public string Time2 { get; set; } = string.Empty;
    public int GolsTime1 { get; set; }
    public int GolsTime2 { get; set; }
    public string Vencedor { get; set; } = string.Empty;
}

class Historico
{
    private static readonly List<PartidaRegistrada> partidas = new();

    public static void AdicionarPartida(PartidaRegistrada partida)
    {
        partidas.Add(partida);
    }

    public static void ExibirHistorico()
    {
        Console.WriteLine();
        Console.WriteLine(new string('=', 80));
        Console.WriteLine("                         HISTÓRICO DE PARTIDAS");
        Console.WriteLine(new string('=', 80));

        if (partidas.Count == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Nenhuma partida cadastrada.");
            Console.WriteLine(new string('=', 80));
            return;
        }

        foreach (var partida in partidas)
        {
            Console.WriteLine();
            Console.WriteLine($"{partida.Time1,-15} {partida.GolsTime1,2} x {partida.GolsTime2,2} {partida.Time2,-15}");
            Console.WriteLine($"Vencedor: {partida.Vencedor}");
            Console.WriteLine(new string('-', 80));
        }

        Console.WriteLine(new string('=', 80));
    }
}
    