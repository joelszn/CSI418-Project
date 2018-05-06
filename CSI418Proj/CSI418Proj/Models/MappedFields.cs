using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;
using System.ComponentModel.DataAnnotations;


namespace CSI418Proj.Models
{
    public class MappedFields
    {
        [Key]
        public int FieldID { get; set; }
        public String Field1 { get; set; }
        public String Field2 { get; set; }
        public String Field3 { get; set; }
        public String Field4 { get; set; }
        public String Field5 { get; set; }
        public String Field6 { get; set; }
        public String Field7 { get; set; }
        public String Field8 { get; set; }
        public String Field9 { get; set; }
        public String Field10 { get; set; }
        public String Field11 { get; set; }
    }
}