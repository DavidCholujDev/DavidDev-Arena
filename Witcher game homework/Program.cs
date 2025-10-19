using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

Console.WriteLine("Zdravim ta dobrodruh, Vitaj v mojej krasnej hre, dufam ze si ju uzijes");
Console.WriteLine("hru vytvoril @ch.d.avid na instagrame");
Console.WriteLine("enjoy");


// deklaracia
const int PlayerHPMax = 100;
const int MonsterHPMax = 100;
const int PlayerHPLow = 0;
const int MonsterHPLow = 0;
const int BossAttackDmg = 41;
bool Kaput = false;
List<string> inventory = new List<string>();
const int GabelHealthMax = 150;
const int GabelHealthLow = 0;
const int GabelAttackDmg = 65;
bool GabelKaput = false;

// zacatek

int monsterattack = PlayerHPMax / 2;
int playerhealth = monsterattack;
Console.WriteLine($"nasiel si priseru menom David Developer, David ta napadol a ubral ti polovicu zdravia, mas {monsterattack}HP , napis GO ak chces pokracovat");
var usrinput = Console.ReadLine();

// fight 1

if (usrinput == "GO")
{
    Console.WriteLine($"nemas vela sily, mozes pouzit len slaby utok - utok zahajis pismenom A");
    usrinput = Console.ReadLine();
    if (usrinput == "A")
        Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Red;
    // maly damage

    Console.WriteLine("David HP = 100");
    while (usrinput == "A")
    {
        int damage = 34;
        int BossHealthD = MonsterHPMax - damage;
        int BossHealthAttackTypeA = MonsterHPMax - damage;
        Console.WriteLine($"Hitnuls Davida, ma {BossHealthD} HP a ty mas {monsterattack} HP");
        int healht = playerhealth - BossAttackDmg;
        Console.WriteLine($"David ta trafil do gebule, ostalo ti {healht} HP");
        Console.WriteLine("Hitni Davida, vyber si utok    W - klasika, D - ultra mega silny utok, nemozes dvakrat za sebu vybrat ten isty utok");
        usrinput = Console.ReadLine();
        // mega ultra silny utok

        if (usrinput == "D")
        {
            damage = 99;
            BossHealthD = BossHealthAttackTypeA - damage;
            if (BossHealthD <= 0)
            {
                Console.WriteLine("porazil si Davida, ides dalej ziskavas jeho klavesnicu ktora ti navysi utok o 30%");
                Console.BackgroundColor = ConsoleColor.Black;
                inventory.Add("Coding Keyboard of David Developer");
                Kaput = true;



            }
        }
        // klasik utok

        if (usrinput == "W")
        {
            damage = 66;
            BossHealthD = BossHealthAttackTypeA - damage;
            if (BossHealthD <= 0)
            {
                Console.WriteLine("porazil si Davida, ides dalej ziskavas jeho klavesnicu ktora ti navysi utok o 30%");
                Console.BackgroundColor = ConsoleColor.Black;
                inventory.Add("Coding Keyboard of David Developer");
                Kaput = true;
            }
        }

    }
}
// druhy bossfight

    if (Kaput = true)
    {    
        Console.WriteLine("Nasiel si noveho bossa po ceste do skoly, ak sa chces dostat do skoly musis Bossa porazit");
        Console.WriteLine("inventar otvoris pismenom E, ak chces item pouzit napis jeho meno, ak nechces otvorit inventar napis pismeno N");
        string inventoryaccess = Console.ReadLine();
    
    // ak chce pouzit item z invu
    if (inventoryaccess == "E")
    {
        inventory.ForEach(Console.WriteLine);
        Console.WriteLine();
        Console.WriteLine("Napis meno itemu kery chces pouzit");
        string inventoryItemSelector = Console.ReadLine();
        if (inventoryItemSelector == "Coding Keyboard of David Developer")
        {
            Console.WriteLine("Zvolil si si : Coding Keyboard of David Developer, tvoj utok sa zvysil o 30%");
            Console.WriteLine();
            Console.WriteLine("Gabel  - Zdravim ta, moje meno je Gabel a teraz budes zapasit so mnou ak sa chces dostat do skoly");
            Console.WriteLine($"Gabel Health = 150 ");
            Console.WriteLine($"Ty = {PlayerHPMax}");
            Console.WriteLine("Gabel na teba zautocil, ubral ti zdravia vela, vyber svoj utok podla predoslych moznosti, si aktualne moc unaveny na ultra mega silny utok");
            usrinput = Console.ReadLine();
            // moznost utoku c 1
            while(usrinput == "D")
            {
                int damage = 129;
                int GabelHealth = GabelHealthMax - damage;
                int playerHealth = PlayerHPMax - GabelAttackDmg;
                Console.WriteLine($"Zautocil si na Gabla, klavesnica keru ti dal David mu ublizila a ostalo mu iba {GabelHealth} HP");
                Console.WriteLine("Gabel - Auuuuu, toto si prehnal , teraz ti dam pastou");
                int PlayerHPAfterGabelAttack = playerHealth;
                Console.WriteLine($"Ty =  {PlayerHPAfterGabelAttack} HP    Gabel = {GabelHealth} HP");
                Console.WriteLine("Musis uz dokoncit Gabla raz a navzdy, vyber nasledujuci utok podla predoslych moznosti");
                usrinput = Console.ReadLine () ;


                if (usrinput == "A")
                {
                    damage = 45;
                    int GabelHealthA = GabelHealth - damage;
                    if (GabelHealthA <= 0)
                    {
                        Console.WriteLine("Gabel - AAGH!!! Porazil si ma, darujem ti moj siroky medeny kabel, pakuj do skoly");
                        inventory.Add("Gabel's ultra wide thick copper cable");
                        GabelKaput = true;
                    }
                }


                if (usrinput == "W") 
                {
                    damage = 86;
                    int GabelHeathW = GabelHealth - damage;
                    if (GabelHeathW <= 0)
                    {
                        Console.WriteLine("Gabel - Porazil si ma AAGH! Za toto ti darujem moj siroky medeny kabel, zmizni mi z oci");
                        inventory.Add("Gabel's ultra wide thick copper cable");
                        GabelKaput = true;
                    }
                }
                

            }
            
            
            
            // druhy typ utoku na Gabel
            while (usrinput == "W")
            {
                int damage = 86;
                int GabelHealth = GabelHealthMax - damage;
                int playerHealth = PlayerHPMax - GabelAttackDmg;
                Console.WriteLine($"Zautocil si na Gabla, tvoja klavesnica mu ublizila, ostalo mu {GabelHealth} HP");
                Console.WriteLine("Gabel - Au, MOJA IZOLACIA, TOTO OLUTUJES AAGH!");
                Console.WriteLine("Gabel ti vrazil");
                int PlayerHPAfterGabelAttack = playerHealth;
                Console.WriteLine($"Ty = {PlayerHPAfterGabelAttack} HP     Gabel = {GabelHealth}");
                Console.WriteLine("Nemozes nechat Gabel ta porazit, vyber dalsi utok podla predoslych moznosti");
                usrinput = Console.ReadLine();
                // nasledujuce utoky
                
                if (usrinput == "D")
                {
                    damage = 129;
                    int  GabelHealthD = GabelHealth - damage;
                    if (GabelHealthD <= 0)
                    {
                        Console.WriteLine("Gabel - AAGH! Porazil si ma, dostavas darcek odomna, moj siroky medeny kabel, miguj do skoly");
                        GabelKaput = true;
                        inventory.Add("Gabel's ultra wide thick copper cable");
                    }
                }
                if (usrinput == "A")
                {
                    damage = 45;
                    int GabelHealthW = GabelHealth - damage;
                    Console.WriteLine($"Gabel - AAGH! To bolelo, teraz ti vrazim");
                    int PlayerHealthAfterAttack = playerhealth - GabelAttackDmg;
                    if (PlayerHealthAfterAttack <= 0)
                    {
                        Console.WriteLine("Gabel ta zabil , porazil si iba Davida Developera, dakujem ze si hral moju hru, sbohom");
                        GabelKaput = false;
                    }
                    if (GabelHealthW <= 0)
                    {
                        Console.WriteLine($"Gabel - AAGH! Porazil si ma, ziskavas moj siroky medeny kabel, ic do skoly");
                        inventory.Add("Gabel's ultra wide thick copper cable");
                        GabelKaput = true;
                    }

                }
            }
            

            
            
            
            // treti typ utoku na gabel
            while (usrinput == "A")
            {
                int damage = 45;
                int GabelHealth = GabelHealthMax - damage;
                int playerHealth = PlayerHPMax - GabelAttackDmg;
                Console.WriteLine($"Zautocil si na Gabla, ostry kraj tvojej 'Coding Keyboard of David Developer' mu porezal izolaciu, teraz ma {GabelHealth} HP");
                Console.WriteLine("Gabel - Au, MOJA IZOLACIA, TOTO OLUTUJES AAGH!");
                Console.WriteLine("Gabel ti dal pravy hak do brady");
                int PlayerHPAfterGabelAttack = playerHealth;
                Console.WriteLine($" Ty = {PlayerHPAfterGabelAttack} HP    Gabel = {GabelHealth} HP ");
                Console.WriteLine("Gabel stale nieje mrtvy, MUSIS HO ZMLATIT! Vyber svoj utok podla predoslej moznosti");
                usrinput = Console.ReadLine();
                // nasledovne utoky na Gabla
                      
                if (usrinput == "D")
                {
                    damage = 129;
                    int GabelHealthA = GabelHealth - damage;
                    if (GabelHealthA <= 0)
                    {
                        Console.WriteLine("Gabel - AAGH! Porazil si ma, ziskavas moj siroky medeny kabel, ic do skoly");
                        inventory.Add("Gabel's ultra wide thick copper cable");
                        GabelKaput = true;

                    }
                    
                }
                
                
                if (usrinput == "W")
                {
                    damage = 86;
                    int GabelHealthA = GabelHealth - damage;
                    Console.WriteLine($"GABEL JE SKORO MRTVY! UZ MA LEN {GabelHealthA} HP       TY = {playerHealth}");
                    Console.WriteLine("Gabel ti vrazil celou silou");
                    int playerHealthAfterAttack = playerHealth - GabelAttackDmg;
                    Console.WriteLine("Gabel ta zabil, porazil si 1 monstrum");
                    GabelKaput = false;
                    

                
                }

                 
            }
            
        }
    }

    }






