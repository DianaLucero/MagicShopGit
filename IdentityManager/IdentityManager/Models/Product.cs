using IdentityManager.Data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Mínimo 4 caracteres")]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Display(Name = "Category")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes escoger una categoría")]
        public int CategoryId { get; set; }
        public string Image { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [NotMapped]
        [FileExtension]
        public IFormFile ImagenUpload { get; set; }

    }
}
