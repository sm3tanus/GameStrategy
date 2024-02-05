using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStrategy.Classes
{
    public class Hero
    {
        private string _name;
        private int _levelPoints;
        private int _level;
        private int _power;
        private int _inteligence;
        private int _dexterity;
        private int _vitality;
        private int _starPoints;
        private int _health;
        private int _mana;
        private int _damage;
        private int _armor;
        private int _magicDamage;
        private int _magicDefense;
        private int _critChanсe;
        private int _critDamage;


        public ObjectId _id;
        public string Name { get { return _name; } set { _name = value; } }
        public int LevelPoints { get { return _levelPoints; } set { _levelPoints = value; } }
        public int Level { get { return _level; } set { _level = value; } }
        public int Power { get { return _power; } set { _power = value; } }
        public int Inteligence { get { return _inteligence; } set { _inteligence = value; } }
        public int Dexterity { get { return _dexterity; } set { _dexterity = value; } }
        public int Vitality { get { return _vitality; } set { _vitality = value; } }
        public int StarPoints { get { return _starPoints; } set { _starPoints = value; } }
        public int Health { get { return _health; } set { _health = value; } }
        public int Mana { get { return _mana; } set { _mana = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public int Armor { get { return _armor; } set { _armor = value; } }
        public int MagicDamage { get { return _magicDamage; } set { _magicDamage = value; } }
        public int MagicDefense { get { return _magicDefense; } set { _magicDefense = value; } }
        public int CritChance { get { return _critChanсe; } set { _critChanсe = value; } }
        public int CritDamage { get { return _critDamage; } set { _critDamage = value; } }
        public Hero(string name, int levelPoints, int level, int power, int inteligence, int dexterity, int vitality, int starPoints, int health, int mana, int damage, int armor,
            int magicDamage, int magicDefense, int critChance, int critDamage)
        {
            _name = name;
            _level = level; 
            _power = power;
            _inteligence = inteligence;
            _dexterity = dexterity;
            _vitality = vitality;
            _starPoints = starPoints;
            _health = health;
            _mana = mana;
            _damage = damage;
            _armor = armor;
            _magicDamage = magicDamage;
            _magicDefense = magicDefense;
            _critChanсe = critChance;
            _critDamage = critDamage;
        }

        public Hero()
        {
        }

        public List<Hero> Heroes = new List<Hero>();

    }
}
