/*
Задача 1: Пользователь вводит с клавиатуры 
M чисел. Посчитайте, сколько чисел больше 0 
ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

int[] GenerateArray(int len)//зачем необходимо вводить длину массива
{
    int[] array = new int[len];

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите число {i + 1}=> ");//для считывания массива метод берет число на 1 строку ниже
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int PositiveNumber(int[] number)
{
    int pos = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0) pos++;
    }
    return pos;
}
// Не использовала фукцию печати массива, т.к. в задании это не прописано
// void PrintArray(int[] array)///
// {
//     Console.Write($"[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}");
//         if ((i + 1) < array.Length)
//         {
//             Console.Write($", ");
//         }
//     }
//     Console.Write($"]");
// }

int num = InputInt("Введите количество чисел: ");
int[] array = GenerateArray(num);
System.Console.WriteLine();
int posCount = PositiveNumber(array);
System.Console.WriteLine($"Положительных чисел: {posCount}");
