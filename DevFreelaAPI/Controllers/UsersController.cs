using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreelaAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut("{id}/profile-pic")]
        public IActionResult PostProfilePic(IFormFile file)
        {
            var descricao = $"Arquivo: {file.FileName}, Tamanho: {file.Length}";
            return Ok(descricao);
        }
    }
}
