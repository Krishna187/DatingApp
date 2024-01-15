using System.ComponentModel.DataAnnotations;

namespace DatingApp.Entity
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }

    }
}
