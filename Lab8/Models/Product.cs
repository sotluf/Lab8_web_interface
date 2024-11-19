namespace Lab8.Models;

public record Product : Model
{
    public required string Name { get; init; }

    public required decimal Price { get; init; }

    public required int Stock { get; init; }
}
