/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

System.Console.Write("Введите количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);

void fillArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        if (i == 1||i==4||i==5)
        {
            System.Console.Write("Введите " + i + "-ый элемент массива: ");
            massiv[i] = int.Parse(Console.ReadLine()!);
            continue;
        }
        if (i == 3)
        {
            System.Console.Write("Введите " + i + "-ий элемент массива: ");
            massiv[i] = int.Parse(Console.ReadLine()!);
            continue;
        }
        
        System.Console.Write("Введите " + i + "-ой элемент массива: ");
        massiv[i] = int.Parse(Console.ReadLine()!);
    }
}

void printArray(int []massiv){
    for(int i=0;i<massiv.Length;i++){
        if(i==0){
            System.Console.Write("["+massiv[i]+",");
            continue;
        }
        if(i==massiv.Length-1){
            System.Console.Write(" "+massiv[i]+"]");
            continue;
        }
        System.Console.Write(" "+massiv[i]+",");
    }
}
int[] array =new int[count];
fillArray(array);
printArray(array);
