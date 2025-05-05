namespace BuildingBlocks.Exceptions;

public class BadRequestException(string message, string details) : Exception(message)
{
    public string? Details { get; } = details;
}