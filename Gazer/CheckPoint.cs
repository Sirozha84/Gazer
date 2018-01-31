using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazer
{
    class CheckPoint
    {
        public string Name;
        public string Description;
        public string Camera;
        public string Login;
        public string Password;

        public CheckPoint(string name, string desc, string cam, string login, string pass)
        {
            Name = name;
            Description = desc;
            Camera = cam;
            Login = login;
            Password = pass;
        }
    }
}
