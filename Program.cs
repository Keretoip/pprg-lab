/*String name = "Piotr";
String age = "21";
String favoriteGame = "Hollow Knight";*/

//ZADANIE.1 ---------------------------
//Console.WriteLine("Hola, Amigo!");

//ZADANIE.2 ---------------------------
/*Console.WriteLine("+-------------------+");
Console.WriteLine("|     WIZYTÓWKA     |");
Console.WriteLine("+-------------------+");
Console.WriteLine("| Imię: " + name + "       |");
Console.WriteLine("| Wiek: " + age + "          |");
Console.WriteLine("| Gra: " + favoriteGame + "|");
Console.WriteLine("+-------------------+");*/

//ZADANIE.3 ---------------------------
/*Console.WriteLine("Jak masz na imię?");
String name = Console.ReadLine()!;

Console.WriteLine("Jaki jest twój ulubiony kolor?");
String color = Console.ReadLine()!;

Console.WriteLine("Cześć, " + name + "! " + color + " to świetny kolor na płaszcz poszukiwacza przygód.");*/

//ZADANIE.4 ---------------------------

/*Console.WriteLine("Ile masz lat?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Za rok będziesz miał " + (age + 1) + " lat!");*/

//ZADANIE.5 ---------------------------

/*Console.WriteLine("Ile kilometrów jesteś oddalony/a od celu?");
int distance = int.Parse(Console.ReadLine());

Console.WriteLine("Ile kilometrów pokonujesz każdego dnia?");
int distanceCoveredInADay = int.Parse(Console.ReadLine());

Console.WriteLine("Twoja podróż będzie trwała " + (distance / distanceCoveredInADay) + " dni.");*/

//ZADANIE.6 ---------------------------

/*Console.WriteLine("Ile posiadasz złotych monet?");
int gold = int.Parse(Console.ReadLine());

Console.WriteLine("Ile posiadasz srebrnych monet?");
int silver = int.Parse(Console.ReadLine());

Console.WriteLine("Ile posiadasz miedzianych monet?");
int copper = int.Parse(Console.ReadLine());

int total = gold * 100 + silver * 10 + copper;
Console.WriteLine("Łącznie posiadasz wartość " + total + " miedziaków.");*/

//ZADANIE.7

/*Console.WriteLine("Ile potrzebujesz mikstur?");
int amount = int.Parse(Console.ReadLine());

int crystal = amount / 3;
int herbs = amount / 2;

Console.WriteLine("Będziesz potrzebował następujące składniki:"
                  + "\nKryształ: x" + crystal
                  + "\nZioła: x" + herbs);*/

//ZADANIE.8

/*Console.WriteLine("Cena za nocleg?");
decimal price = decimal.Parse(Console.ReadLine());

Console.WriteLine("Ile nocy?");
int nights = int.Parse(Console.ReadLine());

decimal total = price * nights;
Console.WriteLine("Musisz zapłacić dokładnie " + total + " za swój pobyt.");*/

//ZADANIE.9

/*Console.Write("Sekundy: ");
int seconds = int.Parse(Console.ReadLine());

Console.WriteLine((seconds / 60) + " minuty i " + (seconds % 60)+ " sekund.");*/

//ZADANIE.10

/*Console.WriteLine("Ile monet?");
int coins = int.Parse(Console.ReadLine());

Console.WriteLine("How many characters?");
int characters = int.Parse(Console.ReadLine());

Console.WriteLine("Each character shall receive " + (coins / characters) +
                  " coins, and there will be " + (coins % characters) + " coins left.");*/

//ZADANIE.11

