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
    public class WarehouseController : ControllerBase
    {
        IWarehouseService _warehouseService;
        IRepositoryService _repositoryService;
        public WarehouseController(IRepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
            _warehouseService = repositoryService.Warehouse;
        }

        [HttpGet]
        public IActionResult GetWarehouse()
        {
            var x = _warehouseService.GetAll();
            return Ok(x);
        }

        [HttpGet("WarehousesWithItems")]
        public IActionResult GetWarehousesWithItems()
        {
            var x = _warehouseService.GetAllWitItems();
            return Ok(x);
        }

        //api/GetWarehouseByQueryId?Id=1 ---> Query String   
        [HttpGet("WarehouseByQueryId")]
        public IActionResult GetWarehouseById([FromQuery] Guid id)
        {
            var x = _warehouseService.GetAll(warehouse=> warehouse.Id == id);
            return Ok(x);
        }

        //api/GetWarehouseByQueryId/1 ---> From Route 
        [HttpGet("WarehouseByRouteId/{Id}/{name}")]
        public IActionResult GetWarehouseByRoute([FromRoute] Guid id, [FromRoute] string name)
        {
            var x = _warehouseService.GetAll(warehouse => warehouse.Id == id && warehouse.Name == name);
            return Ok(x);
        }

        [HttpPost]
        public IActionResult AddWarehouse([FromBody] Warehouse warehouse)
        {
            _warehouseService.Add(warehouse);
            _repositoryService.Save();
            return Ok($"I created a warehouse {JsonConvert.SerializeObject(warehouse)}");
        }

    }
}
