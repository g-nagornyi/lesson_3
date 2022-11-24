Console.Write("Введите любое число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void Table(int num)
{
    int count = 1;
    while (count > 0 && count <= num)
    {
        int square = count*count;
        Console.Write($"{count} --> ");
        Console.WriteLine(square);
        count++;
    }
}
if (n > 0)
    Table(n);
else Console.WriteLine("Число не является натуральным");
