using Microsoft.AspNetCore.Mvc;
using MoviesContext.Transversal.Clases;
using MoviesContext.Transversal.Interfaces;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFNgApp.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployee objemployee;

        public EmployeeController(IEmployee _objemployee)
        {
            objemployee = _objemployee;
        }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<TblEmployee> Index()
        {
            return objemployee.GetAllEmployees();
        }
        /// <summary>
        /// Send tblEmployee object         
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///{
        ///  "employeeId": 0,
        ///  "name": "string",
        ///  "city": "string",
        ///  "department": "string",
        ///  "gender": "string"
        ///}
        ///
        /// </remarks>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] TblEmployee employee)
        {
            return objemployee.AddEmployee(employee);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public TblEmployee Details(int id)
        {
            return objemployee.GetEmployeeData(id);
        }

        /// <summary>
        /// Send tblEmployee object         
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///{
        ///  "employeeId": 0,
        ///  "name": "string",
        ///  "city": "string",
        ///  "department": "string",
        ///  "gender": "string"
        ///}
        ///
        /// </remarks>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Edit")]
        public int Edit([FromBody] TblEmployee employee)
        {
            return objemployee.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public int Delete(int id)
        {
            return objemployee.DeleteEmployee(id);
        }

        [HttpGet]
        [Route("GetCityList")]
        public IEnumerable<TblCities> Details()
        {
            return objemployee.GetCities();
        }
    }
}
