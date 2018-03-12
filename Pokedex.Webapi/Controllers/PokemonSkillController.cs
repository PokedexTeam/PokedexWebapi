namespace Pokedex.Webapi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pokedex.Repositories;
    using Pokedex.Repositories.Models;
    using System.Collections.Generic;

    [Route("[controller]")]
    public class PokemonSkillController : Controller
    {

        private PokedexContext Db;

        public PokemonSkillController(PokedexContext db)
        {
            Db = db;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            //var pokemonSkillFacade = new PokemonSkillFacade(Db);
            //return Json(pokemonSkillFacade.GetAll());

            return new OkResult();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //var pokemonSkillFacade = new PokemonSkillFacade(Db);
            //return Json(pokemonSkillFacade.Get(id));

            return new OkResult();
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]List<PokemonSkill> values)
        {
            //var pokemonSkillFacade = new PokemonSkillFacade(Db);
            //pokemonSkillFacade.Insert(values);
            //return new OkObjectResult(values);

            return new OkResult();
        }

        [HttpPatch]
        public IActionResult Patch([FromBody]List<PokemonSkill> values)
        {
            //var pokemonSkillFacade = new PokemonSkillFacade(Db);
            //pokemonSkillFacade.Update(values);
            //return new OkObjectResult(values);

            return new OkResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //var pokemonSkillFacade = new PokemonSkillFacade(Db);
            //pokemonSkillFacade.Delete(id);
            return new OkResult();
        }
    }
}
