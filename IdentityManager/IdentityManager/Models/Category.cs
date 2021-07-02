using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "Minimun Length is 2")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Solo letras")]
        public string Name { get; set; }

        public string Slug { get; set; }
        public int Sorting { get; set; }
    }
}
