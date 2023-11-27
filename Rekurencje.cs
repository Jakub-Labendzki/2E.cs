//Suma pierwszych 10

int suma1 = 0;
for (int i = 0; i < 10; i++)
{
    suma1 += i;
}
Console.WriteLine(suma1);

int reku(int n)
{
    if (n == 0) return 0;
    return reku(n - 1) + n;
}
Console.WriteLine(reku(9));


//Suma przystych

int suma2 = 0;
for (int i = 10; i < 100; i += 2)
{
    suma2 += i;
}
Console.WriteLine(suma2);

int requ(int n)
{
    if (n < 10) return 0;
    return requ(n - 2) + n;
}
Console.WriteLine(requ(98));
