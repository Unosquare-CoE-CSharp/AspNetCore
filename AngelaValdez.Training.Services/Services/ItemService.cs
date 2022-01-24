using AngelaValdez.Training.Data;
using AngelaValdez.Training.Data.Models;
using AngelaValdez.Training.Services.Abtractions;
using AngelaValdez.Training.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelaVadez.Training.Services.Services
{
    public class ItemService : RepositoryBase<Item>,IItemService
    {
        //TODO: We can inject this directly not needed to have a property
        ApplicationDbContext _context;
        public ItemService(ApplicationDbContext applicationDbContext)
            :base(applicationDbContext)
        {
            _context = applicationDbContext;
        }

        IQueryable<Item> IItemService.GetAllWitContainer()
        {
            return _context.Items.Include(item => item.Container);
        }
    }
}
