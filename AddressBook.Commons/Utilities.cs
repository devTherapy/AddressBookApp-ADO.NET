using System;
using System.Text.RegularExpressions;

namespace AddressBook.Commons
{
    public class Utilities
    {
        public static string ValidateName(string name)
        {
            // check that the string does not contain any special characters and numbers
            // Take the first char to make it capital
            // return string
            // else throw FormatException

            // Change first character to caps
            if (!string.IsNullOrEmpty(name) && Regex.IsMatch(name, @"^[A-Za-z]*$"))
                return FirstCharacterToUpper(name);
            throw new FormatException(
                $"{nameof(name)} should start with a capital letter and not contain numbers");
        }

        // Change first character to caps
        public static string FirstCharacterToUpper(string val)
        {
            var str = val.Substring(0, 1).ToCharArray();
            var strCode = (int)str[0];
            if (strCode >= 97)
            {
                var strCaps = strCode - 32;
                if (val.Length > 1) return (char)strCaps + val.Substring(1);
            }

            return val;
        }

        public static string ValidateEmail(string email)
        {
            // use regex to check email
            // check that email not contained in database
            // return email
            // else throw FormatException
            if (
                !string.IsNullOrEmpty(email)
                &&
                Regex.IsMatch(email, @"^[^@\s\.]+@[^@\s]+\.[^@\s]+$")
            )
                return email;
            else
                throw new FormatException($"{nameof(email)} is not in a valid format or already in use");
        }

        public static string ValidatePhoneNumber(string phoneNumber)
        {
            // use regex to check that it is 14 characters long and contains country code
            // return string, else throw FormatException;
            if (Regex.IsMatch(phoneNumber, @"^(\+[0-9]{13})$"))
            {
                return phoneNumber;
            }
            throw new FormatException($"Phone Number not valid, Ensure you include " +
                                      $"country code and length is equal to 14");
        }

        public static string ValidatePassword(string password)
        {
            if (!string.IsNullOrEmpty(password) && password.Length>=5)
                return password;
            throw new FormatException("Password length must be larger or equal to 5");
        }

        public static string ValidateInput(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            throw new FormatException("User role/input cannot be empty");
        }
    }
}
