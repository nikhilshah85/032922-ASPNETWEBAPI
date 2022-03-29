using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using employeeWebAPI.Models;
namespace employeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeModelController : ControllerBase
    {

        EmployeeModel empObj = new EmployeeModel(); //we created the new object of a model
                                        //In .net core it is not recommeded to create any object, as you will be responsible to destroy the object
                                        //We use DI (dependency injection, an inbuilt feature of .net core, which will create the obj for you)
                

        [HttpGet]
        [Route("employee")] //this is called routing 
        public ActionResult EmployeeDetails()
        {
            
            return Ok(empObj.GetEmployee());
        }
        [HttpGet]
        [Route("elist")]
        public IActionResult Employeelist()
        {
            return Ok(empObj.GetEmployeeModelsList());

        }

        [HttpPost]
        [Route("addemp")]
        public IActionResult AccNewEmployee(EmployeeModel newEmp)
        {
            //write the code, to call a method from model file, which will accept the newEmp obj, validate it, add it to the source
            //for learning purpose, lets do small validation of data, Note: Model is suppose to do it
            if (newEmp.empSalary < 25000)
            {
                return BadRequest("Please provide a valid salary, this employee is not added to the system yet");
            }
            else if(newEmp.empName.Length < 3)
            {
                return BadRequest("Name is not valid");
            }

            return Created("", "Employee Added Successfully to the data source");
        }

        [HttpPut]
        [Route("edit")]
        public IActionResult EditEmployee(EmployeeModel changes)
        {
            //pass the changes to model method
            return Accepted("Employee details has been updated successfully");
        }
        [HttpDelete]
        [Route("remove")]
        public IActionResult DeleteEmployee(int empNo)
        {
            if (empNo == 100)
            {
                return NotFound("Employee Not found in system");
            }
            return Ok("Employee Deleted Successfully");
        }


    }
}





