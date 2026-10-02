class ESport : Time
{
    public ESport(string nome) : base(nome)
    {
        Modalidade = "ESport";
    }
    public override void jogar(int feitos, int sofridos)
    {
        if (feitos > 0 || sofridos > 0)
        {
            Console.WriteLine("O número de rounds feitos e sofridos não pode ser negativo.");
            return;
        }
        if (feitos + sofridos > 3)
        {
            Console.WriteLine("só podem ser jogados 3 rounds por partida.");
            return;
        }
    }
}