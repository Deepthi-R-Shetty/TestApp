using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;
using TrainingApi.Data.Interface;
using TrainingWebApplication.Models;

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
        public EmployeesDetails GetEmployeeById(int id)
        {
            EmployeesDetails employee = null;
            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM EmployeesDetails WHERE Id = @Id", con);
                sqlCommand.Parameters.AddWithValue("@Id", id);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        employee = new EmployeesDetails();
                        employee.Id = Convert.ToInt32(reader["Id"]);
                        employee.EmployeeName = reader["EmployeeName"].ToString();
                        employee.project = reader["project"].ToString();
                    }
                }
            }
            return employee;
        }

        public void UpdateEmployee(EmployeesDetails employee)
        {
            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE EmployeesDetails SET EmployeeName = @EmployeeName, project = @Project WHERE Id = @Id", con);
                sqlCommand.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                sqlCommand.Parameters.AddWithValue("@Project", employee.project);
                sqlCommand.Parameters.AddWithValue("@Id", employee.Id);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM EmployeesDetails WHERE Id = @Id", con);
                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
