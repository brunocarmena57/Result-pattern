using Bruno57.ResultPattern.Foundations.Enums;

namespace Bruno57.ResultPattern.Foundations;

public class ValidationError
{
    internal ValidationError(string errorMessage, string errorCode, ValidationErrorType validationError)
    {
        ErrorMessage = errorMessage;
        ErrorCode = errorCode;
        ValidationErrorType = validationError;
    }

    public string? ErrorMessage { get; init; }
    public string? ErrorCode { get; init; }
    public ValidationErrorType ValidationErrorType { get; init; }
}
