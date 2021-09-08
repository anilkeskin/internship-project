using InternshipProject.Server.Services.Infrastruce;
using InternshipProject.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Services
{
    public class ExpenseService : IExpenseService
    {
        public Task<ExpensesDTO> CreateExpense(ExpensesDTO Expense)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteExpenseById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<ExpensesDTO> GetExpenseById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ExpensesDTO>> GetExpenses()
        {
            throw new NotImplementedException();
        }

        public Task<ExpensesDTO> UpdateExpense(ExpensesDTO Expense)
        {
            throw new NotImplementedException();
        }
    }
}
