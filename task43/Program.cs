// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double intersectionsOfLinesInY(double[] array, double ValueX)
{
    double Y = (array[1] * ValueX + array[0]);
    return Y;
}
double intersectionsOfLinesInX(double[] array)
{
    double X = ((array[2] - array[0]) / (array[1] - array[3]));
    return X;
}

double[] GetArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        if (i == 0)
        {
            Console.Write("Введите значение b1 (длина отрезка по оси OY, на который происходит сдвиг от начала координат): ");
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        else if (i == 1)
        {
            Console.Write("Введите значение k1 (угол наклона прямой): ");
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        else if (i == 2)
        {
            Console.Write("Введите значение b2: ");
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
        else if (i == 3)
        {
            Console.Write("Введите значение k2: ");
            arr[i] = Convert.ToDouble(Console.ReadLine());
        }
    }
    return arr;
}

double[] array = GetArray(4);
double valueX = intersectionsOfLinesInX(array);
double valueY = intersectionsOfLinesInY(array, valueX);
Console.WriteLine($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]} -> ({valueX}; {valueY})");


