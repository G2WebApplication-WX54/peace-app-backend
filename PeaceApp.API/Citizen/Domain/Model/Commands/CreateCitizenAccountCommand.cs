namespace PeaceApp.API.Citizen.Domain.Model.Commands
{
    public record CreateCitizenAccountCommand
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Password { get; }
        public string Address { get; }
        public string District { get; }
        public string City { get; }
        public string ProfileImage { get; }

        public CreateCitizenAccountCommand(string firstName, string lastName, string email, string password, string address, string district, string city, string profileImage)
        {
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

            FirstName = firstName;
            LastName = lastName;
            Email = email;
            this.Password = password;
            this.Address = address;
            this.District = district;
            this.City = city;
            this.ProfileImage = profileImage;
        }
        
    }
}