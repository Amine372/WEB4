using Microsoft.AspNetCore.Mvc;

namespace quest_web_dotnet 
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        // Méthode pour répondre à /testSuccess avec un code HTTP 200 et le texte "success"
        [HttpGet("testSuccess")]
        public IActionResult TestSuccess()
        {
            return Ok("success"); // Retourne le code 200 avec le message "success"
        }

        // Méthode pour répondre à /testNotFound avec un code HTTP 404 et le texte "not found"
        [HttpGet("testNotFound")]
        public IActionResult TestNotFound()
        {
            return NotFound("not found"); // Retourne le code 404 avec le message "not found"
        }

        // Méthode pour répondre à /testError avec un code HTTP 500 et le texte "error"
        [HttpGet("testError")]
        public IActionResult TestError()
        {
            return StatusCode(500, "error"); // Retourne le code 500 avec le message "error"
        }
    }
}
