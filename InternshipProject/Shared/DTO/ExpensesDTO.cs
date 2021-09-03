using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipProject.Shared.DTO
{
    public class ExpensesDTO
    {
        public Guid ExId { get; set; }
        public String ExName { get; set; }
        public Double Total { get; set; }
        public DateTime ExDate { get; set; }

        public Guid UserId { get; set; }
    }
}
