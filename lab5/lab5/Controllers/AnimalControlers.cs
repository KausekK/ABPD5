using Microsoft.AspNetCore.Mvc;

namespace lab5.Controllers;

[ApiController]
[Route("/controller/animals")]
    public class AnimalControlers : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}