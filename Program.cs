
// //Exemplo 1
// int i = 0;
// while (i < 30)
// {
//     i += 1;
//     Console.WriteLine(i);
// }

// //Exercicio 1 - Calcular a tabuada do do 2 ao 20;

// int tabuada = 0;
// while (tabuada <= 19)
// {
//     tabuada += 1;
//     Console.WriteLine($"2 x {tabuada} = {2 * tabuada}");
// }

// //Exercicio 2 - Validador de dados, usuário precisa digitar entre 1 e 10, e indique opção errada.
// int digito = 0;

// Console.WriteLine("Digite um número entre 1 e 10: ");
// digito = int.Parse(Console.ReadLine()); 

// while (digito < 1 || digito > 10)
// {
//     Console.WriteLine("Numero errado, digite um numero entre 1 e 10: ");
//     digito = int.Parse(Console.ReadLine()); 
// }
// Console.WriteLine("Você digitou: " + digito);


//Exerciocio 3 - Validador completa 

// // Vai dar erro 
// int num = 0;

// Console.WriteLine("Digite um numero: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine("O numero digitado foi " + num);

// Como corrigir pra não quebrar o código:
// int num = 0;

using System.Xml;

Console.WriteLine("Digite um numero: ");
bool ehNumero = int.TryParse(Console.ReadLine(), out int num);

while (!ehNumero)
{
    Console.WriteLine("Valor inválido, Digite um numero: ");
    ehNumero = int.TryParse(Console.ReadLine(), out num);
}
Console.WriteLine("O numero digitado foi " + num);