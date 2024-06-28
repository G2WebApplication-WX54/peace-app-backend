namespace PeaceApp.API.Citizen.Interfaces.REST.Resources;

public record CitizenResource(int Id, string FullName, string Email, string Password,
    string Address, string District, string City, string ProfileImage);