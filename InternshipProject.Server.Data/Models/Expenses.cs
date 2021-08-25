using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InternshipProject.Server.Data.Models
{
    [Table("Expenses")]
    public class Expenses:BaseEntity
    {
        public Expenses()
        {
            Id = Guid.NewGuid();
        }
        public String ExName { get; set; }
        public Double Total { get; set; }
        public DateTime ExDate { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
