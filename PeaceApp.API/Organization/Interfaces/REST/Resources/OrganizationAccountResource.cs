namespace PeaceApp.API.Organization.Interfaces.REST.Resources;

public record OrganizationAccountResource(int Id, string Name,
    string Email, string Password, string ContactNumber, string Address, string Description, string ProfileImage);