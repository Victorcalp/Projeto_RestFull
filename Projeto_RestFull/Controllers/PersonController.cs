using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_RestFull.Model;
using Projeto_RestFull.Business;
using Projeto_RestFull.Data.VO;

namespace Projeto_RestFull.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personBusiness;

        public PersonController(ILogger<PersonController> logger, IPersonBusiness person)
        {
            _logger = logger;
            _personBusiness = person;
        }

        [HttpGet]
        public IActionResult FiendAll()
        {
            var result = _personBusiness.FiendAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult FiendById(int id)
        {
            var result = _personBusiness.FiendByID(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] PersonVO person)
        {
            if (person == null) return BadRequest();
            var result = _personBusiness.Create(person);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] PersonVO person)
        {
            if (person == null) return BadRequest();
            var result = _personBusiness.Update(person);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
