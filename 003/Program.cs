
double AvN(int A = 2, int N = 3)
{
    return Math.Pow(A,N);
}

double Factorial(int N)
{
    double Fact = 1; 
    if(N==0 || N==1)
    return 1;
    else
    for(int i = 1; i <= N; i++) 
    Fact = Fact * i;
return Fact;
}

double SumNum(int N)
{
    int sum = 0;
   while(N > 0)
   {
    int tail = N % 10;
    N = N / 10;
    sum = sum + tail;
   }
return sum;
}

double Sum2Num(int N, int A)
{
    return N + A;
}

bool ProstNum(int N)
{
    int m = 0;
    for(int i = 2; i < 10; i++)
        if( N != i)
        {
            if(N % i == 0) m++;
        }
    if(m == 0)
    return true;
    else
    return false;
}

bool ChetNum(int N)
{
    if(N % 2 == 0)
    return true;
    else
    return false;
}

bool Palindrom(int N)
{
    string str = N.ToString();
    char [] ar = str.ToCharArray();
    int j = 0;
    int a = ar.Length/2;
    
for(int i=0; i<a; i++)
{
    int n = ar[i];
    int m =ar[ar.Length-1-i];
	if (m==n)j++;
}
if (j==a)
return true;
else
return false;
}




Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"Вычисление числа {A} в степени {N}: {AvN(A,N)}");
Console.WriteLine($"Вычисление факториала числа {N}: {Factorial(N)}");
Console.WriteLine($"Cумма цифр произвольного целого числа {N}: {SumNum(N)}");
Console.WriteLine($"Cумма двух целых чисел: {Sum2Num(A,N)}");
Console.WriteLine($"Является ли число простым: {ProstNum(N)}");
Console.WriteLine($"Является ли число четным: {ChetNum(N)}");
Console.WriteLine($"Является ли число палиндромом: {Palindrom(N)}");