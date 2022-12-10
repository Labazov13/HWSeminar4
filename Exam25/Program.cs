/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
 число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

System.Console.Write("Введите число, которое будем возводить в степень: ");
int num = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число, являющееся степенью для числа " + num + " ");
int stepen = int.Parse(Console.ReadLine()!);

int VozvedenieVStepen(int a, int b)
{
    int result = 1;
    for (int i = 0; i <b; i++)
    {
        result *= a;
    }
    return result;
}
System.Console.WriteLine(VozvedenieVStepen(num, stepen));
