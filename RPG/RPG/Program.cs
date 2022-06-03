using System;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RpgCharacter hero = new RpgCharacter("Cloud Strife", 999, 9999);
            Console.WriteLine(hero.name);
            Console.WriteLine(hero.str);
            Console.WriteLine(hero.hp);
            Console.ReadLine();
        }
    }
}

internal class RpgCharacter
{
    internal readonly string name = ("Cloud strife");
    internal int str;
    internal int hp;

    internal RpgCharacter(int x, int y)
    {
        this.name = ("Cloud Strife");
        this.str = 999;
        this.hp = 9999;
        bullets = new List<Bullet>();
    }

    internal void Shoot()
    {
        bullets.Add(new Bullet(0, 1, 5.5f, 10));
    }
}

class Bullet
{
    private int damage;
    private float speed;
    private int dx, dy;

    internal Bullet(int damage, float speed, int dx, int dy)
    {
        this.damage = damage;
        this.speed = speed;
        this.dx = dx;
        this.dy = dy;
    }
}