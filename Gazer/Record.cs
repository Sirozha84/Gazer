using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazer
{
    class Record
    {
        public string Time;
        public string CP;
        public string Name;
        public string Res;
        public string Photo;

        public Record(string time, string cp, string name, string res, string photo)
        {
            Time = time;
            CP = cp;
            Name = name;
            Res = res;
            Photo = photo;
        }

        public ListViewItem Item()
        {
            return new ListViewItem(new string[] { Time, CP, Name, Res });
        }
    }
}
