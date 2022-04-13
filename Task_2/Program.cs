int[] userPicks = new int[10];

var uniqueNumbers = 0;

while (true)
{
    Console.WriteLine("Podaj liczbe");
    var userPick = Convert.ToInt32(Console.ReadLine());
    if (!userPicks.Contains(userPick))
    {
        userPicks[uniqueNumbers++] = userPick;
    }

    Console.WriteLine($"Liczba unikatowych wartosci: {uniqueNumbers}");
}