using System;
using System.Collections.Generic;
using System.Collections;

namespace FirstProject
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }
    public class Organization : IEnumerable
    {
        List<Employee> Emps = new List<Employee>();
        public void Add(Employee Emp)
        {
            Emps.Add(Emp);
        }
        public int Count
        {
            get
            {
                return Emps.Count;
            }
        }
        public Employee this[int index]
        {
            get { return Emps[index]; }
        }
        public IEnumerator GetEnumerator()
        {
            //return Emps.GetEnumerator();
            return new OrganizationEnumerator(this);
        }
    }
    public class OrganizationEnumerator : IEnumerator
    {
        Organization OrgColl;
        int CurrentIndex;
        Employee CurrentEmployee;
        public OrganizationEnumerator(Organization org)
        {
            OrgColl = org;
            CurrentIndex = -1;
        }
    public Object Current
    {
        get { return CurrentEmployee; }
    }
    public bool MoveNext()
    {
        if (++CurrentIndex >= OrgColl.Count)
            return false;
        else
            CurrentEmployee = OrgColl[CurrentIndex];
        return true;
    }
    public void Reset()
    { }
}
     public class TestEmployee
     {
        static void Main()
    {
        Organization Employees = new Organization();
        Employees.Add(new Employee{Id = 101, Name = "John", Job = "Manager", Salary = 45000 });
        Employees.Add(new Employee{ Id = 102, Name = "Max", Job = "Salesman", Salary = 30000 });
        Employees.Add(new Employee{ Id = 103, Name = "Steve", Job = "CEO", Salary = 75000 });
        Employees.Add(new Employee{ Id = 104, Name = "Stark", Job = "Founder", Salary = 125000 });

        foreach(Employee Empq in Employees)
            Console.WriteLine(Empq.Id + " " + Empq.Name + " " + Empq.Job + " " + Empq.Salary);
            Console.ReadLine();
        }
    }    
}
