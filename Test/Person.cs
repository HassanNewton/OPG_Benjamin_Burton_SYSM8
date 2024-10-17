namespace Test
{
    public abstract class Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Person(string username, string password)
        {
            Username = username;
            Password = password;
        }//benjamin.alexander.burton@gmail.com
        public abstract void SignIn();
    }
}