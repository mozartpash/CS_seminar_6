// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string res1=Convert.ToString(number,2); - переводит в двоичное число
//-----------------------------------------Один вариант с записью в строку-----------------------------------
// string result = "";
// while (number > 0)
// {
//     result = (number % 2) + result;
//     number = number / 2;
// }
// Console.Write(int.Parse(result));
//-----------------------------------------------------------------------------------------------------------

int GetNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

int CountDiv(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 2;
        count++;
    }
    return count;
}

void BinaryNumber(int num)
{
    int b = 0;
    int i = 0;
    while (a > 0)
    {
        b = a % 2;
        a = a / 2;
        binary[binary.Length - 1 - i] = b;
        i++;
    }
    Console.Write(String.Join("", binary));
}

int a = GetNumber("Введите число: ");

int countDivide = CountDiv(a);

int[] binary = new int[countDivide];

BinaryNumber(a);


// --------------------------------------------------------------

//Надо доделать