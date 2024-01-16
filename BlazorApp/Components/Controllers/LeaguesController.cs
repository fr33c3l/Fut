using Microsoft.AspNetCore.Mvc;
using BlazorApp.Data;
using MongoDB.Driver;


namespace BlazorApp.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class LeaguesController : Controller {
        private readonly MongoDBContext _context;

        public LeaguesController(MongoDBContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<LeagueModel>> Get() {
            //var filter = Builders<LeagueModel>.Filter.Eq("seasons.year", 2023);
            var filter = Builders<LeagueModel>.Filter.Eq("league.id", 933);
            var projection = Builders<LeagueModel>.Projection
                .Exclude("seasons.coverage");

            return await _context.Leagues.Find(filter).Project<LeagueModel>(projection).ToListAsync();

            //return await _context.Leagues.Find(_ => true).Project<LeagueModel>(projection).ToListAsync();
        }
    }
}
