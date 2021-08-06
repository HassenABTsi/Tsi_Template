using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsi.Template.Domain.Grh;
using Tsi.Template.ViewModels.Grh;

namespace Tsi.Template.Helpers.Grh
{
    public static class DepartementExtensions
    {
        public static IEnumerable<DepartementViewModel> ToViewModels(this IEnumerable<Departement> departements)
        {
            foreach(var item in departements)
            {
                yield return item.ToViewModel();
            }
        }

        public static DepartementViewModel ToViewModel(this Departement departement) => new()
        {
            Id = departement.Id,
            Code = departement.code,
            Libelle = departement.Libelle
            
        };
    }
}
