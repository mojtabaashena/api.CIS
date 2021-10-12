
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CIS.Models
{
    public class PrescriptionCount
    {
        public int Count { get; set; }

        public string IssueDate { get; set; }

        public int BimehId { get; set; }

        public string BimehName { get; set; }

        public int StatusId { get; set; }

        public string StatusName { get; set; }
    }
}
