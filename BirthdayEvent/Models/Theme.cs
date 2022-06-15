using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthdayEvent.Models
{
    public class Theme
    {
        [Key]
        public int themeId { get; set; }
        public string themeName { get; set; }
        public string themeImageURL { get; set; }
        public string themeAddress { get; set; }
        public string themeDescription { get; set; }
        public string themePhotographer { get; set; }
        public string themeVideographer { get; set; }
        public string themeReturnGift { get; set; }
        public long themeCost { get; set; }
    }
}