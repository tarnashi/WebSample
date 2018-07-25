using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class AccessGroup
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
    }
}