/*Console.Write("Siła broni: ");
int weaponDamage = int.Parse(Console.ReadLine());

Console.Write("Siła gracza: ");
int playerPower = int.Parse(Console.ReadLine());

Console.Write("Zwykły atak (" + (weaponDamage + playerPower) + ") " + "= Siła broni (" + weaponDamage + ") + Siła gracza (" + playerPower + ")" + 
              "\nSpecjalny atak (" + ((weaponDamage + playerPower) * 2) + ") " + "= Siła broni (" + weaponDamage + ") + Siła gracza (" + playerPower + ") * 2" +
              "\nŁączne obrażenia trzech zwykłych ataków i jednego specjalnego: " + (((weaponDamage + playerPower) * 3) + ((weaponDamage + playerPower) * 2)));*/

//ZADANIE.12

//--------------------------------
//LABORATORIUM 2
//--------------------------------

//ZADANIE.1

/*String name = "ziom";
char marker = 'V';
int level = 5;
int gold = 999;
double inventoryWeight = 4.5;
bool hasAMap = false;

Console.WriteLine("=== EKWIPUNEK ===");
Console.Write("Imię: " + name +
              "\nSymbol: " + marker +
              "\nPoziom: " + level +
              "\nZłoto: " + gold +
              "\nWaga: " + inventoryWeight + " kg" +
              "\nMa mapę: " + hasAMap);*/

//ZADANIE.2
/*int training = 0;
int exp = 30;
int gold = 50;

Console.WriteLine("Trening: " + training + "\nDoświadczenie: " + exp + "\nZłoto: " + gold);

exp += 25;
exp *= 2;
gold -= 8;
gold += 15;
training += 1;

Console.Write("\nTrening: " + training + "\nDoświadczenie: " + exp + "\nZłoto: " + 
              gold);*/

//ZADANIE.3

/*Console.Write("Podaj liczbę racji żywnościowych: ");
int foodAmount = int.Parse(Console.ReadLine());

Console.Write("Podaj liczbę członków drużyny: ");
int partyMembers = int.Parse(Console.ReadLine());

Console.Write("liczbę dni wyprawy: ");
int daysPassed = int.Parse(Console.ReadLine());

Console.WriteLine("\nKażdy członek drużyny otrzyma " + (foodAmount / partyMembers) + " pełnych racji żywnościowych." +
                  "\nPo równym podziale zostanie " + (foodAmount % partyMembers) + " racji." +
                  "\nDziennie cała drużyna będzie miała " + (foodAmount / daysPassed) + " racji." +
                  "\nDziennie jedna osoba będzie miała " + ((foodAmount / partyMembers) / daysPassed) + " racji.");*/

//ZADANIE.4

/*Console.Write("Punkty życia: ");
int hp = int.Parse(Console.ReadLine());

Console.Write("Liczba mikstur: ");
int potions = int.Parse(Console.ReadLine());

Console.Write("Czy ma klucz (true/false): ");
bool hasAKey = bool.Parse(Console.ReadLine());

Console.Write("Czy ma mapę (true/false): ");
bool hasAMap = bool.Parse(Console.ReadLine());

bool isALive = hp > 0;
bool hasFullHp = hp == 100;
bool hasEquipment = potions > 0;
bool hasNavigationItem = hasAMap == true || hasAKey == true;
bool isReady = isALive && hasEquipment && hasNavigationItem;

Console.Write("\n" + isALive +
                  "\n" + hasFullHp +
                  "\n" + hasEquipment +
                  "\n" + hasNavigationItem +
                  "\n" + isReady);*/

//ZADANIE.5

Console.WriteLine("");
String name = Console.ReadLine();

Console.WriteLine("");
int maxHp = int.Parse(Console.ReadLine());

Console.WriteLine("");
int hp = int.Parse(Console.ReadLine());

Console.WriteLine("");
int weaponDmg = int.Parse(Console.ReadLine());

Console.WriteLine("");
int strength = int.Parse(Console.ReadLine());

Console.WriteLine("");
int spAtkMultiplier = int.Parse(Console.ReadLine());

Console.WriteLine("");
int normalHitsPerformed = int.Parse(Console.ReadLine());

//ZADANIE.6
