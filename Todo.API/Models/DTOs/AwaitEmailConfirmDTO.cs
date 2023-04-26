namespace Todo.API.Models.DTOs
{
    public class AwaitEmailConfirmDTO
    {
        public string Email { get; set; }
        public string CodeToConfirm { get; set; }
        public string UserName { get; set; }
    }
}
