using jogoDaVelha;
bool vf = true;
bool vf2 = true;
bool vencedor = true;
Service service = new Service();
Random aleatorio = new Random();
Console.Write("1 player\n2 player\nopcao: ");
int players = Convert.ToInt32(Console.ReadLine());
switch (players)
{
    case 1:
        Console.Write("digiete seu nome: ");
        string jogador1 = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"{jogador1} vs RoboTron");
        int cont = 0;
        while (vencedor)
        {
            Console.Clear();
            int n1 = 0;
            service.game();
            while (vf2)
            {
                Console.Write($"{jogador1} sua vez: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                if (service.jogar(n1, "x"))
                {
                    vf2 = false;
                }
            }

            if (service.venc("x"))
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"{jogador1} venceu");
                service.game();
                break;
            }


            Console.WriteLine();
            int empate = 0;
            while (vf)
            {
                n1 = Convert.ToInt32(aleatorio.Next(0, 8));
                vf = !service.jogar(n1, "O");
                if (empate > 10)
                {
                    Console.WriteLine("empate");
                    vencedor = false;
                    break;
                }
                empate++;

            }
            if (service.venc("O"))
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"Robotron venceu");
                service.game();
                break;
            }

            if (cont == 5)
            {
                Console.WriteLine("empate");
                vencedor = false;
                break;
            }
            cont++;

            vf = true;
            vf2 = true;

        }

        break;


    case 2:






        break;
    default:

        break;
}