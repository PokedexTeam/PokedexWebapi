namespace Pokedex.Webapi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pokedex.Repositories.Models;
    using Pokedex.Repositories.Repositories;
    using System.Collections.Generic;

    [Route("[controller]")]
    public class PokemonSkillController : Controller
    {
        private PokemonSkillRepository Repository;

        public PokemonSkillController(PokemonSkillRepository repository)
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
        public IActionResult Post([FromBody]List<PokemonSkill> values)
        {
            values.ForEach(x => Repository.Insert(x));
            return new OkObjectResult(values);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody]List<PokemonSkill> values)
        {
            values.ForEach(x => Repository.Update(x));
            return new OkObjectResult(values);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var skill = Repository.Get(id).Result;
            Repository.Delete(skill);
            return new OkResult();
        }
    }
}
