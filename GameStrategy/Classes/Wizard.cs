using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Wizard : Hero
    {
        public Wizard(string name, int levelPoints, int level, int power, int inteligence, int dexterity, int vitality, int starPoints, int health, int mana, int damage, int armor, int magicDamage, int magicDefense, int critChance, int critDamage) : base(name, levelPoints, level, power, inteligence, dexterity, vitality, starPoints, health, mana, damage, armor, magicDamage, magicDefense, critChance, critDamage)
        {
        }
    }
}
