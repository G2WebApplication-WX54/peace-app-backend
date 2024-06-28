using PeaceApp.API.Organization.Domain.Model.Commands;

namespace PeaceApp.API.Organization.Domain.Model.Aggregates;

public class OrganizationAccount
{
    public int Id { get; private set; }
    //be careful wit this 
    //Mayusculas??
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string ContactNumber { get; private set; }
    public string Address { get; private set; }
    public string Description { get; private set; }
    public string ProfileImage { get; private set; }
    protected OrganizationAccount()
    {
        this.Name = string.Empty;
        this.Email = string.Empty;
        this.Password = string.Empty;
        this.ContactNumber = string.Empty;
        this.Address = string.Empty;
        this.Description = string.Empty;
        this.ProfileImage = string.Empty;
    }

    public OrganizationAccount(CreateOrganizationAccountCommand command)
    {
        this.Name = command.Name;
        this.Email = command.Email;
        this.Password = command.Password;
        this.ContactNumber = command.ContactNumber;
        this.Address = command.Address;
        this.Description = command.Description;
        this.ProfileImage = command.ProfileImage;
    }
}