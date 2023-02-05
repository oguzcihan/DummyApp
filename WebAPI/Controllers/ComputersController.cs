using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Middlewares;

namespace WebAPI.Controllers
{
    [LogFilter]
    [Route("[controller]")]
    [ApiController]
    public class ComputersController : ControllerBase
    {
        private readonly IComputerService _computerService;
        public ComputersController(IComputerService computerService)
        {
            _computerService = computerService;
        }


        [HttpGet]
        public IActionResult GetList()
        {
            var result = _computerService.GetList();
            return result.Success ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Computer computer)
        {
            var result = _computerService.Add(computer);
            return result.Success ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Computer computer)
        {
            var result = _computerService.Update(computer);
            return result.Success ? Ok(result.Message) : BadRequest(result.Message);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var result = _computerService.GetById(id);
            return result.Success ? Ok(result.Data) : NotFound(result.Message);
        }
    }
}
