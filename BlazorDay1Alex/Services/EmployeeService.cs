using BlazorDay1Alex.Models;

namespace BlazorDay1Alex.Services
{
    public class EmployeeService : IService<Employee>
    {
        List<Employee> employees;
        public EmployeeService()
        {
            employees = new List<Employee>();
            
            employees.Add(new Employee() { Id = 1, Name = "Ahmed", Salary = 15000, Address = "Alex", ImageUrl = "m.png", DeptId = 1 });

            employees.Add(new Employee() { Id = 2, Name = "Rowa", Salary = 15000, Address = "Alex", ImageUrl = "2.jpg", DeptId = 2 });

            employees.Add(new Employee() { Id = 3, Name = "Basma", Salary = 15000, Address = "Alex", ImageUrl = "2.jpg", DeptId = 3 });

            employees.Add(new Employee() { Id = 4, Name = "Ali", Salary = 15000, Address = "Alex", ImageUrl = "m.png", DeptId = 1 });

            employees.Add(new Employee() { Id = 5, Name = "Mohamed", Salary = 15000, Address = "Alex", ImageUrl = "m.png", DeptId = 2 });

        }
        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetByID(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
