namespace ChatApp.Dtos
{
    public record MessageITem(Guid Id,
     string Name,
     string Message);

    public record CreatMessage(string Name,
        string Message);
}
