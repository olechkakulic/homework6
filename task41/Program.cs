// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int GetPositiveElementsOfArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива с индексом {i}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int PromptNumber(String text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}

int size = PromptNumber("Введите количество элементов массив: ");
int[] array = GetArray(size);
int positiveNumber = GetPositiveElementsOfArray(array);
Console.WriteLine($"{String.Join(" ", array)} -> {positiveNumber}");


