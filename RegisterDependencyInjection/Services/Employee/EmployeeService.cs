using Entities.Employee;

namespace RegisterDependencyInjection.Services.Employee
{
    public class EmployeeService : IEmployeeDetails
    {
        public async Task<List<EmployeeBasicDetails>> AddingEmployee(EmployeeBasicDetails employeeBasicDetails)
        {
            List<EmployeeBasicDetails> listOfEmp =await GetEmployee();
           var newEmp =  new EmployeeBasicDetails()
            {
                Id = 1,
                Title = employeeBasicDetails.Title,
                Name = employeeBasicDetails.Name,
                Age = employeeBasicDetails.Age,
                EmailId = employeeBasicDetails.EmailId,
                MobileNumber = employeeBasicDetails.MobileNumber,
                Address = employeeBasicDetails.Address,
                Pincode = employeeBasicDetails.Pincode

           };
            listOfEmp.Add(newEmp);
            return listOfEmp;
        }

        public async Task<List<EmployeeBasicDetails>> GetEmployee()
        {
            var employees = new List<EmployeeBasicDetails>()
        {
            new EmployeeBasicDetails()
            {
                Id = 1,
                Title = "Mr",
                Name = "Simon",
                Age = 32,
                EmailId = "test@mailinator.com",
                MobileNumber= "12346",
                Address = "Pune",
                Pincode =   411057

            },
            new EmployeeBasicDetails()
            {
                Id = 2,
                Title = "Mr",
                Name = "David",
                Age = 35,
                EmailId = "David@mailinator.com",
                MobileNumber= "654323456",
                Address = "Mumbai",
                Pincode =   221011
            },
            new EmployeeBasicDetails()
            {
                Id = 3,
                Title = "Mr",
                Name = "Peter",
                Age = 29,
                EmailId = "Peter@mailinator.com",
                MobileNumber= "54323456",
                Address = "Lucknow",
                Pincode =   221100

            }
        };
            return employees;
        }
    }
}
