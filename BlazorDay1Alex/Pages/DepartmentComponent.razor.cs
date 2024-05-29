using BlazorDay1Alex.Models;
using System.Xml.Linq;

namespace BlazorDay1Alex.Pages
{
    public partial class  DepartmentComponent
    {
        public int SelectDeptID { get; set; } = 3;

        public List<Department> DEptList { get; set; }

        public Department Department { get; set; }
        
        public DepartmentComponent()
        {
            DEptList = new List<Department>();
            DEptList.Add(new Department()
            {
                Id = 1,
                Name = "SD",
                MAnagerImage = "2.jpg"
            });
            DEptList.Add(new Department()
            {
                Id = 2,
                Name = "OS",
                MAnagerImage = "m.png"
            });
            DEptList.Add(new Department()
            {
                Id = 3,
                Name = "AI",
                MAnagerImage = "2.jpg"
            });


            Department = new Department()
            {
                Id = 1,
                Name = "SD",
                MAnagerImage = "2.jpg"
            };
        }

        private void LoadDEpt()
        {
            Department = DEptList.FirstOrDefault(d => d.Id == SelectDeptID);
        }
    }
}
