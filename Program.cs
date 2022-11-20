// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// 1 способ через функцию. Нам говорят, что самим искать материал тоже надо - я нашел функцию для решения этой задачи

// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень");
// int B = Convert.ToInt32(Console.ReadLine());

// int stepen = B;
// Console.WriteLine($"{A}^{B}=" + Math.Pow(A, stepen));

// 2 вариант, по поставленной задаче, через цикл

// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите степень");
// int B = Convert.ToInt32(Console.ReadLine());
// int num = 1;
// while (B!=0)
// {
//     num = num*A;
//     B--;
    
// }
// Console.WriteLine(num);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// int num = 0;
// if (A<10)
// {
//     Console.WriteLine(A);
// }
//     if (A<100)
//     {
//         num = A - (A - A%10) + A%10;
//         Console.WriteLine(num);
//     }
//         if (A>1000)
//         {
//         num = (A%100 - A%10)/10 + (A - (A - A%10) + A%10);
//         Console.WriteLine(num);
//         }
//     ???

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
    
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
        Console.WriteLine(col[position]);
        position++;
    }

int[] array = new int[2];
FillArray(array);
PrintArray(array);