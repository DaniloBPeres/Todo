namespace Todo.API.Models.DTOs
{
    public class RegisterDTO
    {
        public string User_name { get; set; }

        public string Pass { get; set; }

        public string PassConfirm { get; set; }

        public string Email { get; set; }

        public string EmailConfirm { get; set; }
    }
}
