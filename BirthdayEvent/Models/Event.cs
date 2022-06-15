using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthdayEvent.Models
{
    public class Event
    {
        [Key]

        public int eventId { get; set; }
        public string eventName { get; set; }
        public string applicantName { get; set; }
        public string ApplicantAddress { get; set; }
        public string applicantMobile { get; set; }
        public string applicantEmail { get; set; }
        public string eventAddress { get; set; }
        public string eventDate { get; set; }
        public string eventTime { get; set; }
        public int eventMenuId { get; set; }
        public int addonId { get; set; }
        public int EventCost { get; set; }
    }
}