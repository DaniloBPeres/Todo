using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Todo.API.Models.Entities
{
    public class EmailConfirm : Base
    {
        public string Email { get; set; }

        public int Code_confirm { get; set; }

        public bool Has_confirmed { get; set; }

        public int PersonId { get; set; }
    }
}
