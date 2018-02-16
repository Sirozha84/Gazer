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
            string ph = "";
            if (Photo != "") ph = "Есть";
            if (Photo == "Error") ph = "Ошибка";
            ListViewItem item = new ListViewItem(new string[] { Time, CP, Name, Res, ph });
            item.Tag = this;
            Record rec = (Record)item.Tag;
            return item;
        }
    }
}
