using PeaceApp.API.Citizen.Domain.Model.Commands;
using PeaceApp.API.Citizen.Interfaces.REST.Resources;

namespace PeaceApp.API.Citizen.Interfaces.REST.Transform;

public static class CreateCitizenCommandFromResourceAssembler
{
    public static CreateCitizenAccountCommand ToCommandFromResource(CreateCitizenResource resource)
    {
        return new CreateCitizenAccountCommand(resource.FirstName, resource.LastName, resource.Email, 
            resource.Password, resource.Address, resource.District, resource.City, resource.ProfileImage);
    }
}