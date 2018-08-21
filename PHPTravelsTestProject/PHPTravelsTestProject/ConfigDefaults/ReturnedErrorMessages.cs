﻿

namespace PHPTravelsTestProject.ConfigDefaults
{
    public static class ReturnedErrorMessages
    {
        //invalid password during signup less than 6 characters
        public static class InvalidPasswordLessSixCharactersMessage
        {
            public static string message = "The Password field must be at least 6 characters in length.";
        }

        public static class InvalidEmailOnSignUp
        {
            public static string message = "The Email field must contain a valid email address.";
        }


        public static class InvalidCredentialsInLogin
        {
            public static string message = "Invalid Email or Password";
        }


    }
}