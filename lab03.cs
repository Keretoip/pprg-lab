//ZADANIE.1

/*int num = int.Parse(Console.ReadLine());
if (num % 2 == 0) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Liczba jest parzysta!");
}
else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Liczba jest nie parzysta...");
}*/

//ZADANIE.2

/*Console.Write("Podaj kierunek świata: ");
String choice = Console.ReadLine().ToLower();
switch (choice)
{   
    case "północ":
        Console.Write("Wyruszasz w stronę gór.");
        break;
    case "południe":
        Console.Write("Wyruszasz w stronę pustyni.");
        break;
    case "wschód":
        Console.Write("Wyruszasz w stronę lasu.");
        break;
    case "zachód":
        Console.Write("Wyruszasz w stronę morza.");
        break;
    default:
        Console.Write("Musisz podać kierunek świata!");
        break;
}*/

//ZADANIE.3

/*Console.Write("Give me your age. Now! ");
int age = int.Parse(Console.ReadLine());

if (age <= 0) {
    Console.WriteLine("You don't exist. Try again.");
} else if (age > 0 && age <= 12) {
    Console.WriteLine("You are a child.");
} else if (age >= 13 && age <=17) {
    Console.WriteLine("You are a teenager.");
} else if (age >= 18 && age <= 65) {
    Console.WriteLine("You are an adult.");
} else if (age >= 65 && age <= 122) {
    Console.WriteLine("You are a senior.");
} else {
    Console.WriteLine("You are older than the oldest person in history.");
}*/

//ZADANIE.4

/*Console.Write("Player hp: ");
int Hp = int.Parse(Console.ReadLine());

Console.Write("Player has a key: ");
bool hasAKey = bool.Parse(Console.ReadLine());

Console.Write("Player knows the password: ");
bool knowsPassword = bool.Parse(Console.ReadLine());

bool canEnter = true;

if (Hp <= 0) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You are dead...");
    canEnter = false;
} else if (Hp > 0 && hasAKey || knowsPassword) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The player may enter.");
} else {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("You don't have the means to enter.");
    canEnter = false;
}
Console.ResetColor();

if (canEnter) {
    Console.WriteLine("Proceed...");
} else if (!canEnter) {
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Better luck next time!");
    Console.ResetColor();
}*/

//ZADANIE.DODATKOWE

//1.
/*Console.Write("Player hp: ");
int Hp = int.Parse(Console.ReadLine());

bool isALive = Hp > 0;

if (!isALive) {
    Console.Write("The player is dead.");
} else {
    Console.Write("The player is alive!");  
}*/

//2.
/*Console.Write("Player's gold: ");
int gold = int.Parse(Console.ReadLine());

String info;

if (gold >= 30) {
    info = "You are able to buy a potion.";
} else if (gold < 0) {
    info = "You are in debt!";
} else {
  info = "You are unable to buy a potion.";  
}

Console.Write(info);*/

//ZADANIE.5

/*Console.Write("Player hp: ");
int hp = int.Parse(Console.ReadLine());

Console.Write("Weapon damage: ");
int weaponDmg = int.Parse(Console.ReadLine());

Console.Write("Player has a potion: ");
bool hasAPotion = bool.Parse(Console.ReadLine());
const int heal = 10;

Console.Write("Choose action(fight[1], heal[2], run[3]: ");
int action = int.Parse(Console.ReadLine());

if (hp <= 0) {
    Console.Write("\nYou have no hp left. You are defeated!");
} else {
    switch (action) {
        case 1:
            Console.Write($"The attack did {weaponDmg} points of damage!");
            break;
        case 2:
            if (hasAPotion) {
                Console.Write($"The player healed {heal} health points!");
                hp += heal;
            } else {
                Console.Write("The player doesn't have a potion!");  
            }
            break;
        case 3:
            Console.Write("The player has fled the scene...");
            break;
        default:
            Console.Write("Invalid action.");
            break;
    }
    if (hp < 20) {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"\nPlayer's hp is really low. ({hp})");
    }
}*/