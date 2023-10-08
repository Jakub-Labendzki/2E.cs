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

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

if ((a / c) + (b / d) > (c / a) + (d / b))
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}

// 4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek.

int sg = 0;
int wg = 0;
String napis = Console.ReadLine();
for (int i = 0; i < napis.Length; i++)
{
    if (napis[i] == 'a' || napis[i] == 'e' || napis[i] == 'i' || napis[i] == 'o' || napis[i] == 'u' || napis[i] == 'y')
    {
        sg++;
    }
    else
    {
       wg++;
    }
}

// 5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.

string napis = Console.ReadLine();
char[] literki = napis.ToCharArray();
int[] ints = new int[100];
foreach (char c in literki)
    ints[(int)c]++;
Console.WriteLine(literki[ints.Max()]);

// 6. Znajdź trzy takie liczby, których suma, a także suma każdej pary tych liczb jest kwadratem innej liczby.

static void Main()
{
    int maxNumber = 100; // Maksymalna liczba do przeszukania
    for (int a = 1; a <= maxNumber; a++)
    {
        for (int b = a + 1; b <= maxNumber; b++)
        {
            for (int c = b + 1; c <= maxNumber; c++)
            {
                if (IsSumSquare(a, b, c) && IsPairSumSquare(a, b, c))
                {
                    Console.WriteLine($"Znaleziono trzy liczby: {a}, {b}, {c}");
                }
            }
        }
    }
}

static bool IsSumSquare(int a, int b, int c)
{
    int sum = a + b + c;
    int sqrt = (int)Math.Sqrt(sum);
    return sqrt * sqrt == sum;
}

static bool IsPairSumSquare(int a, int b, int c)
{
    return IsSquare(a + b) && IsSquare(b + c) && IsSquare(a + c);
}

static bool IsSquare(int number)
{
    int sqrt = (int)Math.Sqrt(number);
    return sqrt * sqrt == number;
}

// 7. Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp. 
Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc 
i lecąc z jednakową prędkością przybywają w tym samym czasie. 
Napisz program, który obliczy jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?

static void Main()
    {
        // Wysokość wieżyc
        double heightTower1 = 30; // Wysokość pierwszej wieżycy w stopach
        double heightTower2 = 40; // Wysokość drugiej wieżycy w stopach

        // Odległość między wieżycami
        double distanceBetweenTowers = 50; // Odległość między wieżycami w stopach

        // Prędkość ptaków
        double birdSpeed = 1; // Jednostkowa prędkość ptaków (np. stopa na sekundę)

        // Oblicz czas potrzebny ptakom, aby dolecieć do wodotrysku
        double timeToReachFountain1 = heightTower1 / birdSpeed;
        double timeToReachFountain2 = heightTower2 / birdSpeed;

        // Oblicz odległość poziomą wodotrysku jednej z wieżyc
        double horizontalDistance1 = timeToReachFountain1 * birdSpeed;
        double horizontalDistance2 = timeToReachFountain2 * birdSpeed;

        // Wypisz wynik
        Console.WriteLine("Odległość pozioma wodotrysku przy pierwszej wieżycy: " + horizontalDistance1 + " stóp");
        Console.WriteLine("Odległość pozioma wodotrysku przy drugiej wieżycy: " + horizontalDistance2 + " stóp");

        // Porównaj odległości i wypisz, która jest dłuższa
        if (horizontalDistance1 > horizontalDistance2)
        {
            Console.WriteLine("Odległość pozioma przy pierwszej wieżycy jest dłuższa.");
        }
        else if (horizontalDistance2 > horizontalDistance1)
        {
            Console.WriteLine("Odległość pozioma przy drugiej wieżycy jest dłuższa.");
        }
        else
        {
            Console.WriteLine("Odległości poziome przy obu wieżycach są równe.");
        }
    }
    
