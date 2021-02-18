
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace damon_mvc.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set;}

        public string Name { get; set;}
    }
}