var generateNumber = new Random();

var randomNumber = generateNumber.Next(10);
var userPick = -1;

while (userPick != randomNumber) {
    Console.WriteLine("Podaj liczbe");
    userPick = Convert.ToInt32(Console.ReadLine());
    if (userPick > randomNumber) {
        Console.WriteLine("Liczba jest wieksza od X");
    } else if (userPick < randomNumber) {
        Console.WriteLine("Liczba jest mniejsza od X");
    } else {
        Console.WriteLine("Zgadles!");
    }
}





