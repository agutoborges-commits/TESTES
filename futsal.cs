class Futsal : Time
{
    public Futsal(string nome) : base(nome)
    {
        Modalidade = "Futsal";
    }
    public override void jogar(int feitos, int sofridos)
    {
        if (feitos < 0 || sofridos < 0)
        {
            Console.WriteLine("O número de gols feitos e sofridos não pode ser negativo.");
            return;
        }
        if (feitos + sofridos > 200)
        {
            Console.WriteLine("O número total de gols feitos e sofridos não pode exceder 200.");
            return;
        }
    }
}