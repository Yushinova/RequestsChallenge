namespace RequestsChallenge.Api
{
    public record StringMessage(string Message);

    // ErrorMessage - сообщение с ошибкой
    public record ErrorMessage(string Type, string Message);
}
