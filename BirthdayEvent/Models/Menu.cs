using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthdayEvent.Models
{
    public class Menu
    {
        [Key]
        public int foodMenuId { get; set; }
        public string foodMenuImageURL { get; set; }
        public string foodMenuType { get; set; }
        public string foodMenuItems { get; set; }
        public long foodMenuCost { get; set; }
    }
}