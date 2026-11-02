byte maxHp = 100;
const byte invSpace = 6;
int turn = 1;
int hp;
int exploration = 0;
int goldTotal = 0;
int noGoldCount = 0;
decimal gold; 
const bool game = true;
bool gameOver = false;
string lastChoice = "";

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

string[] loot = {"Potion", "Key", "Torch", "Scroll"};
int[] goldPerTurn = new int[20];

List<string> inventory = new List<string> {
    "Sword", "Potion"
};
List<string> history = new List<string>();

while (game) {
    double healthPercent = (double)hp / maxHp * 100;
    healthPercent = Math.Round(healthPercent, 2);
    
    Console.WriteLine("=====[-{|}-The PJATK Game-{|}-]=====");
    Console.WriteLine($"Turn: {turn}" +
                      $"\nCharacter: {playerName}");
    Console.Write("HP: ");
    if (hp < 20) {
        Console.ForegroundColor = ConsoleColor.Red;
    } else if (hp < 40) {
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
                gameOver = true;
                lastChoice = "Player died.";
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are dead.");
                Console.ResetColor();
            } else {
                hp -= 8;
            }
            
            exploration++;
            gold += 10;
            goldPerTurn[turn - 1] += 10;
            
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
            
            bool no = false;
            
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
                            } else if (maxHp - hp < 20) {
                                int difference = maxHp - hp;
                                hp += difference;
                                
                                Console.WriteLine($"\nYou heal {difference} HP.\n");
                                break;
                            } else {
                                Console.WriteLine("\nYou heal 20 HP.\n");
                                hp += 20;
                                
                                inventory.RemoveAt(item - 1);
                                break;
                            }
                            history.Add($"Turn {turn}: Player used a potion.");
                        } else if (inventory[item - 1] == loot[2]) {
                            Console.WriteLine("\nYou lit up the corridor.\n");
                            inventory.RemoveAt(item - 1);
                            history.Add($"Turn {turn}: Player used a torch.");
                            break;
                        } else if (inventory[item - 1] == loot[3]) {
                            Console.WriteLine("\nYou open the scroll, and gain 15 gold.\n");
                            gold += 15;
                            goldPerTurn[turn - 1] += 15;
                            
                            inventory.RemoveAt(item - 1);
                            history.Add($"Turn {turn}: Player used a scroll.");
                            break;
                        } else {
                            Console.WriteLine("\nThis item has no use.\n");
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
                    history.Add($"Turn {turn}: Added {loot[item - 1]} to inventory.");
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
                string input = Console.ReadLine();
            
                if (input == "y") {
                    Console.WriteLine($"Choose item (1-{inventory.Count}):");
                    int.TryParse(Console.ReadLine(), out int item);
                    
                    if (inventory.Count == 0) {
                        Console.WriteLine("\nYou have no items.\n");
                    } else if (item <= inventory.Count && item > 0) {
                        history.Add($"Turn {turn}: Removed {inventory[item - 1]} from inventory.");
                        inventory.RemoveAt(item - 1);
                        break;
                    } else {
                        Console.WriteLine("\nIncorrect input.\n");  
                    }
                    
                } else if (input == "n") {
                    nope = true;
                    break;
                }
            }
            if (nope) {
                continue;
            }
            break;
        case 6:
            Console.WriteLine("====PLAYER HISTORY====");
            for (int i = history.Count - 1; i >= 0; i--) {
                Console.WriteLine(history[i]);
            }
            Console.WriteLine("======================");
            continue;
        case 7:
            for (int i = 0; i < turn - 1; i++) {
                if (goldPerTurn[i] == 0) {
                    noGoldCount++;
                }
            }
            for (int i = 0; i < goldPerTurn.Length; i++) {
                goldTotal += goldPerTurn[i];
            }
            for (int i = 0; i < goldPerTurn.Length; i++) {
                for (int j = i + 1; j < goldPerTurn.Length; j++) {
                    if (goldPerTurn[i] > goldPerTurn[j]) {
                        int temp = goldPerTurn[i];
                        goldPerTurn[i] = goldPerTurn[j];
                        goldPerTurn[j] = temp;
                    }
                }
            }
            Console.WriteLine($"\nExplorations: {exploration}" +
                              $"\nGold earned from exploring: {goldTotal}" +
                              $"\nHighest earned gold in a turn: {goldPerTurn[goldPerTurn.Length - 1]}" +
                              $"\nTurns without gold: {noGoldCount}\n");
            continue;
        case 8:
            bool exitChoice = false;
            
            while (true) {
                Console.WriteLine("Are you sure you want to end the game?(y/n)");
                string input = Console.ReadLine();

                if (input == "y") {
                    gameOver = true;
                    lastChoice = "Player ended the game.";
                    Console.WriteLine("\nEnding game...");
                    break;
                }
                if (input == "n") {
                    exitChoice = true;
                    break;
                }
            }
            if (exitChoice) {
                continue;
            }
            break;
    }
    if (hp > 0 && turn == 20) {
        gameOver = true;
        lastChoice = "Player reached game limit.";
        Console.WriteLine("You ran out of turns.");
    }
    if (gameOver) {
        Console.WriteLine("\n=====GAME SUMMARY=====");
        Console.WriteLine($"Character: {playerName}" +
                          $"\nTurns played: {turn}" +
                          $"\nExplorations: {exploration}" +
                          $"\nHP: {hp}/{maxHp}" +
                          $"\nGold: {gold}" +
                          $"\nInventory: {inventory.Count}/6" +
                          $"\nHistory notes: {history.Count}" +
                          $"\nReason of ending: {lastChoice}");
        if (inventory.Count > 0) {
            Console.WriteLine("\n====INVENTORY====");
                
            for (int i = 0, j = 1; i < inventory.Count && j <= inventory.Count; i++, j++) {
                Console.WriteLine($"{j}. {inventory[i]}");
            }
            Console.WriteLine("=================\n");
        } else {
            Console.WriteLine("\nInventory is empty.\n");
        }

        Console.WriteLine("====PLAYER HISTORY====");
        for (int i = history.Count - 1; i >= 0; i--) {
            Console.WriteLine(history[i]);
        }
        Console.WriteLine("======================");
        break;
    }
    turn++;
}
