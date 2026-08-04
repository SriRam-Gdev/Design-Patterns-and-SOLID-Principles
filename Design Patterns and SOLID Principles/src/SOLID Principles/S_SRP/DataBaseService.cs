using System;

namespace SOLID_Principles.S_SRP
{
    class DataBaseService
    {
        public void SaveUser(User user)
        {
            // Logic to save user to the database
            Console.WriteLine($"User {user.Name} saved to the database");
        }
    }
}