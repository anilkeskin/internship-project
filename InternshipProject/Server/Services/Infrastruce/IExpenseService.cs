using InternshipProject.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Infrastruce
{
    public interface IExpenseService
    {
        public Task<ExpensesDTO> GetExpenseById(Guid Id);

        public Task<List<ExpensesDTO>> GetExpenses();

        public Task<ExpensesDTO> CreateExpense(ExpensesDTO Expense);

        public Task<ExpensesDTO> UpdateExpense(ExpensesDTO Expense);

        public Task<bool> DeleteExpenseById(Guid Id);

    }
}
