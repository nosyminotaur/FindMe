using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FindMe.Shared.Helpers
{
    public class AppRegex
    {
        //TODO Add const min/max length boundary
        public const string UsernameRegex = @"^[-_.A-Za-z0-9]+$";
        public const string UsernameError = "Invalid Username. Minimum 5 characters. Special characters allowed: dot, hyphen, underscore";
        public static List<string> UsernameConditions = new List<string>
        {
            "Minimum 5 characters",
            "Special characters allowed: dot, hyphen, underscore"
        };

        //TODO Add error message email
        public const string EmailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
          @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
          @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        public const string EmailError = "Invalid Email format";
        //TODO Add error message password
        public const int MinPasswordLength = 8;
        public const string PasswordRegex = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";
        public static List<string> PasswordConditions = new List<string>
        {
            "Minimum 8 characters",
            "Atleast 1 letter",
            "Atleast 1 number",
            "Atleast 1 special character"
        };

        public static bool IsValidEmail(string emailString)
        {
            //TODO Add length boundary check
            return Regex.IsMatch(emailString, EmailRegex, RegexOptions.IgnoreCase);
        }

        public static bool IsValidUsername(string usernameString)
        {
            //TODO Add length boundary check
            return Regex.IsMatch(usernameString, UsernameRegex, RegexOptions.IgnoreCase);
        }

        public static bool IsValidPassword(string passwordString)
        {
            return Regex.IsMatch(passwordString, PasswordRegex);
        }
    }
}
