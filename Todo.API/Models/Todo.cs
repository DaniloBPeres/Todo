using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo.API.Models
{
    public class Todo
    {
        [Key]
        [Column("todo_id")]
        public int Todo_id { get; set; }

        [Required]
        [Column("task")]
        public string Task { get; set; }

        [Required]
        [Column("has_finished")]
        public bool Has_finished { get; set; }

        [Required]
        [Column("todo_date")]
        public DateTime Todo_date { get; set; }

        [Required]
        [Column("todo_time")]
        public DateTime Todo_time { get; set; }

        [Column("finished_date")]
        public DateTime Finished_date { get; set; }

        [Required]
        [Column("user_id")]
        public int User_id { get; set; }
    }
}
