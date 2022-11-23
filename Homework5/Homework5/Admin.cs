using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework5
{
public class Admin:User
	{
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool isSuperAdmin, string section, string username, string password):base(username,password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
            Username = username;
            Passwordd = password;

        }

        public void Showdata()
        {
            Console.WriteLine($" True or False:  {IsSuperAdmin}, Section: {Section}, Username:{Username},Password:{Passwordd}");
        }

        public string Return()
        {
            return $"{IsSuperAdmin} , {Section}";
        }
    }
}

