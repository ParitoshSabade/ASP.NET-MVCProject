using System;
using System.ComponentModel.DataAnnotations;
using MVCProject.CustomValidators;

namespace MVCProject.Models
{
	public class Student
	{

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [DOBValidator] 
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MinLength(8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Password must meet the criteria.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }


        public override string ToString()
        {
            return $"Student Object contains: Name: {Name},Email: {Email}, Phone No: {PhoneNumber}, Date of Birth: {DateOfBirth},Password: {Password}";
        }
    }
}

