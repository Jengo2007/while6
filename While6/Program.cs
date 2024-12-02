// See https://aka.ms/new-console-template for more information
//
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine());
var factorial=1.0;
while (N > 0)
{
    factorial *= N;
    N -= 2;
}

Console.WriteLine(factorial);

