// 74.Найти сумму цифр числа.
int Loop(int n)
{
    if (n > 10)
    {
        return (n % 10) + Loop(n / 10);
    }
    else
    {
        return n;
    }
}
Console.WriteLine(Loop(8888));