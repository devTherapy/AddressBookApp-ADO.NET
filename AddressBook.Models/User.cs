using System.Collections.Generic;
using System.Text;

namespace AddressBook.Models
{
    public class User
    {
        /// <summary>
        /// models the user
        /// </summary>
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Email { get; set; }
        public int UserRoleId { get; set; }
        public string UserRole { get; set; }
        public List<PhoneNumber> UserPhoneNumbers { get; set; }
        public List<SocialMedia> SocialMediaHandles { get; set; }
        public Address Address { get; set; }


        /// <summary>
        /// Overriden to provide custom representation of user using string builder
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name : {FirstName}\n");
            sb.AppendLine($"Last Name : {LastName}\n");
            sb.AppendLine($"Email Name : {Email}\n");
            sb.AppendLine($"User Role : {UserRole}\n");

            foreach (var phoneNumber in UserPhoneNumbers)
            {
                sb.AppendLine(phoneNumber.Main == 1
                    ? $"Main Phone Number : {phoneNumber.Number}\n"
                    : $"Phone Number : {phoneNumber.Number}");
            }

            sb.Append("\n");
            foreach (var socialMedia in SocialMediaHandles)
            {
                sb.AppendLine($"Social Media Link : {socialMedia.Link}");
            }

            sb.AppendLine($"\nAddress : ");
            sb.AppendLine($"\tStreet : {Address.Street}");
            sb.AppendLine($"\tCity : {Address.City}");
            sb.AppendLine($"\tState : {Address.State}");
            sb.AppendLine($"\tZip Code : {Address.ZipCode}");
            sb.AppendLine($"\tCountry : {Address.Country}");


            return sb.ToString();
        }
    }
}
