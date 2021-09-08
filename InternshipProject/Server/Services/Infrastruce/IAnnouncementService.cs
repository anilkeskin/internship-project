using InternshipProject.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Infrastruce
{
    public interface IAnnouncementService
    {
        public Task<AnnouncementDTO> GetAnnouncementById(Guid Id);

        public Task<List<AnnouncementDTO>> GetAnnouncements();

        public Task<AnnouncementDTO> CreateAnnouncement(AnnouncementDTO Announcement);

        public Task<AnnouncementDTO> UpdateAnnouncement(AnnouncementDTO Announcement);

        public Task<bool> DeleteExpenseById(Guid Id);

    }
}
