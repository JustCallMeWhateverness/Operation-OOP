namespace OperationOOP.Api.Endpoints;
public class GetAllCharacters : IEndpoint
{
    // Mapping
    public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapGet("/character", Handle)
        .WithSummary("Get all characters");

    // Request and Response types
    public record Response(
        int Id,
        string Name,
        string Type,
        int Level,
        int Health,
        int Attack,
        int Defense
    );

    //Logic
    private static List<Response> Handle(IDatabase db)
    {
        return db.Characters
            .Select(character => new Response(
                Id: character.Id,
                Name: character.Name,
                Type: character.GetType().Name,
                Level: character.Level,
                Health: character.Health,
                Attack: character.Attack,
                Defense: character.Defense
            )).ToList();
    }
}