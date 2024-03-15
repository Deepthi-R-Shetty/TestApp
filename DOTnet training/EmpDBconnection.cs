using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DOTnet_training
{
	public class EmpDBconnection
	{

		public List<EmpDetails> GetEmpDetails()
		{
			List<EmpDetails> empDetails = new List<EmpDetails>();
			
			SqlConnection sqlConnection=new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			sqlConnection.Open();
			
			SqlCommand command = new SqlCommand("SELECT * FROM employeedetail", sqlConnection);
			using (SqlDataReader reader = command.ExecuteReader())
			{
				

	while (reader.Read())
				{
					// write the data on to the screen
					EmpDetails emp=new EmpDetails();
					emp.EmployeeName = reader["EmployeeName"].ToString();
					emp.position = reader["position"].ToString();
					emp.Experience =float.Parse( reader["Experience"].ToString());
					emp.project = reader["project"].ToString() ;
					empDetails.Add( emp );


					
				}
			}
			return empDetails;




		}
		public EmpDetails GetById() 
		{

			EmpDetails empname=new EmpDetails();

			SqlConnection sqlConnection = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			sqlConnection.Open();

			SqlCommand command = new SqlCommand("SELECT * FROM employeedetail where EmployeeName=@empname", sqlConnection);
			command.Parameters.Add(new SqlParameter("empname", "Deepthi"));
			using (SqlDataReader reader = command.ExecuteReader())
			{


				while (reader.Read())
				{
					// write the data on to the screen
					
					empname.EmployeeName = reader["EmployeeName"].ToString();
					empname.position = reader["position"].ToString();
					empname.Experience = float.Parse(reader["Experience"].ToString());
					empname.project = reader["project"].ToString();
					



				}
			}
			return empname;
		}
		public void savedetails()

		{
			SqlConnection sqlConnection = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			sqlConnection.Open();

			SqlCommand command = new SqlCommand("insert into employeedetail(EmployeeName,position,project,Experience) values(@name,@position,@project,@experience)", sqlConnection);
			command.Parameters.Add(new SqlParameter("name","deepthi"));
			command.Parameters.Add(new SqlParameter("position","ASE"));
			command.Parameters.Add(new SqlParameter("experience",2.0));
			command.Parameters.Add(new SqlParameter("project","MEA"));

			int rowsAffected = command.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine("data inserted");
			}
			else
			{
				Console.WriteLine("error");
			}




		}
		


	}
}
