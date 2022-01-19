using AngelaValdez.Training.Data.Models;
using AngelaValdez.Training.Services.Abtractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelaValdez.Training.Services.Contracts
{
    public interface IItemService : IRepositoryBase<Item>
    {
        IQueryable<Item> GetAllWitContainer();
    }
}
