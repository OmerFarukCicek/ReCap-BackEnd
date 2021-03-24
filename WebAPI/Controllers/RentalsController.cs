﻿using Business.Abstract;
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
        ICreditCardService _creditCardService;

        public RentalsController(IRentalService rentalService, ICreditCardService creditCardService)
        {
            _rentalService = rentalService;
            _creditCardService = creditCardService;
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
                var result = _rentalService.Add(rental); 

                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdetails")]
        public IActionResult GetRentalDetails(int id)
        {
            var result = _rentalService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getlastrental")]
        public IActionResult GetLast(int carId)
        {
            var result = _rentalService.GetLastRentalOfCar(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
