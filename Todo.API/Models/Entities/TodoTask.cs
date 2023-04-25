using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo.API.Models.Entities
{
    public class TodoTask : Base
    {
        public string Task { get; set; }

        public bool Has_finished { get; set; }

        public DateTime Todo_datetime { get; set; }

        public DateTime Finished_date { get; set; }

        public int PersonId { get; set; }

        public Person Person { get; set; }
    }
}
