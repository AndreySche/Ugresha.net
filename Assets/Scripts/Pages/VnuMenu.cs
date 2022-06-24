namespace Pages
{
    class VnuMenu
    {
        public string Title;
        public string Description;
        public Page Link;
        public VnuMenu() : this("title", "description", Page.PageMain) { }

        public VnuMenu(string title, string decription, Page link)
        {
            Title = title;
            Description = decription;
            Link = link;
        }
    }
}