byte maxHp = 100;
int strength = 5, dexterity = 5, intelligence = 5;
int experience = 0;
const byte inventoryCapacity = 20;
decimal currency = 100;
int requiredExp = 100;
int invSpace = 0;

Console.WriteLine("---------- The PJATK Game ----------");
Console.Write("Name your character: ");
String playerName = Console.ReadLine();

Console.Write($"How old is {playerName}? ");
int playerAge = int.Parse(Console.ReadLine());

Console.Write($"How are you {playerName}, on a scale of 1-10? ");
int playerHappiness = int.Parse(Console.ReadLine());

Console.Write($"How much hp does {playerName} have? ");
int healthPoints= int.Parse(Console.ReadLine());

Console.Write($"Player level: {playerName}? ");
int playerLevel = int.Parse(Console.ReadLine());

Console.Write("Weapon damage: ");
int weaponDmg = int.Parse(Console.ReadLine());

Console.Write("Special attack multiplier: ");
double spAtkMult = double.Parse(Console.ReadLine());

Console.WriteLine("------------------------------------");

double healthPercent = (float)healthPoints / maxHp * 100;
healthPercent = Math.Round(healthPercent, 2);

requiredExp += (playerAge + playerLevel) * 5;
invSpace += 1;

int nAtk = strength + weaponDmg;
decimal entryPayment = currency - 10;
decimal thisIsUselessButTheTaskRequiresItIWillDefinetlyUseItLaterButIJustDontHaveAnyUseForThisRightNow = currency % 7;

double spAtk = nAtk * spAtkMult;
spAtk = Math.Round(spAtk, 2);

bool isAlive = healthPoints > 0;
bool hasAGoodDay = playerHappiness > 5;
bool isInDanger = healthPoints < 20;

Console.WriteLine("\n╔═════════════╗" +
                  "\n║  INVENTORY  ║" +
                  "\n╠═════════════╩═════════════╗" +
                  $"\n║  {invSpace}/{inventoryCapacity}  -  -  -  -  -  -   ║" +
                  "\n╠═══════════════════════════╣" +
                  "\n║       PLAYER INFO         ║" +
                  "\n╠═══════════════════════════╣" +
                  $"\n║ Str: {strength}      Lv: {playerLevel}         ║" +
                  $"\n║ Dex: {dexterity}      Exp: {experience}/{requiredExp}    ║" +
                  $"\n║ Int: {intelligence}      Cur: {currency} G    ║" +
                  $"\n║   Name: {playerName}     Age: {playerAge}     ║" +
                  $"\n║     HP: {healthPoints}/{maxHp} ({healthPercent}%)    ║" +
                  "\n╠═══════════════════════════╣" +
                  $"\n║ Mood: {hasAGoodDay}                ║" +
                  $"\n║ Alive: {isAlive}               ║" +
                  $"\n║ NAtk: {nAtk}                  ║" +
                  $"\n║ SpAtk: {spAtk}               ║" +
                  $"\n║ DmgTotal: {nAtk + spAtk}            ║" + 
                  $"\n║ AThing: {thisIsUselessButTheTaskRequiresItIWillDefinetlyUseItLaterButIJustDontHaveAnyUseForThisRightNow}         ║" +
                  $"\n║ LiveThreatned: {isInDanger}            ║");
