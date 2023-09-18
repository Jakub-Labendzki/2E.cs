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

// Zad 5 Tablice, Listy

Random r = new Random();
int n = 30;
int[] T = new int[n];
for (int i = 0; i < n; i++) T[i] = r.Next(100, 1000);
for (int i = 0; i < n; i++) Console.WriteLine(T[i] + " ");
Console.WriteLine("\n");
List<int> list = new List<int>();
/*ArrayList al = new ArrayList();*/
foreach (var t in T)
{
    if (t % 17 == 0) list.Add(t);
}
foreach (var l in list)
{
    Console.WriteLine(l + " ");
}

// Macierz cyfr - sumy kolejnych ramek w macierzy kwadratowej o n parzystym

using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rozmiar macierzy kwadratowej (n parzyste): ");
        int n = int.Parse(Console.ReadLine());
        int[,] macierz = new int[n, n];
        Console.WriteLine("Wprowadź elementy macierzy:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Element [{0},{1}]: ", i, j);
                macierz[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int sumaRamek = 0;
        int rama = 1;
        while (rama <= n / 2)
        {
            for (int i = rama - 1; i < n - rama + 1; i++)
            {
                sumaRamek += macierz[rama - 1, i]; // Górna rama
                sumaRamek += macierz[n - rama, i]; // Dolna rama
                sumaRamek += macierz[i, rama - 1]; // Lewa rama
                sumaRamek += macierz[i, n - rama]; // Prawa rama
            }
            rama++;
        }
        Console.WriteLine("Suma kolejnych ramek: " + sumaRamek);
        Console.ReadKey();
    }
}

// 1. User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.

static int nwd(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
static int nww(int a, int b)
{
    return a * b / nwd(a, b);
}

int x, y;
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
Console.WriteLine(nwd(x, y));

// 2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym

static string ulamki(int a, int b, int c, int d)
{
    int x = b;
    int y = d;
    int iloczyn = x * y;

    while (y > 0)
    {
        int temp = y;
        y = x % y;
        x = temp;
    }

    int nww = iloczyn / x;
    int e = nww / b * a;
    int f = nww / d * c;
    int g = e + f;

    if (g > nww)
    {
        return "Ułamek jest niewłaściwy";
    }
    else
    {
        return "Ułamek jest właściwy";
    }
}

int x, y, a, b;
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

string wynik = ulamki(a, b, x, y);
Console.WriteLine(wynik);

// 3. Sprawdź czy wieksza jest suma dwóch wpisanych przez usera ułamków czy suma ich odwrotności.


// 4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek.
// 5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.

// 6. Znajdź trzy takie liczby, których suma, a także suma każdej pary tych liczb jest kwadratem innej liczby.

// 7. Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp. 
Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc 
i lecąc z jednakową prędkością przybywają w tym samym czasie. 
Napisz program, który obliczy jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?

// 8. Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b> 
a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb, 
które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie). 
Napisz program, który pomaga w takich obliczeniach.

// 9. Halinka wspina się na schody w centrum handlowym. Za każdym razem, gdy dziewczynka wspina się na nowe schody, 
zaczyna liczyć na głos po kolei od 1 do ilości stopni. Na przykład, 
jeśli wspina się na dwa zestawy schodów – jeden z 3 stopniami, a drugi z 4 stopniami – 
będzie liczyć tak: 1, 2, 3, 1, 2, 3, 4. Masz dane wszystkie liczby, które Halinka wypowiedziała 
podczas całej swojej wycieczki po centrum i Twoim zadaniem jest obliczenie, ile zestawów schodów „zaliczyła”.

// 10. Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował 
przechadzających się ludzi.
W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
znaleźć sobie miejsce na ławce.
Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
Jaka jest minimalna, a jaka maksymalna wartość k?
