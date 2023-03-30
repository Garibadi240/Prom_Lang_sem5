Console.Clear();

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int number = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");

int[] array = GetArray(number);
Console.WriteLine(String.Join(" ", array));

int sumOdd =  SumOddElements(array);

Console.WriteLine($"Сумма нечетных чисел в array[]: {sumOdd}");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber>0) return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 10);
    }
    return res;
}

int SumOddElements(int[] arr){
    int sumOdd = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sumOdd = sumOdd +arr[i];
    }
    return sumOdd;
}