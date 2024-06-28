using PeaceApp.API.Citizen.Domain.Model.Commands;
using PeaceApp.API.Citizen.Domain.Model.ValueObjects;
using PeaceApp.API.Report.Domain.Model.Aggregates;

namespace PeaceApp.API.Citizen.Domain.Model.Aggregates;

public partial class Citizen
{
    public Citizen()
    {
        Name = new PersonName();
        Email = new EmailAddress();
        //Address = new StreetAddress();
    }

    public Citizen(string firstName, string lastName, string email, string password,
        string address, string district, string city, string profileImage)
    {
        Name = new PersonName(firstName, lastName);
        Email = new EmailAddress(email);
        //Address = new StreetAddress(street, number, city, postalCode, country);
        this.Password = password;
        this.Address = address;
        this.District = district;
        this.City = city;
        this.ProfileImage = profileImage;
    }
    
    public Citizen(string firstName, string lastName, string email)
    {
        Name = new PersonName(firstName, lastName);
        Email = new EmailAddress(email);
        //Address = new StreetAddress(street, number, city, postalCode, country);
    }

    public Citizen(CreateCitizenAccountCommand command)
    {
        Name = new PersonName(command.FirstName, command.LastName);
        Email = new EmailAddress(command.Email);
        //Address = new StreetAddress(command.Street, command.Number, command.City, command.PostalCode, command.Country);
        Password = command.Password;
        Address = command.Address;
        District = command.District;
        City = command.City;
        ProfileImage = command.ProfileImage;
    }

    public int Id { get; set; } 
    public string Password { get; set; }
    public string Address { get; set; }
    public string District { get; set; }
    public string City { get; set; }
    public string ProfileImage { get; set; }
    public PersonName Name { get; private set; }
    public EmailAddress Email { get; private set; }
    //public StreetAddress Address { get; private set; }

    public string FullName => Name.FullName;

    public string EmailAddress => Email.Email;

    //public string StreetAddress => Address.FullAddress;
    public ICollection<ReportManagement> Reports { get; private set; }
    public void UpdateName(string firstName, string lastName)
    {
        Name = new PersonName(firstName, lastName);
    }

    public void UpdateEmail(string email)
    {
        Email = new EmailAddress(email);
    }

   /* public void UpdateAddress(string street, string number, string city, string postalCode, string country)
    {
        Address = new StreetAddress(street, number, city, postalCode, country);
    }*/
}