namespace mvcDesktopApp.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string City { get; set; }
        public Student(string _name, string _city)
        {
            this.Name = _name;
            this.City = _city;
        }

    }
}
