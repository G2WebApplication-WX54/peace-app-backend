namespace PeaceApp.API.Citizen.Interfaces.ACL;

public interface ICitizensContextFacade
{
    Task<int> CreateCitizen(string firstName, string lastName, string email,
        string password, string address, string district, string city, string profileImage);

    Task<int> FetchCitizenIdByEmail(string email);

    Task<bool> UpdateCitizen(int id, string firstName, string lastName, string email,
        string password, string address, string district, string city, string profileImage);

    Task<bool> DeleteCitizen(int id);
}