using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddProblemDetails();
var app = builder.Build();
app.UseExceptionHandler();
app.UseHttpsRedirection();
// Deliberately a stateless, anonymous demo. Production needs identity, authorization,
// rate limits, durable storage, audit controls, and a reviewed data retention policy.
app.MapPost("/api/demo/requests/validate", (AssistanceRequest request) =>
{
    var errors = new Dictionary<string, string[]>();
    if (string.IsNullOrWhiteSpace(request.FullName) || request.FullName.Length > 100)
        errors["fullName"] = ["Enter a full name of 1 to 100 characters."];
    if (string.IsNullOrWhiteSpace(request.Email) || request.Email.Length > 254 ||
        !new EmailAddressAttribute().IsValid(request.Email))
        errors["email"] = ["Enter a valid email address of at most 254 characters."];
    if (request.Program is not ("housing" or "utilities" or "general"))
        errors["program"] = ["Choose housing, utilities, or general."];
    if (errors.Count > 0) return Results.ValidationProblem(errors);
    // Do not log request bodies, fabricate a persisted record, or return personal data.
    return Results.Ok(new { valid = true, persisted = false, message = "Demo validation passed. No data stored." });
})
.Accepts<AssistanceRequest>("application/json")
.Produces(StatusCodes.Status200OK)
.ProducesValidationProblem()
.WithName("ValidateDemoRequest");
app.MapGet("/health", () => Results.Ok(new { status = "ok" }));
app.Run();
public sealed record AssistanceRequest(string? FullName, string? Email, string? Program);
