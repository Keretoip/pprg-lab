
byte maxHp = 100;
int strength = 5, dexterity = 5, intelligence = 5;
int experience = 0;
const byte inventoryCapacity = 20;
decimal currency = 100;

Console.WriteLine("---------- The PJATK Game ----------");
Console.Write("Name your character: ");
String playerName = Console.ReadLine();

Console.Write($"How old is {playerName}? ");
int playerAge = int.Parse(Console.ReadLine());

Console.Write($"How are you {playerName}, on a scale of 1-10?");
int playerHappiness = int.Parse(Console.ReadLine());

Console.Write($"How much hp does {playerName} have? ");
int healthPoints= int.Parse(Console.ReadLine());

Console.Write($"How old is {playerName}? ");
int playerLevel = int.Parse(Console.ReadLine());

Console.WriteLine("------------------------------------");

double healthPercent = (float)healthPoints / maxHp * 100;
healthPercent = Math.Round(healthPercent, 2);

int requiredExp = 100 + (playerAge + playerLevel) * 5;

bool isAlive = healthPoints > 0;
bool hasAGoodDay = playerHappiness > 5;

if (!isAlive) {
    Console.Write("You are dead.");
} else {
    Console.WriteLine("\n╔═════════════╗" +
                      "\n║  INVENTORY  ║" +
                      "\n╠═════════════╩═════════════╗" +
                      "\n║  -  -  -  -  -  -  -  -   ║" +
                      "\n╠═══════════════════════════╣" +
                      "\n║       PLAYER INFO         ║" +
                      "\n╠═══════════════════════════╣" +
                      $"\n║ Str: {strength}      Lv: {playerLevel}         ║" +
                      $"\n║ Dex: {dexterity}      Exp: {experience}/{requiredExp}    ║" +
                      $"\n║ Int: {intelligence}      Cur: {currency} G    ║" +
                      $"\n║   Name: {playerName}     Age: {playerAge}     ║" +
                      $"\n║     HP: {healthPoints}/{maxHp} ({healthPercent}%)    ║" +
                      "\n╠═══════════════════════════╣" +
                      "\n║       PLAYER INFO         ║" +
                      "\n║       PLAYER INFO         ║" +
                      "\n║       PLAYER INFO         ║" +
                      "\n║       PLAYER INFO         ║" +
                      "\n║       PLAYER INFO         ║");
}


