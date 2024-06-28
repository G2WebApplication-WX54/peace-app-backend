namespace PeaceApp.API.Organization.Domain.Model.Commands;

public record CreateOrganizationAccountCommand(
    string Name,
    string Email,
    string Password,
    string ContactNumber,
    string Address,
    string Description,
    string ProfileImage
    );