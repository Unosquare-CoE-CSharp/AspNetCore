using AngelaVadez.Training.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelaValdez.Training.Services.Contracts
{
    public interface IRepositoryService
    {
        IWarehouseService Warehouse { get; }
        IItemService Item { get; }
        void Save();
    }
}
