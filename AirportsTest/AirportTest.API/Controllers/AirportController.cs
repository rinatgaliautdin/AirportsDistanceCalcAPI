using AirportTest.API.ViewModels;
using AirportTest.BusinessLogic;
using AirportTest.DataAccess.Interfaces;
using AirportTest.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirportTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportRepository _airportRepository;

 
        public AirportController(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }


        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                IEnumerable<Airport> _airports = _airportRepository.GetAll().ToList();

                IEnumerable<AirportViewModel> _airportVM = Mapper.Map<IEnumerable<Airport>, IEnumerable<AirportViewModel>>(_airports);

                return Ok(_airportVM);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpGet]
        [Route("GetDetails/{code}")]
        public IActionResult GetDetails(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return BadRequest();
            }

            try
            {
                var port = _airportRepository.GetSingle(p => p.Code==code);
                var portVM = Mapper.Map<Airport, AirportViewModel>(port);

                return Ok(portVM);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpGet]
        [Route("GetDistance/{code1}/{code2}")]
        public IActionResult GetDistance(string code1, string code2)
        {
            try
            {
                var port1 = _airportRepository.GetSingle(p => p.Code == code1);
                var port2 = _airportRepository.GetSingle(p => p.Code == code2);

                if (port1 == null || port2 == null)
                {
                    return BadRequest();
                }

                var distance = DistanceCalculator.CalculateDistanceInMeters(port1, port2);

                return Ok(distance);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
 
    }//class
}