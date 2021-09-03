using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipProject.Shared.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public String TC { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Phone { get; set; }
        public String BoodType { get; set; }
        public Boolean IsAdmin { get; set; }
        public String Password { get; set; }
        public Int16 FlatNumber { get; set; }
    }
}
