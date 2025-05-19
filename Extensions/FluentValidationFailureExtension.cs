using FluentValidation.Results;
using Bruno57.ResultPattern.Foundations.Enums;

namespace Bruno57.ResultPattern.Foundations.Extensions;

/// <summary>
/// Fluent Validation Result extension to populate Validation Error collection
/// </summary>
public static class FluentValidationFailureExtension
{
    public static IEnumerable<ValidationError> PopulateValidationErrors(this ValidationResult? input)
    {
        return input is null ? [] : input.Errors.Select(x => new ValidationError(x.ErrorMessage, x.ErrorCode, (ValidationErrorType)x.Severity));
    }
}
