using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CIS.Services
{

   public interface IDashboardService
    {
        public Task<IEnumerable<Models.PrescriptionCount>> GetPrescriptionCount(int DoctorId);
    }
}
