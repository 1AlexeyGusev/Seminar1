// int a = 25;
// int b = 6;
// if(a == b * b)
// {
//     Console.WriteLine("Верно");
// }
// else
// {
//     Console.WriteLine("Неверно");
// }

Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

bool c = a == b * b;
Console.WriteLine($"Число {a} является квадратом числа {b} - {c}");