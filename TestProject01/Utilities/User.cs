namespace TestProject01.Utilities
{
    public class User
    {
        public static User DefualtKikaUser = new User("mail.for.emails@gmail.com", "password123");

        public string Username;
        public string Password;

        public User (string username, string password)
        {
            Username = username;
            Password = password;
        }

    }
}
