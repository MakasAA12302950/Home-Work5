/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


double[] startArrayDouble = GetArrayDouble(4, 0, 999);
Console.WriteLine(String.Join(" ", startArrayDouble));
Console.WriteLine($"Разница = {GetDifference(startArrayDouble)}");

double[] GetArrayDouble(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    var randon = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = randon.Next(minValue, maxValue + 1) + randon.NextDouble(); //45 + 45.456854368
    }
    return res;
}

double GetDifference(double[] array)
{
    double min = array [0];
    double max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}