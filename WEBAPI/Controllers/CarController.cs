using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Domain;

namespace MyFirstAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarController : ControllerBase
{
    [HttpPost]
    public void Create([FromBody] Car newCar)
    {
        CarsRepository.AddCar(newCar);
    }

    [HttpGet]
    public ActionResult<List<Car>> Get()
    { 
        return CarsRepository.GetAllCars();
    }

    [HttpGet("{make}")]
    public IActionResult GetSpecificMake(string make)
    {
         var filteredList = CarsRepository.GetAllCars().Where(c => c.Make == make);

        return Ok(filteredList);
    }


    [HttpDelete("{liscensePlate}")]
    public void Delete(string liscensePlate)
    {
        CarsRepository.DeleteCar(liscensePlate);
    }

    }


