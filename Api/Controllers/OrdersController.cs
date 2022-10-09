using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EF;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        //Loosly Coupled
        //IOC -> Inversion of Control

        IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
          _orderService = orderService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
          var res = _orderService.GetAll();

          if (res.Success)
          {
            return Ok(res);
          }
            return BadRequest(res);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(Guid id)
        {
          var res = _orderService.Get(id);
          if (res.Success)
          {
            return Ok(res);
          }

          return BadRequest(res.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Order order)
        {
          var res = _orderService.Add(order);
          if (res.Success)
          {
            return Ok(res);
          }
          return BadRequest(res.Message);
        }
    }
}