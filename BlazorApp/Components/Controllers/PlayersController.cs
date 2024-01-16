using Microsoft.AspNetCore.Mvc;
using BlazorApp.Data;
using MongoDB.Driver;


namespace BlazorApp.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : Controller {
        private readonly MongoDBContext _context;

        public PlayersController(MongoDBContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<PlayersModel>> Get() {
            return await _context.Players.Find(_ => true).ToListAsync();
        }

		[HttpPost]
		public async Task Post([FromBody] PlayersModel newPlayer) {
			PlayersModel playersModel = new PlayersModel {
				name = "Dupa",
				surname = "Blada",
				date = new DateTime().ToString(),
				avatar = "QWE",
				description = "Description",
				user_id = 1,
				bg_color = "QWE"

			};


			await _context.Players.InsertOneAsync(playersModel);
			return;
		}
	}


}
