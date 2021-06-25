using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Models
{
    public class Repository
    {
        [Key]
        [Required]
        [MaxLength(40)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public bool IsPublic { get; set; }
        public string OwnerId { get; set; }
        public User Owner { get; set; }
        public IEnumerable<Commit> Commits { get; set; } = new List<Commit>();
    }
}