// 8. Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b> 
a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb, 
które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie). 
Napisz program, który pomaga w takich obliczeniach.

    static bool IsSevenRelated(int number)
    {
        if (number % 7 == 0)
            return true;

        int sumOfDigits = 0;
        int tempNumber = number;

        while (tempNumber > 0)
        {
            sumOfDigits += tempNumber % 10;
            tempNumber /= 10;
        }

        return sumOfDigits % 7 == 0;
    }

    static void Main()
    {
        Console.WriteLine("Witaj w grze \"siedem\"!");
        Console.Write("Podaj początek przedziału: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Podaj koniec przedziału: ");
        int b = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = a; i <= b; i++)
        {
            if (IsSevenRelated(i))
            {
                count++;
            }
        }

        Console.WriteLine($"Liczba liczb w przedziale <{a}, {b}>, które są podzielne przez siedem lub suma ich cyfr jest podzielna przez siedem: {count}");
    }
    
// 9. Halinka wspina się na schody w centrum handlowym. Za każdym razem, gdy dziewczynka wspina się na nowe schody, 
zaczyna liczyć na głos po kolei od 1 do ilości stopni. Na przykład, 
jeśli wspina się na dwa zestawy schodów – jeden z 3 stopniami, a drugi z 4 stopniami – 
będzie liczyć tak: 1, 2, 3, 1, 2, 3, 4. Masz dane wszystkie liczby, które Halinka wypowiedziała 
podczas całej swojej wycieczki po centrum i Twoim zadaniem jest obliczenie, ile zestawów schodów „zaliczyła”.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj sekwencję liczb, które Halinka wypowiedziała, oddzielając je spacją:");
        string input = Console.ReadLine();
        
        // Podziel wprowadzoną sekwencję na liczby
        string[] numbers = input.Split(' ');

        int setsOfStairs = 0; // Liczba zestawów schodów
        bool counting = false; // Flaga wskazująca, czy Halinka obecnie liczy

        foreach (string numberStr in numbers)
        {
            if (numberStr == "1")
            {
                // Znaleziono liczbę 1, co oznacza początek nowego zestawu schodów
                if (!counting)
                {
                    counting = true; // Zaczynamy liczyć
                    setsOfStairs++; // Zwiększ liczbę zestawów schodów
                }
                else
                {
                    counting = false; // Zakończ liczenie
                }
            }
            else if (counting)
            {
                // Kontynuujemy liczenie
            }
        }

        Console.WriteLine($"Halinka zaliczyła {setsOfStairs} zestawów schodów.");
    }
}

    
// 10. Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował 
przechadzających się ludzi.
W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
znaleźć sobie miejsce na ławce.
Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
Jaka jest minimalna, a jaka maksymalna wartość k?

using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę ławek n: ");
        int n = int.Parse(Console.ReadLine());

        // Tworzenie tablicy ai z początkową liczbą osób na każdej z ławek
        int[] ai = new int[n];
        Console.WriteLine("Podaj początkową liczbę osób na każdej z ławek:");
        for (int i = 0; i < n; i++)
        {
            ai[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Podaj liczbę przybyłych osób m: ");
        int m = int.Parse(Console.ReadLine());

        // Obliczanie minimalnej wartości k
        int minimalK = Math.Max(m, (int)Math.Ceiling((double)(m + Sum(ai)) / n));

        // Obliczanie maksymalnej wartości k
        int[] sortedAi = new int[n];
        Array.Copy(ai, sortedAi, n);
        Array.Sort(sortedAi);

        int maxK = sortedAi[n - 1] + m;

        Console.WriteLine($"Minimalna wartość k: {minimalK}");
        Console.WriteLine($"Maksymalna wartość k: {maxK}");
    }

    // Funkcja do obliczania sumy elementów tablicy
    static int Sum(int[] array)
    {
        int sum = 0;
        foreach (int element in array)
        {
            sum += element;
        }
        return sum;
    }
}
