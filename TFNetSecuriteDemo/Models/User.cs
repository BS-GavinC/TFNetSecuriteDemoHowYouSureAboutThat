namespace TFNetSecuriteDemo.Models
{
    public class User
    {

        public User(int id, string firstname, string lastname, DateTime birthdate, string email, string gender)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Birthdate = birthdate;
            Email = email;
            Gender = gender;
        }

        public int Id { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime Birthdate { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

    }
}
