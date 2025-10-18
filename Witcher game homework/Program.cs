using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

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
    Console.WriteLine($"nemas vela sily, mozes pouzit len slaby utok - utok zahajis pismenom A");
    usrinput = Console.ReadLine();
    if (usrinput == "A")
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        // maly damage
    {
        Console.WriteLine("David HP = 100");
        while (usrinput == "A")
        {
            int damage = 34;
            int BossHealthD = MonsterHPMax - damage;
            int BossHealthAttackTypeA = MonsterHPMax - 34;
            Console.WriteLine($"Hitnuls Davida, ma {BossHealthD} HP a ty mas {monsterattack} HP");
            int  healht = playerhealth - BossAttackDmg;
            Console.WriteLine($"David ta trafil do gebule, ostalo ti {healht} HP");
            Console.WriteLine("Hitni Davida, vyber si utok    W - klasika, D - ultra mega silny utok" );
            usrinput = Console.ReadLine();
            // druhy utok
            
            if (usrinput == "D")
            {
                damage = 99;
                BossHealthD = BossHealthAttackTypeA - damage;
                if (BossHealthD <= 0)
                {
                    Console.WriteLine("porazil si Davida, ides dalej");
                    Console.BackgroundColor = ConsoleColor.Black;
                   // boss 2 
                    Console.WriteLine("Siel si po ulici po ceste z prvej areny, natrafil si na tvoju ucitelku dejepisu Eriku Mikovu. Ta ta ide skusat z dejepisu, musus spravne odpovedat na jej otazky aby si ju porazil");
                    Console.WriteLine("Erika Mikova - Kedy skoncila prva svatova vojna?");
                    string answer = Console.ReadLine();

                    if (answer == "1918")
                    {
                        Console.WriteLine("Erika Mikova  - Velmi dobre, dalsia otazka - V akom roku prisli Cyril i Metod na Slovensko?");
                        string ans2 = Console.ReadLine();
                        if (ans2 == "863")
                        {
                            Console.WriteLine("Erika Mikova - Aagh! Az moc sa ti dari, teraz tazka otazka - Kedy Japonci vybuchli Pearl Harbour - Presny datum! *napis ho cely ako napr 07121941 ");
                            string ans3 = Console.ReadLine();
                            if (ans3 == "07121941")
                            {
                                Console.WriteLine("Erika Mikova - Aagh! Porazil si moje tazke dejepisne otazky teraz ta necham napokoji");
                            }
                        }
                    }

                }
            }
            // treti typ utoku
            
            if (usrinput == "W")
            {
                damage = 66;
                BossHealthD = BossHealthAttackTypeA - damage;
                if (BossHealthD <= 0)
                {
                    Console.WriteLine("porazil si Davida, ides dalej");
                    Console.BackgroundColor = ConsoleColor.Black;
                    // boss 2
                    Console.WriteLine("Siel si po ulici po ceste z prvej areny, natrafil si na tvoju ucitelku dejepisu Eriku Mikovu. Ta ta ide skusat z dejepisu, musus spravne odpovedat na jej otazky aby si ju porazil");
                    Console.WriteLine("Erika Mikova - Kedy skoncila prva svatova vojna?");
                    string answer = Console.ReadLine();

                    if (answer == "1918")
                    {
                        Console.WriteLine("Erika Mikova  - Velmi dobre, dalsia otazka - V akom roku prisli Cyril i Metod na Slovensko?");
                        string ans2 = Console.ReadLine();
                        if (ans2 == "863")
                        {
                            Console.WriteLine("Erika Mikova - Aagh! Az moc sa ti dari, teraz tazka otazka - Kedy Japonci vybuchli Pearl Harbour - Presny datum! *napis ho cely ako napr 07121941 ");
                            string ans3 = Console.ReadLine();
                            if (ans3 == "07121941")
                            {
                                Console.WriteLine("Erika Mikova - Aagh! Porazil si moje tazke dejepisne otazky teraz ta necham napokoji");
                            }
                        }
                    }
                }


                
                if (healht <= 0)
                {
                    Console.WriteLine("David ta porazil, umrel si, ani jedneho bossa si neporazil, slaby si, dovidenia");
                    
                }


                

                
                
            }


            {
             
            }

        } 
        
    }   
    
}







