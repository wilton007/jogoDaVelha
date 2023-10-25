using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogoDaVelha
{
    public class Service
    {
        string[,] jogo = { { "0", "1", "2" }, { "3", "4", "5" }, { "6", "7", "8" } };

        public void game()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(jogo[i, j] + " |");

                }
                Console.WriteLine();
            }
        }

        private bool verificar(string n1)
        {
            bool vf = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (jogo[i, j] == n1)
                    {
                        vf = true;
                        i = 3;
                        break;
                    }
                    else
                    {
                        vf = false;
                    }

                }

            }
            return vf;
        }


        public bool jogar(int numero, string jogador)
        {

            string n1 = Convert.ToString(numero);
            if (verificar(n1))
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (jogo[i, j] == n1)
                        {
                            jogo[i, j] = jogador;
                            i = 3;
                            break;
                        }
                    }
                }
                return true;

            }
            else
            {
                return false;

            }
        }

        public bool venc(string jogador)
        {
            if (jogo[0, 0] == jogador && jogo[0, 1] == jogador && jogo[0, 2] == jogador &&
                jogo[2, 0] == jogador && jogo[2, 1] == jogador && jogo[2, 2] == jogador &&
                jogo[0, 0] == jogador && jogo[1, 0] == jogador && jogo[2, 0] == jogador &&
                jogo[0, 1] == jogador && jogo[1, 1] == jogador && jogo[2, 1] == jogador &&
                jogo[0, 1] == jogador && jogo[1, 1] == jogador && jogo[2, 1] == jogador &&
                jogo[0, 2] == jogador && jogo[1, 2] == jogador && jogo[2, 2] == jogador &&
                jogo[0, 0] == jogador && jogo[1, 1] == jogador && jogo[2, 2] == jogador &&
                jogo[0, 2] == jogador && jogo[1, 1] == jogador && jogo[2, 0] == jogador &&
                jogo[1, 0] == jogador && jogo[1, 1] == jogador && jogo[1, 2] == jogador)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }

}
