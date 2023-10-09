// Algorytm schematu Hornera

// WE system, luiczba
// WE postac dziesiętna tej liczby

int horner(int system, string liczba)
{
    int wynik = (int)char.GetNumericValue(liczba[0]);
    for(int i = 1; i < liczba.Length; i++)
    {
        wynik = system * wynik + (int)char.GetNumericValue(liczba[i]);
    }
    return wynik;
}
int system = int.Parse(Console.ReadLine());
string liczba =  Console.ReadLine();
Console.WriteLine(horner(system,liczba));


// konwersja bin - dec i dec - bin

int bin2dec(string bin)
{
    double wynik = 0;
    int potega = 0;
    for (int i = bin.Length - 1; i >= 0; i--)
    {
        wynik = wynik + Math.Pow(2d,potega) * char.GetNumericValue(bin[i]);
        potega++;
    }
    return (int)wynik;
}

int binik = int.Parse(Console.ReadLine());
Console.WriteLine(bin2dec(binik));

string dec2bin(int dec)
{
    string wynik = "";
    string reszta;
    while (dec > 0)
    {
        reszta = Convert.ToString(dec % 2);
        wynik = new string(reszta) + wynik;
        dec = dec / 2;
    }
    return wynik;
}
int decik = int.Parse(Console.ReadLine());
Console.WriteLine(dec2bin(decik));
