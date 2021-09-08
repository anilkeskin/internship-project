using InternshipProject.Server.Services.Infrastruce;
using InternshipProject.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Services
{
    public class DebtService : IDebtService
    {
        public Task<DebtDTO> CreateDebt(DebtDTO Debt)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDebtById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<DebtDTO> GetDebtById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<DebtDTO>> GetDebts()
        {
            throw new NotImplementedException();
        }

        public Task<DebtDTO> UpdateDebt(DebtDTO Debt)
        {
            throw new NotImplementedException();
        }
    }
}
