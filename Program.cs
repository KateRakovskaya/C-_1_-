//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Введите два числа: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (a < b){
//     max = b;
// }
// Console.Write($"Максимальное число: {max}");


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите три числа: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (b > a && b > c) max = b;
// else if (c > a && c > b) max = c;
// Console.Write($"Максимальное число: {max}");


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.

// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a%2 == 0) Console.Write("Четное");
// else Console.Write("Нечетное");

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++){
    if(i%2 == 0) Console.Write($"{i} ");
}