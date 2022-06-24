namespace Pages
{
    class VnuMenu
    {
        public string Title;
        public string Description;
        public string Link;
        public VnuMenu() : this("title", "description", "back") { }

        public VnuMenu(string title, string decription, string link)
        {
            Title = title;
            Description = decription;
            Link = link;
        }
    }
}