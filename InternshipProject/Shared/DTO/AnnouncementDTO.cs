using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipProject.Shared.DTO
{
    public class AnnouncementDTO
    {
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String AnText { get; set; }
        public DateTime AnDate { get; set; }
        public Guid UserId { get; set; }
    }
}
