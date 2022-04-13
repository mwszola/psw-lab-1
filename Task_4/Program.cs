namespace Task_4;

public static class Task4
{
    public static void Main()
    {
        var collectionA = new int[5];
        var collectionB = new int[5];

        // Pobierz elementy (liczby) do kolekcji od uzytkownika
        GetCollectionItems(collectionA, "A");
        GetCollectionItems(collectionB, "B");

        // Obliczenie sumy zbiorow A oraz B
        Console.WriteLine("=== A union B ===");
        var sumOfCollections = new SortedSet<int>(collectionA.Concat(collectionB));
        foreach (var number in sumOfCollections)
        {
            Console.WriteLine(number);
        }

        // Obliczenie roznicy zbiorow A-B
        Console.WriteLine("=== A - B ===");
        foreach (var number in collectionA)
        {
            if (!collectionB.Contains(number))
            {
                Console.WriteLine(number);
            }
        }

        // Obliczenie roznicy zbiorow B-A
        Console.WriteLine("=== B - A ===");
        foreach (var number in collectionB)
        {
            if (!collectionA.Contains(number))
            {
                Console.WriteLine(number);
            }
        }

        // Obliczenie czesci wspolnej zbiorow
        Console.WriteLine("=== A intersec B ===");
        foreach (var number in new SortedSet<int>(collectionA.Concat(collectionB)).Where(number =>
                     collectionA.Contains(number) & collectionB.Contains(number)))
        {
            Console.WriteLine(number);
        }
        
        // Obliczenie roznicy symetrycznej zbiorow
        Console.WriteLine("=== A Symmetric difference B ===");
        foreach (var number in new SortedSet<int>(collectionA.Concat(collectionB)).Where(number =>
                     !(collectionA.Contains(number) & collectionB.Contains(number))))
        {
            Console.WriteLine(number);
        }
        
        void GetCollectionItems(IList<int> col, string colName)
        {
            for (var i = 0; i < col.Count; i++)
            {
                Console.WriteLine($"Please, enter {i + 1}/{col.Count} number for collection {colName}");
                var input = Console.ReadLine();
                var successParse = int.TryParse(input, out var number);
                if (!successParse)
                {
                    Console.WriteLine($"Unable to parse '{input}'. Inserted '0' by default");
                }

                col[i] = successParse ? number : 0;
            }
        }
    }
}