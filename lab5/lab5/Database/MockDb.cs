using lab5.Models;

namespace lab5.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();


    public MockDb()
    {
        Animals.Add(new Animal { Id = 1, Name = "Pikachu", Category = "Elektryczny", HairColor = "Żółty", Weight = 30});
        Animals.Add(new Animal { Id = 2, Name = "Bulbasaur", Category = "Trawa", HairColor = "Zielony", Weight = 20});
        Animals.Add(new Animal { Id = 3, Name = "Charmander", Category = "Ogień", HairColor = "Pomarańczowy", Weight = 10});
        
        Animals.Add(new Animal());
        Animals[0].Visits.Add(new Visit { Id = 1, VisitDate = DateTime.Now.AddDays(-10), visitDescription = "Badanie ogólne", VisitRating = 5 });
        Animals[0].Visits.Add(new Visit { Id = 2, VisitDate = DateTime.Now.AddDays(-5), visitDescription = "Szczepienie", VisitRating = 3 });

        Animals[1].Visits.Add(new Visit { Id = 1, VisitDate = DateTime.Now.AddDays(-15), visitDescription = "Badanie ogólne", VisitRating = 5 });
        Animals[1].Visits.Add(new Visit { Id = 2, VisitDate = DateTime.Now.AddDays(-10), visitDescription = "Szczepienie", VisitRating = 3 });

        Animals[2].Visits.Add(new Visit { Id = 1, VisitDate = DateTime.Now.AddDays(-20), visitDescription = "Badanie ogólne", VisitRating = 5 });
        Animals[2].Visits.Add(new Visit { Id = 2, VisitDate = DateTime.Now.AddDays(-15), visitDescription = "Szczepienie", VisitRating = 4 });

    }
    
}