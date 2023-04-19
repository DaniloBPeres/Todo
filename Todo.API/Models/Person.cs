using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo.API.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Column("user_id")]
        public int User_id { get; set; }

        [Required]
        [Column("user_name")]
        public string User_name { get; set; }

        [Required]
        [Column("pass")]
        public string Pass { get; set; }

        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("created_on")]
        public DateTime Created_on { get; set; }

        [Column("last_login")]
        public DateTime Last_login { get; set; }

    }
}
