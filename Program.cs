
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
*/

do {
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Tabuada");
    Console.WriteLine("2 - Input Validador");
    Console.WriteLine("3 - Fatorial");
    Console.WriteLine("4 - Sair");
    int opcao = int.Parse(Console.ReadLine());  

}

    
//     if (opcao == 1)
//     {
//         // Chamar função tabuada
//     }
//     else if (opcao == 2)
//     {
//         // Chamar função validador de dados
//     }
//     else if (opcao == 3)
//     {
//         // Chamar função fatorial
//     }
//     else if (opcao == 4)
//     {
//         Console.WriteLine("Saindo...");
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Opção inválida, tente novamente.");
//     }
// }


    // switch (opcao)
    // {
    //     case 1:
    //         // Chamar função tabuada
    //         break;
    //     case 2:
    //         // Chamar função validador de dados
    //         break;
    //     case 3:
    //         // Chamar função fatorial
    //         break;
    //     case 4:
    //         Console.WriteLine("Saindo...");
    //         break;
    //     default:
    //         Console.WriteLine("Opção inválida, tente novamente.");
    //         break;
    // }
