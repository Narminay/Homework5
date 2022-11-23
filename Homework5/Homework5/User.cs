using System;
namespace Homework5
{
public class User
	{
        private string _username;
        private string _password;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length>6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Set username again!");
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value == value.ToLower() && value.Length < 1)
                {
                    Console.WriteLine("Set correct password!");
                }
                else
                {
                    _password = value;
                }
            }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

