using System;

namespace SOLID_Principles.DIP
{
    public class SqlServerDatabase : IUserRepository
    {
        public void SaveUser(string name)
        {
            Console.WriteLine($"User '{name}' saved to SQL Server.");
        }
    }
}