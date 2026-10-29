//ZADANIE.1

/*int[] gold = {5, 3, 6, 2, 1, 10};
int sum = 0;
int counter = 0;
int[] reversed = new int[gold.Length];

for (int i = 1; i < gold.Length; i++) {
    Console.WriteLine($"Turn {i}: {gold[i]} gold earned.");
}

foreach (int i in gold) {
    sum += i;

    if (i >= 5) {
        counter++;
    }
}

double average = (double)sum / gold.Length;

Console.Write($"\nTotal gold earned: {sum}" +
                  $"\nAverage: {Math.Round(average, 2)}" +
                  $"\nTurns with atleast 5 gold: {counter}" +
                  "\nReversed: ");
for (int i = gold.Length - 1; i > 0; i--) {
    Console.Write(gold[i] + " ");
}*/

//ZADANIE.2

/*List<string> inventory = new List<string> {
    "Sword", "Potion", "Torch"
};

Console.WriteLine($"Inventory ({inventory.Count}/6)");
for (int i = 0, j = 1; i <= inventory.Count && j <= inventory.Count; i++, j++) {
    Console.WriteLine($"{j}: {inventory[i]}");
}

string key = "Key";
Console.WriteLine($"\nFound item: {key}" + "\n" +
                  $"Added: {key}" +
                  "\nUsed potion.\n");
inventory.Add(key);
inventory.Remove("Potion");

Console.WriteLine($"Inventory ({inventory.Count}/6)");
for (int i = 0, j = 1; i <= inventory.Count && j <= inventory.Count; i++, j++) {
    Console.WriteLine($"{j}: {inventory[i]}");
}*/

//ZADANIE.3

Dictionary<string, int> price = new Dictionary<string, int> {
    {"Potion", 15}, {"Torch", 5}, {"Sword", 40}
};


//ZADANIE.4



//ZADANIE.5