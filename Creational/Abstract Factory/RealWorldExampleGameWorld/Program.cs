// Abstract Factory: Declares creation methods for abstract products
abstract class GameWorldFactory
{
    public abstract Hero CreateHero();
    public abstract Weapon CreateWeapon();
}

// Abstract Product A
abstract class Hero
{
    public abstract void Attack(Weapon weapon);
}

// Abstract Product B
abstract class Weapon
{
    public abstract string GetName();
}

// Concrete Factory
class MedievalFactory : GameWorldFactory
{
    public override Hero CreateHero() => new Knight();
    public override Weapon CreateWeapon() => new Sword();
}

// Concrete Product A
class Knight : Hero
{
    public override void Attack(Weapon weapon)
    {
        Console.WriteLine($"Knight charges with {weapon.GetName()}!");
    }
}

// Concrete Product B
class Sword : Weapon
{
    public override string GetName() => "Steel Sword";
}

class SciFiFactory : GameWorldFactory
{
    public override Hero CreateHero() => new SpaceSoldier();
    public override Weapon CreateWeapon() => new LaserGun();
}

class SpaceSoldier : Hero
{
    public override void Attack(Weapon weapon)
    {
        Console.WriteLine($"Space Soldier fires {weapon.GetName()}!");
    }
}

class LaserGun : Weapon
{
    public override string GetName() => "Laser Gun";
}

class FantasyFactory : GameWorldFactory
{
    public override Hero CreateHero() => new Wizard();
    public override Weapon CreateWeapon() => new MagicStaff();
}

class Wizard : Hero
{
    public override void Attack(Weapon weapon)
    {
        Console.WriteLine($"Wizard casts a spell using {weapon.GetName()}!");
    }
}

class MagicStaff : Weapon
{
    public override string GetName() => "Magic Staff";
}

class ZombieFactory : GameWorldFactory
{
    public override Hero CreateHero() => new Survivor();
    public override Weapon CreateWeapon() => new Shotgun();
}

class Survivor : Hero
{
    public override void Attack(Weapon weapon)
    {
        Console.WriteLine($"Survivor blasts zombies with {weapon.GetName()}!");
    }
}

class Shotgun : Weapon
{
    public override string GetName() => "Double-Barrel Shotgun";
}

// Client: Uses only abstract types (Hero & Weapon) from abstract factory
class Game
{
    private Hero _hero;
    private Weapon _weapon;

    public Game(GameWorldFactory factory)
    {
        _hero = factory.CreateHero();
        _weapon = factory.CreateWeapon();
    }

    public void Play()
    {
        _hero.Attack(_weapon);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(" Medieval World:");
        var medievalGame = new Game(new MedievalFactory());
        medievalGame.Play();

        Console.WriteLine("\n Sci-Fi World:");
        var sciFiGame = new Game(new SciFiFactory());
        sciFiGame.Play();

        Console.WriteLine("\n Fantasy World:");
        var fantasyGame = new Game(new FantasyFactory());
        fantasyGame.Play();

        Console.WriteLine("\n Zombie World:");
        var zombieGame = new Game(new ZombieFactory());
        zombieGame.Play();

        Console.ReadKey();
    }
}