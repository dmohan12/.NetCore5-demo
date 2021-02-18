
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace damon_mvc.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set;}

        [Required]
        public string Name { get; set;}

        [DisplayName("Display Order")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage="Display Order for category must be greater than Zero")]
        public int DisplayOrder { get; set;}
    }
}