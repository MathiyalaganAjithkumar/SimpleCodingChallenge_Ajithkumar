using MediatR;

using Microsoft.AspNetCore.Mvc;
using SimpleCodingChallenge.Business.Actions.Employees;
using SimpleCodingChallenge.Common.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace SimpleCodingChallenge.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class EmployeesController : Controller
    {
        private readonly IMediator mediator;
       

        
       

        public EmployeesController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        
        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<EmployeeDto>>> Index()
        {
            var result = await mediator.Send(new GetAllEmployeesCommand());
            return result.EmployeeList;
        }


        public async Task<ActionResult<EmployeeDto>> Create()
        {
            return null;
        }



    }
        //[HttpPost]
        //public async Task<ActionResult> AddProduct([FromBody] EmployeeDto employeeDto)
        //{
        //    {
        //        await mediator.Send(new AddProductCommand(employeeDto));

        //        return StatusCode(201);
        //    }




            //[HttpPost]
            //public async Task<ActionResult<EmployeeDto>> CreateEmployee(EmployeeDto employeedto)
            //{
            //    try
            //    {
            //        if (employeedto == null)
            //            return BadRequest();

            //        var createdEmployee = await mediator.Send(employeedto);

            //        return CreatedAtAction(nameof(Index),
            //            new { id = createdEmployee.EmployeeId }, createdEmployee);
            //    }
            //    catch (Exception)
            //    {
            //        return StatusCode(StatusCodes.Status500InternalServerError,
            //            "Error creating new employee record");
            //    }
            //}




            //{
            //    var command = new EmployeesController(employeeDto);
            //    var response = await mediator.Send(command);
            //    return (ActionResult<List<EmployeeDto>>)response;
            //}



    
}


