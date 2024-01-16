using MongoDB.Bson.Serialization.Attributes;

namespace BlazorApp.Data {
    [BsonIgnoreExtraElements]
    public class PlayersModel {
        public int user_id { get; set; }
        public string date { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string description { get; set; }
        public string bg_color { get; set; }
        public string avatar { get; set; }
    }
}
