using System;


namespace StaticMembersAndNamespacesHTMLDispatcher
{
    static class HTMLDispatcher
    {
        public static string CreateImage(string imgSrc, string alt, string title)
        {
            ElementBuilder img = new ElementBuilder("img", true);
            img.AddAtribute("src", imgSrc);
            img.AddAtribute("alt", alt);
            img.AddAtribute("title", title);
            return img.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder eb = new ElementBuilder("a");
            eb.AddAtribute("url", url);
            eb.AddAtribute("title", title);
            eb.AddContent(text);
            return eb.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder eb = new ElementBuilder("input", true);
            eb.AddAtribute("type", type);
            eb.AddAtribute("name", name);
            eb.AddAtribute("value", value);
            return eb.ToString();
        }
    }
}
