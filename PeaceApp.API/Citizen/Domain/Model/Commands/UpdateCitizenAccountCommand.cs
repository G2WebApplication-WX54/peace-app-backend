using System;

namespace PeaceApp.API.Citizen.Domain.Model.Commands
{
    public record UpdateCitizenAccountCommand
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Password { get; }
        public string Address { get; }
        public string District { get; }
        public string City { get; }
        public string ProfileImage { get; }

        public UpdateCitizenAccountCommand(int id, string firstName, string lastName, string email, string password,
            string address, string district, string city, string profileImage)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be a positive integer.", nameof(id));
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentNullException(nameof(firstName), "First name cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException(nameof(lastName), "Last name cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException(nameof(email), "Email cannot be null or empty.");
            if (!email.Contains("@"))
                throw new ArgumentException("Email must contain an '@' symbol.", nameof(email));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password), "Password cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException(nameof(address), "Address cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(district))
                throw new ArgumentNullException(nameof(district), "District cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentNullException(nameof(city), "City cannot be null or empty.");
            if (string.IsNullOrWhiteSpace(profileImage))
                throw new ArgumentNullException(nameof(profileImage), "Profile image cannot be null or empty.");
            
           
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Address = address;
            District = district;
            City = city;
            ProfileImage = profileImage;
        }
    }
}
