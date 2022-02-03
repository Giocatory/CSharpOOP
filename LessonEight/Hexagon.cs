namespace LessonEight
{
    internal sealed class Hexagon : Shape
    {
        public Hexagon() : this("Hexagon") { }
        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine($"We draw {nameof(Hexagon)}: {PetName}");
        }
    }
}