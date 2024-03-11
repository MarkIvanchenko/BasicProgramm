// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы. Пример вы найдете в конце презентации к семинару.


int[] Arr(int n)  // Создад массива размерностью n с заполнением случайными числами
{
    int[] array = new int[n]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void Rec (int [] arr, int i = 0) // Рекурсия на вывод массива в развароте
{
    if (i == arr.Length)
    { 
    return;
    }
    Rec(arr, i + 1);
    Console.Write(arr[i] + "\t");
}

void Print(int[] arr) // Вывод на печать заданного массива
{
    foreach (var item in arr)
    {
         Console.Write(item + "\t");
    }    
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = Arr(n);
Console.WriteLine();
Console.Write("Заданный массив: ");
Print(array);
Console.WriteLine();
Console.Write("Массив в развароте: ");
Rec(array);




// int[] FillArrayRandomly(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }

// void RecursiveArrayPrint (int [] arr, int index = 0)
// {
//     if (index == arr.Length)
//     { 
//     return;
//     }
//     RecursiveArrayPrint(arr, index + 1);
//     Console.Write($"{arr[index]} ");

// }

// void PrintArray(int[] arr)
// {
//     foreach (var item in arr)
//     {
//         Console.Write($"{item} ");
//     }    
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размерность массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int [] array = FillArrayRandomly(m);
// PrintArray(array);
// RecursiveArrayPrint(array);