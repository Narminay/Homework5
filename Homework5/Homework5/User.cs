using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Homework5
{
public class User
	{
        private string _username;
        private string _password;
        private protected string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length<6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Set username again!");
                }
            }
        }
        protected string Passwordd
        {
            get
            {
                return _password;
            }
            set
            {
                if (value == value.ToLower())
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
            Passwordd = password;
        }
    }
}

