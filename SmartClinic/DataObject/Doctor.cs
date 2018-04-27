using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SmartClinic.DataObject
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Department { get; set; }

    }
}