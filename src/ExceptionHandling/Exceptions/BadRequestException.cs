namespace NightCloud.Common.Middlewares.ExceptionHandling.Exceptions;

public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {
        
    }
}