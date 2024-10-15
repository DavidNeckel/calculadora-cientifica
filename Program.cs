using System;

class CalculadoraCientifica
{
    static void Main(string[] args)
    {
        bool continuar = true;

        Console.WriteLine("=== Calculadora Científica ===");

        while (continuar)
        {
            try
            {
                Console.WriteLine("\nEscolha a operação que deseja realizar:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potência");
                Console.WriteLine("6 - Raiz Quadrada");
                Console.WriteLine("7 - Seno");
                Console.WriteLine("8 - Cosseno");
                Console.WriteLine("9 - Tangente");
                Console.WriteLine("10 - Logaritmo");
                Console.WriteLine("11 - Fatorial");
                Console.WriteLine("12 - Sair");

                Console.Write("\nDigite o número da operação: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 12)
                {
                    continuar = false;
                    Console.WriteLine("Encerrando a calculadora. Até logo!");
                    break;
                }

                double num1 = 0;
                double num2 = 0;

                if (opcao >= 1 && opcao <= 5)
                {
                    Console.Write("\nDigite o primeiro número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (opcao >= 6 && opcao <= 11)
                {
                    Console.Write("\nDigite o número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                }

                double resultado = 0;

                switch (opcao)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine($"Resultado da Adição: {resultado}");
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"Resultado da Subtração: {resultado}");
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"Resultado da Multiplicação: {resultado}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"Resultado da Divisão: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não permitida.");
                        }
                        break;
                    case 5:
                        resultado = Math.Pow(num1, num2);
                        Console.WriteLine($"Resultado de {num1} elevado a {num2}: {resultado}");
                        break;
                    case 6:
                        if (num1 >= 0)
                        {
                            resultado = Math.Sqrt(num1);
                            Console.WriteLine($"Raiz Quadrada de {num1}: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Raiz quadrada de número negativo não permitida.");
                        }
                        break;
                    case 7:
                        resultado = Math.Sin(num1 * (Math.PI / 180)); // Seno em graus
                        Console.WriteLine($"Seno de {num1} graus: {resultado}");
                        break;
                    case 8:
                        resultado = Math.Cos(num1 * (Math.PI / 180)); // Cosseno em graus
                        Console.WriteLine($"Cosseno de {num1} graus: {resultado}");
                        break;
                    case 9:
                        resultado = Math.Tan(num1 * (Math.PI / 180)); // Tangente em graus
                        Console.WriteLine($"Tangente de {num1} graus: {resultado}");
                        break;
                    case 10:
                        if (num1 > 0)
                        {
                            resultado = Math.Log10(num1);
                            Console.WriteLine($"Logaritmo base 10 de {num1}: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Logaritmo de número não positivo não permitido.");
                        }
                        break;
                    case 11:
                        if (num1 >= 0 && num1 == Math.Floor(num1))
                        {
                            resultado = Fatorial((int)num1);
                            Console.WriteLine($"Fatorial de {num1}: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Fatorial só é definido para números inteiros não negativos.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Digite um número válido.");
            }
        }
    }

    // Função para calcular o fatorial
    static double Fatorial(int numero)
    {
        if (numero == 0 || numero == 1)
        {
            return 1;
        }

        double resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
