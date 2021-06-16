using EmployeeApplication.API.Interfaces;
using EmployeeApplication.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        public IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Ok("test successful");
        }

        [HttpGet("getinfo/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var employee = _employeeService.GetEmployee(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error getting the data: " + ex.Message);
            }
        }

        [HttpPost("insert")]
        public IActionResult Create([FromBody]Employee employee)
        {
            try
            {
                employee = _employeeService.InsertEmployee(employee);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error inserting the data: " + ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Edit([FromBody] Employee employee)
        {
            try
            {
                employee = _employeeService.UpdateEmployee(employee);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error updating the data: " + ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                var employee = _employeeService.DeleteEmployee(id);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error updating the data: " + ex.Message);
            }
        }
    }
}
