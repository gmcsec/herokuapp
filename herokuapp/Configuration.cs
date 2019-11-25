using System;
using static herokuapp.Enums;

namespace herokuapp
{
    public static class Configuration
    {
        public const string HomePageURL = @"http://the-internet.herokuapp.com/";
        public const BrowerTypes Browser = BrowerTypes.Chrome;

        //Authentication data
        public const string Username = "tomsmith";
        public const string Password = "SuperSecretPassword!";

        /// <summary>
        /// Enum representing the different browsers available for testing
        /// </summary>
        
    }
}
