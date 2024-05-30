using BlazorDay1Alex.Models;

namespace BlazorDay1Alex.Services
{
    public class DepartmentService : IService<Department>
    {
        List<Department> departments;
        public DepartmentService()
        {
            departments = new List<Department>();
            
            departments.Add(new Department() { Id = 1, Name = "SD" });
            departments.Add(new Department() { Id = 2, Name = "OS" });
            departments.Add(new Department() { Id = 3, Name = "Elearning" });

        }

        public List<Department> GetAll()
        {
            return departments;
        }

        public Department GetByID(int id)
        {
            return departments.FirstOrDefault(d => d.Id == id);
        }
    }
}
