using System;
using SOLID_Principles.S_SRP;
namespace SOLID_Principles.S_SRP
{
    class UserService
    {
        public void CreateUser(User user)
        {
            // Logic to create a user
            Console.WriteLine($"User {user.Name} registered successfully");
        }
    }
}