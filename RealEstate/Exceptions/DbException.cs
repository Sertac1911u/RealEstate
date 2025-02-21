namespace RealEstate.Exceptions;

public class DbException
{
    public class NotFoundException(string message) : Exception(message);
    
    public class DuplicateException(string message) : Exception(message);
    
    public class InvalidException(string message) : Exception(message);
    
    public class UnauthorizedException(string message) : Exception(message);
    
    public class ForbiddenException(string message) : Exception(message);
    
    public class InternalException(string message) : Exception(message);
}