namespace Entities
{
    public class UserModel
    {
        public UserModel(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public string Name;
        public string Email;
        public string Password;
    }
}