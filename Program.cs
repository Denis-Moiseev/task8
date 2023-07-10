Console.Write("Введите число: ");
double lengs = double.Parse(Console.ReadLine());
double num = lengs - (lengs % 1);
int variable = 0;
Console.Write($"Все чётные числа от 1 до { lengs }: ");
while (variable < num - 1)
{
    variable = variable + 2;
    Console.Write($"{ variable } ");
}