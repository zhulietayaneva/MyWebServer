using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Git.Models
{
    public class User
    {
        [Key]
        [Required]
        [MaxLength(40)]
        public string Id { get; init; } = Guid.NewGuid().ToString();

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

       public IEnumerable<Repository> Repositories { get; set; } = new List<Repository>();
       public IEnumerable<Commit> Commits { get; set; } = new List<Commit>();
    }
}
