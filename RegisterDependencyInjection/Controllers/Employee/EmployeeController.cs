using Entities.Employee;
using Microsoft.AspNetCore.Mvc;

namespace RegisterDependencyInjection.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeDetails _employeeService;
        public EmployeeController(IEmployeeDetails employeeService)
        {

            _employeeService = employeeService;
        }

        [Route("GetEmployeeList")]
        [HttpGet]
        public async Task< IEnumerable<EmployeeBasicDetails>> GetEmployeeList()
        {
            var res =await _employeeService.GetEmployee();
            return res;
        }
    }
}
