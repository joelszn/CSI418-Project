using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CSI418Proj.Models
{
    public class HREntry
    {
        [Key]
        public int id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Department { get; set; }

        public String JobTitle { get; set; }

        public double HourlyPay { get; set; }

        public String EmploymentStatus { get; set; }

        public String Address { get; set; }

        public String PhoneNumber { get; set; }

        public String Email { get; set; }

        public String ImagePath { get; set; }

    }
}