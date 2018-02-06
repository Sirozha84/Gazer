namespace Server
{
    class CheckPoint
    {
        public string Name;
        public string Description;
        public bool Result;
        public bool Camera;
        public string IP;
        public string Login;
        public string Password;

        public CheckPoint(string name, string desc, bool res, bool cam, string ip, string login, string pass)
        {
            Name = name;
            Description = desc;
            Result = res;
            Camera = cam;
            IP = ip;
            Login = login;
            Password = pass;
        }
    }
}
