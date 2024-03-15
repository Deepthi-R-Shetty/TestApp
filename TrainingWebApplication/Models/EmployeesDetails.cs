
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingWebApplication.Models
{
    public class EmployeesDetails
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string project { get; set; }
    }

    //public class employeeprojectdetail
    //{
    //    [Key]
    //    public int EmployeeId { get; set; }
    //    public string project { get; set; }
    //    public string manager { get; set; }

    //    [ForeignKey("EmployeeId")]
    //    //public virtual EmployeesDetails EmployeesDetails { get; set; }
    //    public EmployeesDetails Employee { get; set; }
    //}

    //public class student
    //{
    //    [Key]
    //    public int EmployeeId { get; set; }
    //    public string name { get; set; }
    //    public string section { get; set; }
    //}

    //public class EmpProject
    //{
    //	[Key]
    //	public int EmployeeId { get; set;}
    //	public string EmployeeName { get; set; }
    //	public string manager { get; set; }

    //}
}
