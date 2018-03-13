namespace pokedex.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using pokedex.Models;
    using pokedex.Repositories;
    using System.Collections.Generic;

    [Route("[controller]")]
    public class PokemonController : Controller
    {
        private PokemonRepository PokemonRepository;

        public PokemonController(PokemonRepository pokemonRepository)
        {
            PokemonRepository = pokemonRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Json(PokemonRepository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(PokemonRepository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]List<Pokemon> values)
        {
            values.ForEach(x => PokemonRepository.Insert(x));
            return new OkObjectResult(values);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody]List<Pokemon> values)
        {
            values.ForEach(x => PokemonRepository.Update(x));
            return new OkObjectResult(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pokemon = PokemonRepository.Get(id).Result;
            PokemonRepository.Delete(pokemon);
            return new OkResult();
        }
    }
}
