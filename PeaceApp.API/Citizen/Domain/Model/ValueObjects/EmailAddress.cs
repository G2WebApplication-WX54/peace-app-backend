public record EmailAddress
{
    public string Email { get; private set; }

    public EmailAddress(string address)
    {
        Email = address ?? throw new ArgumentNullException(nameof(address));
    }

    // Default constructor for EF Core
    public EmailAddress()
    {
        Email = string.Empty;
    }
}