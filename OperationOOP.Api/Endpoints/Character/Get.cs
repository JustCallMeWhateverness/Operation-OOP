namespace OperationOOP.Api.Endpoints;
public class GetCharacter : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapGet("/characters/{id}", Handle)
        .WithSummary("Characters");

    public record Request(int Id);

    public record Response(
        int Id,
        string Name,
        int Level,
        int Health,
        int Attack,
        int Defense
    );

    private static Response Handle([AsParameters] Request request, IDatabase db)
    {
        var character = db.Characters.Find(character => character.Id == request.Id);
        //Check for if the chracter is null
        if (character == null)
        {
            //If character is not found
            throw new Exception("Character not found.");

        }

        var response = new Response(
            Id: character.Id,
            Name: character.Name,
            Level: character.Level,
            Health: character.Health,
            Attack: character.Attack,
            Defense: character.Defense
            );

        return response;
    }
}