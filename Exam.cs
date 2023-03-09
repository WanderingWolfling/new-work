// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых Меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] arr, int count)
{
    Console.WriteLine("Результат:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

string[] FilterArray(string[] arr, int n)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < n; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[index] = arr[i];
            index++;
        }
    }

    return result;
}

string[] FillArray(int n)
{
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите элемент {i}: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void MyProgram(string[] args)
{
    Console.Write("Введите размер массива строк: ");
    int n = int.Parse(Console.ReadLine());

    string[] arr = FillArray(n);

    string[] result = FilterArray(arr, n);

    PrintArray(result, result.Length);
}

MyProgram(new string[] { });

// Ну ПРОСТИТЕ Я ЗАБЫЛ ПРО КОМИТЫ И ПИСАЛ ВСЕ НА ОДНОМ ПОРЫВЕ