class Partidas : iPartida
{
    public string Time1 { get; private set; } = string.Empty;
    public string Time2 { get; private set; } = string.Empty;

    public static void CadastrarPartida()
    {
        Console.WriteLine("Digite o nome do primeiro time:");
        string? time1 = Console.ReadLine();
        Console.WriteLine("Digite o nome do segundo time:");
        string? time2 = Console.ReadLine();

        Partidas partida = new Partidas();
        partida.cadastrarPartida(time1 ?? string.Empty, time2 ?? string.Empty);
    }
    public void jogar(string Time1, string Time2)
    {
        this.Time1 = Time1;
        this.Time2 = Time2;
        Console.WriteLine($"A partida entre {Time1} e {Time2} foi realizada.");
    }
    public void historico(string Time1, string Time2)
    {
        this.Time1 = Time1;
        this.Time2 = Time2;
        Console.WriteLine($"Histórico da partida entre {Time1} e {Time2}:");
    }

    public void cadastrarPartida(string time1, string time2)
    {
        if (string.IsNullOrWhiteSpace(time1) || string.IsNullOrWhiteSpace(time2))
        {
            Console.WriteLine("Os nomes dos times não podem ser vazios.");
            return;
        }

        Time1 = time1;
        Time2 = time2;

        Random random = new Random();
        int golsTime1 = random.Next(0, 11);
        int golsTime2 = random.Next(0, 11);

        string vencedor;
        if (golsTime1 > golsTime2)
        {
            vencedor = time1;
        }
        else if (golsTime2 > golsTime1)
        {
            vencedor = time2;
        }
        else
        {
            vencedor = "Empate";
        }

        var partidaSalva = new PartidaRegistrada
        {
            Time1 = time1,
            Time2 = time2,
            GolsTime1 = golsTime1,
            GolsTime2 = golsTime2,
            Vencedor = vencedor
        };

        Historico.AdicionarPartida(partidaSalva);

        Console.WriteLine();
        Console.WriteLine(new string('=', 80));
        Console.WriteLine("                             RESULTADO DA PARTIDA");
        Console.WriteLine(new string('-', 80));
        Console.WriteLine($"{Time1,-15} {golsTime1,2} x {golsTime2,2} {Time2,-15}");
        Console.WriteLine($"Vencedor: {vencedor}");
        Console.WriteLine(new string('=', 80));
        Console.WriteLine();
    }
}