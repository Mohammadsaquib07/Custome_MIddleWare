using System.Collections.Generic;
public static class Data
{
    public static List<Employee> GetEmployee()
    {
        List<Employee> empList = new List<Employee>();
        Employee employee = new Employee
        {
            EmpId = 1,
            FirstName = "Mohammad Saquib",
            LastName = "Kudle",
            AnnualSalary = 27000,
            DepartmentId = 11,
            IsManager = true
        };
        empList.Add(employee);

        employee = new Employee
        {
            EmpId = 1,
            FirstName = "Mohammad Aadli",
            LastName = "Shaikh",
            AnnualSalary = 27000,
            DepartmentId = 12,
            IsManager = false
        };
        empList.Add(employee);

        employee = new Employee
        {
            EmpId = 1,
            FirstName = "Ayyub",
            LastName = "Mujawar",
            AnnualSalary = 27000,
            DepartmentId = 11,
            IsManager = true
        };
        empList.Add(employee);

        employee = new Employee
        {
            EmpId = 1,
            FirstName = "Hania",
            LastName = "Aamir",
            AnnualSalary = 50000,
            DepartmentId = 10,
            IsManager = false
        };
        empList.Add(employee);

        return empList;
    }

    public static List<Department> GetDepartment()
    {
        List<Department> departmentList = new List<Department>();

        Department deptObj = new Department
        {
            DeptId = 10,
            DepartmentName = "IT"
        };
        departmentList.Add(deptObj);

        deptObj = new Department
        {
            DeptId = 11,
            DepartmentName = "HR"
        };
        departmentList.Add(deptObj);

        deptObj = new Department
        {
            DeptId = 12,
            DepartmentName = "IT"
        };
        departmentList.Add(deptObj);

        deptObj = new Department
        {
            DeptId = 10,
            DepartmentName = "HR"
        };
        departmentList.Add(deptObj);

        return departmentList;
    }
}