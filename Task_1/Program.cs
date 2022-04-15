var generateNumber = new Random();

// Wylosowanie dodatniej liczby mniejszej od 10 
var randomNumber = generateNumber.Next(10);
var userPick = -1;

// Dopoki uzytkownik nie zgadnie liczby 
while (userPick != randomNumber) {
    Console.WriteLine("Podaj liczbe");
    // Pobieramy dane od uzytkownika, ktore konwertujemy na liczbe 
    userPick = Convert.ToInt32(Console.ReadLine());
    if (userPick > randomNumber) {
        Console.WriteLine("Liczba jest wieksza od X");
    } else if (userPick < randomNumber) {
        Console.WriteLine("Liczba jest mniejsza od X");
    } else {
        Console.WriteLine("Zgadles!");
    }
}