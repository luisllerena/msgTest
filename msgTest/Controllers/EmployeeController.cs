using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mgcTest.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mgcTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IBusinessService _businessService;
        public EmployeeController(IBusinessService businessService)
        {
            _businessService = businessService;
        }

        public ActionResult GetEmployees()
        {
            var employeeList = _businessService.GetEmployees();
            return Ok(employeeList);
        }

        [HttpGet("{id}")]
        public ActionResult GetEmployeeById(int id)
        {
            var employeeList = _businessService.GetEmployeeById(id);
            return Ok(employeeList);
        }
    }
}
