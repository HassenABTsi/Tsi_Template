using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Abstraction.Grh;
using Tsi.Template.Core.Attributes;
using Tsi.Template.Domain.Grh;
using Tsi.Template.Infrastructure.Repository;

namespace Tsi.Template.Services.Grh
{
    [Injectable(typeof(IDepartementService))]
    class DepartementService : IDepartementService
    {
        private readonly IRepository<Departement> _departementRepo;

        public DepartementService(IRepository<Departement> departementRepo)
        {
            _departementRepo = departementRepo;
        }

        public async Task<Departement> CreateDepartementAsync(Departement departement)
        {
            return await _departementRepo.AddAsync(departement);
        }

        public async Task DeleteDepartementAsync(int id)
        {
            await _departementRepo.DeleteAsync(d => d.Id == id);
        }

        public async Task<IEnumerable<Departement>> GetAllAsync()
        {
            return await _departementRepo.GetAllAsync();
        }
    }
}
