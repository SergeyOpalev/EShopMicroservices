namespace BuildingBlocks.Exceptions;

public class InternalServerException(string message, string details) : Exception(message)
{
    public string? Details { get; } = details;
}