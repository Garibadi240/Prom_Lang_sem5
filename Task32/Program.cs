Console.Clear();

//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int number = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");

int[] array = GetArray(number);
Console.WriteLine(String.Join(" ", array));

int count =  NumbersEven(array);


Console.WriteLine($"Количество четных чисел в array[]: {count}");





int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber>0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int NumbersEven(int[] arr){
    int count = 0;
    foreach (var el in arr)
    {
        if (el % 2 == 0) count ++;
    }
    return count;
}