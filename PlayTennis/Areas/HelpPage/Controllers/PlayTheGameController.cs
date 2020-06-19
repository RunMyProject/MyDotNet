using PlayTennis.Areas.HelpPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlayTennis.Areas.HelpPage.Controllers
{
    public class PlayTheGameController : ApiController
    {
        // GET: api/PlayTheGame
        public IEnumerable<string> Get()
        {
            GameModel gameModel = new GameModel();
            return gameModel.GetPlayTheGame();
        }

        // GET: api/PlayTheGame/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PlayTheGame
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PlayTheGame/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PlayTheGame/5
        public void Delete(int id)
        {
        }
    }
}
