/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int sum(int number)
{
    int summaChisel = 0;
    if (num >1&&num<9)
    {
        summaChisel = num;
        System.Console.WriteLine(summaChisel);    
    }
    if (num >= 10 && num <= 99)
    {
        summaChisel = (number / 10) + (number % 10);
        System.Console.WriteLine(summaChisel);
    }
    if (num >= 100 && num <= 999)
    {
        summaChisel = (number / 100) + ((number / 10) % 10) + (number % 10);
        System.Console.WriteLine(summaChisel);
    }
    if (num >= 1000 && num <= 9999)
    {
        summaChisel = (number / 1000) + ((number / 100) % 10) + ((number / 10)%10)+(number%10);
        System.Console.WriteLine(summaChisel);
    }
    if (num >= 10000 && num <= 99999)
    {
        summaChisel = (number / 10000) + ((number / 1000) % 10) + ((number / 100)%10)+((number/10)%10)+(number%10);
        System.Console.WriteLine(summaChisel);
    }
    return summaChisel;
}
sum(num);
