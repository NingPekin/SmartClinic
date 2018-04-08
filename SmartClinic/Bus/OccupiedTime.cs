using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartClinic.Bus
{
    public class OccupiedTime
    {
        private int occupiedId { get; set; }
        private DateTime date { get; set; }
        private int time { get; set; }
        private Doctor docter { get; set; }
    }
}