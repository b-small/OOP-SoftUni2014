using System;

namespace DelegatesAndEvents03StudentClass
{
    class Test
    {
        static void Main(string[] args)
        {
            Student uno = new Student("Isperih", 72);
            Student dos = new Student("Stamat", 11);

            uno.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.Property, eventArgs.OldValue, eventArgs.NewValue);
            };
            uno.Name = "Sulio";
            uno.Age = 19;

            dos.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.Property, eventArgs.OldValue, eventArgs.NewValue);
            };

            dos.Name = "Pulio";
            dos.Age = 2;
        }
    }
}
