
int value = 123474321;
string str = value.ToString();
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
Console.Write(true);
else
Console.Write(false);

