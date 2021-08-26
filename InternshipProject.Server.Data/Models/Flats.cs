using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InternshipProject.Server.Data.Models
{
    [Table("Flats")]
    public class Flats
    {
        public Flats()
        {
            Users = new List<User>();
            Debts = new List<Debt>();
        }
        [Key]
        public Int16 FlatNumber { get; set; }
        public Int16 Floor { get; set; }
        public Boolean IsBaloncy { get; set; }
        public Int16 NoRooms { get; set; }

        public List<User> Users { get; set; }

        public List<Debt> Debts { get; set; }
    }
}
