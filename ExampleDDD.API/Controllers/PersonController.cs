using ExampleDDD.API.ApplicationServices;
using ExampleDDD.API.Comands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleDDD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ExampleServices exampleServices;

        public PersonController(ExampleServices exampleServices)
        {
            this.exampleServices = exampleServices;
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson(CreatePersonComand createPersonComand)
        {
            await exampleServices.HandlerComand(createPersonComand);
            return Ok(createPersonComand);
        }
        [HttpGet ("{id}")]
        public async Task<IActionResult> GetPerson(Guid id)
        {
            var response = await exampleServices.GetPerson(id);
            return Ok(response);
        }
    }
}
