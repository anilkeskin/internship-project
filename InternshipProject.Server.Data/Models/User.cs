using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InternshipProject.Server.Data.Models
{
    [Table("Users")]
    public class User:BaseEntity
    {
        public User()
        {
            Id = Guid.NewGuid();
        }
        public String TC { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Phone { get; set; }
        public String BoodType { get; set; }
        public Boolean IsAdmin { get; set; }
        public String Password { get; set; }

        public Int16 FlatNumber { get; set; }
        [ForeignKey("FlatNumber")]
        public virtual Flats Flats { get; set; }

    }
}
