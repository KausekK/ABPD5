using System.Data;
using lab5.Database;
using lab5.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab5.Controllers;

[ApiController]
[Route("/controller/animals")]
    public class AnimalControllers : ControllerBase
    {

        private readonly MockDb _mockDb;

        public AnimalControllers(MockDb mockDb)
        {
            _mockDb = mockDb;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> GetAnimals()
        {
            return Ok(_mockDb.Animals);
        }
        
    [HttpPost]
    public IActionResult AddAnimals(Animal animal)
    {
        _mockDb.Animals.Add(animal);
        return Created();
        
    }
    
    [HttpGet("{id}")]
    public ActionResult<IEnumerable<Animal>> GetAnimal(int id)
    {
        var animal = _mockDb.Animals.FirstOrDefault(i => i.Id == id);
        if (animal == null)
        {
            return NotFound();
        }
    
        animal.Visits = _mockDb.Visits.Where(v => v.Animal.Id == id).ToList();
    
        return Ok(animal);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    { 
        if (id != animal.Id)
        {
            return BadRequest();
        }
        
        var animalToUpdate = _mockDb.Animals.Find(i => i.Id == id);
        if (animalToUpdate == null)
        {
            return NotFound();
        }
        
        animalToUpdate.Name = animal.Name;
        animalToUpdate.Category = animal.Category;
        animalToUpdate.Weight = animal.Weight;
        animalToUpdate.HairColor = animal.HairColor;
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = _mockDb.Animals.Find(i => i.Id == id);
        if (animal == null)
        {
            return NotFound();
        }

        _mockDb.Animals.Remove(animal);
        return NoContent();
    }
  
    
    }