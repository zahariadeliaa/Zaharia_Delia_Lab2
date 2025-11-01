using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zaharia_Delia_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; } = default!;

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = default!;

        public ICollection<Book>? Books { get; set; }
    }
}
