using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo.API.Models.Entities
{

    public class Person : Base
    {
        public string User_name { get; set; }

        public string Pass { get; set; }

        public string Email { get; set; }

        public DateTime Created_on { get; set; }

        public DateTime Last_login { get; set; }

        public ICollection<TodoTask> Tasks { get; set; }

        public EmailConfirm EmailConfirm { get; set; }
    }
}
