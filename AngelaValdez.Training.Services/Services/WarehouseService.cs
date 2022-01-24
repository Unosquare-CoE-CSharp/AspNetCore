using AngelaVadez.Training.Services.Contracts;
using AngelaValdez.Training.Data;
using AngelaValdez.Training.Data.Models;
using AngelaValdez.Training.Services.Abtractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelaVadez.Training.Services.Services
{
    public class WarehouseService : RepositoryBase<Warehouse>,IWarehouseService
    {
        //TODO: We can inject this directly not needed to have a property
        ApplicationDbContext _applicationDbContext { get; set; }
        public WarehouseService(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IQueryable<Warehouse> GetAllWitItems()
        {
            return _applicationDbContext.Warehouses.Include(warehouse=>warehouse.Items);
        }
    }
}
