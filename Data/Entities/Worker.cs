using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
        public virtual ICollection<AccessGroup> AccessGroups { get; set; }
    }
}
