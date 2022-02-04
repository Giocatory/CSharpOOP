namespace LessonNine
{
    internal class SimpleClass
    {
        public SimpleClass() : this("no-name", default) { }
        public SimpleClass(string name, int age)
        {
            Name = name;
            if (age > 0 || age < 120) Age = age;
            else Age = default;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        // All classes inherit from System.Object by default
        public override string ToString() => $"User: {Name}; Age: {Age}; Class: {nameof(SimpleClass)}";
        public override bool Equals(object? obj)
        {
            if (obj is SimpleClass && obj != null)
            {
                SimpleClass temp = (SimpleClass)obj;
                if (temp.Name == this.Name && temp.Age == this.Age) return true;
                else return false;
            }
            return false;
            /*
             OR we can write simple:
            public override bool Equals(object? obj) => obj?.ToString() == ToString();
             */
        }
    }
}
