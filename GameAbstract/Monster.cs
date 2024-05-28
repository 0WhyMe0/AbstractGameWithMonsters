using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAbstract
{
    abstract class Monster
    {
        public string name;
        public int hp;
        public int damage;

        public Monster(string name, int hp, int damage)
        {
            this.name = name;
            this.hp = hp;   
            this.damage = damage;
        }

        public void Attack(Hero target)
        {
            target.hp -= damage;
            Console.WriteLine($"{name} наніс урон герою ");
        }
    }
}
