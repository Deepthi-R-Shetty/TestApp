////// See https://aka.ms/new-console-template for more information
//////nested object,nullable and default values for properties,enum,constructor
//////list,dict,array(for,foreach,while),dictionary(model),liq(where,any,select,order,group by)
/////palindrome,anagram,string reverse,palindrome,star pattern
/////data adapter,data set
///why web API,diff https,http,ROUTE

using DOTnet_training;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

////Console.WriteLine("Hello, World!");

////double  salary = 10.5;
////bool isactive=false;
////DateTime datenow=DateTime.Now;
////Console.WriteLine(datenow);


//////Employee employee = new Employee() { Id = 1, Name = "deepthi", age = 22 };
//////Employee employee1 = new Employee(2, "deepthi", 22);
//////Employee employee2 = new Employee();
//////manager manager = new manager();
//////manager.designation = "Supriya";
//////manager.Employee.Id = employee1.Id;
//////manager.Employee.Name = employee1.Name;
//////manager.Employee.age = employee1.age;

////List<int> numbers = new List<int> { 1, 4, 7 };
////numbers.Add(8);
////numbers.Remove(numbers.IndexOf(2));
////numbers.IndexOf(1);
////numbers.RemoveRange(1, 2);

//Dictionary<int, string> dic = new Dictionary<int, string> { [1] = "a", [2] = "b" };
//foreach (var item in dic)
// Console.WriteLine(item);
//for(int i=1; i<=dic.Count; i++)
//	Console.WriteLine(dic[i]);




////Dictionary<string, int> dictionary2 = new Dictionary<string, int> { ["a"] = 3, ["a"] = 7 };


////Console.WriteLine(dic);
////EmpDetails emp = new EmpDetails()  { Name = "deepthi", experience = 2, position = "SE", project = "MEA" } ;
////List<EmpDetails> emp2 = new List<EmpDetails>() { new EmpDetails() { Name = "a", experience = 3, position = "se", project = "mea" } };
////List<EmpDetails> emp3 = new List<EmpDetails>() { new EmpDetails() { Name = "b", experience = 3, position = "se", project = "mea" } };
////List<EmpDetails> emp4 = new List<EmpDetails>() { new EmpDetails() { Name = "c", experience = 6, position = "se", project = "mea" } };


//List<EmpDetails> list = new List<EmpDetails>();
////List.Add(new EmpDetails()
////{
////	Name = "a",
////	experience = 3,
////	position = "se",
////	project = "mea"
////});
////EmpDetails emp1 = new EmpDetails() { Name = "deepthi", experience = 3, position = "SE", project = "MEA" };
////list.Add(emp1);
//////list.Add(emp2);
//////list.Add(emp3);
//////list.Add(emp4);
////var a=list.Where(e=>e.experience == 3).ToList();
//foreach(var e in a)
//{
//    Console.WriteLine(e.project);
//}

//int[] array1 = [1, 2, 3,3,9,8];
//for(int i = 0; i < array1.Length; i++)
//	Console.WriteLine(array1[i]);

//foreach(int i in array1)
//{ Console.WriteLine(i); }

//List<int> ints = new List<int> { 5, 3, 4, 7, 6 };
//for(int i = 0;i < ints.Count; i++)
//{ Console.WriteLine(ints[i]); }

//foreach(int i in ints)
//{ Console.WriteLine(i); }

//Array.Sort(array1);
//foreach(int i in array1)
//{
//	Console.WriteLine(i);

//}

//var b = list.Where(e => e.experience == 3).ToList();











////List<studentdetails> stu = new List<studentdetails>() { new studentdetails() { name = "Deepthi" } };
////List<object> list = new List<object>();              //generic
////EmpDetails emp2 = new EmpDetails();
////studentdetails emp3 = new studentdetails();
////list.Add(emp2);
////list.Add(emp3);
////foreach (var item in list)

////{
////	Console.WriteLine(item);

////}







//////if (employee1.age < 18)
//////	Console.WriteLine("not eligible");
//////else
//////	Console.WriteLine("eligible");

//////switch(employee1.age)
//////{
//////	case 22:
//////		Console.WriteLine("eligible");
//////		break;

//////    case 23:
//////		Console.WriteLine("not eligible");
//////		break;

//////}
//////string eligibility = employee1.age < 18 ? "not eligible" : "eligible";
//////Console.WriteLine(eligibility);



////Calculation calculation = new Calculation();
////calculation.add(2, 3);

////public class Employee()
////{
////	public int Id { get; set; }
////	public string Name { get; set; }	

////	public int age {  get; set; }

////	//public Employee(int id, string name, int age)
////	//{
////	//	Id= id; Name = name;age = age;
////	//}


////}


//////public class manager()
//////{
//////	public string designation { get; set; }
//////	public Employee Employee { get; set; }
//////}
/////

//int a1 = 10;
//string b2 = $"a {a1} {JsonConvert.SerializeObject(emp1)}";				//interploation
//Console.WriteLine(b2);

//salaryprocessing s=new salaryprocessing();
//var h = s.getsalary();
//var t=s.getsalaryTask();
//Console.WriteLine(h);
//Console.WriteLine(t);

//Palindrome p=new Palindrome();
//p.palindromeprogram();
//starpattern v=new starpattern();
//v.patternprogram();

//anagram anagram = new anagram();
//anagram.anagramprgram();


EmpDBconnection empDB=new EmpDBconnection();
//List<EmpDetails> list1= empDB.GetEmpDetails();
//foreach (EmpDetails emp in list1)
//{
//	Console.WriteLine(emp.project);
//}

//empDB.GetById();
//empDB.savedetails();

Dbconnection db=new Dbconnection();
List<EmpDetails> list2=db.GetallEmployees();
foreach (EmpDetails emp in list2)
	Console.WriteLine(emp.project);
EmpDetails e=db.GetEmpByName();
	Console.WriteLine(e.project);

db.DeleteEmployeeByName();
db.UpdateEmployeeById();
List<EmpDetails> l=db.GetallEmployees();
foreach(EmpDetails emp in l)
	Console.WriteLine(emp.project);
EmpDetails emp1 = db.GetEmpByName();
Console.WriteLine(emp1.project);
db.AddEmp();
db.DeleteEmpByName();
db.UpdateEmployeeByName();
EmpDetails emp2 = db.GetEmpByName();
emp2.EmployeeName = "KATARI";
emp2.Experience = 6.4f;
emp2.project = "ORKES";
emp2.position = "ASE";
db.AddEmployee(emp2);
db.GetEmployeeByName();
db.GetAllEmployees();

Filereader filereader = new Filereader();
filereader.Reader();








