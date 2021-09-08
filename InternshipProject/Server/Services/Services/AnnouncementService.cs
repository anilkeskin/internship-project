using InternshipProject.Server.Services.Infrastruce;
using InternshipProject.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        public Task<AnnouncementDTO> CreateAnnouncement(AnnouncementDTO Announcement)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteExpenseById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<AnnouncementDTO> GetAnnouncementById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AnnouncementDTO>> GetAnnouncements()
        {
            throw new NotImplementedException();
        }

        public Task<AnnouncementDTO> UpdateAnnouncement(AnnouncementDTO Announcement)
        {
            throw new NotImplementedException();
        }
    }
}
