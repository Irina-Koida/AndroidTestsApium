using System;

namespace AndroidTestsApium.POM
{
    static public class Helper
    {
        public static string RandomEmailUser()
        {
            DateTime dataTime = new DateTime();
            dataTime = DateTime.Now;
            string name = dataTime.ToString();
            name = name.Replace(".", "");
            name = name.Replace(":", "");
            return name = "newMail" + name + "@test.com";
        }
    }
}
