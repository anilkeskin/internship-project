using InternshipProject.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Infrastruce
{
    public interface IFlatService
    {
        public Task<FlatDTO> GetFlatById(Int16 Id);

        public Task<List<FlatDTO>> GetFlats();

        public Task<FlatDTO> CreateFlat(FlatDTO Flat);

        public Task<FlatDTO> UpdateFlat(FlatDTO Flat);

        public Task<bool> DeleteFlatById(Int16 Id);

    }
}
