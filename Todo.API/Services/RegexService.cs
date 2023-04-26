using System.Text.RegularExpressions;
using Todo.API.Interfaces;

namespace Todo.API.Services
{
    public class RegexService : IRegexService
    {
        public bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(email);

            return match.Success;
        }
    }
}
