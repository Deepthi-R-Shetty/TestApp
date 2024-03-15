using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DOTnet_training
{
	public class Dbconnection
	{
		public List<EmpDetails> GetallEmployees()
		{
			List<EmpDetails> employees = new List<EmpDetails>();
			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT * FROM employeedetail", conn);
			using SqlDataReader reader = cmd.ExecuteReader();
			{
				while (reader.Read())
				{
					EmpDetails emp = new EmpDetails();
					emp.EmployeeName = reader["EmployeeName"].ToString();
					emp.position = reader["position"].ToString();
					emp.Experience = float.Parse(reader["Experience"].ToString());
					emp.project = reader["project"].ToString();
					employees.Add(emp);


				}
			}
			return employees;

		}

		public EmpDetails GetEmpByName()
		{
			EmpDetails emp= new EmpDetails();
			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlCommand cmd = new SqlCommand("select * from employeedetail where EmployeeName=@name", conn);
			cmd.Parameters.Add(new SqlParameter("name", "Deepthi"));
			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				emp.EmployeeName = reader["EmployeeName"].ToString();
				emp.position = reader["position"].ToString();
				emp.Experience = float.Parse(reader["Experience"].ToString());
				emp.project = reader["project"].ToString();

			}
			return emp;
		}

		public void AddEmployee(EmpDetails emp2)
		{
			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlCommand cmd = new SqlCommand("insert into employeedetail(EmployeeName,Experience,position,project)values(@name,@experience,@position,@project)", conn);

			cmd.Parameters.Add(new SqlParameter("name", emp2.EmployeeName));
			cmd.Parameters.Add(new SqlParameter("position", emp2.position));
			cmd.Parameters.Add(new SqlParameter("experience",emp2.Experience ));
			cmd.Parameters.Add(new SqlParameter("project", emp2.project));
			int rowsAffected = cmd.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine("data inserted");
			}
			else
			{
				Console.WriteLine("error");
			}
		}
		public void DeleteEmployeeByName()
		{

			
			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlCommand cmd = new SqlCommand("delete from employeedetail where EmployeeName=@name", conn);
			cmd.Parameters.Add(new SqlParameter("name", "Deepthi"));
			int rowsAffected = cmd.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine("data deleted");
			}
			else
			{
				Console.WriteLine("error");
			}



		}
		public void UpdateEmployeeById()
		{
			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlCommand cmd = new SqlCommand("update employeedetail set project=@project where EmployeeName=@ename", conn);
			cmd.Parameters.Add(new SqlParameter("ename", "Jithesh"));
			cmd.Parameters.Add(new SqlParameter("project", "Orkes"));
			int rowsAffected = cmd.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine("data updated");
			}
			else
			{
				Console.WriteLine("error");
			}
		}

		public List<EmpDetails> GetAllEmployees()
		{
			DataTable dataTable = new DataTable();
			List<EmpDetails> employees = new List<EmpDetails>();
			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlDataAdapter da = new SqlDataAdapter("getemp", conn);
			DataSet ds=new DataSet();
			
			da.Fill(ds);
			//foreach(DataRow dr in dataTable.Rows)
			//{
			//	Console.WriteLine(dr[0]);
			//}
			Console.WriteLine(ds.Tables[0].Rows[0][0]);

			//using SqlDataReader reader = cmd.ExecuteReader();
			//{
			//	while (reader.Read())
			//	{
			//		EmpDetails emp = new EmpDetails();
			//		emp.EmployeeName = reader["EmployeeName"].ToString();
			//		emp.position = reader["position"].ToString();
			//		emp.Experience = float.Parse(reader["Experience"].ToString());
			//		emp.project = reader["project"].ToString();
			//		employees.Add(emp);


			//	}
			//}
			return employees;

		}

		public EmpDetails GetEmployeeByName()
		{
			EmpDetails emp = new EmpDetails();
			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlCommand cmd = new SqlCommand("GetEmployee", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(new SqlParameter("@name", "Deepthi"));
			using SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				emp.EmployeeName = reader["EmployeeName"].ToString();
				emp.position = reader["position"].ToString();
				emp.Experience = float.Parse(reader["Experience"].ToString());
				emp.project = reader["project"].ToString();

			}
			return emp;
		}

		public void AddEmp()
		{
			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlCommand cmd = new SqlCommand("AddEmployees", conn);
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add(new SqlParameter("@name", "Deepthi"));
			cmd.Parameters.Add(new SqlParameter("@position", "ASE"));
			cmd.Parameters.Add(new SqlParameter("@experience", 1.0));
			cmd.Parameters.Add(new SqlParameter("@project", "MEA"));
			int rowsAffected = cmd.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine("data inserted");
			}
			else
			{
				Console.WriteLine("error");
			}
		}

		public void DeleteEmpByName()
		{


			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlCommand cmd = new SqlCommand("DeleteEmp", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add(new SqlParameter("@name", "Jithesh"));
			int rowsAffected = cmd.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine("data deleted");
			}
			else
			{
				Console.WriteLine("error");
			}



		}

		public void UpdateEmployeeByName()
		{
			SqlConnection conn = new SqlConnection("Server= TL444\\SQLEXPRESS; Database = employee; Trusted_Connection = True; TrustServerCertificate = True;");
			conn.Open();
			SqlCommand cmd = new SqlCommand("UpdateEmp", conn);
			cmd.Parameters.Add(new SqlParameter("@name", "Srinidhi"));
			cmd.Parameters.Add(new SqlParameter("@project", "HealthEdge"));
			cmd.CommandType= CommandType.StoredProcedure;
			int rowsAffected = cmd.ExecuteNonQuery();

			if (rowsAffected > 0)
			{
				Console.WriteLine("data updated");
			}
			else
			{
				Console.WriteLine("error");
			}
		}



	}
}

