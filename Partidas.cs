class Partidas : iPartida
{
    public string Time1 { get; private set; }
    public string Time2 { get; private set; }

    public static void CadastrarPartida()
    {
        Console.WriteLine("Digite o nome do primeiro time:");
        string time1 = Console.ReadLine();
        Console.WriteLine("Digite o nome do segundo time:");
        string time2 = Console.ReadLine();

        Partidas partida = new Partidas();
        partida.cadastrarPartida(time1, time2);
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
        // Aqui você pode adicionar a lógica para exibir o histórico da partida.
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
        Console.WriteLine($"Partida cadastrada entre {Time1} e {Time2}.");
    }
}