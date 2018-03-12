namespace Pokedex.Webapi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pokedex.Repositories;
    using Pokedex.Repositories.Models;
    using System.Collections.Generic;

    [Route("[controller]")]
    public class PokemonController : Controller
    {

        private PokedexContext Db;

        public PokemonController(PokedexContext db)
        {
            Db = db;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            // var pokemonFacade = new PokemonFacade(Db);
            //return Json(pokemonFacade.GetAll());

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //var pokemonFacade = new PokemonFacade(Db);
            //return Json(pokemonFacade.Get(id));

            return Ok();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]List<Pokemon> values)
        {
            //var pokemonFacade = new PokemonFacade(Db);
            //pokemonFacade.Insert(values);
            //return new OkObjectResult(values);

            return Ok();
        }

        [HttpPatch]
        public IActionResult Patch([FromBody]List<Pokemon> values)
        {
            //var pokemonFacade = new PokemonFacade(Db);
            //pokemonFacade.Update(values);
            //return new OkObjectResult(values);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //var pokemonFacade = new PokemonFacade(Db);
            //pokemonFacade.Delete(id);
            return new OkResult();
        }
    }
}
