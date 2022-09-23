// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int tempNumber = number;
int reversedNumber = 0;

if (number >= 10000 && number <= 99999)
{
    while(tempNumber > 0)
    {
        int digit = tempNumber % 10;
        reversedNumber = reversedNumber * 10 + digit;
        tempNumber = tempNumber / 10;
    }
    Console.WriteLine($"Зеркальное число - {reversedNumber}");
    if (reversedNumber == number)
    {
        Console.WriteLine("Введенное число является палиндромом.");
    }
    else Console.WriteLine("Введенное число не является палиндромом.");
}
else
{
    Console.WriteLine("Введенное число не является 5-ти значным. Введите пятизначное число:");
}
