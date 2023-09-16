// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int [] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(101, 1000);
    }

}



int[] ArrayOfNumbers(int size)
{ 
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = InputNum($"Введите цифру {i} из массива: ");
    }
    return array;
}

void PrintArray(int[] newArray)
{   Console.WriteLine("Ваш массив:");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i]+" ");
    }
}

int Chet(int[] newArray)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i]%2 == 0)
        count++;
    } 
    Console.WriteLine($"Количество четных чисел {count}");

    return count;
}

int size = InputNum("Введите размер массива: ");
int[] newArray = new int[size];

FillArray(newArray);
Console.WriteLine(" ");
PrintArray(newArray);
Console.WriteLine(" ");

Chet(newArray);