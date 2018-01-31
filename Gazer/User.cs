using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazer
{
    class User
    {
        public string Name;
        public int Type;
        public string Key;

        public User(string name, int type, string key)
        {
            Name = name;
            Type = type;
            Key = key;
        }
    }
}
