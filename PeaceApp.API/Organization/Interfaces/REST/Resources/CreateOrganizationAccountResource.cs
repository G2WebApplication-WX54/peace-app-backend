namespace PeaceApp.API.Organization.Interfaces.REST.Resources;

public record CreateOrganizationAccountResource(
    string Name, string Email, string Password, string ContactNumber, string Address, string Description, string ProfileImage
    );