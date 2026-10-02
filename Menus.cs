class Menu
{
    private static void mostrarMenu()
    {
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          FESTIVAL DE TIMES");
        Console.WriteLine("========================================");
        Console.WriteLine("1 - Cadastrar Time   |   2 - Cadastrar Partida");
        Console.WriteLine("3 - Histórico        |   0 - Sair");
        Console.WriteLine("========================================");
    }

    private static void mostrarOpcaoInvalidaMenu()
    {
        Console.WriteLine("\nOpção inválida. Tente novamente.");
    }

    public static void Executar()
    {
        bool sairDoPrograma = false;

        while (!sairDoPrograma)
        {
            mostrarMenu();
            Console.Write("Escolha uma opção: ");

            string? entrada = Console.ReadLine();

            switch (entrada)
            {
                case "1":
                    Time.Cadastrar();
                    break;

                case "2":
                    Partidas.CadastrarPartida();
                    break;

                case "3":
                    Historico.ExibirHistorico();
                    break;

                case "0":
                    sairDoPrograma = true;
                    break;

                default:
                    mostrarOpcaoInvalidaMenu();
                    break;
            }

            if (!sairDoPrograma)
            {
                Console.WriteLine();
                Console.WriteLine(new string('=', 60));
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        Console.Clear();
        Console.WriteLine("Obrigado por participar!");
    }
}