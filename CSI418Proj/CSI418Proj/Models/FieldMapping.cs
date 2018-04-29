using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CSI418Proj.Models
{
    public class FieldMapping
    {
        [Key]
        public int id { get; set; }

        public String FieldNum { get; set; }

        public String FieldName { get; set; }
    }
}