﻿// Задача №2.  Напишите программу, которая на вход принимает два числа и выдает, какое число большее,
//             а какое меньшее. 
//
//  Пример: a=5; b=7 -> max=7
//          a=2; b=10 -> max=10
//          a=-9; b=-3 -> max=-3

Console.WriteLine("Введите число (Enter): ");
int namberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число (Enter): ");
int namberB = int.Parse(Console.ReadLine()!);


if (namberA > namberB)
{
  Console.WriteLine( "Наибольшее число = " + namberA + ", наименьшее число = " + namberB); 
}
if (namberA < namberB)
{
    Console.WriteLine( "Наибольшее число = " + namberB + ", наименьшее число = " + namberA);
}