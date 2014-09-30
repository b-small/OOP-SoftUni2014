using System;
using System.ComponentModel;

namespace DelegatesAndEvents03StudentClass
{
   public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs pcea);

    class Student
    {
        private string name;
        private int age;
        public event PropertyChangedEventHandler PropertyChanged;
        public PropertyChangedEventArgs newArgs;

        public Student(string n, int a)
        {
            this.Name = n;
            this.Age = a;
        }

        public string Name {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                if (value != this.Name)
                {
                    this.newArgs = new PropertyChangedEventArgs(this.Name, value, "Name");
                    this.OnChanged(this, newArgs);
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value != this.Age)
                {
                    this.newArgs = new PropertyChangedEventArgs(this.Age.ToString(), value.ToString(), "Age");
                    this.OnChanged(this, newArgs);
                }
                this.age = value;
            }
        }

        private void OnChanged(object sender, PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(sender, e);
            }
        }
    }
}
