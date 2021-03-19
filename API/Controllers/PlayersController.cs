using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PlayersController : BaseApiController
    {
        [HttpGet]
        public string GetPlayers()
        {
            return "This will return players";
        }

    }
}