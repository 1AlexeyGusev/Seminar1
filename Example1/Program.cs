Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int str = number * number;

//Вывод построчно
Console.Write("Квадрат числа: ");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(str);


//Вывод с использованием символа $
Console.WriteLine($"Квадарт числа {number} равен = {str}");


//Вывод с обращением к переменной
Console.WriteLine("Квадарт числа {0} равен = {1}", number, str);


//Использование библиотеки Math
int sqr = Convert.ToInt32(Console.ReadLine());
double sqr_2 = Math.Pow(sqr,2);
Console.WriteLine("Квадарт числа {0} равен = {1}", sqr, sqr_2);