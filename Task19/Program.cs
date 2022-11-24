Console.WriteLine("Введите любое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
int firstDigit = number / 10000;
int secondDigit = (number / 1000) % 10;
int fourthDigit = (number % 100) / 10;
int fifthDigit = number % 10;
if (firstDigit == fifthDigit && secondDigit == fourthDigit) 
{
    Console.WriteLine("Да");
}
else 
Console.WriteLine("Нет");
}
else
Console.WriteLine("Вы ввели некорректное число");