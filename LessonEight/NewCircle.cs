namespace LessonEight
{
    internal class NewCircle : Circle
    {
        public NewCircle() : this($"{nameof(NewCircle)}")
        {
        }

        public NewCircle(string name) : base(name)
        {
            MyNewCircle = name;
        }

        public string MyNewCircle { get; set; }

        public new void Draw()
        {
            Console.WriteLine($"We draw {nameof(NewCircle)}: {MyNewCircle}");
        }
    }
}