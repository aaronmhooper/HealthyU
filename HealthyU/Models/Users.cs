using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HealthyU.Models
{
    public class Users
    {   
        [Key]
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string UserPhone { get; set; }

        public bool IsAdmin { get; set; }

        public int PointTotal { get; set; }

        public List<Activities> UserActivities { get; set; }
    }
}