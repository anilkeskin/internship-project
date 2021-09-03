using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipProject.Shared.DTO
{
    public class DebtDTO
    {
        public Guid DebtId { get; set; }
        public String DebtName { get; set; }
        public Double Total { get; set; }
        public Int16 FlatNumber { get; set; }
    }
}
