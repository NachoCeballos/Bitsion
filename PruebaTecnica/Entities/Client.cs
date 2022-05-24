using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Entities
{
    public class Client
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string FirstName { get; set; }
        [Required, StringLength(255)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required, StringLength(255)]
        public string Gender { get; set; }
        [Required]
        public bool Condition { get; set; }

    }
}
