using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_RestFull.Business;
using Projeto_RestFull.Model;

namespace Projeto_RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPerson _person;

        public PersonController(ILogger<PersonController> logger, IPerson person)
        {
            _logger = logger;
            _person = person;
        }

        [HttpGet]
        public IActionResult FiendAll()
        {
            var result = _person.FiendAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult FiendById(int id)
        {
            var result = _person.FiendByID(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            var result = _person.Create(person);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Person person)
        {
            if (person == null) return BadRequest();
            var result = _person.Update(person);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _person.Delete(id);
            return NoContent();
        }
    }
}
