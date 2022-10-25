
void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}


int[] CreateArray(int length, int minimum, int maximum)
{
    int[] array = new int [length];
    Random random = new Random();
    for(int i=0;i<array.Length;i++)
        array[i] = random.Next(minimum, maximum);
    return array;
}


int SumArray(int[] array)
{
    int sum = 0;
    foreach (int element in array)
        sum += element;
    return sum;
}


float ArrayAverage(int[] array) 
{
    return SumArray(array) / ((float)array.Length);
}


int MaxArray(int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    return max;       
}
int MinArray(int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    return min;
}

int CompArray(int[] array)
{
    int comp = 1;
    for(int i = 0; i < array.Length; i++)
    {
        comp = comp * array[i];
    }
    return comp;
}

bool TrueArray(int[] array, int num = 5)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i]==num)
        return true;
    return false;
}

int IndexArray(int[] array, int num = 5)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i]==num)
        return i;
    return -1;
}

int OtritArray(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) n++;
    return n;
}

int ElemArray(int[] array, int num = 5)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i]==num) n++;
    return n;
}

int ChetArray(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) n++;
    return n;
}

int PolozArray(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= 0) n++;
    return n;
}

int NechetArray(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 != 0) n++;
    return n;
}


Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите начальный элемент массива: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите последний элемент массива: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[] array = CreateArray(length, start, finish);
Console.Write("Сгенерированный массив: " );
PrintArray(array);
Console.WriteLine($"Сумма элементов массива: {SumArray(array)}");
Console.WriteLine($"Среднее арифметическое элеметов массива: {ArrayAverage(array)}");
Console.WriteLine($"Минимальное значение в массиве: {MinArray(array)}");
Console.WriteLine($"Максимальное значение в массиве: {MaxArray(array)}");
Console.WriteLine($"Произведения элементов массива: {CompArray(array)}");
Console.WriteLine($"Наличие элемента (число 5) в массиве: {TrueArray(array)}");
Console.WriteLine($"Поиск индекса (число 5) в массиве: {IndexArray(array)}");
Console.WriteLine($"Подсчёт количества отрицательных элементов массива: {OtritArray(array)}");
Console.WriteLine($"Подсчёт количества вхождений элемента в массив: {ElemArray(array)}");
Console.WriteLine($"Подсчёт количества чётных элементов в массив: {ChetArray(array)}");
Console.WriteLine($"Подсчёт количества положительных элементов в массиве: {PolozArray(array)}");
Console.WriteLine($"Подсчёт количества нечётных элементов в массиве: {NechetArray(array)}");