interface iTime
{ 
    string Modalidade { get; }
    string Nome { get; }
    void jogar(int feitos, int sofridos);
}