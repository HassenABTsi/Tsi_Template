using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Domain.Grh;

namespace Tsi.Template.Abstraction.Grh
{
    public interface IDepartementService
    {
        Task<Departement> CreateDepartementAsync(Departement departement);

        Task DeleteDepartementAsync(int id);

        Task<IEnumerable<Departement>> GetAllAsync();
    }
}
