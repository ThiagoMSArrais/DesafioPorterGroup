using DesafioPorterGroup.Console;


Console.WriteLine(Desafios.ObterNumeroPorExtenso(123123));

int[] numeros = new int[10] { 1, 2, 3, 4 ,5, 6, 7, 8, 9, 10 };

Console.WriteLine($"Resultado da somas dos números [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] = {Desafios.SomarValores(numeros)}");

Console.WriteLine($"expressão 2 + 3 * 5 = {Desafios.CalcularExpressaoMatematica("2+3*5")}");