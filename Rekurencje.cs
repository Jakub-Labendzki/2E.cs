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

-----------------------------------------------------

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

----------------------------------------------------
//Suma dla liczb 3,6,9,12
int n = 6;
int suma3 = 0;
for (int i = 0; i < n; i++)
{
    suma3 += 3 * i + 3;
}
Console.WriteLine(suma3);

int reku(int n)
{
    if (n == 1) return 3;
    return reku(n - 1) + 3 * n;
}
Console.WriteLine(reku(6));

-----------------------------------------------------
//Suma dla liczb 12,23,34,45
int n = 3;
int suma4 = 0;
for (int i = 0; i < n; i++)
{
    suma4 = suma4 + 1 + (i+1) * 11;
}
Console.WriteLine(suma4);

int reku(int n)
{
    if (n == 1) return 12;
    return reku(n - 1) + 11;
}
int suma = 0;
for (int i = 0;i < 3;i++)
{
    suma += reku(i + 1);
    Console.WriteLine(suma);
}
-----------------------------------------------------
