using System;

class Program
{   
    //O PROGRAMA FOI ENVOLVIDO EM UM LAÇO, QUE ENQUANTO FOR 'TRUE' CONTINUARÁ RODANDO, ATÉ QUE SEJA INTERROMPIDO PELO USUÁRIO. 
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("**        CALCULADORA MEGA ULTRA 2.0         **");
            Console.WriteLine("***********************************************");
            Console.WriteLine("**   Seja bem vindos amigos do ACELERA.NET   **");
            Console.WriteLine("***********************************************");
            Console.WriteLine("");
            Console.WriteLine("Escolha o cálculo que deseja:");
            Console.WriteLine("");
            Console.WriteLine("1 - CALCULAR MÉDIA DE NOTAS");
            Console.WriteLine("2 - CALCULAR IMC");
            Console.WriteLine("");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    calculaMedia();
                    break; // APRENDI QUE SEMPRE SE USA BREAK NO FINAL DO CASE 
                case 2:
                    calculaIMC();
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente digitando os números 1 ou 2"); // TRATAMENTO DE ERRO
                    break;
            }

            Console.Write("Deseja fazer outro cálculo? (S/N): ");
            char calcula = Convert.ToChar(Console.ReadLine());

            if (calcula != 'S' && calcula != 's') //TRATANDO MAIUSCULO E MINUSCULA
            {
                Console.WriteLine("Obrigado por usar a CALCULADORA MEGA ULTRA 2.0. Até mais!");
                break;
            }
        }
    }

    // ********************** CALCULADORA DE MÉDIA **********************
    static void calculaMedia()
    {
        double[] notas = new double[3];
        Console.WriteLine("Digite a primeira nota:");
        notas[0] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        notas[1] = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota:");
        notas[2] = Convert.ToDouble(Console.ReadLine());

        double media = (notas[0] + notas[1] + notas[2]) / 3;

        Console.WriteLine("O aluno " + verificaAprovacao(media)); 

        Console.WriteLine("Média: " + media.ToString("F2")); //TRATAMENTO PARA MOSTRAR 2 CASAS DEPOIS DA VIRGULA 
    }

    static string verificaAprovacao(double media)
    {
        if (media < 5)
            return "SE LASCOU, ESTA REPROVADO !";
        else if (media >= 5 && media < 7)
            return "EM RECUPERAÇÃO !";
        else
            return "ESTA APROVADO. PARABÉNS !";
    }

    // ********************** CALCULADORA DE IMC **********************
    static void calculaIMC()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura em metros e utilize: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double IMC = peso / (altura * altura);

        Console.WriteLine("");
        Console.WriteLine("O IMC de " + nome + " é: " + IMC.ToString("F2"));
        Console.WriteLine("Classificação: " + classificaIMC(IMC)); //RECEBE O VALOR DO IMC, PROCESSA ESSE VALOR E RETORNA INDICANDO A CLASSIFICAÇÃO
    }

    static string classificaIMC(double IMC)
    {
        if (IMC < 18.5)
            return "MAGREZA";
        else if (IMC >= 18.5 && IMC <= 24.9)
            return "NORMAL";
        else if (IMC >= 25.0 && IMC <= 29.9)
            return "SOBREPESO";
        else if (IMC >= 30.0 && IMC <= 39.9)
            return "OBESIDADE";
        else
            return "OBESIDADE GRAVE";
    }


}