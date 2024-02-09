using MongoDB.Driver;
using GameStrategy.Classes;
using System.Collections.Generic;
using MongoDB.Bson;
using System.Windows;

namespace GameStrategy
{
    public class CRUD
    {
        public static void CreateRogue(Rogue rogue)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            collection.InsertOne(rogue);
        }
        public static List<Hero> GetHero(string type)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            List<Hero> result = new List<Hero>();
            result = collection.Find(x => x._t == type).ToList();
            return result;
        }
        public static void UpdateRogue(Rogue rogue)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("StrategyGame");
            var collection = database.GetCollection<Hero>("HeroCollection");
            var filter = Builders<Hero>.Filter.Eq(i => i._id, rogue._id);
            collection.ReplaceOne(filter, rogue);
        }
    }
}