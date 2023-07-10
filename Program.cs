Console.Write("Введите число: ");
double lengs = double.Parse(Console.ReadLine());
int variable = 2;
Console.Write($"Все чётные числа от 1 до { lengs }: ");
while (variable <= lengs)
{
    Console.Write($"{ variable } ");
    variable = variable + 2;
}