using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_RestFull.Business;
using Projeto_RestFull.Data.VO;

namespace Projeto_RestFull.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookBusiness _bookBusiness;
        public BookController(ILogger<BookController> logger, IBookBusiness bookBusiness)
        {
            _logger = logger;
            _bookBusiness = bookBusiness;
        }

        [HttpPost]
        public IActionResult Create([FromBody] BookVO book)
        {
            var result = _bookBusiness.Create(book);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update([FromBody] BookVO book)
        {
            var result = _bookBusiness.Update(book);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookBusiness.Delete(id);
            return NoContent();
        }

        [HttpGet]
        public IActionResult FiendAll()
        {
            return Ok(_bookBusiness.FiendAll());
        }

        [HttpGet("{id}")]
        public IActionResult FiendById(long id)
        {
            return Ok(_bookBusiness.FiendByID(id));
        }
    }
}
