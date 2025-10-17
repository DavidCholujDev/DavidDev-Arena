Console.WriteLine("Zdravim ta dobrodruh, Vitaj v mojej krasnej hre, dufam ze si ju uzijes");
Console.WriteLine("hru vytvoril @ch.d.avid na instagrame");
Console.WriteLine("enjoy");


// health
const int PlayerHPMax = 100;
const int MonsterHPMax = 100;
const int PlayerHPLow = 0;
const int MonsterHPLow = 0;
const int BossAttackDmg = 41;



// beggining 

int monsterattack = PlayerHPMax / 2;
int playerhealth = monsterattack;
Console.WriteLine($"nasiel si priseru menom David Developer, David ta napadol a ubral ti polovicu zdravia, mas {monsterattack}HP , napis GO ak chces pokracovat");
var usrinput = Console.ReadLine();

// fight

if (usrinput == "GO")
{
    Console.WriteLine($"vyber si utok: Stlac A ak chces pouzit slaby utok, stlac W ak chces pouzit klasicky a stlac D ak chces ultra extra maximum silny utok");
    usrinput = Console.ReadLine();
    if (usrinput == "A")
    // maly damage
    {
        Console.WriteLine("David HP = 100");
        while (usrinput == "A")
        {
            int damage = 34;
            int BossHealth = MonsterHPMax - damage;
            Console.WriteLine($"Hitnuls Davida, ma {BossHealth} HP a ty mas {monsterattack} HP");
            int  healht = playerhealth - BossAttackDmg;
            Console.WriteLine($"David ta trafil do gebule, ostalo ti {healht} HP");
            break;
            if (usrinput == "A")


            {
             
            }

        }
        
    }   
    
}

else
{
    Console.WriteLine("dovidenia");
}
