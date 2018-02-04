namespace Pokedex.Webapi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pokedex.Facades;
    using Pokedex.Repositories;
    using Pokedex.Repositories.Models;
    using Pokedex.Webapi.Models;
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
            var pokemonFacade = new PokemonFacade(Db);
            return Json(pokemonFacade.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pokemonFacade = new PokemonFacade(Db);
            return Json(pokemonFacade.Get(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]List<PokemonResponse> values)
        {
            var pokemonFacade = new PokemonFacade(Db);
            pokemonFacade.Insert(values);
            return new OkObjectResult(values);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody]List<PokemonResponse> values)
        {
            var pokemonFacade = new PokemonFacade(Db);
            pokemonFacade.Update(values);
            return new OkObjectResult(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pokemonFacade = new PokemonFacade(Db);
            pokemonFacade.Delete(id);
            return new OkResult();
        }
    }
}
