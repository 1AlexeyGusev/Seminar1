//Напишите программу, которая принимает на вход трехзначное число и выводит последнюю цифру данного числа
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int Z = n%10;
Console.WriteLine(Z);