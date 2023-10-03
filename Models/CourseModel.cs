using System;
using System.ComponentModel.DataAnnotations;

namespace MyFirstApplication.Models
{
	public class CourseModel
	{
        [Key]
        public int Id { get; set; }
        [Required]

        public string Title { get; set; }
        [StringLength(250)]

        public string Description { get; set; }


    }
}

