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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result =_brandService.GetAll();
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpPost("Add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
        [HttpPost("Update")]
        public IActionResult Update(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Success == true)
            {
                return Ok(result);
            }
            return BadRequest(" Messages '" + result.Message + "' Success '" + result.Success + "'");
        }
    }
}
