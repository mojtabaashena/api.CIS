using api.CIS.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.CIS.Services
{
    public class DashboardService :IDashboardService
    {
        private readonly Data.DapperContext _context;
        public DashboardService(Data.DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PrescriptionCount>> GetPrescriptionCount(int DoctorId)
        {
            var query = $"SELECT * FROM dbo.fn_PrCount_GroupByDate_Bimeh_Status({DoctorId})";
            using (var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<PrescriptionCount>(query);
                return companies.ToList();
            }
        }
    }
}
