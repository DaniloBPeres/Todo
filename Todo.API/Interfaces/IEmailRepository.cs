namespace Todo.API.Interfaces
{
    public interface IEmailRepository
    {
        bool CreateEmailRecoverPass();

        bool CreateEmailConfirm(string email);
    }
}
