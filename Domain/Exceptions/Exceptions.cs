namespace desenroleApi.Domain.Exceptions;

public class BasicException : Exception
{
    public int Code { get; set; }
    public int Number { get; set; } = 0;
    public Exception? Ex { get; set; }

    public BasicException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message)
    {
        Number = errorNumber;
    }

    public BasicException(string message, int errorNumber = 0, bool isDefaultMessage = false, Exception? ex = null) : base(message)
    {
        Number = errorNumber;
        Ex = ex;
    }
}

public class NotFoundException : BasicException
{
    public NotFoundException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 404;
    }
}

public class BadRequestException : BasicException
{
    public IList<string> Messages { get; set; }

    public BadRequestException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 400;
        Messages = [message];
    }

    public BadRequestException(string message, Exception ex, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage, ex)
    {
        Code = 400;
        Messages = [message];
    }

    public BadRequestException(IList<string> messages, int errorNumber = 0, bool isDefaultMessage = false) : base(string.Join("<br/>", messages), errorNumber, isDefaultMessage)
    {
        Code = 400;
        Messages = messages;
    }

    public BadRequestException(IList<string> messages, Exception ex, int errorNumber = 0, bool isDefaultMessage = false) : base(string.Join("<br/>", messages), errorNumber, isDefaultMessage, ex)
    {
        Code = 400;
        Messages = messages;
    }
}

public class ConflictException : BasicException
{
    public ConflictException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 409;
    }
}

public class NotAcceptableException : BasicException
{
    public NotAcceptableException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 406;
    }
}

public class NotAuthorizedException : BasicException
{
    public NotAuthorizedException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 401;
    }
}

public class ForbiddenException : BasicException
{
    public ForbiddenException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 403;
    }
}

public class RequestTimeoutException : BasicException
{
    public RequestTimeoutException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 408;
    }
}

public class UnsupportedMediaTypeException : BasicException
{
    public UnsupportedMediaTypeException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 415;
    }
}

public class InternalServerError : BasicException
{
    public InternalServerError(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 500;
    }
}

public class GatewayTimeoutException : BasicException
{
    public GatewayTimeoutException(string message, int errorNumber = 0, bool isDefaultMessage = false) : base(message, errorNumber, isDefaultMessage)
    {
        Code = 504;
    }
}

