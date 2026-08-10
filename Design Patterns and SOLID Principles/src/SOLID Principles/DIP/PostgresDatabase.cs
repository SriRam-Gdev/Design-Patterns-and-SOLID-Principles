using System;

namespace SOLID_Principles.DIP
{
    public class PostgresDatabase : IUserRepository
    {
        public void SaveUser(string name)
        {
            Console.WriteLine($"User '{name}' saved to PostgreSQL.");
        }
    }
}