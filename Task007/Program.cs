// //Напишите программу, которая принимает на вход трехзначное число и выводит последнюю цифру данного числа
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// int Z = n%10;
// Console.WriteLine(Z);

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int amount = number.Length;

if(amount != 3)
{
    Console.WriteLine("Введите ТРЕХзначное число!");
}
else    
{
    Console.WriteLine(number.Substring(amount-1));
}