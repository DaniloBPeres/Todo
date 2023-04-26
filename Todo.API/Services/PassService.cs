using System.Security.Cryptography;
using System.Text;
using Todo.API.Interfaces;

namespace Todo.API.Services
{
    public class PassService : IPassService
    {
        public string GetPass(string pass)
        {
            using(SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(pass));

                StringBuilder sb = new();

                for(int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
