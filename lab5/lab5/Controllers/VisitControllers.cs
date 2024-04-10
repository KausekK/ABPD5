using lab5.Database;
using lab5.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab5.Controllers;
[ApiController]
[Route("/controller/visits")]
public class VisitControllers : ControllerBase
{
    private readonly MockDb _mockDb;

    public VisitControllers(MockDb mockDb)
    {
        _mockDb = mockDb;
    }

    [HttpGet("{id}")]
    public ActionResult<IEnumerable<Visit>> getVisitsForAnimal(int id)
    {
        var animal = _mockDb.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound();
        }
        return Ok(animal.Visits);
    }

    [HttpPost("{id}")]
    public ActionResult<Visit> AddVisitForAnimal(int id, Visit visit)
    {
        var animal = _mockDb.Animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound();
        }
        visit.Id = animal.Visits.Count + 1;
        animal.Visits.Add(visit);
        return Created();
    }
}