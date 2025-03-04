namespace OperationOOP.Api.Endpoints
{
    public class CreateEquipment : IEndpoint
    {
        public static void MapEndpoint(IEndpointRouteBuilder app) => app
            .MapPost("/equipment", Handle)
            .WithSummary("Create new equipment");

        public record Request(
            int Id,
            string Name,
            string Classification
        );

        public record Response(int Id);

        private static IResult Handle(Request request, IDatabase db)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
                return Results.BadRequest("Name cannot be empty."); // Check for empty name

            if (string.IsNullOrWhiteSpace(request.Classification))
                return Results.BadRequest("Classification cannot be empty."); // Check for empty classification

            var equipment = new Equipment(db.Equipments.Count + 1, request.Name, request.Classification);

            db.Equipments.Add(equipment);

            return Results.Ok(new Response(equipment.Id));
        }
    }
}