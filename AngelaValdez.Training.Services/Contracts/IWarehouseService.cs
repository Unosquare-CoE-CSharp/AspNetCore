using AngelaValdez.Training.Data.Models;
using AngelaValdez.Training.Services.Abtractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelaVadez.Training.Services.Contracts
{
    public interface IWarehouseService : IRepositoryBase<Warehouse>
    {
        IQueryable<Warehouse> GetAllWitItems();
    }
}
