namespace mvcDesktopApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(int _id, string _name, string _email)
        {
            this.Id = _id;
            this.Name = _name;
            this.Email = _email;
        }
    }
}
