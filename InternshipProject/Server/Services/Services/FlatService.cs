using InternshipProject.Server.Services.Infrastruce;
using InternshipProject.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipProject.Server.Services.Services
{
    public class FlatService : IFlatService
    {
        public Task<FlatDTO> CreateFlat(FlatDTO Flat)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteFlatById(short Id)
        {
            throw new NotImplementedException();
        }

        public Task<FlatDTO> GetFlatById(short Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<FlatDTO>> GetFlats()
        {
            throw new NotImplementedException();
        }

        public Task<FlatDTO> UpdateFlat(FlatDTO Flat)
        {
            throw new NotImplementedException();
        }
    }
}
