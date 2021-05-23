using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_Project.Controllers
{
    //Defines an class as a controller
    [ApiController]
    //Define the route for the controller
    [Route("/api/[controller]")]
    //Our class should inherit from controllerbase
    public class WarehouseController : ControllerBase
    {
        //IWarehouseService _warehouseService;
        //public WarehouseController(IWarehouseService warehouseService)
        //{
        //    _warehouseService = warehouseService;
        //}

        [HttpGet("GetWarehouse")]
        public IActionResult GetWarehouse([FromServices] IWarehouseService _warehouseService)
        {
            var x = _warehouseService.GetWarehouses();
            return Ok(x);
        }

        //api/GetWarehouseByQueryId?Id=1 ---> Query String   
        [HttpGet("GetWarehouseByQueryId")]
        public IActionResult GetWarehouseById([FromQuery] int id)
        {
            return Ok($"I received an id {id}");
        }

        //api/GetWarehouseByQueryId/1 ---> From Route 
        [HttpGet("GetWarehouseByRouteId/{Id}/{name}")]
        public IActionResult GetWarehouseByRoute([FromRoute] int id, [FromRoute] string name)
        {
            return Ok($"I received an id {id}, and a name {name}");
        }

        [HttpPost("AddWarehouse")]
        public IActionResult AddWarehouse([FromBody] Warehouse warehouse)
        {
            return Ok($"I created a warehouse {JsonConvert.SerializeObject(warehouse)}");
        }

    }
}
