namespace Ugresha
{
    public class PageContent
    {
        public string Title;
        public string Description;
        public Page Link;
        public PageContent() : this("title", "description", Page.PageMain) { }

        public PageContent(string title, string decription, Page link)
        {
            Title = title;
            Description = decription;
            Link = link;
        }
    }
}