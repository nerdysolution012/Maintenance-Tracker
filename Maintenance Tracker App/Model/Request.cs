using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maintenance_Tracker_App.Model
{
    public class Request
    {
        public int requestId { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string Urgency { get; set; }
        public string Status { get; set; }
    }
}
