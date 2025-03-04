namespace OperationOOP.Api.Endpoints;

public class FilterCharacters : IEndpoint
{
    public static void MapEndpoint(IEndpointRouteBuilder app) => app
        .MapGet("/characters/filter/{type}", (string type, IDatabase db) =>
        {
            var filteredCharacters = type.ToLower() switch
            {
                "warrior" => db.Characters.Where(c => c is Warrior).ToList(),
                "mage" => db.Characters.Where(c => c is Mage).ToList(),
                "archer" => db.Characters.Where(c => c is Archer).ToList(),
                _ => new List<Character>()
            };

            return filteredCharacters.Any()
                ? Results.Ok(filteredCharacters)
                : Results.NotFound($"No characters found for type '{type}'");
        })
        .WithSummary("Filter characters by predefined types (warrior, mage, archer)");
}