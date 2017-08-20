using System;
namespace Depth.GenericeType
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public virtual void Print() {
            Console.WriteLine("This is {0}, age {1}", Name, Age);
        }
    }

    public class Employee : Person
    {
        public Employee(string name, int age, long employeeNo) : base(name, age) {
            EmployeeNo = employeeNo;
        }

        public long EmployeeNo { get; set; }

        public override void Print() {
            Console.WriteLine("This is employee {0}, age {1}, employee No. {2}", Name, Age, EmployeeNo);
        }
    }

    public class Student : Person 
    {
        public Student(string name, int age, long studentNo) : base(name, age) {
            StudentNo = studentNo;
        }

        public long StudentNo { get; set; }

        public override void Print() {
            Console.WriteLine("This is student {0}, age {1}, student No. {2}", Name, Age, StudentNo);
		}
    }
}
