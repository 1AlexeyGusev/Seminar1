// // Напишите программу, которая на входе принимает число N, а потом выводит целые числа из промежутка от -N до N
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
// int num = n*(-1);
// if(n > 0)
// {
//     while(num <= n)
//     {
//         Console.Write($"{num};");
//         num++;
//     }
// }

// else
// {
//     while(num >= n)
//     {
//         Console.Write($"{num};");
//         num--;
//     }
// }
//------------------------------------------------------------------


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Math.Abs(a);
int i = Math.Abs(a) * (-1);
do
{
    Console.Write($"{i}, ");
    i++;
}
    while(i <= Math.Abs(a));

