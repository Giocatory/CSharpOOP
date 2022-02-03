namespace LessonEight
{
    internal class Circle : Shape
    {
        public Circle() : this("Circle")
        {
        }

        public Circle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"We draw {nameof(Circle)}: {PetName}");
        }
    }
}