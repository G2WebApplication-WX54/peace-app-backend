using PeaceApp.API.Organization.Domain.Model.Commands;

namespace PeaceApp.API.Organization.Domain.Model.Aggregates;

public class OrganizationAccount
{
    public int Id { get; private set; }
    //be careful wit this 
    //Mayusculas??
    public string OrganizationName { get; private set; }
    
    // Location should be a value object
    public string Location { get; private set; }
    
    // Cellphone should have restriction to have 9 characters 
    public string Cellphone { get; private set; }
    
    protected OrganizationAccount()
    {
        this.OrganizationName = string.Empty;
        this.Location = string.Empty;
        this.Cellphone = string.Empty;
    }

    public OrganizationAccount(CreateOrganizationAccountCommand command)
    {
        this.OrganizationName = command.OrganizationName;
        this.Location = command.Location;
        this.Cellphone = command.Cellphone; 
    }
}