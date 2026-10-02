interface iPartida
{
    string Time1 { get; }
    string Time2 { get; }
    void jogar(string Time1, string Time2);

    void historico(string Time1, string Time2);
}