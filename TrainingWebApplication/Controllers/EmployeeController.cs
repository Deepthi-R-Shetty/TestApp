using Microsoft.AspNetCore.Mvc;
using TrainingApi.Data.Interface;
using TrainingWebApplication.Models;

namespace TrainingWebApplication.Controllers
{
	public class EmployeeController : Controller
	{
		private IEmployeeInterface _employeeInterface;
		public EmployeeController(IEmployeeInterface employeeInterface) 
		{ 
			_employeeInterface = employeeInterface;
			
		}

		public ActionResult GetAllEmployees() 
		{ 
			var result=_employeeInterface.GetEmployees();
			return View(result);
		}
        public ActionResult UpdateEmployee(EmployeesDetails employee)
        {
            if (ModelState.IsValid)
            {
                _employeeInterface.UpdateEmployee(employee);
                return RedirectToAction("GetAllEmployees");
            }
            return View(employee); // Return the view with validation errors if ModelState is not valid
        }
        public ActionResult DeleteEmployee(int id)
        {
            _employeeInterface.DeleteEmployee(id);
            return RedirectToAction("GetAllEmployees");
        }
        public ActionResult GetEmployeeById(int id)
        {
            var employee = _employeeInterface.GetEmployeeById(id);
            
            return View(employee);
        }
    }
}
