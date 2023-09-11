// Zad 1 Euklides odejmowanie
int Eulikidesodej(int a, int b)
{
    while (a != b)
    {
        if (a > b)
            a = a - b;
        if (b > a)
            b = b - a;
    }
    return a;
}

int x, y;
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
Console.WriteLine(Eulikidesodej(x, y));

// Zad 2 Eulikides modulo

int Eulikidesmodulo(int a, int b)
{
    int pom;
    while (b > 0)
    {
        pom = b;
        b = a % b;
        a = pom;
    }
    return a;
}

int x, y;
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
Console.WriteLine(Eulikidesmodulo(x, y));

// Zad 3 Algorytm sortowania bąbelkowego

Random r = new Random();
int n = 8;
int temp;
int[] T = new int[n];
for (int i = 0; i < n; i++)
{
    T[i] = r.Next(1, 10);
    Console.WriteLine(T[i] + " ");
}
for (int i = n - 1; i > 0; i--)
{
    for (int j = 0; j < n; j++)
    {
        if (T[i] > T[j + 1])
        {
            temp = T[j];
            T[j] = T[j + 1];
            T[j + 1] = temp;
        }
    }
}
Console.WriteLine("\n\n");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(T[i] + " ");

}

// Zad 4 liczby zaprzyjaźnione
int sumaDzielnikowWlasciwych(int n)
{
    int suma = 0;
    for (int i = 1; i < n / 2; i++)
        if (n % i == 0)
            suma += i;
    return suma;
}
int pom;
for (int i = 1; i <= 10000; i++)
{
    pom = sumaDzielnikowWlasciwych(i);
    if (i == sumaDzielnikowWlasciwych(pom) && i != pom)
    {
        Console.WriteLine(i + " " + pom);
    }
}

// Macierz
