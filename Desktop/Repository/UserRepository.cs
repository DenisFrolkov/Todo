using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Desktop.Repository
{
    public static class UserRepository
    {
        private static readonly List<UserModel> Users = new List<UserModel>
        {
            new UserModel("Denis", "deniska-frolkov@mail.ru", "12345678"),
            new UserModel("Liz", "lizaliza@mail.ru", "123454321"),
            new UserModel("Liz", "deniska-frolkov@mail.ru", "12345678"),
        };
        public static UserModel RegistrationUser(UserModel user)
        {
            foreach (var item in Users)
            {
                if(user.Email == item.Email)
                {
                    return null;
                } 
            }
            Users.Add(user);
            return user;
        }
        
        public static UserModel LoginUser(UserModel user) =>
            Users.FirstOrDefault(item => item.Email == user.Email && item.Password == user.Password);
        }
}