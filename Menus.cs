class Menu
{
    private static void mostrarMenu()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Cadastrar Time");
        Console.WriteLine("2 - Cadastrar Partida");
        Console.WriteLine("3 - Histórico de Partidas");
        Console.WriteLine("0 - Sair");
    }

    private static void mostrarOpcaoInvalidaMenu()
    {
        Console.WriteLine("\nOpção inválida. Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey(true);
    }
    public static void Executar()
        {
            bool sairDoPrograma = false;

            while (!sairDoPrograma)
            {
                mostrarMenu();

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
                        // Entrada inválida: avisa e retorna ao menu, sem encerrar o programa.
                        mostrarOpcaoInvalidaMenu();
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("Obrigado por participar!");
        }
}