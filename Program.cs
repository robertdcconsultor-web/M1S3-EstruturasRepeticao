
/*
Exemplo 1
*/
// int i = 0;
// while (i < 30)
// {
//     i += 1;
//     Console.WriteLine(i);
// }

/*
Exercicio 1 - Calcular a tabuada do do 2 ao 20;
*/
// int tabuada = 0;
// while (tabuada <= 19)
// {
//     tabuada += 1;
//     Console.WriteLine($"2 x {tabuada} = {2 * tabuada}");
// }

/*
Exercicio 2 - Validador de dados, usuário precisa digitar entre 1 e 10, e indique opção errada.
*/
//  int digito = 0;

// Console.WriteLine("Digite um número entre 1 e 10: ");
// digito = int.Parse(Console.ReadLine()); 

// while (digito < 1 || digito > 10)
// {
//     Console.WriteLine("Numero errado, digite um numero entre 1 e 10: ");
//     digito = int.Parse(Console.ReadLine()); 
// }
// Console.WriteLine("Você digitou: " + digito);


/*
Exerciocio 3 - Validador completa 
*/

// // Vai dar erro 
// int num = 0;

// Console.WriteLine("Digite um numero: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine("O numero digitado foi " + num);

// // Como corrigir pra não quebrar o código:
// // int num = 0;

// using System.Xml;

// Console.WriteLine("Digite um numero: ");
// bool ehNumero = int.TryParse(Console.ReadLine(), out int num);

// while (!ehNumero)
// {
//     Console.WriteLine("Valor inválido, Digite um numero: ");
//     ehNumero = int.TryParse(Console.ReadLine(), out num);
// }
// Console.WriteLine("O numero digitado foi " + num);

/*
Entendendo o do while - O do while executa o bloco de código pelo menos uma vez, mesmo que a condição seja falsa.
*/
// int num = 0;

// while (num < 1 || num > 10)
// {
//     Console.WriteLine("Digite um numero entre 1 e 10: ");
//     num = int.Parse(Console.ReadLine());
// }
// do
// {
//     Console.WriteLine("Digite um numero entre 1 e 10: ");
//     num = int.Parse(Console.ReadLine());
// } while (num < 1 || num > 10);
// Console.WriteLine("Você digitou: " + num);

/*
Entendendo o for - O for é uma estrutura de repetição que possui três partes: inicialização, condição e incremento. Ele é utilizado quando sabemos o número de vezes que queremos repetir um bloco de código.
for ele tem o objetivo de interar e já tem estrutura enchuta
*/

// for (int i = 0; i < 30; i++)
// {
//     Console.WriteLine(i);
// }

// // Exemplo tabuada;
// for (int i = 1; i <= 100; i++)
// {
//     Console.WriteLine($"2 x {i} = {2 * i}");
// }


/*
Exercicio 4 - Fatorial de um número - O fatorial de um número é o produto de todos os números inteiros positivos menores ou iguais a ele. Por exemplo, o fatorial de 5 é 5 x 4 x 3 x 2 x 1 = 120.
Utilizar estrutura de repetição;
multiplicar antessessores positivos.
*/

// int fatorial = 1;
// Console.WriteLine("Digite um numero para calcular o fatorial: ");   

// int number = int.Parse(Console.ReadLine());
// for (int i = 1; i <= number; i++)
// {
//     fatorial *= i;
// }
// Console.WriteLine($"O fatorial de {number} é {fatorial}");

/*
Exemplo 2
*/
// fatorial com "for"

// Console.WriteLine("Informe um número inteiro para ver seu fatorial: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// int fatorial = numero;
// for (int i = 1; i < numero; i++)
// {
//     fatorial *= i;  
// }
// Console.WriteLine($"O resultado fatorial de {numero} é igual a {fatorial}");


/*
Criar menu para "desafio" 1
Crie um menu de aplicação interativo e englobe os exercicios anteriores para selecionar qual sera executado. 
Os itens do menu devem ser :
1 - Tabuada                          3 Fatorial 
2 - input validator             4 sair (se selecionado sair do programa)

*/

string opcaoMenu;

do
{
    // Mostra as opções na tela
    Console.WriteLine("\n--- MENU DE EXERCÍCIOS ---");
    Console.WriteLine("1 - Tabuada");
    Console.WriteLine("2 - Input Validator");
    Console.WriteLine("3 - Fatorial");
    Console.WriteLine("4 - Sair");
    Console.Write("Escolha uma opção: ");

    // Lê o que o usuário digitou ;     
    opcaoMenu = Console.ReadLine();
    
    // int opcaoMenu = int.TryParse(Console.ReadLine());

    // Direciona para o código correspondente
    switch (opcaoMenu)
    {
        case "1":
            ExecutarTabuada();
            break;
        case "2":
            ExecutarInputValidator();
            break;
        case "3":
            ExecutarFatorial();
            break;
        case "4":
            Console.WriteLine("Saindo do programa... Até logo!");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente com um número de 1 a 4.");
            break;
    }

} while (opcaoMenu != "4");

    // --- Espaço reservado para os exercícios ---

    static void ExecutarTabuada()
    {
        Console.WriteLine("\n--- MÓDULO: TABUADA ---");
        Console.Write("Digite um número para ver a sua tabuada: ");
        
        // Lê o que o usuário digitou e converte de texto (string) para número inteiro (int)
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabuada do {numero}:");

        // O laço de repetição (for)
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
        
        Console.WriteLine("-----------------------\n");
    }

static void ExecutarInputValidator()
    {
        Console.WriteLine("\n--- MÓDULO: INPUT VALIDATOR ---");
        
        int numeroValido = 0;
        bool entradaCorreta = false;

        // O laço vai continuar rodando ENQUANTO a entrada não for correta
        while (!entradaCorreta)
        {
            Console.Write("Digite um número entre 1 e 100: ");
            string textoDigitado = Console.ReadLine();

            // Tenta converter o texto para número de forma segura
            if (int.TryParse(textoDigitado, out numeroValido))
            {
                // Se for número, verifica se está dentro da regra (entre 1 e 100)
                if (numeroValido >= 1 && numeroValido <= 100)
                {
                    Console.WriteLine($"\nSucesso! Você digitou o número válido: {numeroValido}");
                    entradaCorreta = true; // Isso quebra o laço while
                }
                else
                {
                    Console.WriteLine("Erro: O número precisa estar exatamente entre 1 e 100. Tente de novo.\n");
                }
            }
            else
            {
                // Se o usuário digitou letras, símbolos ou deixou em branco
                Console.WriteLine("Erro: Entrada inválida. Por favor, digite apenas números.\n");
            }
        }
        
        Console.WriteLine("-------------------------------\n");
    }

static void ExecutarFatorial()
    {
        Console.WriteLine("\n--- MÓDULO: FATORIAL ---");
        Console.Write("Digite um número inteiro positivo: ");
        
        // Usamos o TryParse para garantir que não vai quebrar se digitar letras
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
        {
            // Usamos 'long' em vez de 'int' porque fatoriais crescem absurdamente rápido e não cabem em um 'int' normal
            long resultado = 1;

            // O laço começa no número digitado e vai diminuindo até chegar em 1
            for (int i = numero; i > 1; i--)
            {
                // Isso é o mesmo que: resultado = resultado * i;
                resultado *= i; 
            }

            Console.WriteLine($"\nO fatorial de {numero} é {resultado}!");
        }
        else
        {
            Console.WriteLine("\nErro: Entrada inválida. Por favor, digite apenas números inteiros e positivos.");
        }
        
        Console.WriteLine("------------------------\n");
    }
