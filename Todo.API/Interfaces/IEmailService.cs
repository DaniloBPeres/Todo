namespace Todo.API.Interfaces
{
    public interface IEmailService
    {
        bool CreateEmailRecoverPass();

        bool CreateEmailConfirm(string email, int codeConfirm);
    }
}
