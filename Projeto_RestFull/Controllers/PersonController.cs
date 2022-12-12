using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_RestFull.Business;
using Projeto_RestFull.Business.Implementations;
using Projeto_RestFull.Model;
using Projeto_RestFull.Model.Context;

namespace Projeto_RestFull.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPerson _person;

        public PersonController(IPerson person)
        {
            _person = person;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _person.FiendAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var result = _person.FiendByID(id);
            return Ok(result);
        }
    }
}
