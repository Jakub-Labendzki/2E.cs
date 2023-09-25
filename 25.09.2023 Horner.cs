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
