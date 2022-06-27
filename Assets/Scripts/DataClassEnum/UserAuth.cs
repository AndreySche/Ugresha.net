namespace Ugresha
{
    public class UserAuth
    {
        public int Aid { get; set; }
        public string Hash { get; set; }
        public int Update { get; set; }
        public bool Guest { get; set; }

        public UserAuth() { }
    }
}
