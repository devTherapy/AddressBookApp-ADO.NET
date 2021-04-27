using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using AddressBook.Data;
using AddressBook.Models;

namespace AddressBook.Core
{
    public class UserRepository : DataAccess, IUserRepository
    {

        /// <summary>
        /// Add Details entered into database
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="userRoleId"></param>
        /// <param name="phoneNumber"></param>
        public void AddUser(string firstName, string lastName, string email,
            string password, int userRoleId, string phoneNumber)
        {
            var id = Guid.NewGuid().ToString();
            var addUserQuery = $"INSERT INTO tblUsers " +
                               $"VALUES(@Id, @FirstName, @LastName, @Email, @Password, @UserRoleId )";

            var inputParameters = new[]
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password),
                new SqlParameter("@UserRoleId",userRoleId )
            };

            var addMainPhoneNumberQuery = $"INSERT INTO tblPhoneNumbers VALUES(@UserId, @PhoneNumber, 1)";
            var inputPhoneNumberParameters = new[]
            {
                new SqlParameter("@UserId", id),
                new SqlParameter("@PhoneNumber", phoneNumber),
            };

            // Execute both queries together
            ExecuteTransaction(addUserQuery, inputParameters, 
                addMainPhoneNumberQuery
            , inputPhoneNumberParameters);
        }


        /// <summary>
        ///  Add phone Number to the phone number table with id that references user id
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public int AddPhoneNumber(string userId, string phoneNumber)
        {
            var addPhoneQuery = $"INSERT INTO tblPhoneNumbers VALUES(@UserId, @PhoneNumber, 0)";

            var inputParameters = new[]
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@PhoneNumber", phoneNumber),
            };

            return QueryExecute(addPhoneQuery, inputParameters);
        }


        /// <summary>
        /// Update user phone number
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="oldPhoneNumber"></param>
        /// <param name="newPhoneNumber"></param>
        /// <returns></returns>
        public int UpdatePhoneNumber(string userId, string oldPhoneNumber, string newPhoneNumber)
        {
            var updatePhoneQuery = $"UPDATE tblPhoneNumbers SET PhoneNumber = @NewPhoneNumber" +
                                   $"WHERE UserId = @UserId AND PhoneNumber = @OldPhoneNumber";

            var inputParameters = new[]
            {
                new SqlParameter("@NewPhoneNumber", newPhoneNumber),
                new SqlParameter("@UserId", userId),
                new SqlParameter("@OldPhoneNumber", oldPhoneNumber),
            };
            return QueryExecute(updatePhoneQuery, inputParameters);
        }


        /// <summary>
        /// Delete phone number
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public int DeletePhoneNumber(string userId, string phoneNumber)
        {
            var deletePhoneQuery = $"DELETE FROM tblPhoneNumbers WHERE UserId = @UserId AND " +
                                   $"PhoneNumber = @PhoneNumber AND Main = 0";
            var inputParameters = new[]
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@PhoneNumber", phoneNumber),
            };

            return QueryExecute(deletePhoneQuery, inputParameters);
        }

        /// <summary>
        /// Add address to address table references user id
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        public int AddAddress(string userId, string street, string city,
            string state, string zipCode, string country)
        {
            var addAddressQuery = $"INSERT INTO tblAddresses VALUES(@UserId, @Street, @City, @State," +
                                $" @ZipCode, @Country)";

            var inputParameters = new[]
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Street", street),
                new SqlParameter("@City", city),
                new SqlParameter("@State", state),
                new SqlParameter("@ZipCode", zipCode),
                new SqlParameter("@Country", country),
            };

            return QueryExecute(addAddressQuery, inputParameters);
        }


        /// <summary>
        /// update user address
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="zipCode"></param>
        /// <param name="country"></param>
        /// <returns></returns>
        public int UpdateAddress(string userId, string street, string city,
            string state, string zipCode, string country)
        {
            var updateAddressQuery = $"UPDATE tblAddresses " +
                                     $"SET Street = @Street, City = @City, State = @State," +
                                     $" ZipCode = @ZipCode, Country = @Country " +
                                     $"WHERE UserId = @UserId;";

            var inputParameters = new[]
            {
                new SqlParameter("@Street", street),
                new SqlParameter("@City", city),
                new SqlParameter("@State", state),
                new SqlParameter("@ZipCode", zipCode),
                new SqlParameter("@Country", country),
                new SqlParameter("@UserId", userId),
            };

            return QueryExecute(updateAddressQuery, inputParameters);
        }


        /// <summary>
        /// performs check if user have an address
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool CheckForAddress(string userId)
        {
            var checkForAddressQuery = $"SELECT COUNT(*) FROM tblAddresses WHERE UserId = @UserId;";

            var inputParameters = new[]
            {
                new SqlParameter("@UserId", userId),
            };

            var returnedInt = QueryScalar(checkForAddressQuery, inputParameters);


            return returnedInt == 1;
        }


        /// <summary>
        /// Add social media handle of user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        public int AddSocialMediaHandles(string userId, string link)
        {
            var addUserQuery = $"INSERT INTO tblSocialMediaHandles VALUES(@UserId, @Link )";

            var inputParameters = new[]
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Link", link),
            };
            return QueryExecute(addUserQuery, inputParameters);
        }



        /// <summary>
        /// Returns a DTO of the user in database
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<User> GetUser(string email)
        {
            var user = new User {Email = email};
            var queryToGetUser = $"SELECT Id, FirstName, LastName, UserRoleId, tblRoles.Role " +
                                 "FROM tblUsers INNER JOIN tblRoles ON tblUsers.UserRoleId = tblRoles.RoleId " +
                                 "WHERE Email=@Email;";
            var inputParameters = new[]
            {
                new SqlParameter("@Email", email),
            };

            var dr = await ReadFromDatabase(queryToGetUser, inputParameters);

            while (await dr.ReadAsync())
            {
                user.Id = dr.GetFieldValue<string>(dr.GetOrdinal("Id"));
                user.FirstName = dr.GetFieldValue<string>(dr.GetOrdinal("FirstName"));
                user.LastName = dr.GetFieldValue<string>(dr.GetOrdinal("LastName"));
                user.UserRoleId = dr.GetFieldValue<int>(dr.GetOrdinal("UserRoleId"));
                user.UserRole = dr.GetFieldValue<string>(dr.GetOrdinal("Role"));
            }

            await GetUserOtherDetails(user);
            return user;
        }

        /// <summary>
        /// populate User address, social media links and phone numbers
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private async Task GetUserOtherDetails(User model)
        {
            var address = new Address();
            var listOfPhoneNumbers = new List<PhoneNumber>();
            var listOfSocialMediaHandles = new List<SocialMedia>();

            var queriesToGetOtherDetails = $"SELECT PhoneNumber, Main FROM tblPhoneNumbers WHERE UserId = @Userid;" +
                                         $"SELECT City, Country, State, Street, ZipCode FROM tblAddresses WHERE UserId = @UserId;" +
                                         $"SELECT Link FROM tblSocialMediaHandles WHERE UserId = @UserId;";
            var inputParameters = new[]
            {
                new SqlParameter("@UserId", model.Id),
            };

            var dr = await ReadFromDatabase(queriesToGetOtherDetails, inputParameters); // get data reader

            while (await (dr.ReadAsync()))
            {
                listOfPhoneNumbers.Add(new PhoneNumber()
                {
                    Number = dr.GetFieldValue<string>(dr.GetOrdinal("PhoneNumber")),
                    Main = dr.GetFieldValue<int>(dr.GetOrdinal("Main"))
                });
            }

            await dr.NextResultAsync();
            while (await (dr.ReadAsync()))
            {
                address.City = dr.GetFieldValue<string>(dr.GetOrdinal("City"));
                address.Country = dr.GetFieldValue<string>(dr.GetOrdinal("Country"));
                address.State = dr.GetFieldValue<string>(dr.GetOrdinal("State"));
                address.Street = dr.GetFieldValue<string>(dr.GetOrdinal("Street"));
                address.ZipCode = dr.GetFieldValue<string>(dr.GetOrdinal("ZipCode"));

            }

            await dr.NextResultAsync();
            while (await (dr.ReadAsync()))
            {
                listOfSocialMediaHandles.Add(new SocialMedia()
                {
                    Link = dr.GetFieldValue<string>(dr.GetOrdinal("Link"))
                });
            }

            model.UserPhoneNumbers = listOfPhoneNumbers;
            model.SocialMediaHandles = listOfSocialMediaHandles;
            model.Address = address;
        }

        /// <summary>
        /// Get all users and display their details
        /// </summary>
        /// <param name="userRoleId"></param>
        public async Task<string> GetAllUsers(int userRoleId)
        {
            if (userRoleId == 0)
            {
                var query =
                    $"SELECT FirstName, LastName, Email, tblRoles.Role, tblAddresses.City, tblAddresses.Country, " +
                    "tblAddresses.State,tblAddresses.Street, tblAddresses.ZipCode , tblPhoneNumbers.PhoneNumber, tblSocialMediaHandles.Link " +
                    "FROM ((((tblUsers FULL JOIN tblRoles ON tblUsers.UserRoleId = tblRoles.RoleId) FULL JOIN tblAddresses ON tblUsers.Id = UserId) " +
                    "FULL JOIN tblPhoneNumbers ON tblUsers.Id = tblPhoneNumbers.UserId) " +
                    "FULL JOIN tblSocialMediaHandles ON tblUsers.Id = tblSocialMediaHandles.UserId)";


                var dt = GetAdapter(query);
                var sb = new StringBuilder();
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        sb.AppendLine($"{column.ColumnName} = {row[column]}");
                    }

                    sb.AppendLine("\n");
                }

                return sb.ToString();


            }
            throw new UnauthorizedAccessException("You do not have the priviledges");
        }
    }
}
