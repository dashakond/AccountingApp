namespace Accounting.DAL.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool LoggedIn { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public virtual void PerformDuties() { }
    }
}