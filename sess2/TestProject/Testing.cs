using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Testing
    {
        public static bool IsValidEmail(string email)
        {
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public static bool IsValidPhone(string phone)
        {
            var pattern = @"^[\d+\-()\s]+$";
            return Regex.IsMatch(phone, pattern);
        }
    }
}
