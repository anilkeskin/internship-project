using InternshipProject.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Infrastruce
{
    public interface IDebtService
    {
        public Task<DebtDTO> GetDebtById(Guid Id);

        public Task<List<DebtDTO>> GetDebts();

        public Task<DebtDTO> CreateDebt(DebtDTO Debt);

        public Task<DebtDTO> UpdateDebt(DebtDTO Debt);

        public Task<bool> DeleteDebtById(Guid Id);

    }
}
