﻿using MongoDB.Driver;
using GameStrategy.Classes;
using System.Collections.Generic;

namespace GameStrategy
{
    public class CRUD
    {
        public static void CreateHero(Hero hero)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            collection.InsertOne(hero);
        }
        public static List<Hero> GetHero() 
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            List<Hero> result = new List<Hero>();
            result = collection.Find(x => true).ToList();
            return result;
        }
    }
}