namespace Pokedex.Webapi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pokedex.Facades;
    using Pokedex.Repositories;
    using Pokedex.Repositories.Models;
    using System.Collections.Generic;

    [Route("[controller]")]
    public class PokemonTypeController : Controller
    {

        private PokedexContext Db;

        public PokemonTypeController(PokedexContext db)
        {
            Db = db;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var pokemonTypeFacade = new PokemonTypeFacade(Db);
            return Json(pokemonTypeFacade.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pokemonTypeFacade = new PokemonTypeFacade(Db);
            return Json(pokemonTypeFacade.Get(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]List<PokemonType> values)
        {
            var pokemonTypeFacade = new PokemonTypeFacade(Db);
            pokemonTypeFacade.Insert(values);
            return new OkObjectResult(values);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody]List<PokemonType> values)
        {
            var pokemonTypeFacade = new PokemonTypeFacade(Db);
            pokemonTypeFacade.Update(values);
            return new OkObjectResult(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pokemonTypeFacade = new PokemonTypeFacade(Db);
            pokemonTypeFacade.Delete(id);
            return new OkResult();
        }
    }
}
