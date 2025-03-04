namespace OperationOOP.Api.Endpoints;
public class Createcharacter : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapPost("/Characters", Handle)
        .WithSummary("Create new character");

    public record Request(
  int Id,
        string Name,
        string Type,
        int Level
        
        );
    public record Response(int id);

    private static Ok<Response> Handle(Request request, IDatabase db)
    {
        Character character;

        switch (request.Type.ToLower())
        {
            case "warrior":
                character = new Warrior(db.Characters.Count + 1, request.Name, request.Level);
                break;
            case "mage":
                character = new Mage(db.Characters.Count + 1, request.Name, request.Level);
                break;
            case "archer":
                character = new Archer(db.Characters.Count + 1, request.Name, request.Level);
                break;
            default:
                throw new Exception("Invalid character type!");
        }

        db.Characters.Add(character);

        return TypedResults.Ok(new Response(character.Id));
    }
}