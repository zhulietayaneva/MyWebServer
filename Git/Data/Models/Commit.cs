using System;
using System.ComponentModel.DataAnnotations;

namespace Git.Models
{
    public class Commit
    {
        [Key]
        [Required]
        [MaxLength(40)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatorId { get; set; }
        public User Creator { get; set; }
        
        public string RepositoryId { get; set; }
        public Repository Repository { get; set; }


    }
}
