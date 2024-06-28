namespace PeaceApp.API.Citizen.Interfaces.REST.Resources;

public record CreateCitizenResource(string FirstName, string LastName, string Email, 
    string Password, string Address, string District, string City, string ProfileImage);