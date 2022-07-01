using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BirthdayEvent.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }

        [Required(ErrorMessage = "Email Id is Required")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6, ErrorMessage = "Need min 6 character")]
        public string password { get; set; }

        [Required(ErrorMessage = "Confirm is Required")]
        [Compare("password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Mobile Number is Required")]
        public string mobileNumber { get; set; }

        [Required(ErrorMessage = "User Role is Required")]
        public string userRole { get; set; }

        public string LoginErrorMessge { get; set; }

    }
    public class DBContextClass : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Theme> themes { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<AddOn> AddOn { get; set; }
    }
}
