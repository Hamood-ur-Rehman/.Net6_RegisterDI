using Entities.Employee;

namespace RegisterDependencyInjection
{
    public interface IEmployeeDetails
    {
       public Task<List<EmployeeBasicDetails>> GetEmployee();
    }
}
