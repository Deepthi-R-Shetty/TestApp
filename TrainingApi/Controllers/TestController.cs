using Microsoft.AspNetCore.Mvc;

using TrainingApi.Data;


namespace TrainingApi.Controllers
{

	[ApiController]
	[Route("[controller]")]
	

	public class TestController : ControllerBase
	{
		private readonly EmployeeRepository _employeeRepository;
		public TestController(EmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}



		//[HttpGet("id")]
		//	public IActionResult GetDataById()
		//	{
		//		DataTable dt = new DataTable();
		//		using (SqlConnection con = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;"))
		//		{
		//			con.Open();
		//			SqlCommand cmd = new SqlCommand("select * from employeedetail where EmployeeName=@name", con);
		//			SqlDataAdapter adapter = new SqlDataAdapter();

		//			cmd.CommandType = CommandType.Text;
		//			cmd.Parameters.AddWithValue("@name", "Deepthi");
		//			adapter.SelectCommand = cmd;
		//			adapter.Fill(dt);
		//			con.Close();
		//		}
		//		var result = JsonConvert.SerializeObject(dt);
		//		return Ok(result);
		//	}
		//	[HttpPost]
		//	public IActionResult PostData()
		//	{
		//		using (SqlConnection con = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;"))
		//		{
		//			con.Open();
		//			SqlCommand cmd = new SqlCommand("insert into employeedetail values(@name,@experience,@position,@project)", con);

		//			cmd.CommandType = CommandType.Text;
		//			cmd.Parameters.AddWithValue("@name", "deepthi");
		//			cmd.Parameters.AddWithValue("@experience", 2.0);
		//			cmd.Parameters.AddWithValue("@position", "ASE");
		//			cmd.Parameters.AddWithValue("@project", "mea");
		//			cmd.ExecuteNonQuery();
		//			con.Close();



		//		}
		//		return Ok("data inserted");
		//	}




		//}
		[HttpGet("GetEmployee")]
		public IActionResult GetAllEmployeeDetails()
		{
			var result=_employeeRepository.GetEmployees().ToList();
			
			return Ok(result);


		}


	}
}









