System.Console.WriteLine("введие число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введие число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int count = N - M;
int res = 0;
for (int i = 0; i <= count; i++)
{
    if (M > 0)
    {
        res += M;
    }
    M++;
}
System.Console.WriteLine(res);