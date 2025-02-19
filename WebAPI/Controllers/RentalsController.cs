﻿using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpGet("GetRentalDetails")]
        public IActionResult GetRentalDetails()
        {
            var result = _rentalService.GetRentaltDetails();
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _rentalService.GetById(id);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpPost("Add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpPost("Update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
    }
}
