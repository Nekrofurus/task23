// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
Console.WriteLine("Введите количество элементов таблици кубов");
int number = Convert.ToInt32(Console.ReadLine());
var i = 1;
    for(i = 1; i < number; i++)
    {
        int x = i;
        int cubeTabl = x * x * x;
        Console.Write($"{cubeTabl} ,");
    }

