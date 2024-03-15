using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using TrainingApi.Data.Interface;

namespace TrainingApi.Data
{
	public class EmployeeRepository : IEmployeeInterface
	{

		IConfiguration _configuration;
		public EmployeeRepository(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public List<EmployeesDetails> GetEmployees()
		{
			
				List<EmployeesDetails> employeesDetails = new List<EmployeesDetails>();
				using(SqlConnection con=new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
				{
					con.Open();
					SqlCommand sqlCommand = new SqlCommand("select * from EmployeesDetails", con);
					sqlCommand.CommandType = CommandType.Text;
					using(SqlDataReader reader = sqlCommand.ExecuteReader())
					while(reader.Read())
					{
						EmployeesDetails employeesDetails1 = new EmployeesDetails();
						employeesDetails1.Id = Convert.ToInt32(reader["Id"].ToString());
						employeesDetails1.EmployeeName = reader["EmployeeName"].ToString();
						employeesDetails1.project = reader["project"].ToString();
						employeesDetails.Add(employeesDetails1);
					}


				}
				return employeesDetails;

		}
	}
}
