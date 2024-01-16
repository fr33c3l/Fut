using MongoDB.Bson.Serialization.Attributes;

namespace BlazorApp.Data {
    [BsonIgnoreExtraElements]
    public class BetsModel {
        public DateTime date { get; set; }
        public int user_id { get; set; }
        public int fixture_id { get; set; }
        public int home_id { get; set; }
        public int home_goals { get; set; }
        public int away_id { get; set; }
        public int away_goals { get; set; }
    }
}
