using PeaceApp.API.Citizen.Domain.Model.Commands;

namespace PeaceApp.API.Citizen.Domain.Services;

public interface ICitizenCommandService
{
    Task<Model.Aggregates.Citizen?> Handle(CreateCitizenAccountCommand command);
    Task<Model.Aggregates.Citizen?> Handle(UpdateCitizenAccountCommand command);
    Task<bool> Handle(DeleteCitizenAccountCommand command);
}