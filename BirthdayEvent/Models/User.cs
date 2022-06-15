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
        public string Email { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string password { get; set; }

        [Required(ErrorMessage = "Mobile Number is Required")]
        public string mobileNumber { get; set; }

        public string userRole { get; set; }
        public object LoginErrorMessge { get; internal set; }
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
