using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace InternshipProject.Server.Data.Models
{
    [Table("Flats")]
    public class Flats
    {
        public Int16 FlatNumber { get; set; }
        public Int16 Floor { get; set; }
        public Boolean IsBaloncy { get; set; }
        public Int16 NoRooms { get; set; }
    }
}
