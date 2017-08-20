using System;
namespace Depth.GenericeType
{
    public class MainGenericType
    {
		public static void MyMain()
		{
			Group<Student> school = new Group<Student>();
			school.Add(new Student(name: "Alpha", age: 10, studentNo: 1234));
			school.Add(new Student(name: "Beta", age: 30, studentNo: 4321));
			school.Print();

			Group<Employee> company = new Group<Employee>();
			company.Add(new Employee(name: "Gamma", age: 20, employeeNo: 12345));
			company[0].Print();
		}
    }
}
