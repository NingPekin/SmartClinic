using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SmartClinic.DataObject
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }
        //public int PatientId { get; set; }
        //public int DocterId { get; set; }

        public DateTime Date { get; set; }
        public String Time { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; } 

    }
}