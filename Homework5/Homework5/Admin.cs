using System;
namespace Homework5
{
public class Admin
	{
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool isSuperAdmin, string section)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;

        }

        public string Return()
        {
            return $"{IsSuperAdmin} , {Section}";
        }
    }
}

