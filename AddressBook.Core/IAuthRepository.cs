using System;
using System.Threading.Tasks;

namespace AddressBook.Core
{
    public interface IAuthRepository
    {
        public void CheckStoreForEmail(string email);
        public void StoreAuthWithStreamWriter(string email, string password);
        public Task<Tuple<string,int,string,bool>> LogInWithStreamReader(string email, string password);
    }
}