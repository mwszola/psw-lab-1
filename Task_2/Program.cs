// Inicjalizacja 10-elementowej tablicy
int[] userPicks = new int[10];

var uniqueNumbers = 0;

for (var i = 0; i < 10; i++)
{
    Console.WriteLine("Podaj liczbe");
    // Pobranie danych od uzytkownika i konwersja na liczbe
    var userPick = Convert.ToInt32(Console.ReadLine());
    // Jezeli tablica nie zawiera jeszcze takiej liczby
    if (!userPicks.Contains(userPick))
    {
        // Dodajemy liczbe do tablicy i zwiekszamy ilosc unikatowych wartosci
        userPicks[uniqueNumbers++] = userPick;
    }
    // Co kazda interacje wyswietlamy ilosc unikatowych wartosci do tej pory
    Console.WriteLine($"Liczba unikatowych wartosci: {uniqueNumbers}");
}