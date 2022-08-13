using CircleGame.Business.Abstract;
using CircleGame.Business.Concrete;
using CircleGame.WebAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CircleGame.WebAPI.Controllers
{
    public class GameController : ApiController
    {
        private IGameManager _gameManager ;

        public GameController(IGameManager gameManager)
        {
            _gameManager = gameManager;
        }

        [HttpGet]
        public IHttpActionResult PlayerNumber(int count)
        {
            if(count < 2)
            {
                return BadRequest("Oyuncu Sayısı Minimum 2 Olmalıdır.");
            }
            return Ok(_gameManager.LastPlayerNumber(count));
        }

        [HttpGet]
        public IHttpActionResult PlayerNumber()
        {
            return BadRequest("Lütfen Oyuncu Sayısı Belirtiniz!");
        }
    }
}
