﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Tsi.Template.Domain.Gesc.Catalog;
using Tsi.Template.ViewModels.Catalog;

namespace Tsi.Template.Abstraction.Catalog
{
    public interface IProductService
    {
        public Task<Product> CreateProductAsync(Product product); 
        public Task DeleteProductAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync(); 
        Task<Product> GetProductByIdAsync(int id);

        Task UpdateProductAsync(int id, ProductViewModel model);
    }
}
