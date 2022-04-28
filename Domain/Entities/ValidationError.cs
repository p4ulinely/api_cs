namespace api.Domain.Entities;

public class ValidationError
{
    public int Code { get; private set; }
    public string Message { get; private set; }

    public ValidationError(int code, string message)
    {
        Code = code;
        Message = message;
    }

    public ValidationError(string message)
    {
        Code = 0;
        Message = message;
    }
}