


namespace PHPTravelsTestProject.ConfigDefaults
{
    public static class TestVariables
    {
        public static class Credentials
        {
            public static class AccountDropDown
            {
                //relative xpaths for account login and sign up menus
                public static string AccountButton = "/html/body/nav//*[@id=\"li_myaccount\"]";
                public static string Login = "/html/body/nav//*[@id=\"li_myaccount\"]/ul/li[1]/a";
                public static string SignUp = "/html/body/nav//*[@id=\"li_myaccount\"]/ul/li[2]/a";
            }

            public static class ValidSignUp
            {
                public static string name = "Tester";
                public static string lastName = "Program";
                public static string password = "admin1!";
                public static string repeatPassword = "admin1!";
                public static string phoneNumber = "202-555-0176";
                public static string email = "example@example.com";
            }


            public static class ValidLogin
            {
                //test credentials for a valid login account
                public static string email = "";
                public static string password = "";
            }


            public static class InvalidSignUpPasswordLessThanSixCharacters
            {
                public static string password = "asdf";
            }

            
            public static class InvalidEmail
            {
                public static string email = "wrongpassword@password";
            }


        }
   
    }
}
