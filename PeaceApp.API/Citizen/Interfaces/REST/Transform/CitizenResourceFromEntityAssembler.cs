using PeaceApp.API.Citizen.Interfaces.REST.Resources;

namespace PeaceApp.API.Citizen.Interfaces.REST.Transform;

public static class CitizenResourceFromEntityAssembler
{
    public static CitizenResource ToResourceFromEntity(Domain.Model.Aggregates.Citizen entity)
    {
        return new CitizenResource(entity.Id, entity.FullName, entity.EmailAddress,
            entity.Password, entity.Address, entity.District, entity.City, entity.ProfileImage);
    }
}