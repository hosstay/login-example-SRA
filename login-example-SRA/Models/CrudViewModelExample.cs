// using System;
// using System.ComponentModel.DataAnnotations;

// namespace login_example_SRA.Models
// {
//     public class UsersViewModel
//     {
//         public int Id { get; set; }

//         [Required(ErrorMessage = "Username is required.")]
//         public string Username { get; set; }

//         // [Display(Name = "Email Address")]
//         // [Required(ErrorMessage = "Email Address is required.")]
//         // [DataType(DataType.EmailAddress)]
//         // public string Email { get; set; }
        
//         [Display(Name = "Password")]
//         [Required(ErrorMessage = "Password is required.")]
//         [DataType(DataType.Password)]
//         [StringLength(100, MinimumLength = 8, ErrorMessage = "You need to provide a password 8-100 characters long.")]
//         public string Password { get; set; }

//         [Display(Name = "Confirm Password")]
//         [Compare("Password", ErrorMessage = "Password and Confirm Password must match.")]
//         public string ConfirmPassword { get; set; }
//     }
// }