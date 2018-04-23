using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartClinic.DataObject
{
    public class OccupiedTime
    {
        [Key]
        public int OccupiedId { get; set; }
        public DateTime Date { get; set; }
        public String Time { get; set; }
        //public int DocterId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}