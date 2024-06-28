using PeaceApp.API.Organization.Domain.Model.Aggregates;
using PeaceApp.API.Organization.Domain.Model.Queries;
using PeaceApp.API.Organization.Domain.Repositories;
using PeaceApp.API.Organization.Domain.Services;

namespace PeaceApp.API.Organization.Application.Internal.QueryServices;

public class OrganizationAccountQueryService(IOrganizationAccountRepository organizationAccountRepository)
    : IOrganizationAccountQueryService
{

    public async Task<OrganizationAccount> Handle(GetOrganizationAccountByOrganizationNameQuery query)
    {
        return await organizationAccountRepository.FindByOrganizationNameAsync(query.OrganizationName);
    }
    
    public async Task<OrganizationAccount> Handle(GetOrganizationAccountByEmailQuery query)
    {
        return await organizationAccountRepository.FindByOrganizationEmailAsync(query.Email);
    }
}