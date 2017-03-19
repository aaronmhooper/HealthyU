using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HealthyU.Models
{
    public class Activities
    {
        [Key]
        public int ActivityID { get; set; }

        [Display(Name = "Activity")]
        public string Name { get; set; }

        public int Points { get; set; }

        public int Duration { get; set; }

        public bool RequireValidation { get; set; }

        public bool Validated { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateComplete { get; set; }
    }
}