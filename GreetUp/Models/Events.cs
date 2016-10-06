using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace greet_up.Models
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        [Display(Name = "Event Name")]
        public string EventName { get; set; }
        [Display(Name = "Date")]
        public DateTime EventDate { get; set; }
        [Display(Name = "Location")]
        public string EventLocation { get; set; }
        [Display(Name = "Description")]
        public string EventDescription { get; set; }
        [Display(Name = "Number Attending")]
        public int EventAttendee { get; set; }
    }
}