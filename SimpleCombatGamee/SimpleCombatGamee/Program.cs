using System;

// 1. This Is The Base Class
public abstract class Player
{
    public string Name { get; set; }
    public int HP { get; set; }
    public int ATK { get; set; }
    public abstract void SpecialAttack(Player target);
}

// 2. This is The Fighter Class
public class Fighter : Player
{
    public override void SpecialAttack(Player target)
    {
        target.HP -= 20;
        Console.WriteLine($"{Name} used Heavy Strike! Dealt 20 damage.");
    }
}

// 3. DA Wizard Class
public class Wizard : Player
{
    public override void SpecialAttack(Player target)
    {
        target.HP -= 15;
        Console.WriteLine($"{Name} used Fireball! Dealt 15 damage.");
    }
}

// 4. DA Game Class
public class Game
{
    public void Start(Player p1, Player p2)
    {
        Random rng = new Random();

        while (p1.HP > 0 && p2.HP > 0)
        {
            // Da Fighter attacks Wizard
            int fDmg = rng.Next(10, p1.ATK + 1);
            p2.HP -= fDmg;
            Console.WriteLine($"Fighter dealt {fDmg} damage to Wizard.");

            // Da Wizard attacks Fighter
            int wDmg = rng.Next(5, p2.ATK + 1);
            p1.HP -= wDmg;
            Console.WriteLine($"Wizard dealt {wDmg} damage to Fighter.");
        }

        Console.WriteLine(p1.HP > 0 ? "Fighter won!" : "Wizard won!");
    }
}

// 5. now for EXECUTION
class Program
{
    static void Main()
    {
        Fighter f = new Fighter { Name = "Fighter", HP = 100, ATK = 20 };
        Wizard w = new Wizard { Name = "Wizard", HP = 100, ATK = 20 };

        new Game().Start(f, w);
    }
}