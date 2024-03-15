using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainingApi.Data;

namespace TrainingApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeDetailController : ControllerBase
	{
		private readonly EmployeeDBContext employeeDBContext;
        public EmployeeDetailController(EmployeeDBContext _employeeDBContext)
        {

			employeeDBContext = _employeeDBContext;
        }
		[HttpGet]
		public IActionResult GetEmployeedetails()
		{
			var result = employeeDBContext.EmployeesDetails.ToList();
			return Ok(result);
		}

		[HttpGet("id")]
		public IActionResult GetEmployeeid()
		{
			var result = employeeDBContext.EmployeesDetails.ToList().Find(i => i.Id ==1);
			return Ok(result);
		}
		[HttpDelete]
		public IActionResult DeleteEmployee()
		{
			//var result = employeeDBContext.EmployeesDetails.ToList();
			var result1= employeeDBContext.EmployeesDetails.ToList().Find(i => i.Id == 2);
			employeeDBContext.Remove(result1);
			employeeDBContext.SaveChanges();
			if(result1 != null)
			{
				return Ok("data deleted");
			}
			else { return BadRequest(); }


		}
		[HttpPost]
		public IActionResult InsertEmployeeData()
		{
			EmployeesDetails emp1= new EmployeesDetails();
			emp1.EmployeeName = "deepthi";
			emp1.project = "mea";
			employeeDBContext.Add(emp1);
			employeeDBContext.SaveChanges();
			return Ok();
		}

		[HttpGet("combinedtable")]
		public IActionResult GetEmployees()
		{
			var result = (from e in employeeDBContext.EmployeesDetails
						  
						  from p in employeeDBContext.employeeprojectdetail
						  where e.Id==p.EmployeeId
						  
						  select new 
						  {
							  EmpName = e.EmployeeName,
							  EmployeeProject = e.project,
							  Manager = p.manager
						  }).ToList();
			return Ok(result);

		}
		[HttpPost("projecttable")]
		public IActionResult SaveEmpandProject()
		{
			var data = new employeeprojectdetail
			{
				Employee = new EmployeesDetails
				{
					EmployeeName = "katari",
					project = "orkes",

				},
				manager = "bommanan"


			};
			employeeDBContext.Add(data);
			employeeDBContext.SaveChanges();
			return Ok("success");
		}
    }
}
