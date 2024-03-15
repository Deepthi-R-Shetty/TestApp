using Microsoft.EntityFrameworkCore;
using TrainingApi.Data;
namespace TrainingApi.Data
{
	public class EmployeeDBContext : DbContext
	{
		public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
		{
		}

		public DbSet<EmployeesDetails> EmployeesDetails { get; set; }
		public DbSet<employeeprojectdetail> employeeprojectdetail { get; set; }

		public DbSet<student> students { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}


	}
}
