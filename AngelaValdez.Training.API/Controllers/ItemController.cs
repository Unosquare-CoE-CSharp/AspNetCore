using AngelaVadez.Training.Services.Contracts;
using AngelaValdez.Training.Data.Models;
using AngelaValdez.Training.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_Project.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ItemController : ControllerBase
    {
        IItemService _itemService;
        IRepositoryService _repositoryService;
        public ItemController(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
            _itemService = repositoryService.Item;
        }

        [HttpGet]
        public IActionResult GetItem()
        {
            var x = _itemService.GetAll();
            return Ok(x);
        }

        [HttpGet("ItemsWithContainer")]
        public IActionResult GetItemWithContainer()
        {
            var x = _itemService.GetAllWitContainer();
            return Ok(x);
        }
 
        [HttpGet("ItemByQueryId")]
        public IActionResult GetItemById([FromQuery] Guid id)
        {
            var x = _itemService.GetAll(item=> item.Id == id);
            return Ok(x);
        }
        [HttpGet("ItemByRouteId/{Id}/{type}")]
        public IActionResult GetItemByRoute([FromRoute] Guid id, [FromRoute] string type)
        {
            var x = _itemService.GetAll(item => item.Id == id && item.Type == type);
            return Ok(x);
        }

        [HttpPost]
        public IActionResult AddItem([FromBody] Item item)
        {
            _itemService.Add(item);
            _repositoryService.Save();
            return Ok($"I created an item {JsonConvert.SerializeObject(item)}");
        }

    }
}
