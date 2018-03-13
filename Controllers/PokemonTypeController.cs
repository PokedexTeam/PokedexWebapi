namespace pokedex.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using pokedex.Models;
    using pokedex.Repositories;
    using System.Collections.Generic;

    [Route("[controller]")]
    public class PokemonTypeController : Controller
    {
        private PokemonTypeRepository Repository;

        public PokemonTypeController(PokemonTypeRepository repository)
        {
            Repository = repository;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Json(Repository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(Repository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]List<PokemonType> values)
        {
            values.ForEach(x => Repository.Insert(x));
            return new OkObjectResult(values);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody]List<PokemonType> values)
        {
            values.ForEach(x => Repository.Update(x));
            return new OkObjectResult(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var type = Repository.Get(id).Result;
            Repository.Delete(type);
            return new OkResult();
        }
    }
}
