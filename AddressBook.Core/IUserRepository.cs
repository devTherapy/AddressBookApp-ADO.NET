using System.Data;
using System.Threading.Tasks;
using AddressBook.Models;

namespace AddressBook.Core
{
    public interface IUserRepository
    {
        void AddUser(string firstName, string lastName, string email, 
            string password, int userRoleId, string phoneNumber );

        int AddPhoneNumber(string userId, string phoneNumber);
        int UpdatePhoneNumber(string userId, string oldPhoneNumber, string newPhoneNumber);
        int DeletePhoneNumber(string userId, string phoneNumber);
        bool CheckForAddress(string userId);
        int AddAddress(string userId, string street, string city, 
            string state, string zipCode, string country);

        int UpdateAddress(string userId, string street, string city, 
            string state, string zipCode, string country);

        int AddSocialMediaHandles(string userId, string link);
        Task<User> GetUser(string email);
        Task<string> GetAllUsers(int userRoleId);
    }
}