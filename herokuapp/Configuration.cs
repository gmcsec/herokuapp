using System;
using static herokuapp.Enums;

namespace herokuapp
{
    public static class Configuration
    {
        public const string HomePageURL = @"http://the-internet.herokuapp.com/";
        public const BrowerTypes Browser = BrowerTypes.Chrome;

        public const string Username = "tomsmith";
        public const string Password = "SuperSecretPassword!";
    }
}
