using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace Text_Adventure
{
    // enum, arrays, loops, debugging are shown at the bottom of the script
    struct CharacterData
    {
        public float hp;
        public float max_hp;
        public float stamina;
        public float max_stamina;
        public float damage;
        public bool can_attack;
        public string ability;
    }
    internal class Program
    {
        static int progress = 1;
        static int gold = 500;
        static CharacterData player = new()
        {
            hp = 100,
            max_hp = 100,
            stamina = 100,
            max_stamina = 100,
            damage = 30,
            can_attack = true,
            ability = "Robbery",
        };
        static CharacterData enemy = new()
        {
            hp = 0,
            max_hp = 0,
            stamina = 0,
            max_stamina = 0,
            damage = 0,
            can_attack = true,
            ability = "Robbery",
        };

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = 192;
            Console.WindowHeight = 54;
            Console.WriteLine(" ░▒ Perilous Trail ▒░");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" WARNING: Don't use inputs unless instructed, otherwise the game will continue unexceptly without your inputs, this includes holding down or spamming inputs. \r\n >>> this is caused by the console's engine and can't be fixed <<<");
            Thread.Sleep(6000);
            new_enemy();
        }

        static void new_enemy()
        {
            player.hp = player.max_hp;
            player.stamina = player.max_stamina;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Thread.Sleep(400);
            Console.WriteLine(" Progress: " + progress);
            Thread.Sleep(400);
            Console.WriteLine(" Gold: " + gold);
            Thread.Sleep(400);
            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Thread.Sleep(800);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n Something approaches you...\r\n");
            Thread.Sleep(1500);
            Console.WriteLine(" ░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄\r\n ░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄\r\n ░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█\r\n ░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█\r\n ░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█\r\n █▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█\r\n █▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█\r\n ░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█\r\n ░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█\r\n ░░░█░░██░░▀█▄▄▄█▄▄█▄████░█\r\n ░░░░█░░░▀▀▄░█░░░█░███████░█\r\n ░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█\r\n ░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█\r\n ░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█\r\n ░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█");
            Thread.Sleep(800);
            enemy.max_hp = 100.0f * progress;
            enemy.hp = 100.0f * progress;
            enemy.stamina = 100.0f;
            enemy.max_stamina = 100.0f;
            Console.WriteLine("\r\n Enemy Health: " + enemy.hp + "/" + enemy.max_hp);
            Thread.Sleep(150);
            Console.WriteLine(" Enemy Stamina: " + enemy.stamina + "/" + enemy.max_stamina);
            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Thread.Sleep(1000);
            players_turn();
        }
        static void players_turn()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            if (player.can_attack == false)
            {
                player.can_attack = true;
                Console.WriteLine(" You're stunned from the enemy's parry, can't move this turn");
                Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                enemys_turn(33);
            }
            else if (player.can_attack == true)
            {
                Console.WriteLine(" Your Turn.\r\n");
                Thread.Sleep(800);
                health_change(0);
                Thread.Sleep(150);
                stamina_change(0);
                Thread.Sleep(150);
                Console.WriteLine("\r\n Z to Attack      | Deal " + player.damage + " damage, unless the enemy parries");
                Thread.Sleep(150);
                Console.WriteLine(" X to Rob         | Do a cheap move and steal 100 gold from the enemy, steal double the gold if the enemy rests. This move can be parried, but you won't be stunned");
                Thread.Sleep(150);
                Console.WriteLine(" C to Parry       | Costs 30 Stamina, If the enemy attacks or uses certain items againist you this turn, You'll cancel their move");
                Thread.Sleep(150);
                Console.WriteLine(" V to Rest        | Recover 30 Stamina and recover " + (int)(player.max_hp * 0.3f) + " Health, but take 30% more damage and become more vulernable to being robbed");
                Thread.Sleep(150);
                Console.WriteLine(" ---------------------------------------------------------------");
                int players_move = make_choice();
                Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                enemys_turn(players_move);
                Thread.Sleep(800);
            }
            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
        }
        static int make_choice()
        {
            char letter = Console.ReadKey(true).KeyChar;

            switch (letter)
            {
                case 'z':
                    Console.WriteLine(" You attack the enemy");
                    return 1;
                case 'x':
                    Console.WriteLine(" You prepared to do a cheap move");
                    return 2;
                case 'c':
                    Console.WriteLine(" You raise your weapon...");
                    Thread.Sleep(800);
                    stamina_change(30);
                    return 3;
                case 'v':
                    Console.WriteLine(" You rest, recovered " + (int)(player.max_hp * 0.3f) + " Health and 30 stamina");
                    Thread.Sleep(800);
                    stamina_change(-30);
                    health_change(-player.max_hp * 0.3f);
                    return 4;
                default:
                    return make_choice();
            }
        }
        static void enemys_turn(int players_move)
        {
            enemy.can_attack = true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.WriteLine(" Enemy's Turn.");
            Thread.Sleep(800);
            Console.WriteLine(" \r\n ░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄\r\n ░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄\r\n ░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█\r\n ░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█\r\n ░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█\r\n █▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█\r\n █▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█\r\n ░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█\r\n ░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█\r\n ░░░█░░██░░▀█▄▄▄█▄▄█▄████░█\r\n ░░░░█░░░▀▀▄░█░░░█░███████░█\r\n ░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█\r\n ░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█\r\n ░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█\r\n ░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█\r\n");
            Random rng = new Random();
            int move = rng.Next(1, 5);

            // ATTACK
            if (move == 1)
            {
                if (players_move == 3)
                {
                    enemy.can_attack = false;
                    Thread.Sleep(800);
                    Console.WriteLine(" The enemy attacks...");
                    Thread.Sleep(800);
                    Console.WriteLine(" But you parried the attack!");
                    Thread.Sleep(800);
                    Console.WriteLine(" The enemy is stunned for the next turn!");
                }
                else if (players_move == 1)
                {
                    Thread.Sleep(800);
                    enemy_health_change(player.damage);
                    if (enemy.hp < 0)
                    {
                        enemy.can_attack = false;
                    }
                }
                else if (players_move == 2)
                {
                    if (player.ability == "Robbery")
                    {
                        Thread.Sleep(800);
                        Console.WriteLine(" You did a cheap move and stole 100 gold");
                        gold += 100;
                        Thread.Sleep(800);
                        Console.WriteLine(" Gold: " + (int)gold);
                    }
                }
                if (enemy.can_attack == true)
                {
                    if (players_move == 4)
                    {
                        Thread.Sleep(800);
                        Console.WriteLine(" The enemy attacks, and dealt extra damage...");
                        Thread.Sleep(800);
                        health_change((40 * progress * 0.5f) * 1.3f);
                    }
                    else
                    {
                        Thread.Sleep(800);
                        Console.WriteLine(" The enemy attacks and dealt " + (int)(40 * progress * 0.5f) + " damage");
                        Thread.Sleep(800);
                        health_change(40 * progress * 0.5f);
                    }
                }
            }


            // ITEM
            else if (move == 2)
            {
                if (players_move == 3)
                {
                    enemy.can_attack = false;
                    Thread.Sleep(800);
                    Console.WriteLine(" The enemy tried to do a cheap move...");
                    Thread.Sleep(800);
                    Console.WriteLine(" But you parried the attack!");
                    Thread.Sleep(800);
                    Console.WriteLine(" The enemy is stunned for the next turn!");
                }
                else if (players_move == 1)
                {
                    Thread.Sleep(800);
                    enemy_health_change(player.damage);
                    if (enemy.hp < 0)
                    {
                        enemy.can_attack = false;
                    }
                }
                else if (players_move == 2)
                {
                    if (player.ability == "Robbery")
                    {
                        Thread.Sleep(800);
                        Console.WriteLine(" You did a cheap move and stole 100 gold!");
                        gold += 100;
                        Thread.Sleep(800);
                        Console.WriteLine(" Gold: " + (int)gold);
                    }
                }
                if (enemy.can_attack == true)
                {
                    if (players_move == 4)
                    {
                        Thread.Sleep(800);
                        Console.WriteLine(" While you rested, the enemy did a cheap move and stole " + (int)(gold / 5) + " gold from you...");
                        Thread.Sleep(800);
                        gold_change(gold / 5);
                    }
                    else
                    {
                        Thread.Sleep(800);
                        Console.WriteLine(" The enemy did a cheap move and stole " + (int)(gold / 10) + " gold from you...");
                        Thread.Sleep(800);
                        gold_change(gold / 10);
                    }
                }
            }

            // PARRY
            else if (move == 3)
            {
                if (players_move == 1)
                {
                    if (enemy.stamina > 30)
                    {
                        player.can_attack = false;
                        Thread.Sleep(800);
                        Console.WriteLine(" The enemy parried your attack...");
                        Thread.Sleep(800);
                        enemy_stamina_change(30);
                        Thread.Sleep(800);
                        Console.WriteLine(" You're stunned for the next turn...");
                    }
                    else
                    {
                        if (enemy.can_attack == true)
                        {
                            Thread.Sleep(800);
                            enemy_health_change(player.damage);
                            Thread.Sleep(800);
                            Console.WriteLine(" The enemy attacks and dealt " + (int)(40 * progress * 0.5f) + " damage");
                            Thread.Sleep(800);
                            health_change(40 * progress * 0.5f);
                        }
                    }
                }
                else if (players_move == 2)
                {
                    if (player.ability == "Robbery")
                    {
                        if (enemy.stamina > 30)
                        {
                            Thread.Sleep(800);
                            Console.WriteLine(" The enemy was quick enough to stop the cheap move...");
                            Thread.Sleep(800);
                            enemy_stamina_change(30);
                        }
                        else
                        {
                            Thread.Sleep(800);
                            Console.WriteLine(" You did a cheap move and stole 100 gold!");
                            gold += 100;
                            Thread.Sleep(800);
                            Console.WriteLine(" Gold: " + (int)gold);
                            Thread.Sleep(800);
                            Console.WriteLine(" The enemy attacks and dealt " + (int)(40 * progress * 0.5f) + " damage");
                            Thread.Sleep(800);
                            health_change(40 * progress * 0.5f);
                        }
                    }
                }
                else if (players_move == 3)
                {
                    if (enemy.stamina > 30)
                    {
                        Thread.Sleep(800);
                        Console.WriteLine(" Both of you tried to parry... nothing happens");
                        Thread.Sleep(800);
                        enemy_stamina_change(30);
                    }
                    else
                    {
                        enemy.can_attack = false;
                        Thread.Sleep(800);
                        Console.WriteLine(" The enemy attacks...");
                        Thread.Sleep(800);
                        Console.WriteLine(" But you parried the attack!");
                        Thread.Sleep(800);
                        Console.WriteLine(" The enemy is stunned for the next turn!");
                    }
                }
                else if (players_move == 4)
                {
                    if (enemy.stamina > 30)
                    {
                        Thread.Sleep(800);
                        Console.WriteLine(" The enemy parried... but there was nothing to parry");
                        Thread.Sleep(800);
                        enemy_stamina_change(30);
                    }
                    else
                    {
                        if (enemy.can_attack == true)
                        {
                            Thread.Sleep(800);
                            Console.WriteLine(" The enemy attacks, and dealt extra damage...");
                            Thread.Sleep(800);
                            health_change((40 * progress * 0.5f) * 1.3f);
                        }
                    }
                }
            }

            // REST
            else if (move == 4)
            {
                Thread.Sleep(800);
                Console.WriteLine(" The enemy rests and recovers 30 stamina.");
                Thread.Sleep(800);
                enemy_stamina_change(-30);
                if (players_move == 1)
                {
                    Thread.Sleep(800);
                    Console.WriteLine(" You attacked while the enemy had it's guard down!");
                    Thread.Sleep(800);
                    enemy_health_change(player.damage * 1.3f);
                    if (enemy.hp < 0)
                    {
                        enemy.can_attack = false;
                    }
                }

                else if (players_move == 2)
                {
                    if (player.ability == "Robbery")
                    {
                        Thread.Sleep(800);
                        Console.WriteLine(" You did a cheap move while the enemy had it's guard down and stole 200 gold!");
                        gold += 200;
                        Thread.Sleep(800);
                        Console.WriteLine(" Gold: " + (int)gold);
                    }
                }

                else if (players_move == 3)
                {
                    Thread.Sleep(800);
                    Console.WriteLine(" You didn't parry anything...");
                }
            }
            Thread.Sleep(800);
            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            if (enemy.hp > 0.0f)
            {
                players_turn();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                Thread.Sleep(800);
                Console.WriteLine(" You won the battle!");
                Thread.Sleep(800);
                int add_gold = (int)(rng.Next(100 * progress, 200 * progress));
                Console.WriteLine(" You found " + add_gold + " gold!");
                Thread.Sleep(800);
                gold_change(-add_gold);
                Thread.Sleep(800);
                Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                shop();
            }
        }
        static void health_change(float damage)
        {
            player.hp -= damage;
            player.hp = Math.Clamp(player.hp, -player.max_hp, player.max_hp);
            Console.WriteLine(" Your health: " + (int)player.hp + "/" + (int)player.max_hp);
            if (player.hp < 1)
            {
                Console.WriteLine(" You've fallen in battle! \r\n GAME OVER.");
                while (true)
                {
                    Console.ReadKey(true);
                }
            }
        }
        static void stamina_change(float cost)
        {
            player.stamina -= (int)cost;
            player.stamina = Math.Clamp(player.stamina, 0, player.max_stamina);
            Console.WriteLine(" Your stamina: " + (int)player.stamina + "/" + (int)player.max_stamina);
        }
        static void gold_change(int cost)
        {
            gold -= cost;
            Console.WriteLine(" Gold: " + (int)gold);
        }
        static void enemy_health_change(float damage)
        {
            float current_enemy_hp = enemy.hp;
            enemy.hp -= (int)damage;
            if (current_enemy_hp > enemy.hp)
            {
                Console.WriteLine(" The enemy took " + damage + " damage!");
                Thread.Sleep(800);
                if (enemy.hp < 0)
                {
                    enemy.can_attack = false;
                }
            }
            Console.WriteLine(" Enemy Health: " + (int)enemy.hp + "/" + (int)enemy.max_hp);
        }
        static void enemy_stamina_change(float cost)
        {
            enemy.stamina -= (int)cost;
            enemy.stamina = Math.Clamp(enemy.stamina, 0, enemy.max_stamina);
            Console.WriteLine(" Enemy Stamina: " + (int)enemy.stamina + "/" + (int)enemy.max_stamina);
        }
        static void shop()
        {
            progress++;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Thread.Sleep(800);
            Console.WriteLine(" ░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄\r\n ░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄\r\n ░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█\r\n ░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█\r\n ░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█\r\n █▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█\r\n █▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█\r\n ░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█\r\n ░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█\r\n ░░░█░░██░░▀█▄▄▄█▄▄█▄████░█\r\n ░░░░█░░░▀▀▄░█░░░█░███████░█\r\n ░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█\r\n ░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█\r\n ░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█\r\n ░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█");
            Thread.Sleep(1600);
            Console.WriteLine(" hi, im the travelling merchant and i just so happen to appear every time you defeat an enemy");
            Thread.Sleep(1600);
            Console.WriteLine(" here's what i'm selling, you only get one item by the way, i'm very limited on stock");
            Thread.Sleep(1200);
            gold_change(0);
            Thread.Sleep(500);
            Console.WriteLine(" \r\n PRESS Z TO BUY: Health Potion | Generic rpg game health boost, gain +100 max health once bought ||| COST: " + (int)(400 * progress * 0.5f) + " gold");
            Thread.Sleep(500);
            Console.WriteLine(" \r\n PRESS X TO BUY: Attack Potion | Generic rpg game damage boost, gain +50 damage once bought ||| COST: " + (int)(400 * progress * 0.5f) + " gold");
            buy_something();

            static int buy_something()
            {
                char letter = Console.ReadKey(true).KeyChar;

                switch (letter)
                {
                    case 'z':
                        if (gold > (int)(400 * progress * 0.5f))
                        {
                            Console.WriteLine(" You gained 100 max health");
                            Thread.Sleep(500);
                            player.max_hp += 100;
                            gold -= (int)(400 * progress * 0.5f);
                            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                            new_enemy();
                        }
                        else
                        {
                            Console.WriteLine(" Not enough gold...");
                            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                            new_enemy();
                        }
                        return 0;
                    case 'x':
                        if (gold > (int)(400 * progress * 0.5f))
                        {
                            Console.WriteLine(" You gained 50 damage");
                            Thread.Sleep(500);
                            player.damage += 50;
                            gold -= (int)(400 * progress * 0.5f);
                            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                            new_enemy();

                        }
                        else
                        {
                            Console.WriteLine(" Not enough gold...");
                            Console.WriteLine(" ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                            new_enemy();
                        }
                        return 0;
                    default:
                        return buy_something();
                }
            }
            // ---------- COMMENTS
            // this line is disabled and wont run
            // int unused_int = 1;

            //this code block will not run

            /*
            Console.WriteLine(" hi, im the disabled block of code and i just so happen to appear on the bottom of this script");
            Thread.Sleep(800);
            Console.WriteLine(" don't ask how i got here");
            */

            // ----------- ENUMS

            /*
            enum Animals
            {
                cat = 0,
                dog = 1,
                mouse = 2,
                fish = 3,
                bird = 4,
            }
            
            Console.WriteLine(Animals.cat + " is represented as this int in the animals enum: " + (int)Animals.cat);
            */

            // ----------- ARRAY


            // ------------ LOOPS

            // ------------- DEBUGGING

        }
    }
}