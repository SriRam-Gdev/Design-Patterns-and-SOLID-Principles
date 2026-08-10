using System;

using SOLID_Principles.DIP;

UserService userService = new UserService(new SqlServerDatabase());
userService.RegisterUser("John Doe");

UserService userService2 = new UserService(new PostgresDatabase());
userService2.RegisterUser("Jane Smith");

UserService userService3 = new UserService(new SqlServerDatabase());
userService3.RegisterUser("Alice Johnson");