using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthdayEvent.Models
{
    public class AddOn
    {
        [Key]
        public int addOnId { get; set; }
        public string addOnName { get; set; }
        public string addOnDescription { get; set; }
        public long addOnPrice { get; set; }
        public string addOnImageURL { get; set; }
    }
}