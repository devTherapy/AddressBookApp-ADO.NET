using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using AddressBook.Data;

namespace AddressBook.Core
{
    class AuthRepository : IAuthRepository
    {
        public void CheckStoreForEmail(string email)
        {
            string path = @"C:\temp\storeAuth.txt";

            using StreamReader sr = new StreamReader(path);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                var resultingStringArr = line.Split('\t');
                if (resultingStringArr[0] == email)
                {
                    throw new ArgumentException("Email already exists, use another");
                }
            }
        }

        public void StoreAuthWithStreamWriter(string email, string password)
        {
            string path = @"C:\temp\storeAuth.txt";

            using StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(email + "\t" + password);
            sw.Close();
        }

        public async Task<Tuple<string,int,string,bool>> LogInWithStreamReader(string email, string password)
        {
            string path = @"C:\temp\storeAuth.txt";
            using StreamReader sr = new StreamReader(path);
            string line = "";
            string returnedId = default;
            int userRoleId = -1;
            while ((line = sr.ReadLine()) != null)
            {
                var resultingStringArr = line.Split('\t');
                if (resultingStringArr[0] == email && resultingStringArr[1] == password)
                {
                    var query = "SELECT Id, UserRoleId FROM tblUsers WHERE Email = @Email AND Password = @Password;";
                    var inputParameters = new[]
                    {
                        new SqlParameter("@Email", email),
                        new SqlParameter("@Password", password),
                    };
                     var dr = await DataAccess.ReadFromDatabase(query, inputParameters);
                     while (await dr.ReadAsync())
                     {
                         returnedId = dr.GetFieldValue<string>(dr.GetOrdinal("Id"));
                         userRoleId = dr.GetFieldValue<int>(dr.GetOrdinal("UserRoleId"));

                     }
                     if(!string.IsNullOrWhiteSpace(returnedId) && userRoleId != -1)
                         return Tuple.Create(returnedId, userRoleId, email, true);
                }
            }

            return Tuple.Create(returnedId, userRoleId, email, false);
        }
    }
}
