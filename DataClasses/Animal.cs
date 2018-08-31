namespace DM.MultiLayer.Data.Repositories
{
    public class Animal
    {
        public Animal(int id, string firstname, string lastname, int age)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
    }
}