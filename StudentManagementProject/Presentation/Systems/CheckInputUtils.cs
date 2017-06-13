using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentManagementProject.Presentation.Systems
{
    public class CheckInputUtils
    {
        public static Boolean checkEmail(String email)
        {
            Regex emailregex = new Regex(@"^[0-9a-zA-Z]+@(gmail|yahoo|tma)\.com\.vn$");
            Match m = emailregex.Match(email);
            if (m.Success)
            {
                return true;
            }
            return false;
        }

        private static Boolean checkPasswordLength(String password)
        {
            Regex passLRegex = new Regex(@"^[0-9a-zA-Z]{8,}$");
            Match m = passLRegex.Match(password);
            if (m.Success)
            {
                return true;
            }
            return false;
        }

        private static Boolean checkPasswordCharacter(String password)
        {
            Regex passTRegex = new Regex(@"\d{1}");
            Match m2 = passTRegex.Match(password);
            if (m2.Success)
            {
                Regex passNRegex = new Regex(@"[a-zA-Z]{1}");
                Match m3 = passNRegex.Match(password);
                if (m3.Success)
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean checkPassword(string password)
        {
            Boolean result1 = checkPasswordLength(password);
            Boolean result2 = checkPasswordCharacter(password);

            return result1 & result2;
        }

    }
}
