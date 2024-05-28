using GameAbstract;

class Program
{
    static void Main(string[] args)
    {
        List<Monster> monsters = new List<Monster>();
        {
            monsters.Add(new Orc());
            monsters.Add(new Goblin());
            monsters.Add(new Dragon());
        }

        Random random = new Random();

        Monster monster = monsters[random.Next(monsters.Count)];

        Hero hero = new Hero(120, 25);

        while(hero.hp > 0 && monster.hp > 0)
        {
            hero.Attack(monster);

            if (monster.hp <= 0)
            {
                Console.WriteLine("Герой переміг! ");
                break;
            }

            monster.Attack(hero);

            if (hero.hp <= 0)
            {
                Console.WriteLine($"{monster.name} переміг! ");
                break;
            }
        }
    }
}