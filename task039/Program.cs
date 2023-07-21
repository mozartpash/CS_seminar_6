// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();
int[] array = GetArray(10,0,15);
Console.Write(String.Join(" ", array));

ReversArray1(array);
Console.WriteLine();
Console.Write(String.Join(" ", array));// Join позволяет печатать массивы

int[] reversArray = ReversArray2(array);//Второй способ
Console.WriteLine();
Console.Write(String.Join(" ", reversArray));//Второй способ

int [] GetArray(int size, int min, int max)
{
    int[]res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min,max);
    }
    return res;
}

void ReversArray1(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array[i];//Перезаписываем
        array[i] = array[array.Length - 1 - i];//Меняем местами перевенные в массиве, Отнимаем от последнего элнмента i
        array[array.Length - 1 - i] = temp;//Перезаписываем
    }
}

int[] ReversArray2(int[]arr)//Второй вариант решения
{
    int[] revers = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        revers[i] = arr[arr.Length - 1 -i];
    }
    return revers;
}




