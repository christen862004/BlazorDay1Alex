namespace BlazorDay1Alex.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
        
        public int DeptId { get; set; }
    }
}
