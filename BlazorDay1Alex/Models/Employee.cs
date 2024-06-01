

namespace BlazorDay1Alex.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MinLength(3,ErrorMessage ="Name Must Be More Than 3 Char")]
        [MaxLength(25,ErrorMessage ="Name Must Be Less Than 25 Char")]
        public string Name { get; set; }

        [Range(6000,25000,ErrorMessage ="Salary must be in betwwen 6000 : 25000")]
        public int Salary { get; set; }

        public string Address { get; set; }

        [RegularExpression(@"\w+\.(jpg|png)",ErrorMessage ="Image Must be Jpg Or Png")]
        public string ImageUrl { get; set; }
        
        public int DeptId { get; set; }
    }
}
