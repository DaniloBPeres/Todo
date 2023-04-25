using Todo.API.Interfaces;

namespace Todo.API.Services
{
    public class EmailService : IEmailService
    {
        private bool SendEmail(string email)
        {
            return true;
        }

        public bool CreateEmailConfirm(string email, int codeConfirm) 
        { 
            return true;
        }

        public bool CreateEmailRecoverPass()
        {
            return true;
        }
    }
}
