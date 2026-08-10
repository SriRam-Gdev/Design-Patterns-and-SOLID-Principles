using System;

namespace SOLID_Principles.DIP
{
    public class UserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public void RegisterUser(string name)
        {
            Console.WriteLine($"Registering user: {name}");

            repository.SaveUser(name);
        }
    }
}