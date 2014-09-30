using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents03StudentClass
{

    public class PropertyChangedEventArgs : EventArgs
    {
       
        private string property;
        private string oldValue;
        private string newValue;

        public PropertyChangedEventArgs(string oldValue, string newValue, string property)
        {
            this.property = property;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }

       
        public string Property
        {
            get { return this.property; }
        }

        public string OldValue
        {
            get { return this.oldValue; }
        }

        public string NewValue
        {
            get { return this.newValue; }
        }

    }

}