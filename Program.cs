// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
Console.WriteLine("Введите количество элементов таблици кубов");
int number = Convert.ToInt32(Console.ReadLine());
var i = 1;
int cube = Cube(number);
int Cube(int num)
{
    for(i = 1; i < num; i++)
    {
        int cubeTabl = i * i * i;
        Console.Write($"{cubeTabl} ,");
    }
return num*num*num;
}
Console.WriteLine(cube);
