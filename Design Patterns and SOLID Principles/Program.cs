using SOLID_Principles.S_SRP;

User user = new User
{
    Name = "John Doe",
    Email = "ssriram@gmail.com"
};

EmailService emailService = new EmailService();
DataBaseService dataBaseService = new DataBaseService();
UserService userService = new UserService();
userService.CreateUser(user);
dataBaseService.SaveUser(user);
emailService.SendEmail(user.Email);

