using AngelaVadez.Training.Services.Contracts;
using AngelaVadez.Training.Services.Services;
using AngelaValdez.Training.Data;
using AngelaValdez.Training.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelaValdez.Training.Services.Services
{
    public class RepositoryService : IRepositoryService
    {
        private ApplicationDbContext _applicationDbContext;
        private IWarehouseService _warehouse;
        private IItemService _item;
        public IWarehouseService Warehouse
        {
            get
            {
                if (_warehouse == null)
                {
                    _warehouse = new WarehouseService(_applicationDbContext);
                }
                return _warehouse;
            }
        }
        public IItemService Item
        {
            get
            {
                if (_item == null)
                {
                    _item = new ItemService(_applicationDbContext);
                }
                return _item;
            }
        }
        public RepositoryService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public void Save()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}

