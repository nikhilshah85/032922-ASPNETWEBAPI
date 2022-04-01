using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dependencyInjection_demo.Models;
namespace dependencyInjection_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //  Employee empObj = new Employee(); //this is not good
        //this object to be managed by the framework

        //how do you want the lifecycle of this object to be maintained
        //.          - Scoped - a object per session
        //1. same object instace to be used for all the calls ? - 
        //           - Transcient
        //2. new object everytime for every call 
        //           - Singleton
        //3. same object instance, to be shared with all incoming request by 200 users accross the world --

        Employee empObj; // object will be created by runtime, and runtime needs to ibject the reference of that obj 
                         //in this controller

        //we can collect the obj reference at 2 places
        //1. in the contructor(more recommended)
        //2. in the method, only if you have 1 method to be used

        public EmployeeController(Employee empObjRef) //depndency injected
        {
            empObj = empObjRef;
        }



        [HttpGet]
        [Route("employee")]
        public IActionResult GetEmployee()
        {
            //if we do not create the object, we will not be able to invoke this method
            return Ok(empObj.GetEmployee());
        }



        [HttpGet]
        [Route("elist")]
        public IActionResult GetEmployeeList()
        {
            //if we do not create the object, we will not be able to invoke this method
            return Ok(empObj.GetListOfEmployee());
        }





    }
}
