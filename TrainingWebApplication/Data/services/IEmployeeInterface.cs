using TrainingWebApplication.Models;

namespace TrainingApi.Data.Interface
{
    public interface IEmployeeInterface
	{
		List<EmployeesDetails> GetEmployees();
        EmployeesDetails GetEmployeeById(int id);
        void UpdateEmployee(EmployeesDetails employee); 
        void DeleteEmployee(int id);
    }
}
