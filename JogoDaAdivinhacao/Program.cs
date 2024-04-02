using System.ComponentModel.Design;

namespace JogoDaAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tentei refatorar mas não conseguia quebrar o loop dai.
            int soma = 1000;
            string dificuldade = "";
            int resposta;
            Random rand = new Random();
            int aleatorio = rand.Next(0, 21);
            int tentativa = 1;
            Apresentacao();
            int df = EscolhaDeDificuldade();
            while (true)
            {
                int pf;
                Tentatica(out resposta, aleatorio, out pf);

                Console.Clear();

                if (df == 1)
                {
                    if (tentativa < 5)
                    {
                        Console.WriteLine("\nEssa é a tentativa número " + tentativa + " de 5.\n\n");
                        if (resposta == aleatorio)
                        {
                            Ganhar1(soma);
                            break;
                        }
                        if (resposta > aleatorio)
                        {
                            Console.WriteLine("O número aleatório é menor!!!");
                        }
                        else if (resposta < aleatorio)
                        {
                            Console.WriteLine("O número número aleatório é maior!!!");


                        }
                        tentativa++;
                        soma -= pf;
                    }
                    else
                    {
                        soma -= pf;
                        Console.WriteLine("VOCÊ PERDEU !!!!!!!!!!!!!!!!!!! :( \n Sua pontuação foi de " + soma);
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("\nTente novamente!!!");
                }

                if (df == 2)
                {
                    if (tentativa < 10)
                    {
                        Console.WriteLine("\nEssa é a tentativa número " + tentativa + " de 10.\n\n");
                        if (resposta == aleatorio)
                        {
                            Ganhar2(soma);
                            break;
                        }
                        else if (resposta > aleatorio)
                        {
                            Console.WriteLine("O número aleatório é menor!!!");
                        }
                        else if (resposta < aleatorio)
                        {
                            Console.WriteLine("O número número aleatório é maior!!!");


                        }
                        tentativa++;
                        soma -= pf;
                    }
                    else
                    {
                        soma -= pf;
                        Console.WriteLine("VOCÊ PERDEU !!!!!!!!!!!!!!!!!!! :( \n Sua pontuação foi de " + soma);
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("\nTente novamente!!!");
                }

                if (df == 3)
                {
                    Console.WriteLine("\nEssa é a tentativa número " + tentativa + " de 15.\n\n");
                    if (tentativa < 15)
                    {

                        if (resposta == aleatorio)
                        {
                            Ganhar3(soma);
                            break;
                        }
                        else if (resposta > aleatorio)
                        {
                            Console.WriteLine("O número aleatório é menor!!!");
                        }
                        else if (resposta < aleatorio)
                        {
                            Console.WriteLine("O número número aleatório é maior!!!");


                        }
                        tentativa++;
                        soma -= pf;
                    }
                    else
                    {
                        soma -= pf;
                        Console.WriteLine("VOCÊ PERDEU !!!!!!!!!!!!!!!!!!! :(\n Sua pontuação foi de: " + soma);
                        Console.ReadLine();
                        break;
                    }

                    Console.WriteLine("\nTente novamente!!!");
                }

















            }





















        }

        private static void Ganhar3(int soma)
        {
            Console.WriteLine("Parabéns!!! Você Ganhou!!! \n Sua pontuação foi de " + soma);
            Console.WriteLine("Aperte ENTER para sair:");
            Console.ReadLine();
        }

        private static void Ganhar2(int soma)
        {
            Console.WriteLine("Parabéns!!! Você Ganhou!!! \n Sua pontuação foi de " + soma);
            Console.WriteLine("Aperte ENTER para sair:");
            Console.ReadLine();
        }

        private static void Ganhar1(int soma)
        {
            Console.WriteLine("Parabéns!!! Você Ganhou!!!\n Sua pontuação foi de " + soma);
            Console.WriteLine("Aperte ENTER para sair:");
            Console.ReadLine();
        }

        private static void Tentatica(out int resposta, int aleatorio, out int pf)
        {
            Console.WriteLine("Digite sua tentativa:");
            resposta = Convert.ToInt32(Console.ReadLine());
            if (resposta > aleatorio)
            {
                pf = ((resposta - aleatorio) / 2);
            }
            else
            {
                pf = ((aleatorio-resposta)/2);
            }
        }

        private static int EscolhaDeDificuldade()
        {
            Console.WriteLine("Digite\n 1 para dificil:\n 2 para médio: \n 3 para fácil:");

            int df = Convert.ToInt32(Console.ReadLine());
            return df;
        }

        private static void Apresentacao()
        {
            Console.WriteLine("Bem-Vindo ao Jogo da Adivinhação:");
            Console.WriteLine("Tente adivinhar um número aleatório entre 1 e 20.");
            Console.WriteLine("---------------------------------");
        }
    }
}
