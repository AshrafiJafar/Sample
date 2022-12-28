using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Sample.Models
{
    public class Person
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "First name")]
        [Required]
        [MaxLength(20)]
        [MinLength(3,ErrorMessage = "Can not be less than 3 Character")]
        
        public string FirstName { get; set; }

        
        [Display(Name = "Last name")]
        [Required]
        [MaxLength(40)]
        [MinLength(3, ErrorMessage = "Can not be less than 3 Character")]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public int Gender { get; set; }

        [Display(Name = "Age")]
        [Range(10, 50)]
        public int? Age { get; set; }

        [Display(Name = "Father name")]
        [Required]
        [MaxLength(20)]
        [MinLength(3, ErrorMessage = "Can not be less than 3 Character")]
        public string FatherName { get; set; }

        [Display(Name = "Phone number")]
        //[RegularExpression("^(\\+98?)?{?(0?9[0-9]{9,9}}?)$", ErrorMessage = "Phone number is not in a correct format.")]
        [Remote("IsValid","Default",HttpMethod = "Get", ErrorMessage = "Phone number exists!")]
        public string? PhoneNumber { get; set; }
        [Display(Name = "Created time")]
        public DateTime CreatedTime { get; set; }
    }
}
