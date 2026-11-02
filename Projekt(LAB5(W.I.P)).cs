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
int[] goldAquiredPerTurn = new int[20];

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
            goldAquiredPerTurn[turn - 1] += 10;
            
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
            if (inventory.Count > 0) {
                Console.WriteLine("\n====INVENTORY====");
                
                for (int i = 0, j = 1; i < inventory.Count && j <= inventory.Count; i++, j++) {
                    Console.WriteLine($"{j}. {inventory[i]}");
                }
                Console.WriteLine("=================\n");
            } else {
                Console.WriteLine("\nInventory is empty.\n");
            }
            
            bool no;
            
            while (true) {
                Console.WriteLine("Would you like to use an item?(y/n)");
                string input = Console.ReadLine();

                if (input == "y") {
                    Console.WriteLine($"Choose item (1-{inventory.Count}):");
                    int.TryParse(Console.ReadLine(), out int item);
                    
                    if (item <= inventory.Count && item > 0) {
                        if (inventory[item - 1] == loot[0]) {
                            if (hp == maxHp) {
                                Console.WriteLine("\nYou have full health.\n");
                            } else {
                                hp += 20;
                                Console.WriteLine("\nYou heal 20 HP\n");
                                inventory.RemoveAt(item - 1);
                            }
                        } else if (inventory[item - 1] == loot[1]) {
                            Console.WriteLine("Nothing happens.");
                        } else if (inventory[item - 1] == loot[2]) {
                            Console.WriteLine("You lit up the corridor.");
                            inventory.RemoveAt(item - 1);
                        } else if (inventory[item - 1] == loot[3]) {
                            Console.WriteLine("You open the scroll, and gain 15 gold.");
                            gold += 15;
                            inventory.RemoveAt(item - 1);
                        }
                    } else {
                        Console.WriteLine("\nIncorrect input.\n");  
                    }
                } else if (input == "n") {
                    no = true;
                    break;
                }
            }
            if (no) {
                continue;
            }
            break;
        case 4:
            bool check = false;
            
            for (int i = 0, j = 1; i < loot.Length && j <= loot.Length; i++, j++) {
                Console.WriteLine($"{j}: {loot[i]}");
            }
            while (true) {
                Console.Write($"Pick an item(1-{loot.Length}): ");
                int.TryParse(Console.ReadLine(), out int item);
                
                if (item == 0 || item > 4) {
                    Console.WriteLine("\nIncorrect input.\n");
                    check = true;
                } else if (invFull) {
                    Console.WriteLine("\nYour inventory is full.\n");
                } else if (item >= 1 && item <= loot.Length) {
                    inventory.Add(loot[item - 1]);
                    history.Add($"Added {loot[item - 1]} to inventory.");
                }
                break;
            }
            if (invFull || check) {
                continue;
            }
            break;
        case 5:
            bool nope = false;
            
            while (true) {
                Console.WriteLine("Are you sure you want to remove an item?(y/n)");
                string input2 = Console.ReadLine();
            
                if (input2 == "y") {
                    Console.WriteLine($"Choose item (1-{inventory.Count}):");
                    int.TryParse(Console.ReadLine(), out int item);
                    
                    if (inventory.Count == 0) {
                        Console.WriteLine("\nYou have no items.\n");
                    } else if (item <= inventory.Count && item > 0) {
                        history.Add($"Removed {inventory[item - 1]} from inventory.");
                        inventory.RemoveAt(item - 1);
                        break;
                    } else {
                        Console.WriteLine("\nIncorrect input.\n");  
                    }
                } else if (input2 == "n") {
                    nope = true;
                    break;
                }
            }
            if (nope) {
                continue;
            }
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
