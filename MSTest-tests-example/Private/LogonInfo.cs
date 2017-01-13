using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MSTest_tests_example.Private
{
    class LogonInfo
    {
        private static int conunterPasswordChangedCorrectly;

        public LogonInfo(string userId, string password)
        {
            this.UserId = userId;
            this.Password = password;
        }

        private string _UserId;
        public string UserId
        {
            get { return _UserId; }
            private set
            {
                if (value == null || value.Trim() == string.Empty)
                {
                    throw new ArgumentException(
                       "Parameter userId may not be null or blank.");
                }
                _UserId = value;
            }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            private set
            {
                string errorMessage;
                if (!IsValidPassword(value, out errorMessage))
                {
                    throw new ArgumentException(
                       errorMessage);
                }
                _Password = value;
            }
        }

        private static bool IsValidPassword(string value,
           out string errorMessage)
        {
            const string passwordSizeRegex = "(?=^.{6,255}$)";
            const string uppercaseRegex = "(?=.*[A-Z])";
            const string lowercaseRegex = "(?=.*[a-z])";
            const string punctuationRegex = @"(?=.*\d)";
            const string upperlowernumericRegex = "(?=.*[^A-Za-z0-9])";

            bool isValid;
            Regex regex = new Regex(
               passwordSizeRegex +
               "(" + punctuationRegex + uppercaseRegex + lowercaseRegex +
                  "|" + punctuationRegex + upperlowernumericRegex + lowercaseRegex +
                  "|" + upperlowernumericRegex + uppercaseRegex + lowercaseRegex +
                  "|" + punctuationRegex + uppercaseRegex + upperlowernumericRegex +
               ")^.*");

            if (value == null || value.Trim() == string.Empty)
            {
                isValid = false;
                errorMessage = "Password may not be null or blank.";
            }
            else
            {
                if (regex.Match(value).Success)
                {
                    isValid = true;
                    errorMessage = "";
                }
                else
                {
                    isValid = false;
                    errorMessage = "Password does not meet the complexity requirements.";
                }
            }
            return isValid;
        }

        public void ChangePassword(
           string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
            {
                string errorMessage = "";
                if (IsValidPassword(newPassword, out errorMessage))
                {
                    Password = newPassword;
                    conunterPasswordChangedCorrectly++;
                }
                else
                {
                    throw new ArgumentException(
                      errorMessage);
                }
            }
            else
            {
                throw new ArgumentException(
                   "The old password was not correct.");
            }
        }
    }
}
