class Time : iTime
{
    public string Modalidade { get; set; } = string.Empty;
    public string Nome { get; private set; }

    public Time(string nome)
    {
        Nome = nome;
    }

    public virtual void jogar( int feitos, int sofridos)
    {
        Console.WriteLine($"O time {Nome} está jogando a modalidade {Modalidade}.");
    }

    public static Time? Cadastrar()
    {
        string? nome;
        string? modalidade;
        Console.WriteLine("Digite o nome do time:");
        nome = Console.ReadLine();
        Console.WriteLine("Digite a modalidade do time:");
        modalidade = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("O nome do time não pode ser vazio.");
            return null;
        }

        if (string.IsNullOrWhiteSpace(modalidade))
        {
            Console.WriteLine("A modalidade do time não pode ser vazia.");
            return null;
        }

        switch (modalidade.ToLower())
        {
            case "futsal":
                return new Futsal(nome);
            case "esport":
                return new ESport(nome);
            default:
                Console.WriteLine("Modalidade inválida. Escolha entre 'Futsal' ou 'ESport'.");
                return null;
        }
    }
}