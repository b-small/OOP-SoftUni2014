using System;

namespace StaticMembersAndNamespacesHTMLDispatcher
{
    class HTMLDispatcherTest
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAtribute("id", "page");
            div.AddAtribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div);
            Console.WriteLine(div * 3);

            string link = HTMLDispatcher.CreateURL("http://www.2leva.com", "2lv", "Some shit");
            Console.WriteLine(link);

            string input = HTMLDispatcher.CreateInput("hello", "lala", "100");
            Console.WriteLine(input);
        }

    }
}
