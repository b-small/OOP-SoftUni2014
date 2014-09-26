using System;
using System.Text;


namespace StaticMembersAndNamespacesHTMLDispatcher
{
    class ElementBuilder
    {
        private string name;
        private string opening;
        private string content;
        private string closing;
        private bool isVoid;

        public ElementBuilder(string name, bool isVoid=false)
        {
            this.Name = name;
            this.IsVoid = isVoid;
            this.Content = string.Empty;
            this.Opening = "<" + this.Name + ">";
            if (this.IsVoid)
            {
                this.Closing = string.Empty;
            }
            else
            {
                this.Closing = "</" + this.Name + ">";
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public string Opening
        {
            get { return this.opening; }
            set
            {
                this.opening = value;
            }
        }

        public string Content
        {
            get { return this.content; }
            set
            {
                this.content = value;
            }
        }

        public string Closing
        {
            get { return this.closing; }
            set
            {
                this.closing = value;
            }
        }


        public bool IsVoid
        {
            get { return this.isVoid; }
            set
            {
                this.isVoid = value;
            }
        }

        public static string operator *(ElementBuilder eb, int counter)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                sb.Append(eb.ToString());
            }
            return sb.ToString();
        }

        public string AddAtribute(string attribute, string value)
        {
            this.Opening = this.Opening.TrimEnd(new[] { '/', '>', ' ' })  + string.Format(" {0}=\"{1}\"", attribute, value);
            this.Opening += '>';
            return this.Opening;
        }

        public void AddContent(string content)
        {
            if (!this.IsVoid)
            {
                this.Content = content;
            }

            else
            {
                throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            return this.Opening + this.Content + this.Closing;
        }
    }
}
