int strength = 5, dexterity = 5, intelligence = 5;
int experience = 0;
int requiredExp = 100;
byte maxHp = 100;
const byte invSpace = 6;
int turn = 1;
int hp;
decimal gold; 
const bool game = true;
Console.WriteLine("Name your character: ");
String playerName = Console.ReadLine();

while (game) {
    Console.WriteLine($"How much hp does {playerName} have?");
    int.TryParse(Console.ReadLine(), out hp);

    if (hp >= 1 && hp <= 100) {
        break;
    }
}
while (game) {
    Console.WriteLine($"How much gold does {playerName} have?");
    string currency = Console.ReadLine();
    if (currency == "0") {
        gold = 0;
        break;
    }
    decimal.TryParse(currency, out gold);
    
    if (gold > 0) {
        break;
    }
}
Console.WriteLine("------------------------------------");

double healthPercent = (double)hp / maxHp * 100;
healthPercent = Math.Round(healthPercent, 2);

bool isAlive = hp > 0;
bool hasLowHp = hp < 30;

string hasFullHp = hp == maxHp ? "Player has full health." : "Player could use healing.";

string[] loot = {"Potion", "Key", "Torch", "Scroll"};

List<string> inventory = new List<string> {
    "Sword", "Potion"
};
List<string> history = new List<string>();

while (game) {
    Console.WriteLine("=====[-{|}-The PJATK Game-{|}-]=====");
    Console.WriteLine($"Turn: {turn}" +
                      $"\nCharacter: {playerName}");
    Console.Write("HP: ");
    if (!isAlive || hp < 20) {
        Console.ForegroundColor = ConsoleColor.Red;
    } else if (hasLowHp) {
        Console.ForegroundColor = ConsoleColor.Yellow;
    } else if (hp == maxHp) {
        Console.ForegroundColor = ConsoleColor.Magenta;
    } else {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    Console.Write($"{hp}");
    Console.ResetColor();
    Console.WriteLine($"/{maxHp} ({healthPercent}%) | Gold: {gold} | Inv: {inventory.Count}/{invSpace}");
    Console.WriteLine("\n1 - Explore dungeon" +
                      "\n2 - Open inventory" +
                      "\n3 - Use item" +
                      "\n4 - Pickup item" +
                      "\n5 - Remove item" +
                      "\n6 - Show history" +
                      "\n7 - Show stats" +
                      "\n8 - End game");
    int.TryParse(Console.ReadLine(), out int action);
    bool invFull = inventory.Count == 6;
    if (action <= 0 || action > 8) {
        continue;
    } 
    switch (action) {
        case 1:
            Console.WriteLine("\nYou venture into the dungeon...\n");
            Console.WriteLine("You lose 8 HP, but gain 10 Gold!\n");
            if (hp < 8) {
                hp -= hp;
            } else {
                hp -= 8;
            }
            gold += 10;
            history.Add($"Turn {turn}: obtained 10 gold, and lost 8 HP.");
            break;
        case 2:
            if (inventory.Count > 0) {
                Console.WriteLine("\n====INVENTORY====");
                for (int i = 0, j = 1; i < inventory.Count && j <= inventory.Count; i++, j++) {
                    Console.WriteLine($"{j}. {inventory[i]}");
                }
                Console.WriteLine("=================\n");
            } else {
                Console.WriteLine("\nInventory is empty.\n");
            }
            continue;
        case 3:
            
            break;
        case 4:
            for (int i = 0, j = 1; i < loot.Length && j <= loot.Length; i++, j++) {
                Console.WriteLine($"{j}: {loot[i]}");
            }
            while (true) {
                Console.Write($"Pick an item(1-{loot.Length}): ");
                int.TryParse(Console.ReadLine(), out int item);
                if (invFull) {
                    Console.WriteLine("\nYour inventory is full.\n");
                } 
                if (item >= 1 && item <= loot.Length) {
                    inventory.Add(loot[item - 1]);
                }
                break;
            }
            if (invFull) {
                continue;
            }
            break;
        case 5:
            break;
        case 6:
            break;
        case 7:
            break;
        case 8:
            break;
    }

    if (hp == 0) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You are dead.");
        break;
    }
    turn++;
}

//║ ══  ╠ ╗ ╔ ╚ ╝
