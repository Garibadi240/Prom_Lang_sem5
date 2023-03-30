Console.Clear();

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int number = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");

double[] array = GetArray(number);
Console.WriteLine(String.Join(" ", array));

double difNumber = DifferenceNumber(array);

Console.WriteLine($"Разница между максимальным и минимальным значением в array[]: {difNumber}");



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

double[] GetArray(int size){
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
    }
    return res;
}

double DifferenceNumber(double[] arr){
double minNumber=1;
double maxNumber=0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i]>maxNumber) maxNumber=arr[i];
    if(arr[i]<minNumber) minNumber=arr[i];
}
return maxNumber-minNumber;
}
