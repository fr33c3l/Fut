using BlazorApp.Data;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace BlazorApp.Data {
    public class MongoDBContext {
        private readonly IMongoDatabase _database;

        public MongoDBContext(string connectionString, string databaseName) {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }
        public IMongoCollection<PlayersModel> Players => _database.GetCollection<PlayersModel>("Players");
        public IMongoCollection<LeagueModel> Leagues => _database.GetCollection<LeagueModel>("Leagues");
        public IMongoCollection<FixtureModel> Fixtures => _database.GetCollection<FixtureModel>("Fixtures");
        public IMongoCollection<BetsModel> Bets => _database.GetCollection<BetsModel>("Bets");
    }
}
