using lab5.Database;

namespace lab5.Endpoints;

public static class AnimalEndpoints 
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        var animal = StaticData.animals;
        app.MapGet("/animals/{id}", (int id) => Results.Ok(animal));

        app.MapPost("/animals", () => Results.Created("", animal));
    }
}