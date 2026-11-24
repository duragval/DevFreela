using DevFreelaAPI.Models;
using DevFreelaAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreelaAPI.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly FreelanceCostConfig _config;
        private readonly IConfigService _configService;

        public ProjectsController(IOptions<FreelanceCostConfig> options, IConfigService configService) // Recebe as configurações através da injeção de dependência (IOptions).
        {
            _config = options.Value; // Obtém os valores configurados no appsettings.json.
            _configService = configService;
        }

        // GET api/projects/search=crm
        [HttpGet]
        public IActionResult Get(string search = "")
        {
            return Ok(_configService.GetValue());
        }

        // GET api/projects/123
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new Exception();

            return Ok();
        }

        // POST api/projects
        [HttpPost]
        public IActionResult Post(CreatePjtInputModel model)
        {
            if (model.TotalCost < _config.Min || model.TotalCost > _config.Max)
            {
                return BadRequest("Valor fora dos limites!");
            }

            return CreatedAtAction(nameof(GetById), new {id = 1}, model);
        }

        // PUT api/projects
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdatePjtInputModel model)
        {
            return NoContent();
        }

        // DELETE api/projects/123
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        // PUT api/projects/123/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        // PUT api/projects/123/complete
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }

        // PUT api/projects/123/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreatePjtCommentInputModel model)
        {
            return Ok();
        }
    }
}